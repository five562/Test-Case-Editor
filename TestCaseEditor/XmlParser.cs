using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Xml;
//using System.Xml.Linq;
using System.IO;

namespace TestCaseEditor
{
    class XmlParser
    {
             
        public Dictionary<string,string> loadXmlFile(string xmlFilePath, string xmlNode)
        {
            Dictionary<string, string> file = new Dictionary<string, string>();
            XmlDocument xmlfile = new XmlDocument();
            try
            {
                xmlfile.Load(xmlFilePath);
                XmlNode root;
                root = xmlfile.SelectSingleNode(xmlNode);
                if (root.HasChildNodes)
                {
                    foreach (XmlNode n in root.ChildNodes)
                    {
                        file.Add(n.Name, n.InnerText);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
            return file;
        }
        
    }
}
