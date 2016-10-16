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
        public string name { get; private set; }
        public List<string> allergies { get; private set; }
        public Dictionary<DayOfWeek, bool> available { get;  private set;}
        public Cooks(string name, List<string> allergies, List<DayOfWeek> daysAvailble)
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
    }
}
