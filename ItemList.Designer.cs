namespace CrossRealmPriceCheck
{
    partial class ItemList
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
            this.ItemID_RichBox = new System.Windows.Forms.RichTextBox();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ItemID_RichBox
            // 
            this.ItemID_RichBox.Location = new System.Drawing.Point(13, 13);
            this.ItemID_RichBox.Name = "ItemID_RichBox";
            this.ItemID_RichBox.ReadOnly = true;
            this.ItemID_RichBox.Size = new System.Drawing.Size(242, 239);
            this.ItemID_RichBox.TabIndex = 0;
            this.ItemID_RichBox.Text = "";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(95, 258);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 1;
            this.Save_Button.Text = "Save to File";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(277, 302);
            this.ControlBox = false;
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.ItemID_RichBox);
            this.Name = "ItemList";
            this.Text = "Item ID List";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox ItemID_RichBox;
        private System.Windows.Forms.Button Save_Button;
    }
}