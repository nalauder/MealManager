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
        public int CookID { get; set; }
        public string Name { get; private set; }
        public string[] Allergies { get; private set; }
        public string[] Available { get;  private set;}
        public Cooks(string name, string[] allergies, string[] daysAvailble)
        {
            Name = name;
            Allergies = allergies;
            Available = daysAvailble;
        }

        public string AllergiesString() => string.Join(",", Allergies);

        public string AvailableString() => string.Join(",", Available);
    }
}
