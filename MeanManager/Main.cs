using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanManager
{
    

    class Main
    {
        ArrayList allCooks;
        ArrayList allMeals;
        ArrayList allReadyMeals;

        public Main()
        {
            allCooks = new ArrayList();
            allMeals = new ArrayList();
            allReadyMeals = new ArrayList();
        }

        public void addCook(Cooks cook)
        {
            allCooks.Add(cook);
        }

        public void addMeal(Meals meal)
        {
            allMeals.Add(meal);
        }

        public void addReadyMeal(ReadyMeal meal)
        {
            allReadyMeals.Add(meal);
        }

        public ArrayList getCook()
        {
            return allCooks;
        }

        public ArrayList getAllMeals()
        {
            return allMeals;
        }

        public ArrayList getReadyMeals()
        {
            return allReadyMeals;
        }
    }
}
