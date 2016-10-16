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
        private string name;
        private bool hasNuts;
        private bool hasDairy;
        private bool hasEggs;
        public Meals(string name, ArrayList ingredients, bool nuts, bool dairy, bool eggs)
        {
            this.ingredients = ingredients;
            this.name = name;
            hasNuts = nuts;
            hasDairy = dairy;
            hasEggs = eggs;
        }
        public string GetName()
        {
            return name;
        }
    }
}
