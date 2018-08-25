namespace CrossRealmPriceCheck
{
    partial class Connect
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
            this.API_KEY_Textbox = new System.Windows.Forms.TextBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TSM_Account_Page_Link = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // API_KEY_Textbox
            // 
            this.API_KEY_Textbox.Location = new System.Drawing.Point(54, 52);
            this.API_KEY_Textbox.Name = "API_KEY_Textbox";
            this.API_KEY_Textbox.Size = new System.Drawing.Size(260, 20);
            this.API_KEY_Textbox.TabIndex = 0;
            this.API_KEY_Textbox.TextChanged += new System.EventHandler(this.API_KEY_Textbox_TextChanged);
            
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(136, 105);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(75, 23);
            this.Connect_Button.TabIndex = 1;
            this.Connect_Button.Text = "Connect";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please enter your TSM API Key.";
            // 
            // TSM_Account_Page_Link
            // 
            this.TSM_Account_Page_Link.AutoSize = true;
            this.TSM_Account_Page_Link.Location = new System.Drawing.Point(130, 78);
            this.TSM_Account_Page_Link.Name = "TSM_Account_Page_Link";
            this.TSM_Account_Page_Link.Size = new System.Drawing.Size(101, 13);
            this.TSM_Account_Page_Link.TabIndex = 3;
            this.TSM_Account_Page_Link.TabStop = true;
            this.TSM_Account_Page_Link.Text = "TSM Account Page";
            this.TSM_Account_Page_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TSM_Account_Page_Link_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 152);
            this.Controls.Add(this.TSM_Account_Page_Link);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.API_KEY_Textbox);
            this.Name = "Form1";
            this.Text = "Connect to TSM API";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox API_KEY_Textbox;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel TSM_Account_Page_Link;
    }
}

