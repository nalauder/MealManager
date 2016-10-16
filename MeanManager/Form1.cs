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
            String name = CookName.Text;
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
            if (ViewerTable.Rows.Count <= main.GetNoCooks())
                ViewerTable.Rows.Add();
            ViewerTable.Rows[main.GetNoCooks()-1].Cells["CooksCol"].Value = name;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            int rowindex = ViewerTable.CurrentCell.RowIndex;
            int columnindex = ViewerTable.CurrentCell.ColumnIndex;
            String selected = ViewerTable.Rows[rowindex].Cells[columnindex].Value.ToString();
            for(int i = rowindex; i < ViewerTable.Rows.Count; i++)
                ViewerTable.Rows[i].Cells[columnindex].Value = ViewerTable.Rows[i + 1].Cells[columnindex].Value;
            ViewerTable.Rows[Math.Max(ViewerTable.Rows.Count, 0)].Cells[columnindex].Value = "";

            if (columnindex == 0)
            {
                foreach (Cooks cook in main.GetCook())
                {
                    if (cook.GetName().Equals(selected))
                    {
                        main.RemoveCook(cook);
                        return;
                    }
                }
            }
            else if(columnindex == 1)
            {
                foreach (ReadyMeal meal in main.GetReadyMeals())
                {
                    if (meal.GetMealName().Equals(selected))
                    {
                        main.RemoveReadyMeal(meal);
                        return;
                    }
                }
            }
            else if(columnindex == 2)
            {
                foreach (Meals meal in main.GetAllMeals())
                {
                    if (meal.GetName().Equals(selected))
                    {
                        main.RemoveMeal(meal);
                        return;
                    }
                }
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            String name = newMealName.Text;
            ArrayList ingredients = new ArrayList();
            bool nuts = false;
            bool dairy = false;
            bool eggs = false;

            for (int i = 0; i < NewMealVegtables.Items.Count - 1; i++)
                if (NewMealVegtables.GetItemChecked(i))
                    ingredients.Add(NewMealVegtables.GetItemText(i));

            for (int i = 0; i < NewMealMeats.Items.Count - 1; i++)
                if (NewMealMeats.GetItemChecked(i))
                    ingredients.Add(NewMealMeats.GetItemText(i));

            for (int i = 0; i < NewMealFillers.Items.Count - 1; i++)
                if (NewMealFillers.GetItemChecked(i))
                    ingredients.Add(NewMealFillers.GetItemText(i));

            for (int i = 0; i < NewMealAllergies.Items.Count - 1; i++)
            {
                if (NewMealAllergies.GetItemChecked(i))
                {
                    if (NewMealAllergies.GetItemText(i).Equals("Dairy"))
                        dairy = true;
                    else if (NewMealAllergies.GetItemText(i).Equals("Eggs"))
                        eggs = true;
                    else if (NewMealAllergies.GetItemText(i).Equals("Nuts"))
                        nuts = true;
                }
            }

            String[] extras = NewMealExtras.Text.Split(',', ' ');
            for (int i = 0; i < extras.Length - 1; i++)
                ingredients.Add(extras[i]);
            main.AddMeal(new Meals(name, ingredients, nuts, dairy, eggs));
            if(ViewerTable.Rows.Count <= main.GetNoMeals())
                ViewerTable.Rows.Add();
            ViewerTable.Rows[main.GetNoMeals() - 1].Cells["AllMeals"].Value = name;
        }

        private void ViewerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
