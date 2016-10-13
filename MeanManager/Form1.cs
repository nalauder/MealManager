using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeanManager
{
    public partial class Form1 : Form
    {
        Main main;
        public Form1()
        {
            InitializeComponent();
            main = new MeanManager.Main();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ArrayList days = new ArrayList();
            String name;
            ArrayList allergies = new ArrayList();
            for(int i = 0; i < AvailableNights.Items.Count-1; i++)
            {
                if(AvailableNights.GetItemChecked(i))
                    days.Add((DayOfWeek)Enum.Parse(typeof(DayOfWeek), AvailableNights.GetItemText(i)));
            }
            name = CookName.Text;
            for (int i = 0; i < CookAllergies.Items.Count - 1; i++)
            {
                if (CookAllergies.GetItemChecked(i))
                    allergies.Add(CookAllergies.GetItemText(i));
            }
            main.addCook(new Cooks(name, allergies, days));
            ViewerTable.Rows.Insert(main.getCook().Count-1, name);
        }

    }
}
