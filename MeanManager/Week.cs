using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanManager
{
    class Week
    {
        private Dictionary<DayOfWeek, ReadyMeal> dailyMeal;
        private DateTime date;
        public Week(DateTime date)
        {
            this.date = date;
            dailyMeal.Add(DayOfWeek.Sunday, null);
            dailyMeal.Add(DayOfWeek.Monday, null);
            dailyMeal.Add(DayOfWeek.Tuesday, null);
            dailyMeal.Add(DayOfWeek.Wednesday, null);
            dailyMeal.Add(DayOfWeek.Thursday, null);
            dailyMeal.Add(DayOfWeek.Friday, null);
            dailyMeal.Add(DayOfWeek.Saturday, null);

        }

        public void addMeal(ReadyMeal meal, DayOfWeek day)
        {
            dailyMeal[day] = meal;
        }
    }
}
