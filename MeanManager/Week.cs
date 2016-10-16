using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MealManager
{
    class Week
    {
        public Dictionary<DayOfWeek, Meals> DailyMeal { get; set; }
        public DateTime Date { get; private set; }
        public Week(DateTime date)
        {
            this.Date = date;
            DailyMeal.Add(DayOfWeek.Sunday, null);
            DailyMeal.Add(DayOfWeek.Monday, null);
            DailyMeal.Add(DayOfWeek.Tuesday, null);
            DailyMeal.Add(DayOfWeek.Wednesday, null);
            DailyMeal.Add(DayOfWeek.Thursday, null);
            DailyMeal.Add(DayOfWeek.Friday, null);
            DailyMeal.Add(DayOfWeek.Saturday, null);

        }
    }
}
