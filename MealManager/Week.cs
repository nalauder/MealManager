using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealManager
{
    class Week
    {
        public int WeekID { get; set; }
        public Dictionary<string, Tuple<Meals, Cooks>> DailyMeal { get; private set; }
        public string Name { get; private set; }
        public Week(string date)
        {
            Name = date;
            DailyMeal = new Dictionary<string, Tuple<Meals, Cooks>>();
        }

        public void AddMeal(string day, Meals meal, Cooks cook)
        {
            DailyMeal.Add(day, new Tuple<Meals, Cooks>(meal, cook));
        }
    }
}
