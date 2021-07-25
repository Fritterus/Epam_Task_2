using Epam_Task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Epam_Task2
{
    /// <summary>
    /// This class describing car park: all available semitrailers and tractos
    /// </summary>
    internal class CarPark
    {
        public IEnumerable<Type> Semitrailers = Assembly.GetAssembly(typeof(ISemitrailer))
            .GetTypes()
            .Where(t => t.IsSubclassOf(typeof(ISemitrailer)));

        public IEnumerable<Type> Tractos = Assembly.GetAssembly(typeof(ITractor))
            .GetTypes()
            .Where(t => t.IsSubclassOf(typeof(ITractor)));
    }
}
