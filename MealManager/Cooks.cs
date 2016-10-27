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
        public List<string> Allergies { get; private set; }
        public List<string> Available { get;  private set;}
        public Cooks(string name, List<string> allergies, List<string> daysAvailble)
        {
            Name = name;
            Allergies = allergies;
            Available = daysAvailble;
        }

        public string AllergiesString()
        {
            if (Allergies.Count == 0)
                return null;
            string text = Allergies[0];
            foreach(string name in Allergies)
                if(name != Allergies[0])
                    text = text + ", " + name;
            return text;
        }
        public string AvailableString()
        {
            if (Available.Count == 0)
                return null;
            string text = Available[0];
            foreach (string name in Available)
                if (name != Available[0])
                    text = text + ", " + name;
            return text;
        }
    }
}
