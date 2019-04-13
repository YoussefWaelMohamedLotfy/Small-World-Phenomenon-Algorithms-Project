using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        private void sampleTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Sample";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
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
