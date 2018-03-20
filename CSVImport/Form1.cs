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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;
using System.Diagnostics;

namespace CSVImport
{
    public partial class Form1 : Form
    {

        private const string delimiter = ",";
        private const string quote = "\"";
        private const string CSVFile = "D://Share/CSV/csv/medline16n0735.xml.csv";
        private const string fixedFile = "D://Share/CSV/csv/output.xml";
        protected const int _batchSize = 10000;
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ExtractFile("D://Share/CSV/XML/", "D://Share/CSV/Op/");
            //ImportData();
        }

        public void ImportData()
        {
            string[] importfiles = Directory.GetFiles(@"D:\Share\CSV\csv", "*.csv");
            lblFileName.Text = "";
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // define the SQL insert statement and use parameters
                string sqlStatement =
                   "INSERT INTO dbo.Import_New(Title, AbstractText) VALUES(@Title, @AbstractText)";

                // define the SqlCommmand to do the insert - use the using() approach again  
                using (SqlCommand cmd = new SqlCommand(sqlStatement, con))
                {
                    // define the parameters for the SqlCommand 
                    cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 50);
                    cmd.Parameters.Add("@AbstractText", SqlDbType.NText);


                    // loop through all files found
                    foreach (string importfile in importfiles)
                    {
                        // read the lines from the text file
                        string[] allLines = File.ReadAllLines(importfile);

                        con.Open();

                        // start counting from index = 1 --> skipping the header (index=0)
                        for (int index = 1; index < allLines.Length; index++)
                        {
                            string[] items = allLines[index].Split(new char[] { '|' });

                            cmd.Parameters["@Title"].Value = items[0];
                            cmd.Parameters["@AbstractText"].Value = items[1];


                            cmd.ExecuteNonQuery();
                        }

                        con.Close();
                    }
                }
            }
        }

        public void ExtractFile(string source, string destination)
        {
            string zPath = @"C:\Program Files\7-Zip\7z.exe";
            try
            {
                ProcessStartInfo pro = new ProcessStartInfo();
                pro.WindowStyle = ProcessWindowStyle.Hidden;
                pro.FileName = zPath;
                pro.Arguments = "x \"" + source + "\" -o" + destination;
                Process x = Process.Start(pro);
                x.WaitForExit();
            }
            catch (System.Exception Ex) { }
        }


    }
}
