namespace CrossRealmPriceCheck
{
    partial class RealmList
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
            this.Realm_List = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Realm_List
            // 
            this.Realm_List.Location = new System.Drawing.Point(12, 22);
            this.Realm_List.Name = "Realm_List";
            this.Realm_List.Size = new System.Drawing.Size(205, 197);
            this.Realm_List.TabIndex = 0;
            this.Realm_List.Text = "";
            // 
            // RealmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(231, 236);
            this.ControlBox = false;
            this.Controls.Add(this.Realm_List);
            this.Name = "RealmList";
            this.Text = "Realm List";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox Realm_List;
    }
}