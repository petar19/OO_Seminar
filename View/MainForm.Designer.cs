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
            this.SuspendLayout();
            // 
            // mealAddBtn
            // 
            this.mealAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mealAddBtn.Location = new System.Drawing.Point(12, 390);
            this.mealAddBtn.Name = "mealAddBtn";
            this.mealAddBtn.Size = new System.Drawing.Size(75, 23);
            this.mealAddBtn.TabIndex = 0;
            this.mealAddBtn.Text = "Add";
            this.mealAddBtn.UseVisualStyleBackColor = true;
            this.mealAddBtn.Click += new System.EventHandler(this.addMealBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 425);
            this.Controls.Add(this.mealAddBtn);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "What did I eat?";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mealAddBtn;
    }
}

