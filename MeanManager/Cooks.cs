using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealManager
{
    class Cooks
    {
        private String name;
        private ArrayList allergies;
        private Dictionary<DayOfWeek, bool> available;
        public Cooks(String name, ArrayList allergies, ArrayList daysAvailble)
        {
            this.name = name;
            this.allergies = allergies;
            available = new Dictionary<DayOfWeek, bool>();
            available.Add(DayOfWeek.Sunday, false);
            available.Add(DayOfWeek.Monday, false);
            available.Add(DayOfWeek.Tuesday, false);
            available.Add(DayOfWeek.Wednesday, false);
            available.Add(DayOfWeek.Thursday, false);
            available.Add(DayOfWeek.Friday, false);
            available.Add(DayOfWeek.Saturday, false);
            List<DayOfWeek> day = new List<DayOfWeek>(available.Keys);
            foreach(DayOfWeek entry in day)
            {
                if (daysAvailble.Contains(entry))
                    available[entry] = true;
            }
        }

        public String GetName()
        {
            return name;
        }


    }
}
