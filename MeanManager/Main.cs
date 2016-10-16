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
    public partial class Main : Form
    {
        List<Cooks> AllCooks = new List<Cooks>();
        List<Meals> AllMeals = new List<Meals>();
        List<Meals> WeeksMeals = new List<Meals>();
        public Main()
        {
            InitializeComponent();
        }

        private void AddCookButton_Click(object sender, EventArgs e)
        {
            string name = CookName.Text;
            Cooks selected = AllCooks.FirstOrDefault(x => x.Name == name);
            if (selected != null)
            {
                return;
            }
            List<DayOfWeek> days = new List<DayOfWeek>();
            
            List<string> allergies = new List<string>();
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
            Cooks cook = new Cooks(name, allergies, days);
            AllCooks.Add(cook);
            CooksListBox.Items.Add(cook);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(CooksListBox.SelectedItem != null)
            {
                AllCooks.Remove((Cooks)CooksListBox.SelectedItem);
                CooksListBox.Items.Remove(CooksListBox.SelectedItem);
            }
            else if(MealsListBox.SelectedItem != null)
            {
                AllMeals.Remove((Meals)MealsListBox.SelectedItem);
                MealsListBox.Items.Remove(MealsListBox.SelectedItem);
            }
        }

        private void AddMealButton_Click(object sender, EventArgs e)
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
            Meals meal = new Meals(name, ingredients, nuts, dairy, eggs);
            AllMeals.Add(meal);
            MealsListBox.Items.Add(meal);
        }

        private void WeeksMealsListBox_Click(object sender, EventArgs e)
        {
            int item = WeeksMealsListBox.SelectedIndex;
            CooksListBox.ClearSelected();
            MealsListBox.ClearSelected();
            WeeksMealsListBox.SetSelected(item, true);
        }

        private void MealsListBox_Click(object sender, EventArgs e)
        {
            int item = MealsListBox.SelectedIndex;
            CooksListBox.ClearSelected();
            WeeksMealsListBox.ClearSelected();
            MealsListBox.SetSelected(item, true);
        }

        private void CooksListBox_Click(object sender, EventArgs e)
        {
            int item = CooksListBox.SelectedIndex;
            MealsListBox.ClearSelected();
            WeeksMealsListBox.ClearSelected();
            CooksListBox.SetSelected(item, true);
        }
    }
}
