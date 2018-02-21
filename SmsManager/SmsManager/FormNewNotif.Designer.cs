namespace SmsManager
{
    partial class FormNewNotif
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MessagetextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Datepicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.timeTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.RecipientTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.typeDropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "New Notification Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(51, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Recipient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label4.Location = new System.Drawing.Point(54, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label5.Location = new System.Drawing.Point(79, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Date";
            // 
            // MessagetextBox
            // 
            this.MessagetextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MessagetextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessagetextBox.Location = new System.Drawing.Point(140, 124);
            this.MessagetextBox.Multiline = true;
            this.MessagetextBox.Name = "MessagetextBox";
            this.MessagetextBox.Size = new System.Drawing.Size(313, 58);
            this.MessagetextBox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label2.Location = new System.Drawing.Point(83, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Time";
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.SubmitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.SubmitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(140, 272);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(101, 39);
            this.SubmitBtn.TabIndex = 23;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = false;
            this.SubmitBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.Clearbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Clearbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clearbutton.Font = new System.Drawing.Font("Corbel", 10F);
            this.Clearbutton.ForeColor = System.Drawing.Color.White;
            this.Clearbutton.Location = new System.Drawing.Point(247, 272);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(101, 39);
            this.Clearbutton.TabIndex = 24;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = false;
            // 
            // Datepicker
            // 
            this.Datepicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Datepicker.BorderRadius = 0;
            this.Datepicker.ForeColor = System.Drawing.Color.White;
            this.Datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.Datepicker.FormatCustom = "MM/dd/yyyy HH:mm:ss";
            this.Datepicker.Location = new System.Drawing.Point(140, 188);
            this.Datepicker.Name = "Datepicker";
            this.Datepicker.Size = new System.Drawing.Size(303, 36);
            this.Datepicker.TabIndex = 25;
            this.Datepicker.Value = new System.DateTime(2018, 2, 21, 17, 13, 55, 284);
            // 
            // timeTextBox1
            // 
            this.timeTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeTextBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.timeTextBox1.Location = new System.Drawing.Point(140, 232);
            this.timeTextBox1.Mask = "00:00";
            this.timeTextBox1.Name = "timeTextBox1";
            this.timeTextBox1.Size = new System.Drawing.Size(43, 27);
            this.timeTextBox1.TabIndex = 26;
            this.timeTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // RecipientTextBox
            // 
            this.RecipientTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RecipientTextBox.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.RecipientTextBox.Location = new System.Drawing.Point(140, 91);
            this.RecipientTextBox.Mask = "00000000000";
            this.RecipientTextBox.Name = "RecipientTextBox";
            this.RecipientTextBox.Size = new System.Drawing.Size(110, 27);
            this.RecipientTextBox.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.label6.Location = new System.Drawing.Point(85, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Type";
            // 
            // typeDropdown
            // 
            this.typeDropdown.BackColor = System.Drawing.Color.Transparent;
            this.typeDropdown.BorderRadius = 1;
            this.typeDropdown.ForeColor = System.Drawing.Color.White;
            this.typeDropdown.Items = new string[] {
        "client",
        "admin"};
            this.typeDropdown.Location = new System.Drawing.Point(140, 50);
            this.typeDropdown.Name = "typeDropdown";
            this.typeDropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.typeDropdown.onHoverColor = System.Drawing.Color.Teal;
            this.typeDropdown.selectedIndex = 0;
            this.typeDropdown.Size = new System.Drawing.Size(217, 35);
            this.typeDropdown.TabIndex = 29;
            // 
            // FormNewNotif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 425);
            this.Controls.Add(this.typeDropdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RecipientTextBox);
            this.Controls.Add(this.timeTextBox1);
            this.Controls.Add(this.Datepicker);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MessagetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "FormNewNotif";
            this.Text = "FormNewNotif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MessagetextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Button Clearbutton;
        private Bunifu.Framework.UI.BunifuDatepicker Datepicker;
        private System.Windows.Forms.MaskedTextBox timeTextBox1;
        private System.Windows.Forms.MaskedTextBox RecipientTextBox;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuDropdown typeDropdown;
    }
}