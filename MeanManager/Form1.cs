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

namespace MealManager
{
    public partial class Form1 : Form
    {
        Main main;
        public Form1()
        {
            InitializeComponent();
            main = new MealManager.Main();
        }

        private void AddCook_Click(object sender, EventArgs e)
        {
            String name;
            name = CookName.Text;
            if (main.ContainsCook(name))
            {
                return;
            }
            ArrayList days = new ArrayList();
            
            ArrayList allergies = new ArrayList();
            for(int i = 0; i < AvailableNights.Items.Count-1; i++)
            {
                if(AvailableNights.GetItemChecked(i))
                    days.Add((DayOfWeek)Enum.Parse(typeof(DayOfWeek), AvailableNights.GetItemText(i)));
            }
            
            for (int i = 0; i < CookAllergies.Items.Count - 1; i++)
            {
                if (CookAllergies.GetItemChecked(i))
                    allergies.Add(CookAllergies.GetItemText(i));
            }
            main.AddCook(new Cooks(name, allergies, days));
            ViewerTable.Rows.Add();
            ViewerTable.Rows[main.GetNoCooks()-1].Cells["CooksCol"].Value = name;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int rowindex = ViewerTable.CurrentCell.RowIndex;
            int columnindex = ViewerTable.CurrentCell.ColumnIndex;
            String selected = ViewerTable.Rows[rowindex].Cells[columnindex].Value.ToString();
            for(int i = rowindex; i < main.GetNoCooks()-1; i++)
                ViewerTable.Rows[i].Cells[columnindex].Value = ViewerTable.Rows[i + 1].Cells[columnindex].Value;
            ViewerTable.Rows[Math.Max(main.GetNoCooks() - 1, 0)].Cells[columnindex].Value = "";
            foreach (Cooks cook in main.GetCook())
            {
                if (cook.GetName().Equals(selected))
                {
                    main.removeCook(cook);
                    return;
                }
            }
        }

    }
}
