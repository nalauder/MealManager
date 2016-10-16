namespace MealManager
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SelectMeal = new System.Windows.Forms.TabPage();
            this.AddMeal = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.NewMealExtras = new System.Windows.Forms.RichTextBox();
            this.NewMealFillers = new System.Windows.Forms.CheckedListBox();
            this.NewMealAllergies = new System.Windows.Forms.CheckedListBox();
            this.NewMealVegtables = new System.Windows.Forms.CheckedListBox();
            this.newMealName = new System.Windows.Forms.TextBox();
            this.NewMealMeats = new System.Windows.Forms.CheckedListBox();
            this.AddCooks = new System.Windows.Forms.TabPage();
            this.AddCook = new System.Windows.Forms.Button();
            this.AvailableNights = new System.Windows.Forms.CheckedListBox();
            this.CookAllergies = new System.Windows.Forms.CheckedListBox();
            this.CookName = new System.Windows.Forms.TextBox();
            this.Viewer = new System.Windows.Forms.TabPage();
            this.Remove = new System.Windows.Forms.Button();
            this.ViewerTable = new System.Windows.Forms.DataGridView();
            this.CooksCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeeksMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.AddMeal.SuspendLayout();
            this.AddCooks.SuspendLayout();
            this.Viewer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewerTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.SelectMeal);
            this.tabControl1.Controls.Add(this.AddMeal);
            this.tabControl1.Controls.Add(this.AddCooks);
            this.tabControl1.Controls.Add(this.Viewer);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(531, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // SelectMeal
            // 
            this.SelectMeal.Location = new System.Drawing.Point(4, 22);
            this.SelectMeal.Name = "SelectMeal";
            this.SelectMeal.Padding = new System.Windows.Forms.Padding(3);
            this.SelectMeal.Size = new System.Drawing.Size(523, 320);
            this.SelectMeal.TabIndex = 0;
            this.SelectMeal.Text = "Select Meal";
            this.SelectMeal.UseVisualStyleBackColor = true;
            // 
            // AddMeal
            // 
            this.AddMeal.Controls.Add(this.label6);
            this.AddMeal.Controls.Add(this.label5);
            this.AddMeal.Controls.Add(this.label4);
            this.AddMeal.Controls.Add(this.label3);
            this.AddMeal.Controls.Add(this.label2);
            this.AddMeal.Controls.Add(this.label1);
            this.AddMeal.Controls.Add(this.Add);
            this.AddMeal.Controls.Add(this.NewMealExtras);
            this.AddMeal.Controls.Add(this.NewMealFillers);
            this.AddMeal.Controls.Add(this.NewMealAllergies);
            this.AddMeal.Controls.Add(this.NewMealVegtables);
            this.AddMeal.Controls.Add(this.newMealName);
            this.AddMeal.Controls.Add(this.NewMealMeats);
            this.AddMeal.Location = new System.Drawing.Point(4, 22);
            this.AddMeal.Name = "AddMeal";
            this.AddMeal.Padding = new System.Windows.Forms.Padding(3);
            this.AddMeal.Size = new System.Drawing.Size(523, 320);
            this.AddMeal.TabIndex = 1;
            this.AddMeal.Text = "Add Meals";
            this.AddMeal.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Meal Name";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(6, 293);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // NewMealExtras
            // 
            this.NewMealExtras.Location = new System.Drawing.Point(6, 191);
            this.NewMealExtras.Name = "NewMealExtras";
            this.NewMealExtras.Size = new System.Drawing.Size(338, 96);
            this.NewMealExtras.TabIndex = 5;
            this.NewMealExtras.Text = "";
            // 
            // NewMealFillers
            // 
            this.NewMealFillers.CheckOnClick = true;
            this.NewMealFillers.FormattingEnabled = true;
            this.NewMealFillers.Items.AddRange(new object[] {
            "Pasta",
            "Spegetti",
            "Rice"});
            this.NewMealFillers.Location = new System.Drawing.Point(178, 64);
            this.NewMealFillers.Name = "NewMealFillers";
            this.NewMealFillers.Size = new System.Drawing.Size(80, 94);
            this.NewMealFillers.TabIndex = 4;
            // 
            // NewMealAllergies
            // 
            this.NewMealAllergies.CheckOnClick = true;
            this.NewMealAllergies.FormattingEnabled = true;
            this.NewMealAllergies.Items.AddRange(new object[] {
            "Dairy",
            "Eggs",
            "Nuts"});
            this.NewMealAllergies.Location = new System.Drawing.Point(264, 64);
            this.NewMealAllergies.Name = "NewMealAllergies";
            this.NewMealAllergies.Size = new System.Drawing.Size(80, 94);
            this.NewMealAllergies.TabIndex = 3;
            // 
            // NewMealVegtables
            // 
            this.NewMealVegtables.CheckOnClick = true;
            this.NewMealVegtables.FormattingEnabled = true;
            this.NewMealVegtables.Items.AddRange(new object[] {
            "Brocoilli",
            "Potato",
            "Carrots",
            "Letuce",
            "Cabage",
            "Peas"});
            this.NewMealVegtables.Location = new System.Drawing.Point(6, 64);
            this.NewMealVegtables.Name = "NewMealVegtables";
            this.NewMealVegtables.Size = new System.Drawing.Size(80, 94);
            this.NewMealVegtables.TabIndex = 2;
            // 
            // newMealName
            // 
            this.newMealName.Location = new System.Drawing.Point(6, 19);
            this.newMealName.Name = "newMealName";
            this.newMealName.Size = new System.Drawing.Size(119, 20);
            this.newMealName.TabIndex = 1;
            // 
            // NewMealMeats
            // 
            this.NewMealMeats.CheckOnClick = true;
            this.NewMealMeats.FormattingEnabled = true;
            this.NewMealMeats.Items.AddRange(new object[] {
            "Beef",
            "Steak",
            "Chicken",
            "Fish",
            "Pork"});
            this.NewMealMeats.Location = new System.Drawing.Point(92, 64);
            this.NewMealMeats.Name = "NewMealMeats";
            this.NewMealMeats.Size = new System.Drawing.Size(80, 94);
            this.NewMealMeats.TabIndex = 0;
            // 
            // AddCooks
            // 
            this.AddCooks.Controls.Add(this.AddCook);
            this.AddCooks.Controls.Add(this.AvailableNights);
            this.AddCooks.Controls.Add(this.CookAllergies);
            this.AddCooks.Controls.Add(this.CookName);
            this.AddCooks.Location = new System.Drawing.Point(4, 22);
            this.AddCooks.Name = "AddCooks";
            this.AddCooks.Padding = new System.Windows.Forms.Padding(3);
            this.AddCooks.Size = new System.Drawing.Size(523, 320);
            this.AddCooks.TabIndex = 2;
            this.AddCooks.Text = "Add Cooks";
            this.AddCooks.UseVisualStyleBackColor = true;
            // 
            // AddCook
            // 
            this.AddCook.Location = new System.Drawing.Point(19, 131);
            this.AddCook.Name = "AddCook";
            this.AddCook.Size = new System.Drawing.Size(75, 23);
            this.AddCook.TabIndex = 3;
            this.AddCook.Text = "Add Cook";
            this.AddCook.UseVisualStyleBackColor = true;
            this.AddCook.Click += new System.EventHandler(this.AddCook_Click);
            // 
            // AvailableNights
            // 
            this.AvailableNights.CheckOnClick = true;
            this.AvailableNights.FormattingEnabled = true;
            this.AvailableNights.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.AvailableNights.Location = new System.Drawing.Point(145, 25);
            this.AvailableNights.Name = "AvailableNights";
            this.AvailableNights.Size = new System.Drawing.Size(120, 109);
            this.AvailableNights.TabIndex = 2;
            // 
            // CookAllergies
            // 
            this.CookAllergies.CheckOnClick = true;
            this.CookAllergies.FormattingEnabled = true;
            this.CookAllergies.Items.AddRange(new object[] {
            "Eggs",
            "Dairy",
            "Nuts"});
            this.CookAllergies.Location = new System.Drawing.Point(19, 51);
            this.CookAllergies.Name = "CookAllergies";
            this.CookAllergies.Size = new System.Drawing.Size(120, 49);
            this.CookAllergies.TabIndex = 1;
            // 
            // CookName
            // 
            this.CookName.Location = new System.Drawing.Point(19, 25);
            this.CookName.Name = "CookName";
            this.CookName.Size = new System.Drawing.Size(120, 20);
            this.CookName.TabIndex = 0;
            // 
            // Viewer
            // 
            this.Viewer.Controls.Add(this.Remove);
            this.Viewer.Controls.Add(this.ViewerTable);
            this.Viewer.Location = new System.Drawing.Point(4, 22);
            this.Viewer.Name = "Viewer";
            this.Viewer.Padding = new System.Windows.Forms.Padding(3);
            this.Viewer.Size = new System.Drawing.Size(523, 320);
            this.Viewer.TabIndex = 3;
            this.Viewer.Text = "View Data";
            this.Viewer.UseVisualStyleBackColor = true;
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(6, 290);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(75, 23);
            this.Remove.TabIndex = 1;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // ViewerTable
            // 
            this.ViewerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CooksCol,
            this.WeeksMeals,
            this.AllMeals});
            this.ViewerTable.Location = new System.Drawing.Point(6, 6);
            this.ViewerTable.Name = "ViewerTable";
            this.ViewerTable.Size = new System.Drawing.Size(511, 278);
            this.ViewerTable.TabIndex = 0;
            this.ViewerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewerTable_CellContentClick);
            // 
            // CooksCol
            // 
            this.CooksCol.HeaderText = "Cooks";
            this.CooksCol.Name = "CooksCol";
            this.CooksCol.ReadOnly = true;
            this.CooksCol.Width = 150;
            // 
            // WeeksMeals
            // 
            this.WeeksMeals.HeaderText = "Weeks Meals";
            this.WeeksMeals.Name = "WeeksMeals";
            this.WeeksMeals.ReadOnly = true;
            this.WeeksMeals.Width = 150;
            // 
            // AllMeals
            // 
            this.AllMeals.HeaderText = "All Meals";
            this.AllMeals.Name = "AllMeals";
            this.AllMeals.ReadOnly = true;
            this.AllMeals.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vegetables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Meats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fillers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Allergies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Extra Ingredients (Seperated by comma)";
            // 
            // cooksBindingSource
            // 
            this.cooksBindingSource.DataSource = typeof(MealManager.Cooks);
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataSource = typeof(MealManager.Meals);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.AddMeal.ResumeLayout(false);
            this.AddMeal.PerformLayout();
            this.AddCooks.ResumeLayout(false);
            this.AddCooks.PerformLayout();
            this.Viewer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewerTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cooksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource cooksBindingSource;
        private System.Windows.Forms.BindingSource mealsBindingSource;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SelectMeal;
        private System.Windows.Forms.TabPage AddMeal;
        private System.Windows.Forms.TabPage AddCooks;
        private System.Windows.Forms.CheckedListBox AvailableNights;
        private System.Windows.Forms.CheckedListBox CookAllergies;
        private System.Windows.Forms.TextBox CookName;
        private System.Windows.Forms.Button AddCook;
        private System.Windows.Forms.TabPage Viewer;
        private System.Windows.Forms.DataGridView ViewerTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CooksCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeeksMeals;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllMeals;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.RichTextBox NewMealExtras;
        private System.Windows.Forms.CheckedListBox NewMealFillers;
        private System.Windows.Forms.CheckedListBox NewMealAllergies;
        private System.Windows.Forms.CheckedListBox NewMealVegtables;
        private System.Windows.Forms.TextBox newMealName;
        private System.Windows.Forms.CheckedListBox NewMealMeats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

