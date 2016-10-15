using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealManager
{
    class ReadyMeal
    {
        private Cooks cook;
        private Meals meal;
        public ReadyMeal(Cooks cook, Meals meal)
        {
            this.cook = cook;
            this.meal = meal;
        }

        public Cooks GetCook()
        {
            return cook;
        }
    }
}
