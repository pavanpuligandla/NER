using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Irony.Compiler;
using System.Diagnostics;
using System.Threading.Tasks;
using POSTagger.Taggers;
using POSTagger.Tokenizers;
using POSTagger.Corpora;
using OpenNLP.Tools.PosTagger;
using System.Configuration;
using OpenNLP.Tools.NameFind;

namespace KeywordMapper
{
    public partial class fmConverter : Form
    {
        private PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        private PerformanceCounter memCounter = new PerformanceCounter("Memory", "Available MBytes");
        private static DataTable AllResults = new DataTable();
        private static Dictionary<String, List<String>> AssociationResults;
        private EnglishMaximumEntropyPosTagger _posTagger;
        private readonly string _modelPath;
        private EnglishNameFinder _nameFinder;
        BindingSource bSource = new BindingSource();

        public fmConverter()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            timer1.Start();
            _modelPath = ConfigurationManager.AppSettings["MaximumEntropyModelDirectory"];
        }

        SearchGrammar _grammar;
        LanguageCompiler _compiler;

        private void fmConverter_Load(object sender, EventArgs e)
        {
            _grammar = new SearchGrammar();
            _compiler = new LanguageCompiler(_grammar);
            Irony.StringSet errors = _compiler.Parser.GetErrors();
            BindSearchTypes();
            cmbSearchDirection.SelectedIndex = 0;
            if (errors.Count > 0)
            {
                FtsQueryTextBox.Text = "SearchGrammar contains errors. Investigate using GrammarExplorer.\r\n" + errors.ToString();
            }
        }
        public void BindSearchTypes()
        {
            cmbSearchTypes.DataSource = Enum.GetValues(typeof(SearchGrammar.TermType));
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            float cpuUsage = 0.00F;
            cpuUsage = this.cpuCounter.NextValue();
            lblCPU.Text = "CPU : " + cpuUsage + " %";

            float ramUsage = 0.00F;
            ramUsage = this.memCounter.NextValue();
            lblRAM.Text = "Free RAM : " + ramUsage + " MB";
        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            ConvertButton.Enabled = false;
            await (Task.Run(() =>
            {
                try
                {
                    System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();
                    watch.Start();
                    AstNode root = _compiler.Parse(SourceQueryText.Text.ToLower());
                    if (!CheckParseErrors()) return;
                    FtsQueryTextBox.Text = SearchGrammar.ConvertQuery(root, SearchGrammar.TermType.Exact);
                    AllResults = SearchGrammar.ExecuteQuery(FtsQueryTextBox.Text);
                    watch.Stop();
                    double elapsedMS = watch.Elapsed.TotalSeconds;
                    lblCount.Text = AllResults.Rows.Count.ToString() + " Matche(s) found in " + elapsedMS + " seconds";
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.ToString());
                    FtsQueryTextBox.Text = "Error: " + ex.Message;
                }
            }));
            ConvertButton.Enabled = true;
            grpTextOperations.Enabled = true;
        }


        public List<string> Associations(string keyword, DataTable abstracts, string searchDirection, int searchIndex)
        {
            List<string> lines = new List<string>();
            char[] charsToTrim = { '*', ' ', '\'', ')', '(', '=', '-', '"', ',', '/', '.', '<', '>', '%', '&' };

            foreach (DataRow abs in abstracts.Rows)
            {
                for (int foundIndex = abs["AbstractText"].ToString().ToLower().IndexOf(keyword.ToLower()); foundIndex >= 0; foundIndex = abs["AbstractText"].ToString().ToLower().IndexOf(keyword.ToLower(), foundIndex + 1))
                {
                    if (searchDirection.ToLower() == "left")
                    {
                        string before = NWords(abs["AbstractText"].ToString().Substring(0, foundIndex), searchIndex, false);
                        lines.Add($"{before.TrimEnd(charsToTrim).TrimStart(charsToTrim).ToLower()}");
                    }
                    else
                    {
                        string after = NWords(abs["AbstractText"].ToString().Substring(foundIndex + keyword.Length, abs["AbstractText"].ToString().Length - (foundIndex + keyword.Length)), searchIndex, true);
                        lines.Add($"{after.TrimEnd(charsToTrim).TrimStart(charsToTrim).ToLower()}");
                    }
                }
            }
            return lines;
        }

        private string NWords(string text, int wordCount, bool isForward = true)
        {
            var chars = isForward ? text.ToCharArray() : text.Reverse().ToArray();
            int found = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var c in chars)
            {
                if (c == ' ')
                    found++;
                if (found > wordCount)
                    break;
                sb.Append(c);
            }
            if (isForward)
                return sb.ToString();

            char[] charArray = sb.ToString().ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private bool CheckParseErrors()
        {
            if (_compiler.Context.Errors.Count == 0) return true;
            string errs = "Errors: \r\n";
            foreach (SyntaxError err in _compiler.Context.Errors)
                errs += err.ToString() + "\r\n";
            FtsQueryTextBox.Text = errs;
            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private string[] PosTagTokens(string[] tokens)
        {
            if (_posTagger == null)
            {
                //_posTagger = new EnglishMaximumEntropyPosTagger(_modelPath + "\\NameFind\\model.nbin");
                _posTagger = new EnglishMaximumEntropyPosTagger(_modelPath + "EnglishPOS.nbin", _modelPath + @"\Parser\tagdict");
            }

            return _posTagger.Tag(tokens);
        }

        private void Search_Click(object sender, EventArgs e)
        {
                AssociationResults = new Dictionary<string, List<string>>();

                if (AllResults != null && AllResults.Rows.Count > 0)
                {
                    Search.Enabled = false;
                    var searchKeyWords = SourceQueryText.Text.Replace("\"", "").Split(new string[] { "AND" }, StringSplitOptions.RemoveEmptyEntries);
                    List<String> result = new List<string>();
                    foreach (var term in searchKeyWords)
                    {
                        var list = Associations(term.Trim(), AllResults, cmbSearchDirection.Text, Convert.ToInt32(SearchIndexNumericUpDown.Value));
                        AssociationResults[term] = list;
                        if (list.Any() && result.Any())
                            result.Add("--------------------------------------------------------");
                        result.AddRange(list);
                    }

                //remove numbers/digits/punctuation/whitespaces from the list
                result = result.Where(w => w.Any(c => !Char.IsDigit(c) & !Char.IsPunctuation(c) & !Char.IsSymbol(c) & !Char.IsWhiteSpace(c))).ToList();

                //create a new filtered list of strings
                var temp = new List<string>();

                string tagResult;
                foreach (var item in result)
                {
                    string[] stringArray = new string[] { item };
                    string[] tags = PosTagTokens(stringArray);
                    tagResult = String.Join(" ", tags);
                    if(tagResult.Equals("NN") || tagResult.Equals("NNS"))
                    {
                        temp.Add(item);
                    }
                }

                //Model tagging logic 
                List<string> _namedEntities = new List<string>();

                foreach (var entity in temp)
                {
                    if (_nameFinder == null)
                    {
                        _nameFinder = new EnglishNameFinder(_modelPath + "namefind\\");
                    }

                    var models = new[] { "date", "location", "money", "organization", "percentage", "person", "time", "oncology" };
                    _namedEntities.Add(_nameFinder.GetNames(models, entity));
                }

                //group by all distinct and non distinct with count of occurrence populated in a grid or chart
                var q = temp.GroupBy(x => x).Select(gdc => new { Value = gdc.Key, Count = gdc.Count() }).OrderByDescending(x => x.Count);
                    Dictionary<string, Int32> dict = new Dictionary<string, int>();
                    dict = temp.GroupBy(x => x).ToDictionary(gdc => gdc.Key, gdc => gdc.Count());

                    Dictionary<int, List<string>> dictKeywordCountWiseLists = new Dictionary<int, List<string>>();
                    dictKeywordCountWiseLists = q.GroupBy(row => row.Count).ToDictionary(c => c.Key, c => c.Select(x => x.ToString()).ToList());

                    dgvSearchOutput.AutoGenerateColumns = false;
                    dgvSearchOutput.DataSource = bSource;
                    bSource.DataSource = q.ToList();
                    lblSearchResultsCount.Text = $"{  q.Count().ToString() + " "}";
                    Search.Enabled = true;

                    KeywordsTreeView.Nodes.Clear();
                    foreach (KeyValuePair<int, List<string>> entry in dictKeywordCountWiseLists)
                    {
                        KeywordsTreeView.Nodes.Add(entry.Key.ToString(),entry.Key.ToString());
                        TreeNode[] treeNodesPerKey = new TreeNode[entry.Value.Count];

                        for (int i = 0; i < dictKeywordCountWiseLists[entry.Key].Count; i++)
                        {
                            for (int k = 0; k < entry.Value.Count; k++)
                            {
                                treeNodesPerKey[k] = new TreeNode { Name = entry.Value[k].ToString(), Text = entry.Value[k].ToString() };
                            }
                        }
                        KeywordsTreeView.Nodes[entry.Key.ToString()].Nodes.AddRange(treeNodesPerKey);
                    }
                }
                btnGrid.Visible = true;
                btnList.Visible = true;
        }
      
        public bool ValidateSearch(int SearchDirectionIndex, string searchIndex, out string errMsg)
        {
            bool valid = true;
            string errMessage = string.Empty;
            if (SearchDirectionIndex == 0 && string.IsNullOrEmpty(searchIndex))
            {
                errMessage += "Please enter search direction and search index.";
                valid = false;
            }
            else if ((SearchDirectionIndex == 0 && !string.IsNullOrEmpty(searchIndex)) || (SearchDirectionIndex > 0 && string.IsNullOrEmpty(searchIndex)))
            {
                errMessage += "Please enter search direction/index.";
                valid = false;
            }
            errMsg = errMessage;
            return valid;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            SearchIndexNumericUpDown.Value = 1;
            cmbSearchDirection.SelectedIndex = 0;
            cmbSearchTypes.SelectedIndex = 0;
            dgvSearchOutput.DataSource = null;
            dgvSearchOutput.Visible = false;
            btnGrid.Visible = false;
            btnList.Visible = false;
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            dgvSearchOutput.Visible = true;
            KeywordsTreeView.Visible = false;

            btnCollapseTreeview.Visible = false;
            btnExpandTreeView.Visible = false;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            KeywordsTreeView.Visible = true;
            dgvSearchOutput.Visible = false;

            btnCollapseTreeview.Visible = true;
            btnExpandTreeView.Visible = true;
        }

        private void btnCollapseTreeview_Click(object sender, EventArgs e)
        {
            KeywordsTreeView.BeginUpdate();
            KeywordsTreeView.CollapseAll();
            KeywordsTreeView.EndUpdate();
        }

        private void btnExpandTreeView_Click(object sender, EventArgs e)
        {
            KeywordsTreeView.BeginUpdate();
            KeywordsTreeView.ExpandAll();
            KeywordsTreeView.EndUpdate();
        }
    }
}