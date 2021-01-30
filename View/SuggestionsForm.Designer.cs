namespace OO_Seminar.View
{
    partial class SuggestionsForm
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
            this.panelSuggestedMeals = new System.Windows.Forms.Panel();
            this.comboBoxBasedOn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxNumberOfMeals = new System.Windows.Forms.ComboBox();
            this.suggestBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelSuggestedMeals
            // 
            this.panelSuggestedMeals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuggestedMeals.AutoScroll = true;
            this.panelSuggestedMeals.Location = new System.Drawing.Point(12, 62);
            this.panelSuggestedMeals.Name = "panelSuggestedMeals";
            this.panelSuggestedMeals.Size = new System.Drawing.Size(1066, 486);
            this.panelSuggestedMeals.TabIndex = 2;
            // 
            // comboBoxBasedOn
            // 
            this.comboBoxBasedOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBasedOn.FormattingEnabled = true;
            this.comboBoxBasedOn.Location = new System.Drawing.Point(268, 6);
            this.comboBoxBasedOn.Name = "comboBoxBasedOn";
            this.comboBoxBasedOn.Size = new System.Drawing.Size(121, 21);
            this.comboBoxBasedOn.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Suggest meals based on how many previous meals?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of meals to suggest?";
            // 
            // comboBoxNumberOfMeals
            // 
            this.comboBoxNumberOfMeals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberOfMeals.FormattingEnabled = true;
            this.comboBoxNumberOfMeals.Location = new System.Drawing.Point(268, 35);
            this.comboBoxNumberOfMeals.Name = "comboBoxNumberOfMeals";
            this.comboBoxNumberOfMeals.Size = new System.Drawing.Size(121, 21);
            this.comboBoxNumberOfMeals.TabIndex = 5;
            // 
            // suggestBtn
            // 
            this.suggestBtn.Location = new System.Drawing.Point(395, 33);
            this.suggestBtn.Name = "suggestBtn";
            this.suggestBtn.Size = new System.Drawing.Size(75, 23);
            this.suggestBtn.TabIndex = 7;
            this.suggestBtn.Text = "Suggest";
            this.suggestBtn.UseVisualStyleBackColor = true;
            this.suggestBtn.Click += new System.EventHandler(this.suggestBtn_Click);
            // 
            // SuggestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 560);
            this.Controls.Add(this.suggestBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxNumberOfMeals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxBasedOn);
            this.Controls.Add(this.panelSuggestedMeals);
            this.Name = "SuggestionsForm";
            this.Text = "SuggestionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSuggestedMeals;
        private System.Windows.Forms.ComboBox comboBoxBasedOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxNumberOfMeals;
        private System.Windows.Forms.Button suggestBtn;
    }
}