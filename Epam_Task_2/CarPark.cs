using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Epam_Task_2
{
    /// <summary>
    /// This class describing car park: all available semitrailers and tractos
    /// </summary>
    internal class CarPark
    {
        public List<string> Semitrailers = new List<string>();
        public List<string> Tractors = new List<string>();

        public IEnumerable<Type> SemitrailerTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(ISemitrailer)));

        public IEnumerable<Type> TractorTypes = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.GetInterfaces().Contains(typeof(ITractor)));

        /// <summary>
        /// Method for getting all semitrailers
        /// </summary>
        public void GetAllSemitrailers()
        {
            foreach (Type item in SemitrailerTypes)
            {
                Semitrailers.Add(item.Name);
            }
        }

        /// <summary>
        /// Method for getting all tractors
        /// </summary>
        public void GetAllTractors()
        {
            foreach (Type item in TractorTypes)
            {
                Tractors.Add(item.Name);
            }
        }
        
        /// <summary>
        /// Method for searching semitrailer by type
        /// </summary>
        /// <param name="type">semitrailer type</param>
        /// <returns>True if semitrailer is found by type, otherwise - false</returns>
        public bool SearchSemitrailerByType(string type)
        {
            GetAllSemitrailers();

            foreach (var item in Semitrailers)
            {
                if (item == type)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Method for searching tractor by type
        /// </summary>
        /// <param name="type">tractor type</param>
        /// <returns>True if tractor is found by type, otherwise - false</returns>
        public bool SearchTractorByType(string type)
        {
            GetAllTractors();

            foreach (var item in Tractors)
            {
                if (item == type)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
