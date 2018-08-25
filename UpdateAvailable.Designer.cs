namespace CrossRealmPriceCheck
{
    partial class UpdateAvailable
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
            this.label1 = new System.Windows.Forms.Label();
            this.Yes_Button = new System.Windows.Forms.Button();
            this.No_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "A New Update is Available. Would you like to download it?";
            // 
            // Yes_Button
            // 
            this.Yes_Button.Location = new System.Drawing.Point(13, 121);
            this.Yes_Button.Name = "Yes_Button";
            this.Yes_Button.Size = new System.Drawing.Size(75, 23);
            this.Yes_Button.TabIndex = 1;
            this.Yes_Button.Text = "Yes";
            this.Yes_Button.UseVisualStyleBackColor = true;
            this.Yes_Button.Click += new System.EventHandler(this.Yes_Button_Click);
            // 
            // No_Button
            // 
            this.No_Button.Location = new System.Drawing.Point(264, 120);
            this.No_Button.Name = "No_Button";
            this.No_Button.Size = new System.Drawing.Size(75, 23);
            this.No_Button.TabIndex = 2;
            this.No_Button.Text = "No";
            this.No_Button.UseVisualStyleBackColor = true;
            this.No_Button.Click += new System.EventHandler(this.No_Button_Click);
            // 
            // UpdateAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.Controls.Add(this.No_Button);
            this.Controls.Add(this.Yes_Button);
            this.Controls.Add(this.label1);
            this.Name = "UpdateAvailable";
            this.Text = "A New Update is Available";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Yes_Button;
        private System.Windows.Forms.Button No_Button;
    }
}