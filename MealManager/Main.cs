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
using System.Data.Sql;
using System.Data.SqlClient;


namespace MealManager
{
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\nalauder\Source\Repos\MealManager\MealManager\Database.mdf;Integrated Security=True");

        public Main()
        {
            InitializeComponent();
            LoadCookSql();
            LoadMealSql();
        }

        private void AddCookButton_Click(object sender, EventArgs e)
        {
            string name = NewCookName.Text;
            Cooks selected = CooksListBox.Items.Cast<Cooks>().FirstOrDefault(cooks => cooks.Name == name);
            if (selected != null)
                return;
            Cooks cook = new Cooks(name, NewCookAllergies.CheckedItems.Cast<string>().ToArray<string>(), NewCookAvailableNights.CheckedItems.Cast<string>().ToArray());
            CooksListBox.Items.Add(cook);
            SaveCookSql(cook);
            ClearCooks();
        }

        private void AddMealButton_Click(object sender, EventArgs e)
        {
            string name = NewMealName.Text;
            string[] extras = NewMealExtras.Text.Split(',');
            for (int i = 0; i < extras.Length; i++)
                extras[i] = extras[i].Trim();
            Meals meal = new Meals(name, NewMealVegetables.CheckedItems.Cast<string>().ToArray(), NewMealMeats.CheckedItems.Cast<string>().ToArray(), NewMealFillers.CheckedItems.Cast<string>().ToArray(), extras, NewMealAllergies.CheckedItems.Cast<string>().ToArray());
            MealsListBox.Items.Add(meal);
            SaveMealSql(meal);
            ClearMeals();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if(CooksListBox.SelectedItem != null)
                CooksListBox.Items.Remove(CooksListBox.SelectedItem);
            else if(MealsListBox.SelectedItem != null)
                MealsListBox.Items.Remove(MealsListBox.SelectedItem);
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

        private void MealsListBox_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectTab("AddMealTab");
        }

        private void CooksListBox_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectTab("AddCookTab");
        }

        private void WeeksMealListBox_DoubleClick(object sender, EventArgs e)
        {
            tabControl.SelectTab("SelectMealTab");
        }

        private void LoadMeal(Meals meal)
        {
            ClearMeals();
            NewMealName.Text = meal.Name;
            MealID.Text = meal.MealID.ToString();
            foreach(string vegeName in meal.Vegetables)
                if (NewMealVegetables.Items.Contains(vegeName))
                    NewMealVegetables.SetItemChecked(NewMealVegetables.Items.IndexOf(vegeName), true);
            foreach (string meatName in meal.Meats)
                if (NewMealMeats.Items.Contains(meatName))
                    NewMealMeats.SetItemChecked(NewMealMeats.Items.IndexOf(meatName), true);
            foreach (string fillerName in meal.Fillers)
                if (NewMealFillers.Items.Contains(fillerName))
                    NewMealFillers.SetItemChecked(NewMealFillers.Items.IndexOf(fillerName), true);
            foreach (string allergieName in meal.Allergies)
                if (NewMealAllergies.Items.Contains(allergieName))
                    NewMealAllergies.SetItemChecked(NewMealAllergies.Items.IndexOf(allergieName), true);
            string extra = "";
            foreach (string extras in meal.Extras)
            {
                if (extra.Equals(""))
                    extra = extras;
                else
                    extra = extra + ", " + extras;
            }
            NewMealExtras.Text = extra;
                
        }

        private void LoadCook(Cooks cook)
        {
            ClearCooks();
            NewCookName.Text = cook.Name;
            CookID.Text = cook.CookID.ToString();
            foreach (string allergieName in cook.Allergies)
                if(NewCookAllergies.Items.Contains(allergieName))
                    NewCookAllergies.SetItemChecked(NewCookAllergies.Items.IndexOf(allergieName), true);
            foreach (string nightsName in cook.Available)
                if (NewCookAvailableNights.Items.Contains(nightsName))
                    NewCookAvailableNights.SetItemChecked(NewCookAvailableNights.Items.IndexOf(nightsName), true);
        }

        private void LoadWeeksMeals(Week week)
        {

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

        private void ClearWeeksMeals()
        {

        }

        private void SaveCookSql(Cooks cook)
        {
            string allergies = cook.AllergiesString();
            string available = cook.AvailableString();
            SqlCommand cmd = new SqlCommand("INSERT INTO Cooks (CookName, Allergies, DaysAvailable) VALUES (@CookName, @Allergies, @DaysAvailable) SELECT SCOPE_IDENTITY()", con);
            cmd.Parameters.AddWithValue("@CookName", cook.Name);
            cmd.Parameters.AddWithValue("@Allergies", cook.AllergiesString() == null ? string.Empty : cook.AllergiesString());
            cmd.Parameters.AddWithValue("@DaysAvailable", cook.AvailableString() == null ? string.Empty : cook.AvailableString());
            con.Open();
            int cookID = (int)(decimal)cmd.ExecuteScalar();
            cook.CookID = cookID;
            con.Close();
        }

        private void SaveMealSql(Meals meal)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Meals (MealName, Vegetables, Meats, Fillers, Extras, Allergies) VALUES (@MealName, @Vegetables, @Meats, @Fillers, @Extras, @Allergies) SELECT SCOPE_IDENTITY()", con);
            cmd.Parameters.AddWithValue("@MealName", meal.Name);
            cmd.Parameters.AddWithValue("@Vegetables", meal.VegetablesString() == null ? string.Empty : meal.VegetablesString());
            cmd.Parameters.AddWithValue("@Meats", meal.MeatsString() == null ? string.Empty : meal.MeatsString());
            cmd.Parameters.AddWithValue("@Fillers", meal.FillersString() == null ? string.Empty : meal.FillersString());
            cmd.Parameters.AddWithValue("@Extras", meal.ExtrasString() == null ? string.Empty : meal.ExtrasString());
            cmd.Parameters.AddWithValue("@Allergies", meal.AllergiesString() == null ? string.Empty : meal.AllergiesString());
            con.Open();
            int mealID = (int)(decimal)cmd.ExecuteScalar();
            meal.MealID = mealID;
            con.Close();
        }

        private void LoadMealSql()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Meals", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                int id = (int)reader["MealID"];
                string name = ((string)reader["MealName"]).Trim();
                string[] vegetables = reader["Vegetables"].ToString().Split(',');
                string[] meats = reader["Meats"].ToString().Split(',');
                string[] fillers = reader["Fillers"].ToString().Split(',');
                string[] extras = reader["Extras"].ToString().Split(',');
                string[] allergies = reader["Allergies"].ToString().Split(',');
                Meals meal = new Meals(name, vegetables, meats, fillers, extras, allergies);
                meal.MealID = id;
                MealsListBox.Items.Add(meal);
            }
            con.Close();
        }
   
        private void LoadCookSql()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cooks", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["CookID"];
                string name = ((string)reader["CookName"]).Trim();
                string[] allergies = (reader["Allergies"]).ToString().Split(',');
                string[] daysAvailable = ((string)reader["DaysAvailable"]).Split(',');
                Cooks cook = new Cooks(name, allergies, daysAvailable);
                cook.CookID = id;
                CooksListBox.Items.Add(cook);
            }
            con.Close();
        }
    }
}
