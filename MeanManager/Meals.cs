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
        private ArrayList ingredients;
        public string Name {get;private set;}
        public bool hasNuts { get; private set; }
        public bool hasDairy { get; private set; }
        public bool hasEggs { get; private set; }
        public Meals(string name, ArrayList ingredients, bool nuts, bool dairy, bool eggs)
        {
            this.ingredients = ingredients;
            this.Name = name;
            hasNuts = nuts;
            hasDairy = dairy;
            hasEggs = eggs;
        }
    }
}
