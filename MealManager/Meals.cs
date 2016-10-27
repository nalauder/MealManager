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
        public string Name {get;private set;}
        public List<string> Extras { get; private set; }
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

        public string VegetablesString()
        {
            if (Vegetables.Count == 0)
                return null;
            string text = Vegetables[0];
            foreach (string name in Vegetables)
                if (name != Vegetables[0])
                    text = text + ", " + name;
            return text;
        }

        public string MeatsString()
        {
            if (Meats.Count == 0)
                return null;
            string text = Meats[0];
            foreach (string name in Meats)
                if (name != Meats[0])
                    text = text + ", " + name;
            return text;
        }

        public string FillersString()
        {
            if (Fillers.Count == 0)
                return null;
            string text = Fillers[0];
            foreach (string name in Fillers)
                if (name != Fillers[0])
                    text = text + ", " + name;
            return text;
        }

        public string ExtrasString()
        {
            if (Extras.Count == 0)
                return null;
            string text = Extras[0];
            foreach (string name in Extras)
                if (name != Extras[0])
                    text = text + ", " + name;
            return text;
        }
        public string AllergiesString()
        {
            if (Allergies.Count == 0)
                return null;
            string text = Allergies[0];
            foreach (string name in Allergies)
                if (name != Allergies[0])
                    text = text + ", " + name;
            return text;
        }
    }
}
