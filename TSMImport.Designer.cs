namespace CrossRealmPriceCheck
{
    partial class TSMImport
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
            this.TSM_Import_Textbox = new System.Windows.Forms.RichTextBox();
            this.Import_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TSM_Import_Textbox
            // 
            this.TSM_Import_Textbox.Location = new System.Drawing.Point(12, 12);
            this.TSM_Import_Textbox.Name = "TSM_Import_Textbox";
            this.TSM_Import_Textbox.Size = new System.Drawing.Size(472, 139);
            this.TSM_Import_Textbox.TabIndex = 0;
            this.TSM_Import_Textbox.Text = "";
            // 
            // Import_Button
            // 
            this.Import_Button.Location = new System.Drawing.Point(206, 163);
            this.Import_Button.Name = "Import_Button";
            this.Import_Button.Size = new System.Drawing.Size(75, 23);
            this.Import_Button.TabIndex = 1;
            this.Import_Button.Text = "Import";
            this.Import_Button.UseVisualStyleBackColor = true;
            this.Import_Button.Click += new System.EventHandler(this.Import_Button_Click);
            // 
            // TSMImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 198);
            this.Controls.Add(this.Import_Button);
            this.Controls.Add(this.TSM_Import_Textbox);
            this.Name = "TSMImport";
            this.Text = "TSM Group Import";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TSM_Import_Textbox;
        private System.Windows.Forms.Button Import_Button;
    }
}