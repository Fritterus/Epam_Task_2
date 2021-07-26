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
        /// Method for write all semitrailers in file
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
        /// Method for write all tractors in file
        /// </summary>
        /// <param name="tractorCollection">collection of tractors</param>
        /// <param name="filePath">path to file</param>
        public static void WriteTractorXmlWriter(IEnumerable<ITractor> tractorCollection, string filePath)
        {
            using var xmlWriter = new XmlTextWriter(filePath, Encoding.UTF8);
            xmlWriter.Formatting = Formatting.Indented;
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Tractors");

            foreach (ITractor tractor in tractorCollection)
            {
                ParserXml.ParseToXmlElementFromTractor(xmlWriter, tractor);
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Flush();
        }

        /// <summary>
        /// Method for read all semitrailers from file
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

        /// <summary>
        /// Method for read all tractors from file
        /// </summary>
        /// <param name="filePath">path to file</param>
        /// <returns>Collection of tractors</returns>
        public static List<ITractor> ReadTractorXmlReader(string filePath)
        {
            using var xmlReader = new XmlTextReader(filePath);
            var tractors = new List<ITractor>();

            while (xmlReader.Read())
            {
                if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == "Tractors"))
                {
                    break;
                }

                ITractor tractor = ParserXml.ParseToTractorFromXmlElement(xmlReader);
                tractors.Add(tractor);
            }

            return tractors;
        }
    }
}
