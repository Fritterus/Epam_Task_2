using Epam_Task2.Interfaces;
using Epam_Task2.Semitrailers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Epam_Task2.Parses
{
    internal static class ParserXml
    {
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
