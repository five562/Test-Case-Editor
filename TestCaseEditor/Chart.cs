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
using System.Windows.Forms.DataVisualization.Charting;

namespace TestCaseEditor
{
    public partial class Chart : Form
    {
        string fileDirectory = @"C:\TestCases";
        public Chart()
        {
            InitializeComponent();
            setComboBoxItems(projectComboBox, getItems(fileDirectory));
        }

        private void projectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileDirectory += @"\" + projectComboBox.Text;
            setComboBoxItems(versionComboBox, getItems(fileDirectory));
            fileDirectory = @"C:\TestCases";
        }

        private void versionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void testerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showChartButton_Click(object sender, EventArgs e)
        {
            fileDirectory += @"\" + projectComboBox.Text + @"\" + versionComboBox.Text;
            setChart(fileDirectory);
            fileDirectory = @"C:\TestCases";
            versionComboBox.Items.Clear();
        }

        public void setChart(string directory)
        {
            this.dataChart.Series.Clear();
            this.dataChart.Titles.Clear();
            this.dataChart.Titles.Add("Module Data");
            Series series = this.dataChart.Series.Add("Module Data");
            Series resultSeries = this.dataChart.Series.Add("Result Data");
            series.ChartType = SeriesChartType.Column;
            resultSeries.ChartType = SeriesChartType.Column;

            //Prepare X and Y values
            string[] modules = getItems(directory);
            foreach(string module in modules)
            {
                string[] testCaseList = Directory.GetFiles(directory + @"\" + module + @"\TestCases\");
                string[] testResultList = Directory.GetFiles(directory + @"\" + module + @"\TestResults\");
                double x = testCaseList.Length;
                double y = testResultList.Length;
                series.Points.AddXY(module, x );
                resultSeries.Points.AddXY(module, y );
            }
        }

        public string[] getItems(string directory)
        {
            List<string> nameList = new List<string>();
            try
            {
                if (Directory.Exists(directory))
                {
                    string[] fileEntries = Directory.GetDirectories(directory);
                    foreach (string file in fileEntries)
                    {
                        nameList.Add(Path.GetFileName(file));
                    }
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
            return nameList.ToArray();
        }

        public void setComboBoxItems(ComboBox combox, string[] items)
        {
            foreach(string item in items)
            {
                combox.Items.Add(item);
            }
        }
    }
}
