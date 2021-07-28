using Epam_Task_2.Interfaces;
using Epam_Task_2.Parser;
using System.Collections.Generic;
using System.IO;
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

        /// <summary>
        /// Methom for read all tractors from file using stream reader
        /// </summary>
        /// <param name="filePath">path to file</param>
        /// <returns>Collection of tractors</returns>
        public static List<ITractor> ReadTractorsStreamReader(string filePath)
        {
            var tractors = new List<ITractor>();

            using (var streamReader = new StreamReader(filePath))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    ITractor tractor = ParserXmlUsingStream.ParseToTractorFromXmlUsingStream(streamReader);
                    tractors.Add(tractor);
                }

                if (tractors.Contains(null))
                {
                    var index = tractors.IndexOf(null);
                    tractors.RemoveAt(index);
                }
            }

            return tractors;
        }

        /// <summary>
        /// Method for read all semitrailers from file using stream reader
        /// </summary>
        /// <param name="filePath">path to file</param>
        /// <returns>Collection of semitrailers</returns>
        public static List<ISemitrailer> ReadSemitrailersStreamReader(string filePath)
        {
            var semitrailers = new List<ISemitrailer>();

            using (var streamReader = new StreamReader(filePath))
            {
                string line;

                while ((line = streamReader.ReadLine()) != null)
                {
                    ISemitrailer semitrailer = ParserXmlUsingStream.ParseToSemitrailerFromXmlUsingStream(streamReader);
                    semitrailers.Add(semitrailer);
                }

                if (semitrailers.Contains(null))
                {
                    var index = semitrailers.IndexOf(null);
                    semitrailers.RemoveAt(index);
                }
            }

            return semitrailers;
        }

        /// <summary>
        /// Method for write all semitrailers in file using stream writer
        /// </summary>
        /// <param name="semitrailerCollection">collection of semitrailers</param>
        /// <param name="filePath">path to file</param>
        public static void WriteSemitrailerStreamWriter(IEnumerable<ISemitrailer> semitrailerCollection, string filePath)
        {
            using var streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            streamWriter.WriteLine("<Semitrailers>");

            foreach (ISemitrailer semitrailer in semitrailerCollection)
            {
                ParserXmlUsingStream.ParseToXmlFromSemitrailerUsingStream(streamWriter, semitrailer);
            }

            streamWriter.WriteLine("</Semitrailers>");
        }

        /// <summary>
        /// Method for write all tractors in file using stream writer
        /// </summary>
        /// <param name="tractorCollection">collection of tractors</param>
        /// <param name="filePath">path to file</param>
        public static void WriteTractorStreamWriter(IEnumerable<ITractor> tractorCollection, string filePath)
        {
            using var streamWriter = new StreamWriter(filePath);
            streamWriter.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            streamWriter.WriteLine("<Tractor>");

            foreach (ITractor tractor in tractorCollection)
            {
                ParserXmlUsingStream.ParseToXmlFromTractorUsingStream(streamWriter, tractor);
            }

            streamWriter.WriteLine("</Tractor>");
        }
    }
}
