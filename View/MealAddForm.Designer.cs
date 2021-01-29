namespace OO_Seminar
{
    partial class MealAddForm
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
            this.mealDetailsBox = new System.Windows.Forms.GroupBox();
            this.buttonChooseImage = new System.Windows.Forms.Button();
            this.pictureBoxMealImage = new System.Windows.Forms.PictureBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.panelIngredientList = new System.Windows.Forms.Panel();
            this.buttonRemoveIngredient = new System.Windows.Forms.Button();
            this.buttonAddIngredient = new System.Windows.Forms.Button();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.trackBarPrice = new System.Windows.Forms.TrackBar();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.trackBarCalories = new System.Windows.Forms.TrackBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.comboBoxPreparationType = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.comboBoxLocation = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.comboBoxDishType = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBarRating = new System.Windows.Forms.TrackBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxMealType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.controlButtonsBox = new System.Windows.Forms.GroupBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxName = new System.Windows.Forms.ComboBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.mealDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMealImage)).BeginInit();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalories)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.controlButtonsBox.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.SuspendLayout();
            // 
            // mealDetailsBox
            // 
            this.mealDetailsBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mealDetailsBox.Controls.Add(this.buttonChooseImage);
            this.mealDetailsBox.Controls.Add(this.pictureBoxMealImage);
            this.mealDetailsBox.Controls.Add(this.groupBox10);
            this.mealDetailsBox.Controls.Add(this.groupBox9);
            this.mealDetailsBox.Controls.Add(this.groupBox8);
            this.mealDetailsBox.Controls.Add(this.groupBox7);
            this.mealDetailsBox.Controls.Add(this.groupBox6);
            this.mealDetailsBox.Controls.Add(this.groupBox5);
            this.mealDetailsBox.Controls.Add(this.groupBox4);
            this.mealDetailsBox.Controls.Add(this.groupBox3);
            this.mealDetailsBox.Controls.Add(this.groupBox2);
            this.mealDetailsBox.Controls.Add(this.groupBox1);
            this.mealDetailsBox.Location = new System.Drawing.Point(12, 70);
            this.mealDetailsBox.Name = "mealDetailsBox";
            this.mealDetailsBox.Size = new System.Drawing.Size(1120, 492);
            this.mealDetailsBox.TabIndex = 0;
            this.mealDetailsBox.TabStop = false;
            this.mealDetailsBox.Text = "Meal details";
            // 
            // buttonChooseImage
            // 
            this.buttonChooseImage.Location = new System.Drawing.Point(1015, 405);
            this.buttonChooseImage.Name = "buttonChooseImage";
            this.buttonChooseImage.Size = new System.Drawing.Size(99, 23);
            this.buttonChooseImage.TabIndex = 11;
            this.buttonChooseImage.Text = "Choose image";
            this.buttonChooseImage.UseVisualStyleBackColor = true;
            this.buttonChooseImage.Click += new System.EventHandler(this.buttonChooseImage_Click);
            // 
            // pictureBoxMealImage
            // 
            this.pictureBoxMealImage.InitialImage = null;
            this.pictureBoxMealImage.Location = new System.Drawing.Point(783, 38);
            this.pictureBoxMealImage.Name = "pictureBoxMealImage";
            this.pictureBoxMealImage.Size = new System.Drawing.Size(331, 361);
            this.pictureBoxMealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMealImage.TabIndex = 10;
            this.pictureBoxMealImage.TabStop = false;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.panelIngredientList);
            this.groupBox10.Controls.Add(this.buttonRemoveIngredient);
            this.groupBox10.Controls.Add(this.buttonAddIngredient);
            this.groupBox10.Location = new System.Drawing.Point(414, 19);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(363, 415);
            this.groupBox10.TabIndex = 9;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Ingredients";
            // 
            // panelIngredientList
            // 
            this.panelIngredientList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelIngredientList.AutoScroll = true;
            this.panelIngredientList.Location = new System.Drawing.Point(6, 19);
            this.panelIngredientList.Name = "panelIngredientList";
            this.panelIngredientList.Size = new System.Drawing.Size(351, 361);
            this.panelIngredientList.TabIndex = 11;
            // 
            // buttonRemoveIngredient
            // 
            this.buttonRemoveIngredient.Location = new System.Drawing.Point(262, 386);
            this.buttonRemoveIngredient.Name = "buttonRemoveIngredient";
            this.buttonRemoveIngredient.Size = new System.Drawing.Size(32, 23);
            this.buttonRemoveIngredient.TabIndex = 10;
            this.buttonRemoveIngredient.Text = "-";
            this.buttonRemoveIngredient.UseVisualStyleBackColor = true;
            this.buttonRemoveIngredient.Click += new System.EventHandler(this.buttonRemoveIngredient_Click);
            // 
            // buttonAddIngredient
            // 
            this.buttonAddIngredient.Location = new System.Drawing.Point(300, 386);
            this.buttonAddIngredient.Name = "buttonAddIngredient";
            this.buttonAddIngredient.Size = new System.Drawing.Size(32, 23);
            this.buttonAddIngredient.TabIndex = 0;
            this.buttonAddIngredient.Text = "+";
            this.buttonAddIngredient.UseVisualStyleBackColor = true;
            this.buttonAddIngredient.Click += new System.EventHandler(this.buttonAddIngredient_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.trackBarPrice);
            this.groupBox9.Location = new System.Drawing.Point(210, 364);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(198, 70);
            this.groupBox9.TabIndex = 8;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Price";
            // 
            // trackBarPrice
            // 
            this.trackBarPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarPrice.Location = new System.Drawing.Point(6, 19);
            this.trackBarPrice.Minimum = 1;
            this.trackBarPrice.Name = "trackBarPrice";
            this.trackBarPrice.Size = new System.Drawing.Size(186, 45);
            this.trackBarPrice.TabIndex = 0;
            this.trackBarPrice.Value = 6;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.trackBarCalories);
            this.groupBox8.Location = new System.Drawing.Point(6, 364);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(198, 70);
            this.groupBox8.TabIndex = 7;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Calories";
            // 
            // trackBarCalories
            // 
            this.trackBarCalories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarCalories.Location = new System.Drawing.Point(6, 19);
            this.trackBarCalories.Minimum = 1;
            this.trackBarCalories.Name = "trackBarCalories";
            this.trackBarCalories.Size = new System.Drawing.Size(186, 45);
            this.trackBarCalories.TabIndex = 0;
            this.trackBarCalories.Value = 6;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.comboBoxPreparationType);
            this.groupBox7.Location = new System.Drawing.Point(6, 224);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(198, 64);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Preparation type";
            // 
            // comboBoxPreparationType
            // 
            this.comboBoxPreparationType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPreparationType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPreparationType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxPreparationType.FormattingEnabled = true;
            this.comboBoxPreparationType.Location = new System.Drawing.Point(6, 29);
            this.comboBoxPreparationType.Name = "comboBoxPreparationType";
            this.comboBoxPreparationType.Size = new System.Drawing.Size(186, 21);
            this.comboBoxPreparationType.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.comboBoxLocation);
            this.groupBox6.Location = new System.Drawing.Point(210, 224);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(198, 64);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Location";
            // 
            // comboBoxLocation
            // 
            this.comboBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLocation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxLocation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxLocation.FormattingEnabled = true;
            this.comboBoxLocation.Location = new System.Drawing.Point(6, 29);
            this.comboBoxLocation.Name = "comboBoxLocation";
            this.comboBoxLocation.Size = new System.Drawing.Size(186, 21);
            this.comboBoxLocation.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.comboBoxDishType);
            this.groupBox5.Location = new System.Drawing.Point(210, 154);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(198, 64);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dish type";
            // 
            // comboBoxDishType
            // 
            this.comboBoxDishType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxDishType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDishType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxDishType.FormattingEnabled = true;
            this.comboBoxDishType.Location = new System.Drawing.Point(6, 29);
            this.comboBoxDishType.Name = "comboBoxDishType";
            this.comboBoxDishType.Size = new System.Drawing.Size(186, 21);
            this.comboBoxDishType.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBarRating);
            this.groupBox4.Location = new System.Drawing.Point(210, 294);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(198, 64);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rating";
            // 
            // trackBarRating
            // 
            this.trackBarRating.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarRating.Location = new System.Drawing.Point(6, 19);
            this.trackBarRating.Minimum = 1;
            this.trackBarRating.Name = "trackBarRating";
            this.trackBarRating.Size = new System.Drawing.Size(186, 45);
            this.trackBarRating.TabIndex = 0;
            this.trackBarRating.Value = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dateTimePicker);
            this.groupBox3.Location = new System.Drawing.Point(6, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 64);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Date and time";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker.Location = new System.Drawing.Point(6, 29);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(186, 20);
            this.dateTimePicker.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxMealType);
            this.groupBox2.Location = new System.Drawing.Point(6, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(198, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Meal type";
            // 
            // comboBoxMealType
            // 
            this.comboBoxMealType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxMealType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMealType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxMealType.FormattingEnabled = true;
            this.comboBoxMealType.Location = new System.Drawing.Point(6, 29);
            this.comboBoxMealType.Name = "comboBoxMealType";
            this.comboBoxMealType.Size = new System.Drawing.Size(186, 21);
            this.comboBoxMealType.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxDescription);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Description";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(390, 104);
            this.richTextBoxDescription.TabIndex = 0;
            this.richTextBoxDescription.Text = "";
            // 
            // controlButtonsBox
            // 
            this.controlButtonsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlButtonsBox.Controls.Add(this.confirmBtn);
            this.controlButtonsBox.Controls.Add(this.resetBtn);
            this.controlButtonsBox.Controls.Add(this.cancelBtn);
            this.controlButtonsBox.Location = new System.Drawing.Point(12, 554);
            this.controlButtonsBox.Name = "controlButtonsBox";
            this.controlButtonsBox.Size = new System.Drawing.Size(1120, 37);
            this.controlButtonsBox.TabIndex = 2;
            this.controlButtonsBox.TabStop = false;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmBtn.Location = new System.Drawing.Point(883, 8);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(75, 23);
            this.confirmBtn.TabIndex = 2;
            this.confirmBtn.Text = "Save";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.Location = new System.Drawing.Point(964, 8);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 1;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(1045, 8);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // comboBoxName
            // 
            this.comboBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxName.FormattingEnabled = true;
            this.comboBoxName.Location = new System.Drawing.Point(6, 19);
            this.comboBoxName.Name = "comboBoxName";
            this.comboBoxName.Size = new System.Drawing.Size(1108, 21);
            this.comboBoxName.TabIndex = 3;
            // 
            // groupBox11
            // 
            this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox11.Controls.Add(this.comboBoxName);
            this.groupBox11.Location = new System.Drawing.Point(12, 12);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1120, 52);
            this.groupBox11.TabIndex = 10;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Meal name";
            // 
            // MealAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 605);
            this.Controls.Add(this.controlButtonsBox);
            this.Controls.Add(this.groupBox11);
            this.Controls.Add(this.mealDetailsBox);
            this.Name = "MealAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add a meal";
            this.mealDetailsBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMealImage)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarPrice)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalories)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRating)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.controlButtonsBox.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mealDetailsBox;
        private System.Windows.Forms.GroupBox controlButtonsBox;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarRating;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBoxMealType;
        private System.Windows.Forms.ComboBox comboBoxName;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBoxDishType;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox comboBoxLocation;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ComboBox comboBoxPreparationType;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TrackBar trackBarPrice;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TrackBar trackBarCalories;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button buttonRemoveIngredient;
        private System.Windows.Forms.Button buttonAddIngredient;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.PictureBox pictureBoxMealImage;
        private System.Windows.Forms.Button buttonChooseImage;
        private System.Windows.Forms.Panel panelIngredientList;
    }
}