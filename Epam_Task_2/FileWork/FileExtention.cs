using Epam_Task_2.Interfaces;
using Epam_Task_2.Parser;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Epam_Task_2.FileWork
{
    /// <summary>
    /// This class describing file work
    /// </summary>
    internal static class FileExtention
    {
        /// <summary>
        /// Method for write in file
        /// </summary>
        /// <param name="semitrailerCollection">collection of semitrailer</param>
        /// <param name="filePath">path to file</param>
        public static void WriteSemitrailerXmlWriter(IEnumerable<ISemitrailer> semitrailerCollection, string filePath)
        {
            using var xmlWriter = new XmlTextWriter(filePath, Encoding.UTF8);
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

        /// <summary>
        /// Method for read from file
        /// </summary>
        /// <param name="filePath">path to file</param>
        /// <returns>Collection of semitrailers</returns>
        public static List<ISemitrailer> ReadSemitrailerXmlReader(string filePath)
        {
            using var xmlReader = new XmlTextReader(filePath);
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
