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
        public int MealID { get; set; }
        public string Name {get;private set;}
        public string[] Extras { get; private set; }
        public string[] Allergies { get; private set; }
        public string[] Meats { get; private set; }
        public string[] Vegetables { get; private set; }
        public string[] Fillers { get; private set; }
        public Meals(string name, string[] veges, string[] meats, string[] fillers, string[] extras, string[] allergies)
        {
            Extras = extras;
            Name = name;
            Vegetables = veges;
            Meats = meats;
            Fillers = fillers;
            Allergies = allergies;
        }

        public string VegetablesString() => string.Join(",", Vegetables);

        public string MeatsString() => string.Join(",", Meats);

        public string FillersString() => string.Join(",", Fillers);

        public string ExtrasString() => string.Join(", ", Extras);

        public string AllergiesString() => string.Join(",", Allergies);

    }
}
