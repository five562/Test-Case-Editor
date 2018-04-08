using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace TestCaseEditor
{
    public partial class Form1 : Form
    {
        //Variables
        Dictionary<string, string[]> filePaths = new Dictionary<string, string[]>();
        Dictionary<string, string> fileName = new Dictionary<string, string>();
        Dictionary<string, string> xmlFileNode = new Dictionary<string, string>();

        public class newTestCase
        {
            public string project;

            public string version;
            public string module;
            public string createdBy;
            public string executedBy;
            public string date;
            public string passFail;
            public string testCaseId;
            public string step;
            public string expectation;
            public string comment;
        }


        public Form1()
        {
            InitializeComponent();
            setComboBoxList("C:\\TestCases", this.projectNameComboBox);
        }


        private void createdByLabel_Click(object sender, EventArgs e)
        {

        }

        private void projectNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            versionComboBox.Text = "";
            moduleComboBox.Text = "";
            versionComboBox.Items.Clear();
            moduleComboBox.Items.Clear();
            generateFilePaths();
            setComboBoxList(filePaths["Version"][0], this.versionComboBox);
            filePaths.Clear();
            fileName.Clear();
        }

        private void versionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            moduleComboBox.Text = "";
            moduleComboBox.Items.Clear();
            generateFilePaths();
            setComboBoxList(filePaths["Module"][0], this.moduleComboBox);
            filePaths.Clear();
            fileName.Clear();
        }

        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void createdByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void executedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passFailComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void testCaseIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stepRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void expectationRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void commentRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                generateFilePaths();
                saveFile();
                MessageBox.Show("File is saved sucessfully");
                cleanTextBoxes();
                filePaths.Clear();
                fileName.Clear();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Invalid xml file path");
                Console.WriteLine(ex.ToString());
            }
        }

        //This method will return the names of existed folders/files in the given directory
        public static List<string> processDirectory(string targetDirectory)
        {
            List<string> folderNameList = new List<string>();
            string[] fileEntries = Directory.GetDirectories(targetDirectory);
            foreach (string fileName in fileEntries)
            {
                folderNameList.Add(Path.GetFileName(fileName));
            }
            return folderNameList;
        }

        //Edit comboBox item list
        public void setComboBoxList(string directory, ComboBox comboBox)
        {
            HashSet<string> itemsList = new HashSet<string>();
            if (Directory.Exists(directory))
            {
                foreach (string project in processDirectory(directory))
                {
                    itemsList.Add(project);
                }
                foreach (string item in itemsList)
                {
                    comboBox.Items.Add(item);
                }
            }
        }

        private void getButton_Click(object sender, EventArgs e)
        {
            generateFilePaths();
            XmlParser p = new XmlParser();
            Dictionary<string, string> xmlFile = p.loadXmlFile(filePaths["TestCasePath"][0], filePaths["TestCasePath"][1]);
            presentDataFromXmlFile();
            executedByComboBox.Enabled = true;
            dateTextBox.Enabled = true;
            passFailComboBox.Enabled = true;
        }

        public void cleanTextBoxes()
        {
            projectNameComboBox.Text = "";
            projectNameComboBox.Items.Clear();
            setComboBoxList("C:\\TestCases\\", this.projectNameComboBox);
            versionComboBox.Text = "";
            versionComboBox.Items.Clear();
            moduleComboBox.Text = "";
            moduleComboBox.Items.Clear();
            createdByComboBox.Text = "";
            executedByComboBox.Text = "";
            executedByComboBox.Enabled = false;
            dateTextBox.Text = "";
            dateTextBox.Enabled = false;
            passFailComboBox.Text = "";
            passFailComboBox.Enabled = false;
            testCaseIdTextBox.Text = "";
            stepRichTextBox.Text = "";
            expectationRichTextBox.Text = "";
            commentRichTextBox.Text = "";
        }

        public void generateFilePaths()
        {
            newTestCase tC = new newTestCase();
            try
            {
                if (projectNameComboBox.Text != "" || versionComboBox.Text != "" || moduleComboBox.Text != "" && testCaseIdTextBox.Text != "")
                {
                    tC.project = projectNameComboBox.Text;
                    tC.version = versionComboBox.Text;
                    tC.module = moduleComboBox.Text;
                    tC.testCaseId = testCaseIdTextBox.Text;

                    filePaths.Add("Project", new string[] { "C:\\TestCases\\", "/Project" });
                    filePaths.Add("Version", new string[] { "C:\\TestCases\\" + tC.project + "\\", "/Version" });
                    filePaths.Add("Module", new string[] { "C:\\TestCases\\" + tC.project + "\\" + tC.version + "\\", "/Module" });
                    filePaths.Add("TestCases", new string[] { "C:\\TestCases\\" + tC.project + "\\" + tC.version + "\\" + tC.module + "\\", "/TestCases" });
                    filePaths.Add("TestResults", new string[] { "C:\\TestCases\\" + tC.project + "\\" + tC.version + "\\" + tC.module + "\\", "/TestResults" });
                    filePaths.Add("TestCasePath", new string[] { "C:\\TestCases\\" + tC.project + "\\" + tC.version + "\\" + tC.module + "\\TestCases\\" + tC.testCaseId + ".xml", "/TestCase" });
                    filePaths.Add("TestResultPath", new string[] { "C:\\TestCases\\" + tC.project + "\\" + tC.version + "\\" + tC.module + "\\TestResults\\" + tC.testCaseId + ".xml", "/TestCase" });

                    fileName.Add("Project", tC.project);
                    fileName.Add("Version", tC.version);
                    fileName.Add("Module", tC.module);
                    fileName.Add("TestCases", tC.testCaseId);
                    fileName.Add("TestResults", tC.testCaseId);

                    //Generate all folders
                    if (projectNameComboBox.Text != "" && versionComboBox.Text != "" && moduleComboBox.Text != "" && testCaseIdTextBox.Text != "")
                    {
                        System.IO.Directory.CreateDirectory(filePaths["TestCases"][0] + "TestCases\\");
                        System.IO.Directory.CreateDirectory(filePaths["TestResults"][0] + "TestResults\\");
                    }      
                }
                
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void saveFile()
        {
            try
            {
                if (executedByComboBox.Text == "")
                {
                    string filePath = filePaths["TestCasePath"][0];
                    generateTestCaseXmlFile(filePath);
                }
                else
                {
                    string filePath = filePaths["TestResultPath"][0];
                    generateTestCaseXmlFile(filePath);
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void presentDataFromXmlFile()
        {
            generateFilePaths();
            XmlParser p = new XmlParser();
            Dictionary<string, string> xmlFile = p.loadXmlFile(filePaths["TestCasePath"][0], filePaths["TestCasePath"][1]);
            projectNameComboBox.Text = xmlFile["project"];
            versionComboBox.Text = xmlFile["version"];
            moduleComboBox.Text = xmlFile["module"];
            createdByComboBox.Text = xmlFile["createdBy"];
            executedByComboBox.Text = xmlFile["executedBy"];
            dateTextBox.Text = xmlFile["date"];
            passFailComboBox.Text = xmlFile["passFail"];
            testCaseIdTextBox.Text = xmlFile["testCaseId"];
            stepRichTextBox.Text = xmlFile["step"];
            expectationRichTextBox.Text = xmlFile["expectation"];
            commentRichTextBox.Text = xmlFile["comment"];
            filePaths.Clear();
            fileName.Clear();
        }

        //This method will create a xml file which contains all the folders in the given path filePaths[key][0]
        /*
        public void generateFolderReferenceFile()
        {
            foreach (string key in fileName.Keys)
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlElement root = xmlDoc.CreateElement(key);
                xmlDoc.AppendChild(root);
                XmlElement child = xmlDoc.CreateElement(fileName[key]);
                child.InnerText = fileName[key];
                root.AppendChild(child);
                xmlDoc.Save(filePaths[key][0] + key + ".xml");
            }

        }
        */

        private void generateTestCaseXmlFile(string xmlFilePath)
        {
            try
            {
                XmlDocument testCaseXml = new XmlDocument();
                //root element
                XmlElement rootElement = testCaseXml.CreateElement("TestCase");
                testCaseXml.AppendChild(rootElement);
                //project element
                XmlElement projectElement = testCaseXml.CreateElement("project");
                projectElement.InnerText = projectNameComboBox.Text;
                rootElement.AppendChild(projectElement);
                //version element
                XmlElement versionElement = testCaseXml.CreateElement("version");
                versionElement.InnerText = versionComboBox.Text;
                rootElement.AppendChild(versionElement);
                //module elemnt
                XmlElement moduleElement = testCaseXml.CreateElement("module");
                moduleElement.InnerText = moduleComboBox.Text;
                rootElement.AppendChild(moduleElement);
                //createdBy elemnt
                XmlElement createdByElement = testCaseXml.CreateElement("createdBy");
                createdByElement.InnerText = createdByComboBox.Text;
                rootElement.AppendChild(createdByElement);
                //executedBy elemnt
                XmlElement executedByElement = testCaseXml.CreateElement("executedBy");
                executedByElement.InnerText = executedByComboBox.Text;
                rootElement.AppendChild(executedByElement);
                //date elemnt
                XmlElement dateElement = testCaseXml.CreateElement("date");
                dateElement.InnerText = dateTextBox.Text;
                rootElement.AppendChild(dateElement);
                //passFail elemnt
                XmlElement passFailElement = testCaseXml.CreateElement("passFail");
                passFailElement.InnerText = passFailComboBox.Text;
                rootElement.AppendChild(passFailElement);
                //testCaseId elemnt
                XmlElement testCaseIdElement = testCaseXml.CreateElement("testCaseId");
                testCaseIdElement.InnerText = testCaseIdTextBox.Text;
                rootElement.AppendChild(testCaseIdElement);
                //step elemnt
                XmlElement stepElement = testCaseXml.CreateElement("step");
                stepElement.InnerText = stepRichTextBox.Text;
                rootElement.AppendChild(stepElement);
                //expectation elemnt
                XmlElement expectationElement = testCaseXml.CreateElement("expectation");
                expectationElement.InnerText = expectationRichTextBox.Text;
                rootElement.AppendChild(expectationElement);
                //comment elemnt
                XmlElement commentElement = testCaseXml.CreateElement("comment");
                commentElement.InnerText = commentRichTextBox.Text;
                rootElement.AppendChild(commentElement);

                testCaseXml.Save(xmlFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }
    }

}
