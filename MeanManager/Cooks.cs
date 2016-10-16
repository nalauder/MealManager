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
        public string Name { get; private set; }
        public List<string> Allergies { get; private set; }
        public Dictionary<DayOfWeek, bool> Available { get;  private set;}
        public Cooks(string name, List<string> allergies, List<DayOfWeek> daysAvailble)
        {
            this.Name = name;
            this.Allergies = allergies;
            Available = new Dictionary<DayOfWeek, bool>();
            Available.Add(DayOfWeek.Sunday, false);
            Available.Add(DayOfWeek.Monday, false);
            Available.Add(DayOfWeek.Tuesday, false);
            Available.Add(DayOfWeek.Wednesday, false);
            Available.Add(DayOfWeek.Thursday, false);
            Available.Add(DayOfWeek.Friday, false);
            Available.Add(DayOfWeek.Saturday, false);
            foreach(DayOfWeek entry in Available.Keys)
            {
                if (daysAvailble.Contains(entry))
                    Available[entry] = true;
            }
        }
    }
}
