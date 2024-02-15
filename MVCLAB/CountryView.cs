using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLAB
{
    internal class CountryView
    {
        //properties
        public Country DisplayCountry { get; set; }

        //constructor
        public CountryView (Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        } 
        //method
        public void Display()
        {
            Console.WriteLine($" Name: {DisplayCountry.Name} Continent: {DisplayCountry.Continent}");
            foreach (string c in DisplayCountry.Colors)
            {
                Console.WriteLine(c);
            }
        }
    }
}
