using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealManager
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

        public void AddCook(Cooks cook)
        {
            allCooks.Add(cook);
        }

        public void AddMeal(Meals meal)
        {
            allMeals.Add(meal);
        }

        public void AddReadyMeal(ReadyMeal meal)
        {
            allReadyMeals.Add(meal);
        }

        public ArrayList GetCook()
        {
            return allCooks;
        }

        public ArrayList GetAllMeals()
        {
            return allMeals;
        }

        public ArrayList GetReadyMeals()
        {
            return allReadyMeals;
        }

        public int GetNoCooks()
        {
            return allCooks.Count;
        }

        public bool ContainsCook(String name)
        {
            foreach(Cooks cook in allCooks)
            {
                if (cook.GetName().Equals(name))
                    return true;
            }
            return false;
        }

        public void removeCook(Cooks remove)
        {
            allCooks.Remove(remove);
        }
    }
}
