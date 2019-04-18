using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Algorithm_Project
{
    public partial class Form1 : Form
    {
        string testCase;

        public Form1()
        {
            InitializeComponent();
        }

        #region Test Case Choice
        List<Node> my_data = new List<Node>();
        private void sampleTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Sample";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
            try
            {
                //read the "movie1" file from (Sample Test Cases)
                FileStream fs = new FileStream("movies1.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    string record;
                    record = sr.ReadLine();
                    string[] recordContent = record.Split('/');
                    Node temp = new Node();
                    temp.movie = recordContent[0];
                    for (int i = 1; i < recordContent.Length; i++)
                    {
                        temp.actors.Add(recordContent[i]);
                    }
                    my_data.Add(temp);
                    //record = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button1);

            }
        }

        private void smallTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Small";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
        }

        private void mediumTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Medium";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
        }

        private void largeTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Large";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
        }

        private void extremeTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Extreme";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
        }
        #endregion

    }
}
