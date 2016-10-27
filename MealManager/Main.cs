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
        List<Cooks> AllCooks = new List<Cooks>();
        List<Meals> AllMeals = new List<Meals>();
        List<Meals> WeeksMeals = new List<Meals>();
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
            Cooks selected = AllCooks.FirstOrDefault(cooks => cooks.Name == name);
            if (selected != null)
                return;
            List<string> days = new List<string>();
            List<string> allergies = new List<string>();
            foreach (string items in NewCookAvailableNights.CheckedItems)
                    days.Add(items);
            foreach (string items in NewCookAllergies.CheckedItems)
                    allergies.Add(items);
            Cooks cook = new Cooks(name, allergies, days);
            AllCooks.Add(cook);
            CooksListBox.Items.Add(cook);
            SaveCookSql(cook);
            SqlCommand cmd = new SqlCommand("SELECT last_insert_rowid()", con);
            con.Open();
            int cookID = (int)cmd.ExecuteScalar();
            cook.CookID = cookID;
            ClearCooks();
            con.Close();
        }

        private void AddMealButton_Click(object sender, EventArgs e)
        {
            string name = NewMealName.Text;
            List<string> extras = new List<string>();
            List<string> meats = new List<string>();
            List<string> vegetables = new List<string>();
            List<string> fillers = new List<string>();
            List<string> allergies = new List<string>();
            foreach (string items in NewMealVegetables.CheckedItems)
                vegetables.Add(items);
            foreach (string items in NewMealMeats.CheckedItems)
                meats.Add(items);
            foreach (string items in NewMealFillers.CheckedItems)
                fillers.Add(items);
            foreach (string items in NewMealAllergies.CheckedItems)
                allergies.Add(items);
            string[] extrasSplit = NewMealExtras.Text.Split(',');
            for (int i = 0; i < extrasSplit.Length; i++)
                extras.Add(extrasSplit[i].Trim());
            Meals meal = new Meals(name, vegetables, meats, fillers, extras, allergies);
            AllMeals.Add(meal);
            MealsListBox.Items.Add(meal);
            SaveMealSql(meal);
            ClearMeals();
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

        private void SaveCookSql(Cooks cook)
        {
            string allergies = cook.AllergiesString();
            string available = cook.AvailableString();
            SqlCommand cmd = new SqlCommand("INSERT INTO Cooks (CookName, Allergies, DaysAvailable) VALUES (@CookName, @Allergies, @DaysAvailable) SELECT SCOPE_IDENTITY()", con);
            cmd.Parameters.AddWithValue("@CookName", cook.Name);

            if (allergies == null)
                cmd.Parameters.AddWithValue("@Allergies", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Allergies", allergies);

            if (available == null)
                cmd.Parameters.AddWithValue("@DaysAvailable", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@DaysAvailable", available);

            con.Open();
            int cookID = (int)(decimal)cmd.ExecuteScalar();
            cook.CookID = cookID;
            con.Close();
        }

        private void SaveMealSql(Meals meal)
        {
            string vegetables = meal.VegetablesString();
            string meats = meal.MeatsString();
            string fillers = meal.FillersString();
            string extras = meal.ExtrasString();
            string allergies = meal.AllergiesString();
            SqlCommand cmd = new SqlCommand("INSERT INTO Meals (MealName, Vegetables, Meats, Fillers, Extras, Allergies) VALUES (@MealName, @Vegetables, @Meats, @Fillers, @Extras, @Allergies) SELECT SCOPE_IDENTITY()", con);
            cmd.Parameters.AddWithValue("@MealName", meal.Name);

            if (vegetables == null)
                cmd.Parameters.AddWithValue("@Vegetables", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Vegetables", vegetables);

            if (meats == null)
                cmd.Parameters.AddWithValue("@Meats", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Meats", meats);

            if (fillers == null)
                cmd.Parameters.AddWithValue("@Fillers", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Fillers", fillers);

            if (extras == null)
                cmd.Parameters.AddWithValue("@Extras", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Extras", extras);

            if (allergies == null)
                cmd.Parameters.AddWithValue("@Allergies", DBNull.Value);
            else
                cmd.Parameters.AddWithValue("@Allergies", allergies);

            con.Open();
            int mealID = (int)(decimal)cmd.ExecuteScalar();
            meal.MealID = mealID;
            con.Close();
        }

        private void LoadMealSql()
        {
            List<string> vegetable;
            List<string> meat;
            List<string> filler;
            List<string> extra;
            List<string> allergy;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Meals", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
                vegetable = new List<string>();
                meat = new List<string>();
                filler = new List<string>();
                extra = new List<string>();
                allergy = new List<string>();
                int id = (int)reader["MealID"];
                string name = (string)reader["MealName"];
                string[] vegetables = reader["Vegetables"].ToString().Split(',');
                string[] meats = reader["Meats"].ToString().Split(',');
                string[] fillers = reader["Fillers"].ToString().Split(',');
                string[] extras = reader["Extras"].ToString().Split(',');
                string[] allergies = reader["Allergies"].ToString().Split(',');
                for (int i = 0; i < vegetables.Length; i++)
                    vegetable.Add(vegetables[i].Trim());
                for (int i = 0; i < meats.Length; i++)
                    meat.Add(meats[i].Trim());
                for (int i = 0; i < fillers.Length; i++)
                    filler.Add(fillers[i].Trim());
                for (int i = 0; i < extras.Length; i++)
                    extra.Add(extras[i].Trim());
                for (int i = 0; i < allergies.Length; i++)
                    allergy.Add(allergies[i].Trim());
                Meals meal = new Meals(name, vegetable, meat, filler, extra, allergy);
                meal.MealID = id;
                AllMeals.Add(meal);
                MealsListBox.Items.Add(meal);
            }
            con.Close();
        }
   
        private void LoadCookSql()
        {
            List<string> allergy;
            List<string> available;
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cooks", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                allergy = new List<string>();
                available = new List<string>();
                int id = (int)reader["CookID"];
                string name = (string)reader["CookName"];
                string[] allergies = (reader["Allergies"]).ToString().Split(',');
                string[] daysAvailable = ((string)reader["DaysAvailable"]).Split(',');
                for (int i = 0; i < allergies.Length; i++)
                    allergy.Add(allergies[i].Trim());
                for (int i = 0; i < daysAvailable.Length; i++)
                    available.Add(daysAvailable[i].Trim());
                Cooks cook = new Cooks(name, allergy, available);
                cook.CookID = id;
                AllCooks.Add(cook);
                CooksListBox.Items.Add(cook);
            }
            con.Close();
        }
    }


}
