using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmutableObjectDesignPattern
{
    public class CountryData
    {
        //Feilds should be readonly
        public  String Name { get; }
        public  decimal Population { get; }
        public CountryData(String name, decimal population)
        {
            Name = name;
            Population = population;
        }
    }
}
