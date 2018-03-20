using OpenNLP.Tools.Chunker;
using OpenNLP.Tools.Tokenize;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeywordMapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CSVFileRead("D://Share/CSV/csv/medline16n0730.xml.csv", "", "CSVTest"))
            {

            }
        }

        public bool CSVFileRead(string fullPathWithFileName, string fileNameModified, string tableName)
        {
            SqlConnection con = new SqlConnection(ConfigurationSettings.AppSettings["DefaultConnection"]);
            string filepath = fullPathWithFileName;
            StreamReader sr = new StreamReader(filepath);
            string line = sr.ReadLine();
            string[] value = line.Split(',');
            DataTable dt = new DataTable();
            DataRow row;
            foreach (string dc in value)
            {
                dt.Columns.Add(new DataColumn(dc));
            }
            while (!sr.EndOfStream)
            {
                //string[] stud = sr.ReadLine().Split(',');
                //for (int i = 0; i < stud.Length; i++)
                //{
                //    stud[i] = stud[i].Replace("\"", "");
                //}
                //value = stud;
                value = sr.ReadLine().Split(',');
                if (value.Length == dt.Columns.Count)
                {
                    row = dt.NewRow();
                    row.ItemArray = value;
                    dt.Rows.Add(row);
                }
            }
            SqlBulkCopy bc = new SqlBulkCopy(con.ConnectionString, SqlBulkCopyOptions.TableLock);
            bc.DestinationTableName = tableName;
            bc.BatchSize = dt.Rows.Count;
            con.Open();
            bc.WriteToServer(dt);
            bc.Close();
            con.Close();

            return true;
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var tokenizer = new EnglishRuleBasedTokenizer(false);
            var sentence = RText1.Text;

            var modelPath = "Resources/Models/EnglishPOS.nbin";
            var chunker = new EnglishTreebankChunker(modelPath);

            var tokens = tokenizer.Tokenize(sentence);
            //var pos = new posTagger.Tag(tokens);
        }
    }
}
