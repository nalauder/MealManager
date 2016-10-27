using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealManager
{
    class Week
    {
        public int WeekID { get; private set; }
        public Dictionary<string, Meals> DailyMeal { get; set; }
        public DateTime Date { get; private set; }
        public Week(DateTime date)
        {
            Date = date;
            DailyMeal.Add("Sunday", null);
            DailyMeal.Add("Monday", null);
            DailyMeal.Add("Tuesday", null);
            DailyMeal.Add("Wednesday", null);
            DailyMeal.Add("Thursday", null);
            DailyMeal.Add("Friday", null);
            DailyMeal.Add("Saturday", null);
        }

        public void AddMeal(string day, Meals meal)
        {
            if(DailyMeal.Keys.Contains(day))
                DailyMeal[day] = meal;
        }
    }
}
