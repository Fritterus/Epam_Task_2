using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using Epam_Task_2.Tractors;
using System.Xml;

namespace Epam_Task_2.Parser
{
    /// <summary>
    /// This class describing xml parser
    /// </summary>
    internal static class ParserXml
    {
        /// <summary>
        /// Method for parse to xml element from object of type semitrailer
        /// </summary>
        /// <param name="xmlWriter">xml writer</param>
        /// <param name="semitrailer">current semitrailer</param>
        public static void ParseToXmlElementFromSemitrailer(XmlTextWriter xmlWriter, ISemitrailer semitrailer)
        {
            xmlWriter.WriteStartElement(semitrailer.GetType().Name);
            xmlWriter.WriteElementString(nameof(ISemitrailer.WheelFormula), semitrailer.WheelFormula.ToString());
            xmlWriter.WriteElementString(nameof(ISemitrailer.MaxCapacity), semitrailer.MaxCapacity.ToString());
            xmlWriter.WriteElementString(nameof(ISemitrailer.BodyVolume), semitrailer.BodyVolume.ToString());
            xmlWriter.WriteElementString(nameof(ISemitrailer.DischargeDirection), semitrailer.DischargeDirection.ToString());
            xmlWriter.WriteElementString(nameof(ISemitrailer.FifthWheelHeight), semitrailer.FifthWheelHeight.ToString());
            xmlWriter.WriteElementString(nameof(ISemitrailer.BodyLength), semitrailer.BodyLength.ToString());
            xmlWriter.WriteEndElement();
        }

        /// <summary>
        /// Method for parse to xml element from object of type tractor
        /// </summary>
        /// <param name="xmlWriter">xml writer</param>
        /// <param name="tractor">current tractor</param>
        public static void ParseToXmlElementFromTractor(XmlTextWriter xmlWriter, ITractor tractor)
        {
            xmlWriter.WriteStartElement(tractor.GetType().Name);
            xmlWriter.WriteElementString(nameof(ITractor.Weight), tractor.Weight.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.WheelFormule), tractor.WheelFormule.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.FuelCapacity), tractor.FuelCapacity.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.EngineVolume), tractor.EngineVolume.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.Cabin), tractor.Cabin.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.FifthWheelHeight), tractor.FifthWheelHeight.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.FifthWheelLoad), tractor.FifthWheelLoad.ToString());
            xmlWriter.WriteElementString(nameof(ITractor.FullWeight), tractor.FullWeight.ToString());
            xmlWriter.WriteEndElement();
        }

        /// <summary>
        /// Method for parse to object of type semitrailer from xml element
        /// </summary>
        /// <param name="xmlReader">xml reader</param>
        /// <returns>semitrailer</returns>
        public static ISemitrailer ParseToSemitrailerFromXmlElement(XmlTextReader xmlReader)
        {
            ISemitrailer semitrailer = null;

            while (semitrailer is null)
            {
                xmlReader.Read();

                if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == nameof(Awning)))
                {
                    semitrailer = new Awning();
                    break;
                }

                if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == nameof(Cistern)))
                {
                    semitrailer = new Cistern();
                    break;
                }

                if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == nameof(Refrigerator)))
                {
                    semitrailer = new Refrigerator();
                    break;
                }
            }

            xmlReader.Read();

            return semitrailer;
        }

        /// <summary>
        /// Method for parse to object of type tractor from xml element
        /// </summary>
        /// <param name="xmlReader">xml reader</param>
        /// <returns>tractor</returns>
        public static ITractor ParseToTractorFromXmlElement(XmlTextReader xmlReader)
        {
            ITractor tractor = null;

            while (tractor is null)
            {
                xmlReader.Read();

                if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == nameof(ActrosLS)))
                {
                    tractor = new ActrosLS();
                    break;
                }

                if ((xmlReader.NodeType == XmlNodeType.EndElement) && (xmlReader.Name == nameof(DAF)))
                {
                    tractor = new DAF();
                    break;
                }
            }

            xmlReader.Read();

            return tractor;
        }
    }
}
