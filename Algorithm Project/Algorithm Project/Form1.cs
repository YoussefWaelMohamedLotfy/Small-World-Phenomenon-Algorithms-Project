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
        Dictionary<string, Dictionary<string, Relation_str>> adjacencyList = new Dictionary<string, Dictionary<string, Relation_str>>();
        Dictionary<string, path> checkNode = new Dictionary<string, path>();
        List<QueriesActors> queriesActors = new List<QueriesActors>();
        
        public Form1()
        {
            InitializeComponent();
        }

        #region Test Case Choice
        private void sampleTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Sample";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
            read_CreateAdjacencyList("Sample Test Cases/movies1.txt");
            ReadQueriesFile("Sample Test Cases/queries1.txt");
        }

        private void smallTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Small";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;

            if (caseOne_radioBtn.Checked)
            {
                read_CreateAdjacencyList("Complete Test Cases/small/Case1/Movies193.txt");
                ReadQueriesFile("Complete Test Cases/small/Case1/queries110.txt");

            }
            else if (caseTwo_radioBtn.Checked)
            {
                read_CreateAdjacencyList("Complete Test Cases/small/Case2/Movies187.txt");
                ReadQueriesFile("Complete Test Cases/small/Case1/queries50.txt");
            }
            else
            {
                MessageBox.Show("Select a Case");
            }

        }

        private void mediumTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Medium";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;

            if (caseOne_radioBtn.Checked)
            {
                adjacencyList.Clear();
                checkNode.Clear();
                read_CreateAdjacencyList("Complete Test Cases/medium/Case1/Movies967.txt");
                
            }
            else if (caseTwo_radioBtn.Checked)
            {
                adjacencyList.Clear();
                checkNode.Clear();
                read_CreateAdjacencyList("Complete Test Cases/medium/Case2/Movies4736.txt");

            }
            else
            {
                MessageBox.Show("Select a Case");
            }
            
            if (smallQuery_radioButton.Checked && caseOne_radioBtn.Checked)
            {
                // Case 1 - Small Query
                ReadQueriesFile("Complete Test Cases/medium/Case1/queries85.txt");
            }
            else if (largeQuery_radioButton.Checked && caseOne_radioBtn.Checked)
            {
                // Case 1 - Large Query
                ReadQueriesFile("Complete Test Cases/medium/Case1/queries4000.txt");
            }
            else if (largeQuery_radioButton.Checked && caseTwo_radioBtn.Checked)
            {
                // Case 2 - Large Query
                ReadQueriesFile("Complete Test Cases/medium/Case2/queries2000.txt");
            }
            else if (smallQuery_radioButton.Checked && caseTwo_radioBtn.Checked)
            {
                // Case 2 - Small Query
                ReadQueriesFile("Complete Test Cases/medium/Case2/queries110.txt");
            }
            else
            {
                MessageBox.Show("Select a query file");
            }
        }

        private void largeTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Large";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
            adjacencyList.Clear();
            checkNode.Clear();
            read_CreateAdjacencyList("Complete Test Cases/large/Movies14129.txt");
            if (smallQuery_radioButton.Checked)
            {
                ReadQueriesFile("Complete Test Cases/large/queries26.txt");
            }
            else if (largeQuery_radioButton.Checked)
            {
                ReadQueriesFile("Complete Test Cases/large/queries600.txt");
            }
            else
            {
                MessageBox.Show("Select a query file");
            }
        }

        private void extremeTest_btn_Click(object sender, EventArgs e)
        {
            testCase = "Extreme";
            selectedTestCaseLabel.Text = "Selected Test Case : " + testCase;
            adjacencyList.Clear();
            checkNode.Clear();
            read_CreateAdjacencyList("Complete Test Cases/extreme/Movies122806.txt");
            if (smallQuery_radioButton.Checked)
            {
                ReadQueriesFile("Complete Test Cases/extreme/queries22.txt");
            }
            else if (largeQuery_radioButton.Checked)
            {
                ReadQueriesFile("Complete Test Cases/extreme/queries200.txt");
            }
            else
            {
                MessageBox.Show("Select a query file");
            }
        }
        #endregion

        #region Reading from files and create the Adjacency List
        /// <summary>
        /// Read movie file according to selected test case and create the adjacency list
        /// </summary>
        /// <param name="filePath">The path of the file to be read</param>
        private void read_CreateAdjacencyList(string filePath)
        {
            adjacencyList.Clear(); // Clear all objects in the List
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)
                {
                    string record = sr.ReadLine();
                    string[] recordContent = record.Split('/');
                    string movie;
                    movie = recordContent[0];
                    for (int i = 1; i < recordContent.Length; i++)
                    {
                        if (!adjacencyList.ContainsKey(recordContent[i]))
                        {
                            adjacencyList[recordContent[i]] = new Dictionary<string, Relation_str>();
                            checkNode.Add(recordContent[i], new path());
                        }
                        for (int j = 1; j < recordContent.Length; j++)
                        {
                            if (adjacencyList[recordContent[i]].ContainsKey(recordContent[j]) && recordContent[i] != recordContent[j])
                            {
                                adjacencyList[recordContent[i]][recordContent[j]].Direct_Freq++;

                            }
                            else if (!adjacencyList[recordContent[i]].ContainsKey(recordContent[j]) && recordContent[i] != recordContent[j])
                            {
                                adjacencyList[recordContent[i]].Add(recordContent[j], new Relation_str(movie));
                            }
                        }
                    }
                }

                MessageBox.Show("Reading Complete from " + filePath);
                fs.Close();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        /// <summary>
        /// Read Queries file according to selected query
        /// </summary>
        /// <param name="filePath">The path of the file to be read</param>
        private void ReadQueriesFile(string filePath)
        {
            queriesActors.Clear(); // Clear all objects in the List

            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    string record = sr.ReadLine();
                    string[] recordContent = record.Split('/');
                    QueriesActors temp = new QueriesActors();
                    temp.actor1 = recordContent[0];
                    temp.actor2 = recordContent[1];
                    queriesActors.Add(temp);
                    //record = sr.ReadLine();
                }
                MessageBox.Show("Reading Complete from " + filePath);
                fs.Close();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        private void startAnalysis_btn_Click(object sender, EventArgs e)
        {
            string result = "";

            for (int i = 0; i < queriesActors.Count; i++)
            {
                Algorithms.BFS_Algorithm(adjacencyList, checkNode, queriesActors[i].actor1, queriesActors[i].actor2);
                result += "DoS = " + checkNode[queriesActors[i].actor2].distance + ", RS = " + checkNode[queriesActors[i].actor2].Undirect_Freq + "\n";
                string Actor = queriesActors[i].actor2;
                string Path_Of_Actors = Actor;
                string Path = "", Parent;
                while (Actor != queriesActors[i].actor1)
                {
                    Parent = checkNode[Actor].Parent;
                    Path_Of_Actors = Parent + "->" + Path_Of_Actors;
                    Path = adjacencyList[Actor][Parent].Common_Movie + "->" + Path;
                    Actor = Parent;
                }
                result += "Chain Of Movies :" + Path + "\n";
                result += "Chain Of Actors :" + Path_Of_Actors + "\n";
            }

            ResultText.Text = result;
        }


    }
}
