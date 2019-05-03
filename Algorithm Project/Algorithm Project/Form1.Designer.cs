namespace Algorithm_Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sampleTest_btn = new System.Windows.Forms.Button();
            this.smallTest_btn = new System.Windows.Forms.Button();
            this.mediumTest_btn = new System.Windows.Forms.Button();
            this.largeTest_btn = new System.Windows.Forms.Button();
            this.extremeTest_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nonOptimized_radioBtn = new System.Windows.Forms.RadioButton();
            this.optimized_radioBtn = new System.Windows.Forms.RadioButton();
            this.selectedTestCaseLabel = new System.Windows.Forms.Label();
            this.startAnalysis_btn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.caseTwo_radioBtn = new System.Windows.Forms.RadioButton();
            this.caseOne_radioBtn = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.largeQuery_radioButton = new System.Windows.Forms.RadioButton();
            this.smallQuery_radioButton = new System.Windows.Forms.RadioButton();
            this.ResultText = new System.Windows.Forms.RichTextBox();
            this.stopWatchText = new System.Windows.Forms.TextBox();
            this.clearAllData_Btn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.bonusTab = new System.Windows.Forms.TabPage();
            this.bonusResultText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.actorName_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.bonusTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // sampleTest_btn
            // 
            this.sampleTest_btn.Location = new System.Drawing.Point(8, 30);
            this.sampleTest_btn.Name = "sampleTest_btn";
            this.sampleTest_btn.Size = new System.Drawing.Size(116, 64);
            this.sampleTest_btn.TabIndex = 0;
            this.sampleTest_btn.Text = "Sample Test Cases";
            this.sampleTest_btn.UseVisualStyleBackColor = true;
            this.sampleTest_btn.Click += new System.EventHandler(this.sampleTest_btn_Click);
            // 
            // smallTest_btn
            // 
            this.smallTest_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallTest_btn.Location = new System.Drawing.Point(4, 28);
            this.smallTest_btn.Name = "smallTest_btn";
            this.smallTest_btn.Size = new System.Drawing.Size(116, 64);
            this.smallTest_btn.TabIndex = 1;
            this.smallTest_btn.Text = "Small Test Cases";
            this.smallTest_btn.UseVisualStyleBackColor = true;
            this.smallTest_btn.Click += new System.EventHandler(this.smallTest_btn_Click);
            // 
            // mediumTest_btn
            // 
            this.mediumTest_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumTest_btn.Location = new System.Drawing.Point(126, 28);
            this.mediumTest_btn.Name = "mediumTest_btn";
            this.mediumTest_btn.Size = new System.Drawing.Size(116, 64);
            this.mediumTest_btn.TabIndex = 2;
            this.mediumTest_btn.Text = "Medium Test Cases";
            this.mediumTest_btn.UseVisualStyleBackColor = true;
            this.mediumTest_btn.Click += new System.EventHandler(this.mediumTest_btn_Click);
            // 
            // largeTest_btn
            // 
            this.largeTest_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeTest_btn.Location = new System.Drawing.Point(248, 28);
            this.largeTest_btn.Name = "largeTest_btn";
            this.largeTest_btn.Size = new System.Drawing.Size(116, 64);
            this.largeTest_btn.TabIndex = 3;
            this.largeTest_btn.Text = "Large Test Cases";
            this.largeTest_btn.UseVisualStyleBackColor = true;
            this.largeTest_btn.Click += new System.EventHandler(this.largeTest_btn_Click);
            // 
            // extremeTest_btn
            // 
            this.extremeTest_btn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extremeTest_btn.Location = new System.Drawing.Point(370, 28);
            this.extremeTest_btn.Name = "extremeTest_btn";
            this.extremeTest_btn.Size = new System.Drawing.Size(116, 64);
            this.extremeTest_btn.TabIndex = 4;
            this.extremeTest_btn.Text = "Extreme Test Cases";
            this.extremeTest_btn.UseVisualStyleBackColor = true;
            this.extremeTest_btn.Click += new System.EventHandler(this.extremeTest_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.extremeTest_btn);
            this.groupBox1.Controls.Add(this.smallTest_btn);
            this.groupBox1.Controls.Add(this.largeTest_btn);
            this.groupBox1.Controls.Add(this.mediumTest_btn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 109);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Complete Test Cases";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nonOptimized_radioBtn);
            this.groupBox2.Controls.Add(this.optimized_radioBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(628, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 56);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Analysis type";
            // 
            // nonOptimized_radioBtn
            // 
            this.nonOptimized_radioBtn.AutoSize = true;
            this.nonOptimized_radioBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nonOptimized_radioBtn.ForeColor = System.Drawing.Color.Red;
            this.nonOptimized_radioBtn.Location = new System.Drawing.Point(131, 28);
            this.nonOptimized_radioBtn.Name = "nonOptimized_radioBtn";
            this.nonOptimized_radioBtn.Size = new System.Drawing.Size(147, 25);
            this.nonOptimized_radioBtn.TabIndex = 1;
            this.nonOptimized_radioBtn.TabStop = true;
            this.nonOptimized_radioBtn.Text = "Non-Optimized";
            this.nonOptimized_radioBtn.UseVisualStyleBackColor = true;
            // 
            // optimized_radioBtn
            // 
            this.optimized_radioBtn.AutoSize = true;
            this.optimized_radioBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optimized_radioBtn.ForeColor = System.Drawing.Color.Green;
            this.optimized_radioBtn.Location = new System.Drawing.Point(18, 28);
            this.optimized_radioBtn.Name = "optimized_radioBtn";
            this.optimized_radioBtn.Size = new System.Drawing.Size(107, 25);
            this.optimized_radioBtn.TabIndex = 0;
            this.optimized_radioBtn.TabStop = true;
            this.optimized_radioBtn.Text = "Optimized";
            this.optimized_radioBtn.UseVisualStyleBackColor = true;
            // 
            // selectedTestCaseLabel
            // 
            this.selectedTestCaseLabel.AutoSize = true;
            this.selectedTestCaseLabel.Location = new System.Drawing.Point(4, 114);
            this.selectedTestCaseLabel.Name = "selectedTestCaseLabel";
            this.selectedTestCaseLabel.Size = new System.Drawing.Size(207, 21);
            this.selectedTestCaseLabel.TabIndex = 8;
            this.selectedTestCaseLabel.Text = "Selected Test Case : None";
            // 
            // startAnalysis_btn
            // 
            this.startAnalysis_btn.BackColor = System.Drawing.Color.Lime;
            this.startAnalysis_btn.Location = new System.Drawing.Point(8, 640);
            this.startAnalysis_btn.Name = "startAnalysis_btn";
            this.startAnalysis_btn.Size = new System.Drawing.Size(92, 70);
            this.startAnalysis_btn.TabIndex = 9;
            this.startAnalysis_btn.Text = "Start Analysis";
            this.startAnalysis_btn.UseVisualStyleBackColor = false;
            this.startAnalysis_btn.Click += new System.EventHandler(this.startAnalysis_btn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.caseTwo_radioBtn);
            this.groupBox3.Controls.Add(this.caseOne_radioBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(628, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 50);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Case number";
            // 
            // caseTwo_radioBtn
            // 
            this.caseTwo_radioBtn.AutoSize = true;
            this.caseTwo_radioBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseTwo_radioBtn.Location = new System.Drawing.Point(131, 19);
            this.caseTwo_radioBtn.Name = "caseTwo_radioBtn";
            this.caseTwo_radioBtn.Size = new System.Drawing.Size(78, 25);
            this.caseTwo_radioBtn.TabIndex = 1;
            this.caseTwo_radioBtn.TabStop = true;
            this.caseTwo_radioBtn.Text = "Case 2";
            this.caseTwo_radioBtn.UseVisualStyleBackColor = true;
            // 
            // caseOne_radioBtn
            // 
            this.caseOne_radioBtn.AutoSize = true;
            this.caseOne_radioBtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caseOne_radioBtn.Location = new System.Drawing.Point(18, 19);
            this.caseOne_radioBtn.Name = "caseOne_radioBtn";
            this.caseOne_radioBtn.Size = new System.Drawing.Size(78, 25);
            this.caseOne_radioBtn.TabIndex = 0;
            this.caseOne_radioBtn.TabStop = true;
            this.caseOne_radioBtn.Text = "Case 1";
            this.caseOne_radioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.largeQuery_radioButton);
            this.groupBox4.Controls.Add(this.smallQuery_radioButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Underline);
            this.groupBox4.Location = new System.Drawing.Point(628, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 60);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select Queries file";
            // 
            // largeQuery_radioButton
            // 
            this.largeQuery_radioButton.AutoSize = true;
            this.largeQuery_radioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largeQuery_radioButton.Location = new System.Drawing.Point(131, 29);
            this.largeQuery_radioButton.Name = "largeQuery_radioButton";
            this.largeQuery_radioButton.Size = new System.Drawing.Size(70, 25);
            this.largeQuery_radioButton.TabIndex = 1;
            this.largeQuery_radioButton.TabStop = true;
            this.largeQuery_radioButton.Text = "Large";
            this.largeQuery_radioButton.UseVisualStyleBackColor = true;
            // 
            // smallQuery_radioButton
            // 
            this.smallQuery_radioButton.AutoSize = true;
            this.smallQuery_radioButton.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallQuery_radioButton.Location = new System.Drawing.Point(18, 29);
            this.smallQuery_radioButton.Name = "smallQuery_radioButton";
            this.smallQuery_radioButton.Size = new System.Drawing.Size(69, 25);
            this.smallQuery_radioButton.TabIndex = 0;
            this.smallQuery_radioButton.TabStop = true;
            this.smallQuery_radioButton.Text = "Small";
            this.smallQuery_radioButton.UseVisualStyleBackColor = true;
            // 
            // ResultText
            // 
            this.ResultText.Location = new System.Drawing.Point(3, 6);
            this.ResultText.Name = "ResultText";
            this.ResultText.ReadOnly = true;
            this.ResultText.Size = new System.Drawing.Size(887, 404);
            this.ResultText.TabIndex = 12;
            this.ResultText.Text = "";
            // 
            // stopWatchText
            // 
            this.stopWatchText.Enabled = false;
            this.stopWatchText.Location = new System.Drawing.Point(378, 114);
            this.stopWatchText.Name = "stopWatchText";
            this.stopWatchText.ReadOnly = true;
            this.stopWatchText.Size = new System.Drawing.Size(154, 29);
            this.stopWatchText.TabIndex = 13;
            this.stopWatchText.Text = "0 ms";
            // 
            // clearAllData_Btn
            // 
            this.clearAllData_Btn.BackColor = System.Drawing.Color.Red;
            this.clearAllData_Btn.Location = new System.Drawing.Point(106, 640);
            this.clearAllData_Btn.Name = "clearAllData_Btn";
            this.clearAllData_Btn.Size = new System.Drawing.Size(92, 70);
            this.clearAllData_Btn.TabIndex = 14;
            this.clearAllData_Btn.Text = "Clear all data";
            this.clearAllData_Btn.UseVisualStyleBackColor = false;
            this.clearAllData_Btn.Click += new System.EventHandler(this.ClearAllData_Btn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.bonusTab);
            this.tabControl1.Location = new System.Drawing.Point(8, 178);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(904, 456);
            this.tabControl1.TabIndex = 15;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.ResultText);
            this.mainTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTab.Location = new System.Drawing.Point(4, 30);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(896, 416);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Main Deliverables";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // bonusTab
            // 
            this.bonusTab.Controls.Add(this.button1);
            this.bonusTab.Controls.Add(this.actorName_txt);
            this.bonusTab.Controls.Add(this.label1);
            this.bonusTab.Controls.Add(this.bonusResultText);
            this.bonusTab.Location = new System.Drawing.Point(4, 30);
            this.bonusTab.Name = "bonusTab";
            this.bonusTab.Padding = new System.Windows.Forms.Padding(3);
            this.bonusTab.Size = new System.Drawing.Size(896, 422);
            this.bonusTab.TabIndex = 1;
            this.bonusTab.Text = "Bonus";
            this.bonusTab.UseVisualStyleBackColor = true;
            // 
            // bonusResultText
            // 
            this.bonusResultText.Location = new System.Drawing.Point(5, 54);
            this.bonusResultText.Name = "bonusResultText";
            this.bonusResultText.ReadOnly = true;
            this.bonusResultText.Size = new System.Drawing.Size(887, 356);
            this.bonusResultText.TabIndex = 13;
            this.bonusResultText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter actor\'s name :";
            // 
            // actorName_txt
            // 
            this.actorName_txt.Location = new System.Drawing.Point(168, 19);
            this.actorName_txt.Name = "actorName_txt";
            this.actorName_txt.Size = new System.Drawing.Size(239, 29);
            this.actorName_txt.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Time taken :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(929, 722);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.clearAllData_Btn);
            this.Controls.Add(this.stopWatchText);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.startAnalysis_btn);
            this.Controls.Add(this.selectedTestCaseLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sampleTest_btn);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Small World Phenomenon";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.bonusTab.ResumeLayout(false);
            this.bonusTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sampleTest_btn;
        private System.Windows.Forms.Button smallTest_btn;
        private System.Windows.Forms.Button mediumTest_btn;
        private System.Windows.Forms.Button largeTest_btn;
        private System.Windows.Forms.Button extremeTest_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton nonOptimized_radioBtn;
        private System.Windows.Forms.RadioButton optimized_radioBtn;
        private System.Windows.Forms.Label selectedTestCaseLabel;
        private System.Windows.Forms.Button startAnalysis_btn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton caseTwo_radioBtn;
        private System.Windows.Forms.RadioButton caseOne_radioBtn;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton largeQuery_radioButton;
        private System.Windows.Forms.RadioButton smallQuery_radioButton;
        private System.Windows.Forms.RichTextBox ResultText;
        private System.Windows.Forms.TextBox stopWatchText;
        private System.Windows.Forms.Button clearAllData_Btn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage bonusTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox actorName_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox bonusResultText;
        private System.Windows.Forms.Label label2;
    }
}