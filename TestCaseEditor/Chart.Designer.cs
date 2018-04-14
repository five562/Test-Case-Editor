namespace TestCaseEditor
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            this.dataChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.showChartButton = new System.Windows.Forms.Button();
            this.projectComboBox = new System.Windows.Forms.ComboBox();
            this.versionComboBox = new System.Windows.Forms.ComboBox();
            this.testerComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.TesterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataChart
            // 
            chartArea2.Name = "ChartArea1";
            this.dataChart.ChartAreas.Add(chartArea2);
            this.dataChart.Location = new System.Drawing.Point(411, 12);
            this.dataChart.Name = "dataChart";
            this.dataChart.Size = new System.Drawing.Size(1049, 725);
            this.dataChart.TabIndex = 0;
            this.dataChart.Text = "dataChart";
            // 
            // showChartButton
            // 
            this.showChartButton.Location = new System.Drawing.Point(145, 258);
            this.showChartButton.Name = "showChartButton";
            this.showChartButton.Size = new System.Drawing.Size(75, 23);
            this.showChartButton.TabIndex = 1;
            this.showChartButton.Text = "Show Data";
            this.showChartButton.UseVisualStyleBackColor = true;
            this.showChartButton.Click += new System.EventHandler(this.showChartButton_Click);
            // 
            // projectComboBox
            // 
            this.projectComboBox.FormattingEnabled = true;
            this.projectComboBox.Location = new System.Drawing.Point(133, 39);
            this.projectComboBox.Name = "projectComboBox";
            this.projectComboBox.Size = new System.Drawing.Size(229, 21);
            this.projectComboBox.TabIndex = 2;
            this.projectComboBox.SelectedIndexChanged += new System.EventHandler(this.projectComboBox_SelectedIndexChanged);
            // 
            // versionComboBox
            // 
            this.versionComboBox.FormattingEnabled = true;
            this.versionComboBox.Location = new System.Drawing.Point(133, 87);
            this.versionComboBox.Name = "versionComboBox";
            this.versionComboBox.Size = new System.Drawing.Size(229, 21);
            this.versionComboBox.TabIndex = 3;
            this.versionComboBox.SelectedIndexChanged += new System.EventHandler(this.versionComboBox_SelectedIndexChanged);
            // 
            // testerComboBox
            // 
            this.testerComboBox.FormattingEnabled = true;
            this.testerComboBox.Location = new System.Drawing.Point(133, 137);
            this.testerComboBox.Name = "testerComboBox";
            this.testerComboBox.Size = new System.Drawing.Size(229, 21);
            this.testerComboBox.TabIndex = 4;
            this.testerComboBox.SelectedIndexChanged += new System.EventHandler(this.testerComboBox_SelectedIndexChanged);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.Location = new System.Drawing.Point(42, 42);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(40, 13);
            this.ProjectLabel.TabIndex = 5;
            this.ProjectLabel.Text = "Project";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(45, 87);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(42, 13);
            this.VersionLabel.TabIndex = 6;
            this.VersionLabel.Text = "Version";
            // 
            // TesterLabel
            // 
            this.TesterLabel.AutoSize = true;
            this.TesterLabel.Location = new System.Drawing.Point(45, 144);
            this.TesterLabel.Name = "TesterLabel";
            this.TesterLabel.Size = new System.Drawing.Size(37, 13);
            this.TesterLabel.TabIndex = 7;
            this.TesterLabel.Text = "Tester";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 771);
            this.Controls.Add(this.TesterLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.testerComboBox);
            this.Controls.Add(this.versionComboBox);
            this.Controls.Add(this.projectComboBox);
            this.Controls.Add(this.showChartButton);
            this.Controls.Add(this.dataChart);
            this.Name = "Chart";
            this.Text = "Chart";
            ((System.ComponentModel.ISupportInitialize)(this.dataChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart dataChart;
        private System.Windows.Forms.Button showChartButton;
        private System.Windows.Forms.ComboBox projectComboBox;
        private System.Windows.Forms.ComboBox versionComboBox;
        private System.Windows.Forms.ComboBox testerComboBox;
        private System.Windows.Forms.Label ProjectLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label TesterLabel;
    }
}