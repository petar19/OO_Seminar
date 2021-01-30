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
            this.buttonAddMeal = new System.Windows.Forms.Button();
            this.panelMeals = new System.Windows.Forms.Panel();
            this.buttonStats = new System.Windows.Forms.Button();
            this.buttonSuggestions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddMeal
            // 
            this.buttonAddMeal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddMeal.Location = new System.Drawing.Point(12, 548);
            this.buttonAddMeal.Name = "buttonAddMeal";
            this.buttonAddMeal.Size = new System.Drawing.Size(75, 23);
            this.buttonAddMeal.TabIndex = 0;
            this.buttonAddMeal.Text = "Add";
            this.buttonAddMeal.UseVisualStyleBackColor = true;
            this.buttonAddMeal.Click += new System.EventHandler(this.addMealBtn_Click);
            // 
            // panelMeals
            // 
            this.panelMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMeals.AutoScroll = true;
            this.panelMeals.Location = new System.Drawing.Point(97, 12);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(958, 559);
            this.panelMeals.TabIndex = 1;
            // 
            // buttonStats
            // 
            this.buttonStats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStats.Location = new System.Drawing.Point(12, 519);
            this.buttonStats.Name = "buttonStats";
            this.buttonStats.Size = new System.Drawing.Size(75, 23);
            this.buttonStats.TabIndex = 2;
            this.buttonStats.Text = "Statistics";
            this.buttonStats.UseVisualStyleBackColor = true;
            this.buttonStats.Click += new System.EventHandler(this.buttonStats_Click);
            // 
            // buttonSuggestions
            // 
            this.buttonSuggestions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSuggestions.Location = new System.Drawing.Point(12, 490);
            this.buttonSuggestions.Name = "buttonSuggestions";
            this.buttonSuggestions.Size = new System.Drawing.Size(75, 23);
            this.buttonSuggestions.TabIndex = 3;
            this.buttonSuggestions.Text = "Suggestions";
            this.buttonSuggestions.UseVisualStyleBackColor = true;
            this.buttonSuggestions.Click += new System.EventHandler(this.buttonSuggestions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 583);
            this.Controls.Add(this.buttonSuggestions);
            this.Controls.Add(this.buttonStats);
            this.Controls.Add(this.panelMeals);
            this.Controls.Add(this.buttonAddMeal);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "What did I eat?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddMeal;
        private System.Windows.Forms.Panel panelMeals;
        private System.Windows.Forms.Button buttonStats;
        private System.Windows.Forms.Button buttonSuggestions;
    }
}

