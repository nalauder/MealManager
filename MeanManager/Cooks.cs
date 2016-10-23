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
        public List<string> Available { get;  private set;}
        public Cooks(string name, List<string> allergies, List<string> daysAvailble)
        {
            Name = name;
            Allergies = allergies;
            Available = daysAvailble;
        }
    }
}
