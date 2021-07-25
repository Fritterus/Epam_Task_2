using Epam_Task2.Interfaces;
using Epam_Task2.Parses;
using Epam_Task2.Semitrailers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Epam_Task2.FileWork
{
    internal static class FileExtention
    {
        public static void WriteSemitrailerXmlWriter(IEnumerable<ISemitrailer> semitrailerCollection, string filePath)
        {
            using (var xmlWriter = new XmlTextWriter(filePath, Encoding.UTF8))
            {
                xmlWriter.Formatting = Formatting.Indented;
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteStartElement("Semitrailers");

                foreach (ISemitrailer semitrailer in semitrailerCollection)
                {
                    ParserXml.ParseToXmlElementFromSemitrailer(xmlWriter, semitrailer);
                }

                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Flush();
            }
        }

        public static List<ISemitrailer> ReadSemitrailerXmlReader(string filePath)
        {
            using (var xmlReader = new XmlTextReader(filePath))
            {
                var semitrailers = new List<ISemitrailer>();

                while (xmlReader.Read())
                {
                    if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == "Semitrailers"))
                    {
                        break;
                    }

                    ISemitrailer semitrailer = ParserXml.ParseToSemitrailerFromXmlElement(xmlReader);
                    semitrailers.Add(semitrailer);
                }

                return semitrailers;
            }
        }
    }
}
