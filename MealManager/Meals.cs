using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealManager
{
    class Meals
    {
        public List<string> Extras { get; private set; }
        public string Name {get;private set;}
        public List<string> Allergies { get; private set; }
        public List<string> Meats { get; private set; }
        public List<string> Vegetables { get; private set; }
        public List<string> Fillers { get; private set; }
        public Meals(string name, List<string> veges, List<string> meats, List<string> fillers, List<string> extras, List<string> allergies)
        {
            Extras = extras;
            Name = name;
            Vegetables = veges;
            Meats = meats;
            Fillers = fillers;
            Allergies = allergies;
        }
    }
}
