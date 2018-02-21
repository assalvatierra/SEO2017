namespace SmsManager.Controls
{
    partial class UnsentMessageControl
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
            this.recipientlabel = new System.Windows.Forms.Label();
            this.Messagelabel = new System.Windows.Forms.Label();
            this.DateTimelabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // recipientlabel
            // 
            this.recipientlabel.AutoSize = true;
            this.recipientlabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientlabel.Location = new System.Drawing.Point(64, 1);
            this.recipientlabel.Name = "recipientlabel";
            this.recipientlabel.Size = new System.Drawing.Size(88, 20);
            this.recipientlabel.TabIndex = 0;
            this.recipientlabel.Text = "[Recipient]";
            // 
            // Messagelabel
            // 
            this.Messagelabel.AutoSize = true;
            this.Messagelabel.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Messagelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Messagelabel.Location = new System.Drawing.Point(65, 19);
            this.Messagelabel.Name = "Messagelabel";
            this.Messagelabel.Size = new System.Drawing.Size(115, 17);
            this.Messagelabel.TabIndex = 1;
            this.Messagelabel.Text = "[Message Details]";
            // 
            // DateTimelabel
            // 
            this.DateTimelabel.AutoSize = true;
            this.DateTimelabel.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.DateTimelabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.DateTimelabel.Location = new System.Drawing.Point(65, 34);
            this.DateTimelabel.Name = "DateTimelabel";
            this.DateTimelabel.Size = new System.Drawing.Size(71, 16);
            this.DateTimelabel.TabIndex = 2;
            this.DateTimelabel.Text = "[Date Time]";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(255, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SmsManager.Properties.Resources.New_Message_64px;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 41);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // UnsentMessageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTimelabel);
            this.Controls.Add(this.Messagelabel);
            this.Controls.Add(this.recipientlabel);
            this.Name = "UnsentMessageControl";
            this.Size = new System.Drawing.Size(333, 53);
            this.Enter += new System.EventHandler(this.UnsentMessageControl_Enter);
            this.MouseEnter += new System.EventHandler(this.UnsentMessageControl_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UnsentMessageControl_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UnsentMessageControl_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label recipientlabel;
        private System.Windows.Forms.Label Messagelabel;
        private System.Windows.Forms.Label DateTimelabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
