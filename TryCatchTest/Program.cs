using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchTest
{
    using System.Xml;
    using System.Xml.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            //XmlReader xmlReader = XmlReader.Create("GeneralTestData.xml");
            //xmlReader.MoveToContent();
            //xmlReader.Read();
            //Console.WriteLine(xmlReader.Name);
            //xmlReader.Read();
            //Console.WriteLine(xmlReader.Name);
            //xmlReader.Read();
            //Console.WriteLine(xmlReader.Name);


            //XDocument doc1 = XDocument.Load("GeneralTestData.xml");
            //XElement someEle = doc1.Element("RAD").Element("TaskGroup").Element("Task");
            //string value = someEle.ToString();
            //Console.WriteLine(value);

            //XmlDocument doc = new XmlDocument();
            //doc.Load("GeneralTestData.xml");
            //XmlNode child = doc.DocumentElement.LastChild.LastChild;
            //string value = child.OuterXml;
            //Console.WriteLine(value);
            int i = 0;
            try
            {
                i = 1;
                throw new Exception();
            }
            finally
            {
                i = 2;
            }
        }
    }
}
