namespace SmsManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OverviewFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LogsFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SettingsFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.newNotifFlatButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 13F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(59, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGER";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.UpdateButton.FlatAppearance.BorderSize = 0;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Corbel", 8F);
            this.UpdateButton.ForeColor = System.Drawing.Color.White;
            this.UpdateButton.Location = new System.Drawing.Point(888, 0);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(102, 54);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Minimize";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(135, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 594);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.UpdateButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(999, 54);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 8F);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(844, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Admin";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel2;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SmsManager.Properties.Resources.SMS_52px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OverviewFlatButton
            // 
            this.OverviewFlatButton.Activecolor = System.Drawing.Color.Teal;
            this.OverviewFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.OverviewFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OverviewFlatButton.BorderRadius = 0;
            this.OverviewFlatButton.ButtonText = "Overview";
            this.OverviewFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OverviewFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.OverviewFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.OverviewFlatButton.Iconimage = global::SmsManager.Properties.Resources.SMS_64px;
            this.OverviewFlatButton.Iconimage_right = null;
            this.OverviewFlatButton.Iconimage_right_Selected = null;
            this.OverviewFlatButton.Iconimage_Selected = null;
            this.OverviewFlatButton.IconMarginLeft = 0;
            this.OverviewFlatButton.IconMarginRight = 0;
            this.OverviewFlatButton.IconRightVisible = true;
            this.OverviewFlatButton.IconRightZoom = 0D;
            this.OverviewFlatButton.IconVisible = true;
            this.OverviewFlatButton.IconZoom = 90D;
            this.OverviewFlatButton.IsTab = false;
            this.OverviewFlatButton.Location = new System.Drawing.Point(-1, 79);
            this.OverviewFlatButton.Name = "OverviewFlatButton";
            this.OverviewFlatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.OverviewFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.OverviewFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.OverviewFlatButton.selected = false;
            this.OverviewFlatButton.Size = new System.Drawing.Size(241, 51);
            this.OverviewFlatButton.TabIndex = 21;
            this.OverviewFlatButton.Text = "Overview";
            this.OverviewFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OverviewFlatButton.Textcolor = System.Drawing.Color.White;
            this.OverviewFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverviewFlatButton.Click += new System.EventHandler(this.OverviewFlatButton_Click);
            // 
            // LogsFlatButton
            // 
            this.LogsFlatButton.Activecolor = System.Drawing.Color.Teal;
            this.LogsFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.LogsFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LogsFlatButton.BorderRadius = 0;
            this.LogsFlatButton.ButtonText = "Logs";
            this.LogsFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogsFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.LogsFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.LogsFlatButton.Iconimage = global::SmsManager.Properties.Resources.Combo_Chart_48px;
            this.LogsFlatButton.Iconimage_right = null;
            this.LogsFlatButton.Iconimage_right_Selected = null;
            this.LogsFlatButton.Iconimage_Selected = null;
            this.LogsFlatButton.IconMarginLeft = 0;
            this.LogsFlatButton.IconMarginRight = 0;
            this.LogsFlatButton.IconRightVisible = true;
            this.LogsFlatButton.IconRightZoom = 0D;
            this.LogsFlatButton.IconVisible = true;
            this.LogsFlatButton.IconZoom = 90D;
            this.LogsFlatButton.IsTab = false;
            this.LogsFlatButton.Location = new System.Drawing.Point(-1, 138);
            this.LogsFlatButton.Name = "LogsFlatButton";
            this.LogsFlatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.LogsFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.LogsFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.LogsFlatButton.selected = false;
            this.LogsFlatButton.Size = new System.Drawing.Size(241, 51);
            this.LogsFlatButton.TabIndex = 22;
            this.LogsFlatButton.Text = "Logs";
            this.LogsFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogsFlatButton.Textcolor = System.Drawing.Color.White;
            this.LogsFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsFlatButton.Click += new System.EventHandler(this.LogsFlatButton_Click);
            // 
            // SettingsFlatButton2
            // 
            this.SettingsFlatButton2.Activecolor = System.Drawing.Color.Teal;
            this.SettingsFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.SettingsFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingsFlatButton2.BorderRadius = 0;
            this.SettingsFlatButton2.ButtonText = "Settings";
            this.SettingsFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingsFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.SettingsFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.SettingsFlatButton2.Iconimage = global::SmsManager.Properties.Resources.Settings_48px;
            this.SettingsFlatButton2.Iconimage_right = null;
            this.SettingsFlatButton2.Iconimage_right_Selected = null;
            this.SettingsFlatButton2.Iconimage_Selected = null;
            this.SettingsFlatButton2.IconMarginLeft = 0;
            this.SettingsFlatButton2.IconMarginRight = 0;
            this.SettingsFlatButton2.IconRightVisible = true;
            this.SettingsFlatButton2.IconRightZoom = 0D;
            this.SettingsFlatButton2.IconVisible = true;
            this.SettingsFlatButton2.IconZoom = 90D;
            this.SettingsFlatButton2.IsTab = false;
            this.SettingsFlatButton2.Location = new System.Drawing.Point(-1, 252);
            this.SettingsFlatButton2.Name = "SettingsFlatButton2";
            this.SettingsFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.SettingsFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SettingsFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.SettingsFlatButton2.selected = false;
            this.SettingsFlatButton2.Size = new System.Drawing.Size(241, 51);
            this.SettingsFlatButton2.TabIndex = 23;
            this.SettingsFlatButton2.Text = "Settings";
            this.SettingsFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsFlatButton2.Textcolor = System.Drawing.Color.White;
            this.SettingsFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFlatButton2.Click += new System.EventHandler(this.SettingsFlatButton2_Click);
            // 
            // newNotifFlatButton
            // 
            this.newNotifFlatButton.Activecolor = System.Drawing.Color.Teal;
            this.newNotifFlatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.newNotifFlatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newNotifFlatButton.BorderRadius = 0;
            this.newNotifFlatButton.ButtonText = "New Message";
            this.newNotifFlatButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newNotifFlatButton.DisabledColor = System.Drawing.Color.Gray;
            this.newNotifFlatButton.Iconcolor = System.Drawing.Color.Transparent;
            this.newNotifFlatButton.Iconimage = global::SmsManager.Properties.Resources.SMS_64px;
            this.newNotifFlatButton.Iconimage_right = null;
            this.newNotifFlatButton.Iconimage_right_Selected = null;
            this.newNotifFlatButton.Iconimage_Selected = null;
            this.newNotifFlatButton.IconMarginLeft = 0;
            this.newNotifFlatButton.IconMarginRight = 0;
            this.newNotifFlatButton.IconRightVisible = true;
            this.newNotifFlatButton.IconRightZoom = 0D;
            this.newNotifFlatButton.IconVisible = true;
            this.newNotifFlatButton.IconZoom = 90D;
            this.newNotifFlatButton.IsTab = false;
            this.newNotifFlatButton.Location = new System.Drawing.Point(-1, 195);
            this.newNotifFlatButton.Name = "newNotifFlatButton";
            this.newNotifFlatButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.newNotifFlatButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.newNotifFlatButton.OnHoverTextColor = System.Drawing.Color.White;
            this.newNotifFlatButton.selected = false;
            this.newNotifFlatButton.Size = new System.Drawing.Size(144, 51);
            this.newNotifFlatButton.TabIndex = 24;
            this.newNotifFlatButton.Text = "New Message";
            this.newNotifFlatButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.newNotifFlatButton.Textcolor = System.Drawing.Color.White;
            this.newNotifFlatButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newNotifFlatButton.Click += new System.EventHandler(this.newNotifFlatButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.ClientSize = new System.Drawing.Size(990, 638);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.OverviewFlatButton);
            this.Controls.Add(this.LogsFlatButton);
            this.Controls.Add(this.SettingsFlatButton2);
            this.Controls.Add(this.newNotifFlatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton OverviewFlatButton;
        private Bunifu.Framework.UI.BunifuFlatButton SettingsFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton LogsFlatButton;
        private Bunifu.Framework.UI.BunifuFlatButton newNotifFlatButton;
    }
}

