namespace CrossRealmPriceCheck
{
    partial class CrossRealmCheck
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
            this.Realm_Name_Textbox = new System.Windows.Forms.TextBox();
            this.Add_Realm_Button = new System.Windows.Forms.Button();
            this.Remove_Realm_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Display_Message_Checkbox = new System.Windows.Forms.CheckBox();
            this.Report_DataGrid = new System.Windows.Forms.DataGridView();
            this.ItemID_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Check_Realms_Button = new System.Windows.Forms.Button();
            this.Item_Report_Label = new System.Windows.Forms.LinkLabel();
            this.EU_Checkbox = new System.Windows.Forms.CheckBox();
            this.US_Checkbox = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showRealmListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Report_DataGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Realm_Name_Textbox
            // 
            this.Realm_Name_Textbox.Location = new System.Drawing.Point(116, 64);
            this.Realm_Name_Textbox.Name = "Realm_Name_Textbox";
            this.Realm_Name_Textbox.Size = new System.Drawing.Size(100, 20);
            this.Realm_Name_Textbox.TabIndex = 0;
            this.Realm_Name_Textbox.TextChanged += new System.EventHandler(this.Realm_Name_Textbox_TextChanged);
            // 
            // Add_Realm_Button
            // 
            this.Add_Realm_Button.Location = new System.Drawing.Point(236, 62);
            this.Add_Realm_Button.Name = "Add_Realm_Button";
            this.Add_Realm_Button.Size = new System.Drawing.Size(75, 23);
            this.Add_Realm_Button.TabIndex = 1;
            this.Add_Realm_Button.Text = "Add";
            this.Add_Realm_Button.UseVisualStyleBackColor = true;
            this.Add_Realm_Button.Click += new System.EventHandler(this.Add_Realm_Button_Click);
            // 
            // Remove_Realm_Button
            // 
            this.Remove_Realm_Button.Location = new System.Drawing.Point(334, 62);
            this.Remove_Realm_Button.Name = "Remove_Realm_Button";
            this.Remove_Realm_Button.Size = new System.Drawing.Size(75, 23);
            this.Remove_Realm_Button.TabIndex = 2;
            this.Remove_Realm_Button.Text = "Remove";
            this.Remove_Realm_Button.UseVisualStyleBackColor = true;
            this.Remove_Realm_Button.Click += new System.EventHandler(this.Remove_Realm_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Realm Name";
            // 
            // Display_Message_Checkbox
            // 
            this.Display_Message_Checkbox.AutoSize = true;
            this.Display_Message_Checkbox.Checked = true;
            this.Display_Message_Checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Display_Message_Checkbox.Location = new System.Drawing.Point(433, 68);
            this.Display_Message_Checkbox.Name = "Display_Message_Checkbox";
            this.Display_Message_Checkbox.Size = new System.Drawing.Size(100, 17);
            this.Display_Message_Checkbox.TabIndex = 4;
            this.Display_Message_Checkbox.Text = "Display Popup?";
            this.Display_Message_Checkbox.UseVisualStyleBackColor = true;
            this.Display_Message_Checkbox.CheckedChanged += new System.EventHandler(this.Display_Message_Checkbox_CheckedChanged);
            // 
            // Report_DataGrid
            // 
            this.Report_DataGrid.AllowUserToAddRows = false;
            this.Report_DataGrid.AllowUserToDeleteRows = false;
            this.Report_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Report_DataGrid.Location = new System.Drawing.Point(21, 158);
            this.Report_DataGrid.Name = "Report_DataGrid";
            this.Report_DataGrid.ReadOnly = true;
            this.Report_DataGrid.Size = new System.Drawing.Size(591, 209);
            this.Report_DataGrid.TabIndex = 5;
            // 
            // ItemID_Textbox
            // 
            this.ItemID_Textbox.Location = new System.Drawing.Point(169, 95);
            this.ItemID_Textbox.Name = "ItemID_Textbox";
            this.ItemID_Textbox.Size = new System.Drawing.Size(89, 20);
            this.ItemID_Textbox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Item ID";
            // 
            // Check_Realms_Button
            // 
            this.Check_Realms_Button.Location = new System.Drawing.Point(243, 383);
            this.Check_Realms_Button.Name = "Check_Realms_Button";
            this.Check_Realms_Button.Size = new System.Drawing.Size(121, 23);
            this.Check_Realms_Button.TabIndex = 8;
            this.Check_Realms_Button.Text = "Check Realms!";
            this.Check_Realms_Button.UseVisualStyleBackColor = true;
            this.Check_Realms_Button.Click += new System.EventHandler(this.Check_Realms_Button_Click);
            // 
            // Item_Report_Label
            // 
            this.Item_Report_Label.AutoSize = true;
            this.Item_Report_Label.Location = new System.Drawing.Point(240, 132);
            this.Item_Report_Label.Name = "Item_Report_Label";
            this.Item_Report_Label.Size = new System.Drawing.Size(55, 13);
            this.Item_Report_Label.TabIndex = 12;
            this.Item_Report_Label.TabStop = true;
            this.Item_Report_Label.Text = "linkLabel1";
            this.Item_Report_Label.Visible = false;
            this.Item_Report_Label.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Item_Report_Label_LinkClicked);
            // 
            // EU_Checkbox
            // 
            this.EU_Checkbox.AutoSize = true;
            this.EU_Checkbox.Location = new System.Drawing.Point(334, 98);
            this.EU_Checkbox.Name = "EU_Checkbox";
            this.EU_Checkbox.Size = new System.Drawing.Size(41, 17);
            this.EU_Checkbox.TabIndex = 13;
            this.EU_Checkbox.Text = "EU";
            this.EU_Checkbox.UseVisualStyleBackColor = true;
            this.EU_Checkbox.CheckedChanged += new System.EventHandler(this.EU_Checkbox_CheckedChanged);
            // 
            // US_Checkbox
            // 
            this.US_Checkbox.AutoSize = true;
            this.US_Checkbox.Location = new System.Drawing.Point(390, 98);
            this.US_Checkbox.Name = "US_Checkbox";
            this.US_Checkbox.Size = new System.Drawing.Size(41, 17);
            this.US_Checkbox.TabIndex = 14;
            this.US_Checkbox.Text = "US";
            this.US_Checkbox.UseVisualStyleBackColor = true;
            this.US_Checkbox.CheckedChanged += new System.EventHandler(this.US_Checkbox_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showRealmListToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // showRealmListToolStripMenuItem
            // 
            this.showRealmListToolStripMenuItem.Name = "showRealmListToolStripMenuItem";
            this.showRealmListToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.showRealmListToolStripMenuItem.Text = "Show Realm List";
            this.showRealmListToolStripMenuItem.Click += new System.EventHandler(this.showRealmListToolStripMenuItem_Click);
            // 
            // CrossRealmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 434);
            this.Controls.Add(this.US_Checkbox);
            this.Controls.Add(this.EU_Checkbox);
            this.Controls.Add(this.Item_Report_Label);
            this.Controls.Add(this.Check_Realms_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ItemID_Textbox);
            this.Controls.Add(this.Report_DataGrid);
            this.Controls.Add(this.Display_Message_Checkbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Remove_Realm_Button);
            this.Controls.Add(this.Add_Realm_Button);
            this.Controls.Add(this.Realm_Name_Textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CrossRealmCheck";
            this.Text = "Cross Realm Check";
            ((System.ComponentModel.ISupportInitialize)(this.Report_DataGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Realm_Name_Textbox;
        private System.Windows.Forms.Button Add_Realm_Button;
        private System.Windows.Forms.Button Remove_Realm_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Display_Message_Checkbox;
        private System.Windows.Forms.DataGridView Report_DataGrid;
        private System.Windows.Forms.TextBox ItemID_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Check_Realms_Button;
        private System.Windows.Forms.LinkLabel Item_Report_Label;
        private System.Windows.Forms.CheckBox EU_Checkbox;
        private System.Windows.Forms.CheckBox US_Checkbox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showRealmListToolStripMenuItem;
    }
}