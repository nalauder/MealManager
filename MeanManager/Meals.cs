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
        private String name;
        private Boolean hasNuts;
        private Boolean hasDairy;
        private Boolean hasEggs;
        public Meals(String name, ArrayList ingredients)
        {
            this.ingredients = ingredients;
            this.name = name;
        }
    }
}
