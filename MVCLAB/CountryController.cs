using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCLAB
{
    internal class CountryController
    {
        List<Country> Countries = new List<Country>()
        {
            new Country("USA", "North America", new List<string>{"Red", "White", "Blue"}),
            new Country("Japan", "Asia", new List<string> {"Red", "White"}),
            new Country("Russia", "Europe", new List<string> {"White", "Blue", "Red"}) 
        };

        public void CountryAction(Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        {
            bool RunProgram = true;
            while (RunProgram)
            {
                CountryListView view = new CountryListView(Countries);
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list:");
                view.Display();
                int choice = int.Parse(Console.ReadLine());
                CountryAction(Countries[choice]);

                Console.WriteLine("Would you like to learn about another country? Y/N");
                string response = Console.ReadLine().ToLower().Trim();
                if(response == "y")
                {
                    RunProgram = true;
                }
                else
                {
                    RunProgram = false;
                }


            }
        }
    }
}
