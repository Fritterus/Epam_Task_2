using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
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
    }
}
