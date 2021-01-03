namespace OO_Seminar.View
{
    partial class IngredientListItem
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
            this.comboBoxIngredientName = new System.Windows.Forms.ComboBox();
            this.trackBarIngredientImportance = new System.Windows.Forms.TrackBar();
            this.checkBoxIngredientListItem = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIngredientImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxIngredientName
            // 
            this.comboBoxIngredientName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxIngredientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxIngredientName.FormattingEnabled = true;
            this.comboBoxIngredientName.Location = new System.Drawing.Point(36, 3);
            this.comboBoxIngredientName.Name = "comboBoxIngredientName";
            this.comboBoxIngredientName.Size = new System.Drawing.Size(390, 21);
            this.comboBoxIngredientName.TabIndex = 0;
            // 
            // trackBarIngredientImportance
            // 
            this.trackBarIngredientImportance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarIngredientImportance.Location = new System.Drawing.Point(36, 30);
            this.trackBarIngredientImportance.Maximum = 100;
            this.trackBarIngredientImportance.Minimum = 1;
            this.trackBarIngredientImportance.Name = "trackBarIngredientImportance";
            this.trackBarIngredientImportance.Size = new System.Drawing.Size(389, 45);
            this.trackBarIngredientImportance.TabIndex = 1;
            this.trackBarIngredientImportance.TickFrequency = 5;
            this.trackBarIngredientImportance.Value = 50;
            // 
            // checkBoxIngredientListItem
            // 
            this.checkBoxIngredientListItem.AutoSize = true;
            this.checkBoxIngredientListItem.Location = new System.Drawing.Point(4, 30);
            this.checkBoxIngredientListItem.Name = "checkBoxIngredientListItem";
            this.checkBoxIngredientListItem.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIngredientListItem.TabIndex = 2;
            this.checkBoxIngredientListItem.UseVisualStyleBackColor = true;
            this.checkBoxIngredientListItem.CheckedChanged += new System.EventHandler(this.checkBoxIngredientListItem_CheckedChanged);
            // 
            // IngredientListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxIngredientListItem);
            this.Controls.Add(this.trackBarIngredientImportance);
            this.Controls.Add(this.comboBoxIngredientName);
            this.Name = "IngredientListItem";
            this.Size = new System.Drawing.Size(436, 83);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIngredientImportance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIngredientName;
        private System.Windows.Forms.TrackBar trackBarIngredientImportance;
        private System.Windows.Forms.CheckBox checkBoxIngredientListItem;
    }
}
