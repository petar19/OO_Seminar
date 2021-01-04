namespace OO_Seminar.View
{
    partial class MealListItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxMealImage = new System.Windows.Forms.PictureBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelMealType = new System.Windows.Forms.Label();
            this.labelDishType = new System.Windows.Forms.Label();
            this.labelPreparationType = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelRating = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelTimestamp = new System.Windows.Forms.Label();
            this.listViewIngredients = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMealImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxMealImage
            // 
            this.pictureBoxMealImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBoxMealImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxMealImage.Name = "pictureBoxMealImage";
            this.pictureBoxMealImage.Size = new System.Drawing.Size(203, 183);
            this.pictureBoxMealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMealImage.TabIndex = 0;
            this.pictureBoxMealImage.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(498, 3);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(98, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Meal Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMealType
            // 
            this.labelMealType.AutoSize = true;
            this.labelMealType.Location = new System.Drawing.Point(452, 42);
            this.labelMealType.Name = "labelMealType";
            this.labelMealType.Size = new System.Drawing.Size(53, 13);
            this.labelMealType.TabIndex = 0;
            this.labelMealType.Text = "Meal type";
            // 
            // labelDishType
            // 
            this.labelDishType.AutoSize = true;
            this.labelDishType.Location = new System.Drawing.Point(452, 64);
            this.labelDishType.Name = "labelDishType";
            this.labelDishType.Size = new System.Drawing.Size(51, 13);
            this.labelDishType.TabIndex = 1;
            this.labelDishType.Text = "Dish type";
            // 
            // labelPreparationType
            // 
            this.labelPreparationType.AutoSize = true;
            this.labelPreparationType.Location = new System.Drawing.Point(452, 89);
            this.labelPreparationType.Name = "labelPreparationType";
            this.labelPreparationType.Size = new System.Drawing.Size(84, 13);
            this.labelPreparationType.TabIndex = 2;
            this.labelPreparationType.Text = "Preparation type";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(452, 113);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(48, 13);
            this.labelLocation.TabIndex = 3;
            this.labelLocation.Text = "Location";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(624, 89);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(31, 13);
            this.labelPrice.TabIndex = 2;
            this.labelPrice.Text = "Price";
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(624, 64);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(38, 13);
            this.labelRating.TabIndex = 1;
            this.labelRating.Text = "Rating";
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Location = new System.Drawing.Point(624, 42);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(44, 13);
            this.labelCalories.TabIndex = 0;
            this.labelCalories.Text = "Calories";
            // 
            // labelTimestamp
            // 
            this.labelTimestamp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTimestamp.AutoSize = true;
            this.labelTimestamp.Location = new System.Drawing.Point(796, 3);
            this.labelTimestamp.Name = "labelTimestamp";
            this.labelTimestamp.Size = new System.Drawing.Size(58, 13);
            this.labelTimestamp.TabIndex = 3;
            this.labelTimestamp.Text = "Timestamp";
            // 
            // listViewIngredients
            // 
            this.listViewIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewIngredients.HideSelection = false;
            this.listViewIngredients.Location = new System.Drawing.Point(212, 26);
            this.listViewIngredients.Name = "listViewIngredients";
            this.listViewIngredients.Size = new System.Drawing.Size(220, 160);
            this.listViewIngredients.TabIndex = 0;
            this.listViewIngredients.UseCompatibleStateImageBehavior = false;
            this.listViewIngredients.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ingredient";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Importance";
            this.columnHeader2.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Calories:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(574, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(574, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Price:";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescription.Location = new System.Drawing.Point(674, 26);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(236, 166);
            this.textBoxDescription.TabIndex = 6;
            // 
            // MealListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPreparationType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTimestamp);
            this.Controls.Add(this.labelRating);
            this.Controls.Add(this.labelDishType);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelMealType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxMealImage);
            this.Name = "MealListItem";
            this.Size = new System.Drawing.Size(913, 195);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMealImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMealImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelPreparationType;
        private System.Windows.Forms.Label labelDishType;
        private System.Windows.Forms.Label labelMealType;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelTimestamp;
        private System.Windows.Forms.ListView listViewIngredients;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}
