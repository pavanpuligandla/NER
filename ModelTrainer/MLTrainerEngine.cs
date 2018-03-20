using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenNLP.Tools.NameFind;
using SharpEntropy;
using SharpEntropy.IO;
using System.IO;
using ModelTrainer.StaticConstants;

namespace ModelTrainer
{
    public partial class MLTrainerEngine : Form
    {
        public MLTrainerEngine()
        {
            InitializeComponent();
        }
        static string inputModelName = string.Empty;
        private void btnTrain_Click(object sender, EventArgs e)
        {
            //TrainModel("D:\\KeywordMatchStuff\\OpenNlp-master\\OpenNlp-master\\Resources\\Models\\drug.txt");
            if (!string.IsNullOrEmpty(txtModelName.Text))
            {
                string uploadedFilePath = string.Empty;
                string destinationFilePath = string.Empty;

                try
                {
                    OpenFileDialog browseFile = new OpenFileDialog();
                    browseFile.DereferenceLinks = true;
                    browseFile.Filter = "Text Files (.txt)|*.txt";
                    browseFile.Multiselect = false;
                    browseFile.Title = "Browse Text File";

                    DialogResult result = browseFile.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        if (File.Exists(browseFile.FileName))
                        {
                            uploadedFilePath = browseFile.FileName;
                            txtUploadTextFile.Text = uploadedFilePath;
                            string sourceFileName = Path.GetFileName(uploadedFilePath);
                            destinationFilePath = Path.Combine(StaticVariables.ModelFolderPath, sourceFileName);
                            File.Copy(uploadedFilePath, destinationFilePath, true);
                            inputModelName = txtModelName.Text.Trim();
                            TrainModel(destinationFilePath);
                            if (File.Exists(destinationFilePath))
                                File.Delete(destinationFilePath);
                            MessageBox.Show($"{ "Model file created."}", "NLP", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show("Please enter the model file name.", "NLP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private static void Train(ITrainingEventReader eventReader, int iterations, int cutoff)
        {
            var outputFilePath = Path.Combine(StaticVariables.ModelFolderPath, inputModelName + ".nbin"); //@"D:\KeywordMatchStuff\OpenNlp-master\OpenNlp-master\Resources\Models\NameFind\drug.nbin";
            GisTrainer trainer = new GisTrainer();
            trainer.TrainModel(iterations, new TwoPassDataIndexer(eventReader, cutoff));
            GisModel model = new GisModel(trainer);
            new BinaryGisModelWriter().Persist(model, outputFilePath);
        }

        public static void TrainModel(string trainingFile)
        {
            TrainModel(trainingFile, 100, 5);
        }

        public static void TrainModel(string trainingFile, int iterations, int cutoff)
        {
            StreamReader streamReader= new StreamReader(trainingFile);
            ITrainingEventReader eventReader = new NameFinderEventReader(new PlainTextByLineDataReader(streamReader));
            Train(eventReader, iterations, cutoff);
            streamReader.Close();
        }
    }
}
