﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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
        Stopwatch stopwatch = new Stopwatch();
        
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
                ReadQueriesFile("Complete Test Cases/small/Case2/queries50.txt");
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
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                while (sr.Peek() != -1)    //Θ(J * n * k^2) assume J stands for number of records within the file
                {
                    string record = sr.ReadLine();                  //Θ(1)
                    string[] recordContent = record.Split('/');     //Θ(n)
                    string movie;                                   //Θ(1)
                    movie = recordContent[0];                       //Θ(1)
                    for (int i = 1; i < recordContent.Length; i++)  //Θ(n * k^2) assume k stands for length of the list(recordContent)
                    {
                        if (!adjacencyList.ContainsKey(recordContent[i]))    //Θ(n) assume n stands for number of elements in the (adjacencyList)
                        {
                            adjacencyList[recordContent[i]] = new Dictionary<string, Relation_str>();  //Θ(1)
                            checkNode.Add(recordContent[i], new path());                           //Θ(1)
                        }
                        for (int j = 1; j < recordContent.Length; j++) //Θ(n * k) assume k stands for length of the list(recordContent)
                        {
                            if (adjacencyList[recordContent[i]].ContainsKey(recordContent[j]) && recordContent[i] != recordContent[j])   //Θ(n) Check if that key existe 
                            {
                                adjacencyList[recordContent[i]][recordContent[j]].Direct_Freq++;     //Θ(1)increament the Relation Strength

                            }
                            else if (!adjacencyList[recordContent[i]].ContainsKey(recordContent[j]) && recordContent[i] != recordContent[j])//Θ(n) 
                            {
                                adjacencyList[recordContent[i]].Add(recordContent[j], new Relation_str(movie));    //Θ(1) 
                            }
                        }
                    }
                }

                MessageBox.Show("Reading Complete from " + filePath);
                fs.Close();      //Θ(1)
                sr.Close();      //Θ(1)
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
            try
            {
                FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                while (sr.Peek() != -1)
                {
                    string record = sr.ReadLine();      //Θ(1)
                    string[] recordContent = record.Split('/');   //Θ(n)
                    QueriesActors temp = new QueriesActors();     //Θ(1)
                    temp.actor1 = recordContent[0];     //Θ(1)
                    temp.actor2 = recordContent[1];     //Θ(1)
                    queriesActors.Add(temp);   //Θ(1) or Θ(n) if the list need to be extended
                }
                MessageBox.Show("Reading Complete from " + filePath);
                fs.Close();    //Θ(1)
                sr.Close();    //Θ(1)
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        private void startAnalysis_btn_Click(object sender, EventArgs e)
        {
            stopwatch.Start();   //Θ(1)
            string result = "";   //Θ(1)

            for (int i = 0; i < queriesActors.Count; i++)    //  //Θ(n) assume n stands for number of elements in the (queriesActors)
            {
                Algorithms.BFS_Algorithm(adjacencyList, checkNode, queriesActors[i].actor1, queriesActors[i].actor2);
                result += "DoS = " + checkNode[queriesActors[i].actor2].distance + ", RS = " + checkNode[queriesActors[i].actor2].Undirect_Freq + "\n";  //Θ(1)
                string Actor = queriesActors[i].actor2;  //Θ(1)
                string Path_Of_Actors = Actor;   //Θ(1)
                string Path = "", Parent;  //Θ(1)

                while (Actor != queriesActors[i].actor1)    //can not be determined
                {
                    Parent = checkNode[Actor].Parent;  //Θ(1)  
                    Path_Of_Actors = Parent + "=>" + Path_Of_Actors;   //Θ(1)
                    Path = adjacencyList[Actor][Parent].Common_Movie + "=>" + Path;   //Θ(1)
                    Actor = Parent;   //Θ(1)
                }

                result += "CHAIN OF ACTORS : " + Path_Of_Actors + "\n";   //Θ(1)
                result += "CHAIN OF MOVIES : " + Path + "\n\n";     //Θ(1)
            }  

            ResultText.Text = result;   //Θ(1)
            stopwatch.Stop();   //Θ(1)
            stopWatchText.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";   //Θ(1)
        }

        private void ClearAllData_Btn_Click(object sender, EventArgs e)
        {
            adjacencyList.Clear();   //Θ(1)
            checkNode.Clear();   //Θ(1)
            queriesActors.Clear();   //Θ(1)
            ResultText.Text = "";   //Θ(1)
            stopWatchText.Text = "0 ms";   //Θ(1)
            testCase = "";   //Θ(1)
            selectedTestCaseLabel.Text = "Selected Test Case : None";   //Θ(1)
            stopwatch.Reset();   //Θ(1)
        }
    }
}
