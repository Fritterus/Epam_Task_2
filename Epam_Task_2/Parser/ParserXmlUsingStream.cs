using System.IO;
using Epam_Task_2.Interfaces;
using Epam_Task_2.Semitrailers;
using Epam_Task_2.Tractors;

namespace Epam_Task_2.Parser
{
    /// <summary>
    /// This class describing parser xml using stream
    /// </summary>
    internal class ParserXmlUsingStream
    {
        /// <summary>
        /// Method for parse xml element from semitrailer objects using stream
        /// </summary>
        /// <param name="streamWriter">stream writer</param>
        /// <param name="semitrailer">semitrailer</param>
        public static void ParseToXmlFromSemitrailerUsingStream(StreamWriter streamWriter, ISemitrailer semitrailer)
        {
            streamWriter.WriteLine($"\t<{semitrailer.GetType().Name}>");
            streamWriter.WriteLine($"\t\t<{nameof(ISemitrailer.WheelFormula)}>{semitrailer.WheelFormula}</{nameof(ISemitrailer.WheelFormula)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ISemitrailer.MaxCapacity)}>{semitrailer.MaxCapacity}</{nameof(ISemitrailer.MaxCapacity)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ISemitrailer.BodyVolume)}>{semitrailer.BodyVolume}</{nameof(ISemitrailer.BodyVolume)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ISemitrailer.DischargeDirection)}>{semitrailer.DischargeDirection}</{nameof(ISemitrailer.DischargeDirection)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ISemitrailer.FifthWheelHeight)}>{semitrailer.FifthWheelHeight}</{nameof(ISemitrailer.FifthWheelHeight)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ISemitrailer.BodyLength)}>{semitrailer.BodyLength}</{nameof(ISemitrailer.BodyLength)}>");
            streamWriter.WriteLine($"\t</{semitrailer.GetType().Name}>");
        }

        /// <summary>
        /// Method for parse to xml element from tractor objects usint stream
        /// </summary>
        /// <param name="streamWriter">stream writer</param>
        /// <param name="tractor">tractor</param>
        public static void ParseToXmlFromTractorUsingStream(StreamWriter streamWriter, ITractor tractor)
        {
            
            streamWriter.WriteLine($"\t<{tractor.GetType().Name}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.Weight)}>{tractor.Weight}</{nameof(ITractor.Weight)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.WheelFormule)}>{tractor.WheelFormule}</{nameof(ITractor.WheelFormule)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.FuelCapacity)}>{tractor.FuelCapacity}</{nameof(ITractor.FuelCapacity)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.EngineVolume)}>{tractor.EngineVolume}</{nameof(ITractor.EngineVolume)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.Cabin)}>{tractor.Cabin}</{nameof(ITractor.Cabin)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.FifthWheelHeight)}>{tractor.FifthWheelHeight}</{nameof(ITractor.FifthWheelHeight)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.FifthWheelLoad)}>{tractor.FifthWheelLoad}</{nameof(ITractor.FifthWheelLoad)}>");
            streamWriter.WriteLine($"\t\t<{nameof(ITractor.FullWeight)}>{tractor.FullWeight}</{nameof(ITractor.FullWeight)}>");
            streamWriter.WriteLine($"\t</{tractor.GetType().Name}>");
        }

        /// <summary>
        /// Method for parse to semitrailer objects from xml element using stream
        /// </summary>
        /// <param name="streamReader">stream reader</param>
        /// <returns>semitrailer</returns>
        public static ISemitrailer ParseToSemitrailerFromXmlUsingStream(StreamReader streamReader)
        {
            ISemitrailer semitrailer = null;

            while (semitrailer is null)
            {
                string line = streamReader.ReadLine();

                if (line is null)
                {
                    break;
                }

                line = line.Trim('\t', ' ', '<', '>');

                if (line.Contains(nameof(Awning)) && !line.Contains($"/{nameof(Awning)}"))
                {
                    semitrailer = new Awning();
                    break;
                }

                if (line.Contains(nameof(Cistern)) && !line.Contains($"/{nameof(Cistern)}"))
                {
                    semitrailer = new Cistern();
                    break;
                }

                if (line.Contains(nameof(Refrigerator)) && !line.Contains($"/{nameof(Refrigerator)}"))
                {
                    semitrailer = new Refrigerator();
                    break;
                }
            }

            return semitrailer;
        }

        /// <summary>
        /// Method for parse to tractor objects from xml element using stream
        /// </summary>
        /// <param name="streamReader">stream reader</param>
        /// <returns>tractor</returns>
        public static ITractor ParseToTractorFromXmlUsingStream(StreamReader streamReader)
        {
            ITractor tractor = null;

            while (tractor is null)
            {
                string line = streamReader.ReadLine();

                if (line is null)
                {
                    break;
                }

                line = line.Trim('\t', ' ', '<', '>');

                if (line.Contains(nameof(ActrosLS)))
                {
                    tractor = new ActrosLS();
                    break;
                }

                if (line.Contains(nameof(DAF)))
                {
                    tractor = new DAF();
                    break;
                }

            }

            return tractor;
        }
    }
}
