﻿namespace MealManager
{
    partial class Main
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
            this.ViewerTab = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MealsListBox = new System.Windows.Forms.ListBox();
            this.WeeksMealsListBox = new System.Windows.Forms.ListBox();
            this.CooksListBox = new System.Windows.Forms.ListBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddCookTab = new System.Windows.Forms.TabPage();
            this.AddCookButton = new System.Windows.Forms.Button();
            this.NewCookAvailableNights = new System.Windows.Forms.CheckedListBox();
            this.NewCookAllergies = new System.Windows.Forms.CheckedListBox();
            this.NewCookName = new System.Windows.Forms.TextBox();
            this.AddMealTab = new System.Windows.Forms.TabPage();
            this.AddMealButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NewMealExtras = new System.Windows.Forms.RichTextBox();
            this.NewMealName = new System.Windows.Forms.TextBox();
            this.NewMealFillers = new System.Windows.Forms.CheckedListBox();
            this.NewMealAllergies = new System.Windows.Forms.CheckedListBox();
            this.NewMealVegetables = new System.Windows.Forms.CheckedListBox();
            this.NewMealMeats = new System.Windows.Forms.CheckedListBox();
            this.SelectMealTab = new System.Windows.Forms.TabPage();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ViewerTab.SuspendLayout();
            this.AddCookTab.SuspendLayout();
            this.AddMealTab.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewerTab
            // 
            this.ViewerTab.Controls.Add(this.label8);
            this.ViewerTab.Controls.Add(this.label7);
            this.ViewerTab.Controls.Add(this.label1);
            this.ViewerTab.Controls.Add(this.MealsListBox);
            this.ViewerTab.Controls.Add(this.WeeksMealsListBox);
            this.ViewerTab.Controls.Add(this.CooksListBox);
            this.ViewerTab.Controls.Add(this.RemoveButton);
            this.ViewerTab.Location = new System.Drawing.Point(4, 22);
            this.ViewerTab.Name = "ViewerTab";
            this.ViewerTab.Padding = new System.Windows.Forms.Padding(3);
            this.ViewerTab.Size = new System.Drawing.Size(523, 320);
            this.ViewerTab.TabIndex = 3;
            this.ViewerTab.Text = "View Data";
            this.ViewerTab.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Weeks Meals";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Meals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cooks";
            // 
            // MealsListBox
            // 
            this.MealsListBox.DisplayMember = "Name";
            this.MealsListBox.FormattingEnabled = true;
            this.MealsListBox.Location = new System.Drawing.Point(125, 24);
            this.MealsListBox.Name = "MealsListBox";
            this.MealsListBox.Size = new System.Drawing.Size(120, 238);
            this.MealsListBox.TabIndex = 4;
            this.MealsListBox.ValueMember = "Name";
            this.MealsListBox.Click += new System.EventHandler(this.MealsListBox_Click);
            this.MealsListBox.DoubleClick += new System.EventHandler(this.MealsListBox_DoubleClick);
            // 
            // WeeksMealsListBox
            // 
            this.WeeksMealsListBox.DisplayMember = "Name";
            this.WeeksMealsListBox.FormattingEnabled = true;
            this.WeeksMealsListBox.Location = new System.Drawing.Point(244, 24);
            this.WeeksMealsListBox.Name = "WeeksMealsListBox";
            this.WeeksMealsListBox.Size = new System.Drawing.Size(120, 238);
            this.WeeksMealsListBox.TabIndex = 3;
            this.WeeksMealsListBox.ValueMember = "Name";
            this.WeeksMealsListBox.Click += new System.EventHandler(this.WeeksMealsListBox_Click);
            this.WeeksMealsListBox.DoubleClick += new System.EventHandler(this.WeeksMealListBox_DoubleClick);
            // 
            // CooksListBox
            // 
            this.CooksListBox.DisplayMember = "Name";
            this.CooksListBox.FormattingEnabled = true;
            this.CooksListBox.Location = new System.Drawing.Point(6, 24);
            this.CooksListBox.Name = "CooksListBox";
            this.CooksListBox.Size = new System.Drawing.Size(120, 238);
            this.CooksListBox.TabIndex = 2;
            this.CooksListBox.ValueMember = "Name";
            this.CooksListBox.Click += new System.EventHandler(this.CooksListBox_Click);
            this.CooksListBox.DoubleClick += new System.EventHandler(this.CooksListBox_DoubleClick);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(6, 290);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 1;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddCookTab
            // 
            this.AddCookTab.Controls.Add(this.AddCookButton);
            this.AddCookTab.Controls.Add(this.NewCookAvailableNights);
            this.AddCookTab.Controls.Add(this.NewCookAllergies);
            this.AddCookTab.Controls.Add(this.NewCookName);
            this.AddCookTab.Location = new System.Drawing.Point(4, 22);
            this.AddCookTab.Name = "AddCookTab";
            this.AddCookTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddCookTab.Size = new System.Drawing.Size(523, 320);
            this.AddCookTab.TabIndex = 2;
            this.AddCookTab.Text = "Add Cooks";
            this.AddCookTab.UseVisualStyleBackColor = true;
            // 
            // AddCookButton
            // 
            this.AddCookButton.Location = new System.Drawing.Point(19, 111);
            this.AddCookButton.Name = "AddCookButton";
            this.AddCookButton.Size = new System.Drawing.Size(75, 23);
            this.AddCookButton.TabIndex = 3;
            this.AddCookButton.Text = "Add Cook";
            this.AddCookButton.UseVisualStyleBackColor = true;
            this.AddCookButton.Click += new System.EventHandler(this.AddCookButton_Click);
            // 
            // NewCookAvailableNights
            // 
            this.NewCookAvailableNights.CheckOnClick = true;
            this.NewCookAvailableNights.FormattingEnabled = true;
            this.NewCookAvailableNights.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.NewCookAvailableNights.Location = new System.Drawing.Point(145, 25);
            this.NewCookAvailableNights.Name = "NewCookAvailableNights";
            this.NewCookAvailableNights.Size = new System.Drawing.Size(120, 109);
            this.NewCookAvailableNights.TabIndex = 2;
            // 
            // NewCookAllergies
            // 
            this.NewCookAllergies.CheckOnClick = true;
            this.NewCookAllergies.FormattingEnabled = true;
            this.NewCookAllergies.Items.AddRange(new object[] {
            "Eggs",
            "Dairy",
            "Nuts"});
            this.NewCookAllergies.Location = new System.Drawing.Point(19, 51);
            this.NewCookAllergies.Name = "NewCookAllergies";
            this.NewCookAllergies.Size = new System.Drawing.Size(120, 49);
            this.NewCookAllergies.TabIndex = 1;
            // 
            // NewCookName
            // 
            this.NewCookName.Location = new System.Drawing.Point(19, 25);
            this.NewCookName.Name = "NewCookName";
            this.NewCookName.Size = new System.Drawing.Size(120, 20);
            this.NewCookName.TabIndex = 0;
            // 
            // AddMealTab
            // 
            this.AddMealTab.Controls.Add(this.AddMealButton);
            this.AddMealTab.Controls.Add(this.label6);
            this.AddMealTab.Controls.Add(this.label5);
            this.AddMealTab.Controls.Add(this.label4);
            this.AddMealTab.Controls.Add(this.label3);
            this.AddMealTab.Controls.Add(this.label2);
            this.AddMealTab.Controls.Add(this.NewMealExtras);
            this.AddMealTab.Controls.Add(this.NewMealName);
            this.AddMealTab.Controls.Add(this.NewMealFillers);
            this.AddMealTab.Controls.Add(this.NewMealAllergies);
            this.AddMealTab.Controls.Add(this.NewMealVegetables);
            this.AddMealTab.Controls.Add(this.NewMealMeats);
            this.AddMealTab.Location = new System.Drawing.Point(4, 22);
            this.AddMealTab.Name = "AddMealTab";
            this.AddMealTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddMealTab.Size = new System.Drawing.Size(523, 320);
            this.AddMealTab.TabIndex = 6;
            this.AddMealTab.Text = "Add Meal";
            this.AddMealTab.UseVisualStyleBackColor = true;
            // 
            // AddMealButton
            // 
            this.AddMealButton.Location = new System.Drawing.Point(6, 293);
            this.AddMealButton.Name = "AddMealButton";
            this.AddMealButton.Size = new System.Drawing.Size(75, 23);
            this.AddMealButton.TabIndex = 13;
            this.AddMealButton.Text = "Add";
            this.AddMealButton.UseVisualStyleBackColor = true;
            this.AddMealButton.Click += new System.EventHandler(this.AddMealButton_Click);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Allergies";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Meats";
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
            // NewMealExtras
            // 
            this.NewMealExtras.Location = new System.Drawing.Point(6, 191);
            this.NewMealExtras.Name = "NewMealExtras";
            this.NewMealExtras.Size = new System.Drawing.Size(338, 96);
            this.NewMealExtras.TabIndex = 5;
            this.NewMealExtras.Text = "";
            // 
            // NewMealName
            // 
            this.NewMealName.Location = new System.Drawing.Point(6, 19);
            this.NewMealName.Name = "NewMealName";
            this.NewMealName.Size = new System.Drawing.Size(119, 20);
            this.NewMealName.TabIndex = 1;
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
            // NewMealVegetables
            // 
            this.NewMealVegetables.CheckOnClick = true;
            this.NewMealVegetables.FormattingEnabled = true;
            this.NewMealVegetables.Items.AddRange(new object[] {
            "Brocoilli",
            "Potato",
            "Carrots",
            "Letuce",
            "Cabage",
            "Peas"});
            this.NewMealVegetables.Location = new System.Drawing.Point(6, 64);
            this.NewMealVegetables.Name = "NewMealVegetables";
            this.NewMealVegetables.Size = new System.Drawing.Size(80, 94);
            this.NewMealVegetables.TabIndex = 2;
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
            // SelectMealTab
            // 
            this.SelectMealTab.Location = new System.Drawing.Point(4, 22);
            this.SelectMealTab.Name = "SelectMealTab";
            this.SelectMealTab.Padding = new System.Windows.Forms.Padding(3);
            this.SelectMealTab.Size = new System.Drawing.Size(523, 320);
            this.SelectMealTab.TabIndex = 0;
            this.SelectMealTab.Text = "Select Meal";
            this.SelectMealTab.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.SelectMealTab);
            this.tabControl.Controls.Add(this.AddMealTab);
            this.tabControl.Controls.Add(this.AddCookTab);
            this.tabControl.Controls.Add(this.ViewerTab);
            this.tabControl.Location = new System.Drawing.Point(2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(531, 346);
            this.tabControl.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 347);
            this.Controls.Add(this.tabControl);
            this.Name = "Main";
            this.Text = "Form1";
            this.ViewerTab.ResumeLayout(false);
            this.ViewerTab.PerformLayout();
            this.AddCookTab.ResumeLayout(false);
            this.AddCookTab.PerformLayout();
            this.AddMealTab.ResumeLayout(false);
            this.AddMealTab.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ViewerTab;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox MealsListBox;
        private System.Windows.Forms.ListBox WeeksMealsListBox;
        private System.Windows.Forms.ListBox CooksListBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TabPage AddCookTab;
        private System.Windows.Forms.Button AddCookButton;
        private System.Windows.Forms.CheckedListBox NewCookAvailableNights;
        private System.Windows.Forms.CheckedListBox NewCookAllergies;
        private System.Windows.Forms.TextBox NewCookName;
        private System.Windows.Forms.TabPage AddMealTab;
        private System.Windows.Forms.Button AddMealButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox NewMealExtras;
        private System.Windows.Forms.TextBox NewMealName;
        private System.Windows.Forms.CheckedListBox NewMealFillers;
        private System.Windows.Forms.CheckedListBox NewMealAllergies;
        private System.Windows.Forms.CheckedListBox NewMealVegetables;
        private System.Windows.Forms.CheckedListBox NewMealMeats;
        private System.Windows.Forms.TabPage SelectMealTab;
        private System.Windows.Forms.TabControl tabControl;
    }
}

