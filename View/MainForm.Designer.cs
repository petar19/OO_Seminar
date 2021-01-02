namespace OO_Seminar
{
    partial class MainForm
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
            this.mealAddBtn = new System.Windows.Forms.Button();
            this.listViewMeals = new System.Windows.Forms.ListView();
            this.MealName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MealType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Timestamp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mealAddBtn
            // 
            this.mealAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mealAddBtn.Location = new System.Drawing.Point(12, 542);
            this.mealAddBtn.Name = "mealAddBtn";
            this.mealAddBtn.Size = new System.Drawing.Size(75, 23);
            this.mealAddBtn.TabIndex = 0;
            this.mealAddBtn.Text = "Add";
            this.mealAddBtn.UseVisualStyleBackColor = true;
            this.mealAddBtn.Click += new System.EventHandler(this.addMealBtn_Click);
            // 
            // listViewMeals
            // 
            this.listViewMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MealName,
            this.MealType,
            this.Timestamp,
            this.Rating});
            this.listViewMeals.HideSelection = false;
            this.listViewMeals.Location = new System.Drawing.Point(93, 12);
            this.listViewMeals.Name = "listViewMeals";
            this.listViewMeals.Size = new System.Drawing.Size(934, 553);
            this.listViewMeals.TabIndex = 1;
            this.listViewMeals.UseCompatibleStateImageBehavior = false;
            this.listViewMeals.View = System.Windows.Forms.View.Details;
            this.listViewMeals.SelectedIndexChanged += new System.EventHandler(this.listViewMeals_SelectedIndexChanged);
            // 
            // MealName
            // 
            this.MealName.Text = "Name";
            this.MealName.Width = 120;
            // 
            // MealType
            // 
            this.MealType.Text = "Meal type";
            this.MealType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MealType.Width = 120;
            // 
            // Timestamp
            // 
            this.Timestamp.Text = "Timestamp";
            this.Timestamp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Timestamp.Width = 200;
            // 
            // Rating
            // 
            this.Rating.Text = "Meal rating";
            this.Rating.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rating.Width = 80;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 577);
            this.Controls.Add(this.listViewMeals);
            this.Controls.Add(this.mealAddBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "What did I eat?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mealAddBtn;
        private System.Windows.Forms.ListView listViewMeals;
        private System.Windows.Forms.ColumnHeader MealName;
        private System.Windows.Forms.ColumnHeader MealType;
        private System.Windows.Forms.ColumnHeader Timestamp;
        private System.Windows.Forms.ColumnHeader Rating;
    }
}

