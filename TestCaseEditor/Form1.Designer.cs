namespace TestCaseEditor
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
            this.testCaseEditorLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.moduleLabel = new System.Windows.Forms.Label();
            this.projectNameComboBox = new System.Windows.Forms.ComboBox();
            this.versionComboBox = new System.Windows.Forms.ComboBox();
            this.moduleComboBox = new System.Windows.Forms.ComboBox();
            this.createdByLabel = new System.Windows.Forms.Label();
            this.executedByLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.passFailLabel = new System.Windows.Forms.Label();
            this.createdByComboBox = new System.Windows.Forms.ComboBox();
            this.executedByComboBox = new System.Windows.Forms.ComboBox();
            this.dateTextBox = new System.Windows.Forms.TextBox();
            this.passFailComboBox = new System.Windows.Forms.ComboBox();
            this.testCaseIdLabel = new System.Windows.Forms.Label();
            this.testCaseIdTextBox = new System.Windows.Forms.TextBox();
            this.stepLabel = new System.Windows.Forms.Label();
            this.stepRichTextBox = new System.Windows.Forms.RichTextBox();
            this.expectationLabel = new System.Windows.Forms.Label();
            this.commentLabel = new System.Windows.Forms.Label();
            this.expectationRichTextBox = new System.Windows.Forms.RichTextBox();
            this.commentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.getButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testCaseEditorLabel
            // 
            this.testCaseEditorLabel.AutoSize = true;
            this.testCaseEditorLabel.Location = new System.Drawing.Point(679, 13);
            this.testCaseEditorLabel.Name = "testCaseEditorLabel";
            this.testCaseEditorLabel.Size = new System.Drawing.Size(85, 13);
            this.testCaseEditorLabel.TabIndex = 0;
            this.testCaseEditorLabel.Text = "Text Case Editor";
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(36, 43);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(71, 13);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "Project Name";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(36, 74);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 2;
            this.versionLabel.Text = "Version";
            // 
            // moduleLabel
            // 
            this.moduleLabel.AutoSize = true;
            this.moduleLabel.Location = new System.Drawing.Point(36, 104);
            this.moduleLabel.Name = "moduleLabel";
            this.moduleLabel.Size = new System.Drawing.Size(42, 13);
            this.moduleLabel.TabIndex = 3;
            this.moduleLabel.Text = "Module";
            // 
            // projectNameComboBox
            // 
            this.projectNameComboBox.FormattingEnabled = true;
            //setComboBoxList("C:\\TestCases", this.projectNameComboBox);
            //this.projectNameComboBox.Items.AddRange(new object[] {"Project1", "Project2", "Project3"});
            this.projectNameComboBox.Location = new System.Drawing.Point(113, 40);
            this.projectNameComboBox.Name = "projectNameComboBox";
            this.projectNameComboBox.Size = new System.Drawing.Size(342, 21);
            this.projectNameComboBox.TabIndex = 5;
            this.projectNameComboBox.SelectedIndexChanged += new System.EventHandler(this.projectNameComboBox_SelectedIndexChanged);
            // 
            // versionComboBox
            // 
            this.versionComboBox.FormattingEnabled = true;
            //this.versionComboBox.Items.AddRange(new object[] {"Version1","Version2","Version3"});
            this.versionComboBox.Location = new System.Drawing.Point(113, 71);
            this.versionComboBox.Name = "versionComboBox";
            this.versionComboBox.Size = new System.Drawing.Size(342, 21);
            this.versionComboBox.TabIndex = 6;
            this.versionComboBox.SelectedIndexChanged += new System.EventHandler(this.versionComboBox_SelectedIndexChanged);
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.FormattingEnabled = true;
            //this.moduleComboBox.Items.AddRange(new object[] {"Module1","Module2","Module3",});
            this.moduleComboBox.Location = new System.Drawing.Point(113, 101);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.Size = new System.Drawing.Size(342, 21);
            this.moduleComboBox.TabIndex = 7;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // createdByLabel
            // 
            this.createdByLabel.AutoSize = true;
            this.createdByLabel.Location = new System.Drawing.Point(502, 43);
            this.createdByLabel.Name = "createdByLabel";
            this.createdByLabel.Size = new System.Drawing.Size(59, 13);
            this.createdByLabel.TabIndex = 8;
            this.createdByLabel.Text = "Created By";
            this.createdByLabel.Click += new System.EventHandler(this.createdByLabel_Click);
            // 
            // executedByLabel
            // 
            this.executedByLabel.AutoSize = true;
            this.executedByLabel.Location = new System.Drawing.Point(502, 74);
            this.executedByLabel.Name = "executedByLabel";
            this.executedByLabel.Size = new System.Drawing.Size(67, 13);
            this.executedByLabel.TabIndex = 9;
            this.executedByLabel.Text = "Executed By";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(505, 104);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(71, 26);
            this.dateLabel.TabIndex = 10;
            this.dateLabel.Text = "Date\n(mm/dd/yyyy)";
            // 
            // passFailLabel
            // 
            this.passFailLabel.AutoSize = true;
            this.passFailLabel.Location = new System.Drawing.Point(812, 74);
            this.passFailLabel.Name = "passFailLabel";
            this.passFailLabel.Size = new System.Drawing.Size(57, 13);
            this.passFailLabel.TabIndex = 11;
            this.passFailLabel.Text = "Pass / Fail";
            // 
            // createdByComboBox
            // 
            this.createdByComboBox.FormattingEnabled = true;
            this.createdByComboBox.Items.AddRange(new object[] {"Name1","Name2","Name3"});
            this.createdByComboBox.Location = new System.Drawing.Point(575, 35);
            this.createdByComboBox.Name = "createdByComboBox";
            this.createdByComboBox.Size = new System.Drawing.Size(184, 21);
            this.createdByComboBox.TabIndex = 12;
            this.createdByComboBox.SelectedIndexChanged += new System.EventHandler(this.createdByComboBox_SelectedIndexChanged);
            // 
            // executedByComboBox
            // 
            this.executedByComboBox.Enabled = false;
            this.executedByComboBox.FormattingEnabled = true;
            this.executedByComboBox.Items.AddRange(new object[] {"Tester1","Tester2","Tester3"});
            this.executedByComboBox.Location = new System.Drawing.Point(575, 70);
            this.executedByComboBox.Name = "executedByComboBox";
            this.executedByComboBox.Size = new System.Drawing.Size(184, 21);
            this.executedByComboBox.TabIndex = 13;
            this.executedByComboBox.SelectedIndexChanged += new System.EventHandler(this.executedByComboBox_SelectedIndexChanged);
            // 
            // dateTextBox
            // 
            this.dateTextBox.Enabled = false;
            this.dateTextBox.Location = new System.Drawing.Point(575, 102);
            this.dateTextBox.Name = "dateTextBox";
            this.dateTextBox.Size = new System.Drawing.Size(184, 20);
            this.dateTextBox.TabIndex = 14;
            this.dateTextBox.TextChanged += new System.EventHandler(this.dateTextBox_TextChanged);
            // 
            // passFailComboBox
            // 
            this.passFailComboBox.Enabled = false;
            this.passFailComboBox.FormattingEnabled = true;
            this.passFailComboBox.Items.AddRange(new string[] {
            "Pass",
            "Failed",
            " "});
            this.passFailComboBox.Location = new System.Drawing.Point(887, 66);
            this.passFailComboBox.Name = "passFailComboBox";
            this.passFailComboBox.Size = new System.Drawing.Size(121, 21);
            this.passFailComboBox.TabIndex = 15;
            this.passFailComboBox.SelectedIndexChanged += new System.EventHandler(this.passFailComboBox_SelectedIndexChanged);
            // 
            // testCaseIdLabel
            // 
            this.testCaseIdLabel.AutoSize = true;
            this.testCaseIdLabel.Location = new System.Drawing.Point(812, 43);
            this.testCaseIdLabel.Name = "testCaseIdLabel";
            this.testCaseIdLabel.Size = new System.Drawing.Size(69, 13);
            this.testCaseIdLabel.TabIndex = 16;
            this.testCaseIdLabel.Text = "Test Case ID";
            // 
            // testCaseIdTextBox
            // 
            this.testCaseIdTextBox.Location = new System.Drawing.Point(887, 40);
            this.testCaseIdTextBox.Name = "testCaseIdTextBox";
            this.testCaseIdTextBox.Size = new System.Drawing.Size(206, 20);
            this.testCaseIdTextBox.TabIndex = 17;
            this.testCaseIdTextBox.TextChanged += new System.EventHandler(this.testCaseIdTextBox_TextChanged);
            // 
            // stepLabel
            // 
            this.stepLabel.AutoSize = true;
            this.stepLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepLabel.Location = new System.Drawing.Point(38, 144);
            this.stepLabel.Name = "stepLabel";
            this.stepLabel.Size = new System.Drawing.Size(57, 20);
            this.stepLabel.TabIndex = 18;
            this.stepLabel.Text = "Step :";
            // 
            // stepRichTextBox
            // 
            this.stepRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepRichTextBox.Location = new System.Drawing.Point(42, 167);
            this.stepRichTextBox.Name = "stepRichTextBox";
            this.stepRichTextBox.Size = new System.Drawing.Size(413, 571);
            this.stepRichTextBox.TabIndex = 19;
            this.stepRichTextBox.Text = "";
            this.stepRichTextBox.TextChanged += new System.EventHandler(this.stepRichTextBox_TextChanged);
            // 
            // expectationLabel
            // 
            this.expectationLabel.AutoSize = true;
            this.expectationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectationLabel.Location = new System.Drawing.Point(505, 144);
            this.expectationLabel.Name = "expectationLabel";
            this.expectationLabel.Size = new System.Drawing.Size(114, 20);
            this.expectationLabel.TabIndex = 20;
            this.expectationLabel.Text = "Expectation :";
            // 
            // commentLabel
            // 
            this.commentLabel.AutoSize = true;
            this.commentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentLabel.Location = new System.Drawing.Point(952, 144);
            this.commentLabel.Name = "commentLabel";
            this.commentLabel.Size = new System.Drawing.Size(95, 20);
            this.commentLabel.TabIndex = 21;
            this.commentLabel.Text = "Comment :";
            // 
            // expectationRichTextBox
            // 
            this.expectationRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectationRichTextBox.Location = new System.Drawing.Point(509, 167);
            this.expectationRichTextBox.Name = "expectationRichTextBox";
            this.expectationRichTextBox.Size = new System.Drawing.Size(393, 571);
            this.expectationRichTextBox.TabIndex = 22;
            this.expectationRichTextBox.Text = "";
            this.expectationRichTextBox.TextChanged += new System.EventHandler(this.expectationRichTextBox_TextChanged);
            // 
            // commentRichTextBox
            // 
            this.commentRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentRichTextBox.Location = new System.Drawing.Point(956, 167);
            this.commentRichTextBox.Name = "commentRichTextBox";
            this.commentRichTextBox.Size = new System.Drawing.Size(398, 571);
            this.commentRichTextBox.TabIndex = 23;
            this.commentRichTextBox.Text = "";
            this.commentRichTextBox.TextChanged += new System.EventHandler(this.commentRichTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(1229, 104);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(125, 27);
            this.saveButton.TabIndex = 24;
            this.saveButton.Text = "SAVE TEST CASE";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(1229, 71);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(125, 23);
            this.getButton.TabIndex = 25;
            this.getButton.Text = "GET TEST CASE";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 783);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.commentRichTextBox);
            this.Controls.Add(this.expectationRichTextBox);
            this.Controls.Add(this.commentLabel);
            this.Controls.Add(this.expectationLabel);
            this.Controls.Add(this.stepRichTextBox);
            this.Controls.Add(this.stepLabel);
            this.Controls.Add(this.testCaseIdTextBox);
            this.Controls.Add(this.testCaseIdLabel);
            this.Controls.Add(this.passFailComboBox);
            this.Controls.Add(this.dateTextBox);
            this.Controls.Add(this.executedByComboBox);
            this.Controls.Add(this.createdByComboBox);
            this.Controls.Add(this.passFailLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.executedByLabel);
            this.Controls.Add(this.createdByLabel);
            this.Controls.Add(this.moduleComboBox);
            this.Controls.Add(this.versionComboBox);
            this.Controls.Add(this.projectNameComboBox);
            this.Controls.Add(this.moduleLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.testCaseEditorLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label testCaseEditorLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label moduleLabel;
        private System.Windows.Forms.ComboBox projectNameComboBox;
        private System.Windows.Forms.ComboBox versionComboBox;
        private System.Windows.Forms.ComboBox moduleComboBox;
        private System.Windows.Forms.Label createdByLabel;
        private System.Windows.Forms.Label executedByLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label passFailLabel;
        private System.Windows.Forms.ComboBox createdByComboBox;
        private System.Windows.Forms.ComboBox executedByComboBox;
        private System.Windows.Forms.TextBox dateTextBox;
        private System.Windows.Forms.ComboBox passFailComboBox;
        private System.Windows.Forms.Label testCaseIdLabel;
        private System.Windows.Forms.TextBox testCaseIdTextBox;
        private System.Windows.Forms.Label stepLabel;
        private System.Windows.Forms.RichTextBox stepRichTextBox;
        private System.Windows.Forms.Label expectationLabel;
        private System.Windows.Forms.Label commentLabel;
        private System.Windows.Forms.RichTextBox expectationRichTextBox;
        private System.Windows.Forms.RichTextBox commentRichTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button getButton;
    }
}

