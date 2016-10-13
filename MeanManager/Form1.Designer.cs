namespace MeanManager
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
            this.AddCooks = new System.Windows.Forms.TabPage();
            this.AddCook = new System.Windows.Forms.Button();
            this.AvailableNights = new System.Windows.Forms.CheckedListBox();
            this.CookAllergies = new System.Windows.Forms.CheckedListBox();
            this.CookName = new System.Windows.Forms.TextBox();
            this.Viewer = new System.Windows.Forms.TabPage();
            this.ViewerTable = new System.Windows.Forms.DataGridView();
            this.CooksCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WeeksMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cooksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mealsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(531, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // SelectMeal
            // 
            this.SelectMeal.Location = new System.Drawing.Point(4, 22);
            this.SelectMeal.Name = "SelectMeal";
            this.SelectMeal.Padding = new System.Windows.Forms.Padding(3);
            this.SelectMeal.Size = new System.Drawing.Size(523, 323);
            this.SelectMeal.TabIndex = 0;
            this.SelectMeal.Text = "Select Meal";
            this.SelectMeal.UseVisualStyleBackColor = true;
            // 
            // AddMeal
            // 
            this.AddMeal.Location = new System.Drawing.Point(4, 22);
            this.AddMeal.Name = "AddMeal";
            this.AddMeal.Padding = new System.Windows.Forms.Padding(3);
            this.AddMeal.Size = new System.Drawing.Size(523, 323);
            this.AddMeal.TabIndex = 1;
            this.AddMeal.Text = "Add Meals";
            this.AddMeal.UseVisualStyleBackColor = true;
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
            this.AddCooks.Size = new System.Drawing.Size(523, 323);
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
            this.AddCook.Click += new System.EventHandler(this.button1_Click_1);
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
            this.AvailableNights.Location = new System.Drawing.Point(277, 25);
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
            this.CookAllergies.Location = new System.Drawing.Point(139, 25);
            this.CookAllergies.Name = "CookAllergies";
            this.CookAllergies.Size = new System.Drawing.Size(120, 49);
            this.CookAllergies.TabIndex = 1;
            // 
            // CookName
            // 
            this.CookName.Location = new System.Drawing.Point(19, 25);
            this.CookName.Name = "CookName";
            this.CookName.Size = new System.Drawing.Size(100, 20);
            this.CookName.TabIndex = 0;
            // 
            // Viewer
            // 
            this.Viewer.Controls.Add(this.ViewerTable);
            this.Viewer.Location = new System.Drawing.Point(4, 22);
            this.Viewer.Name = "Viewer";
            this.Viewer.Padding = new System.Windows.Forms.Padding(3);
            this.Viewer.Size = new System.Drawing.Size(523, 323);
            this.Viewer.TabIndex = 3;
            this.Viewer.Text = "View Data";
            this.Viewer.UseVisualStyleBackColor = true;
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
            this.ViewerTable.Size = new System.Drawing.Size(511, 311);
            this.ViewerTable.TabIndex = 0;
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
            // cooksBindingSource
            // 
            this.cooksBindingSource.DataSource = typeof(MeanManager.Cooks);
            // 
            // mealsBindingSource
            // 
            this.mealsBindingSource.DataSource = typeof(MeanManager.Meals);
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
    }
}

