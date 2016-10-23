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
            string name = NewCookName.Text;
            Cooks selected = AllCooks.FirstOrDefault(x => x.Name == name);
            if (selected != null)
            {
                return;
            }
            List<string> days = new List<string>();
            
            List<string> allergies = new List<string>();
            foreach (string items in NewCookAvailableNights.CheckedItems)
                    days.Add(items);
            foreach (string items in NewCookAllergies.CheckedItems)
                    allergies.Add(items);
            Cooks cook = new Cooks(name, allergies, days);
            AllCooks.Add(cook);
            CooksListBox.Items.Add(cook);
            ClearCooks();
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
            string name = NewMealName.Text;
            List<string> ingredients = new List<string>();
            List<string> meats = new List<string>();
            List<string> vegetables = new List<string>();
            List<string> fillers = new List<string>();
            List<string> allergies = new List<string>();
            foreach(string items in NewMealVegetables.CheckedItems)
                vegetables.Add(items);
            foreach (string items in NewMealMeats.CheckedItems)
                meats.Add(items);
            foreach (string items in NewMealFillers.CheckedItems)
                fillers.Add(items);
            foreach (string items in NewMealAllergies.CheckedItems)
                allergies.Add(items);
            string[] extras = NewMealExtras.Text.Split(',', ' ');
            for (int i = 0; i < extras.Length - 1; i++)
                ingredients.Add(extras[i]);
            Meals meal = new Meals(name, vegetables, meats, fillers, ingredients, allergies);
            AllMeals.Add(meal);
            MealsListBox.Items.Add(meal);
            ClearMeals();
        }

        private void WeeksMealsListBox_Click(object sender, EventArgs e)
        {
            int item = WeeksMealsListBox.SelectedIndex;
            if (item < 0)
                return;
            CooksListBox.ClearSelected();
            MealsListBox.ClearSelected();
            WeeksMealsListBox.SetSelected(item, true);
        }

        private void MealsListBox_Click(object sender, EventArgs e)
        {
            int item = MealsListBox.SelectedIndex;
            if (item < 0)
                return;
            CooksListBox.ClearSelected();
            WeeksMealsListBox.ClearSelected();
            MealsListBox.SetSelected(item, true);
            LoadMeal((Meals)MealsListBox.SelectedItem);
        }

        private void CooksListBox_Click(object sender, EventArgs e)
        {
            int item = CooksListBox.SelectedIndex;
            if (item < 0)
                return;
            MealsListBox.ClearSelected();
            WeeksMealsListBox.ClearSelected();
            CooksListBox.SetSelected(item, true);
            LoadCook((Cooks)CooksListBox.SelectedItem);
        }

        private void LoadMeal(Meals meal)
        {
            ClearMeals();
            NewMealName.Text = meal.Name;
            foreach(string vegeName in meal.Vegetables)
                NewMealVegetables.SetItemChecked(NewMealVegetables.Items.IndexOf(vegeName), true);
            foreach (string meatName in meal.Meats)
                NewMealMeats.SetItemChecked(NewMealMeats.Items.IndexOf(meatName), true);
            foreach (string fillerName in meal.Fillers)
                NewMealFillers.SetItemChecked(NewMealFillers.Items.IndexOf(fillerName), true);
            foreach (string allergieName in meal.Allergies)
                NewMealAllergies.SetItemChecked(NewMealAllergies.Items.IndexOf(allergieName), true);
        }

        private void LoadCook(Cooks cook)
        {
            ClearCooks();
            NewCookName.Text = cook.Name;
            foreach (string allergieName in cook.Allergies)
                NewCookAllergies.SetItemChecked(NewCookAllergies.Items.IndexOf(allergieName), true);
            foreach (string nightsName in cook.Available)
                NewCookAvailableNights.SetItemChecked(NewCookAvailableNights.Items.IndexOf(nightsName), true);
        }

        private void ClearMeals()
        {
            for (int i = 0; i < NewMealVegetables.Items.Count; i++)
                NewMealVegetables.SetItemChecked(i, false);
            for (int i = 0; i < NewMealMeats.Items.Count; i++)
                NewMealMeats.SetItemChecked(i, false);
            for (int i = 0; i < NewMealFillers.Items.Count; i++)
                NewMealFillers.SetItemChecked(i, false);
            for (int i = 0; i < NewMealAllergies.Items.Count; i++)
                NewMealAllergies.SetItemChecked(i, false);
            NewMealExtras.Clear();
            NewMealName.Clear();
            NewMealAllergies.ClearSelected();
            NewMealFillers.ClearSelected();
            NewMealMeats.ClearSelected();
            NewMealVegetables.ClearSelected();
        }

        private void ClearCooks()
        {
            NewCookName.Clear();
            for (int i = 0; i < NewCookAllergies.Items.Count; i++)
                NewCookAllergies.SetItemChecked(i, false);
            for (int i = 0; i < NewCookAvailableNights.Items.Count; i++)
                NewCookAvailableNights.SetItemChecked(i, false);
            NewCookAvailableNights.ClearSelected();
            NewCookAllergies.ClearSelected();
        }

        private void MealsListBox_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectTab("AddMealTab");
        }

        private void CooksListBox_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectTab("AddCookTab");
        }
    }
}
