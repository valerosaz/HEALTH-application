namespace Health_app
{
    partial class Register
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxUserAddress = new System.Windows.Forms.TextBox();
            this.textBoxUserBirthday = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.textBoxPasswordconfirm = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(19)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 70);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER REGISTER";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.textBoxUserPhoneNumber);
            this.panel1.Controls.Add(this.textBoxUserAddress);
            this.panel1.Controls.Add(this.textBoxUserBirthday);
            this.panel1.Controls.Add(this.textBoxUserId);
            this.panel1.Controls.Add(this.textBoxPasswordconfirm);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.textBoxUsername);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.textBoxLastname);
            this.panel1.Controls.Add(this.textBoxFirstname);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 360);
            this.panel1.TabIndex = 1;
            // 
            // textBoxUserPhoneNumber
            // 
            this.textBoxUserPhoneNumber.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUserPhoneNumber.Location = new System.Drawing.Point(12, 209);
            this.textBoxUserPhoneNumber.Multiline = true;
            this.textBoxUserPhoneNumber.Name = "textBoxUserPhoneNumber";
            this.textBoxUserPhoneNumber.Size = new System.Drawing.Size(425, 20);
            this.textBoxUserPhoneNumber.TabIndex = 15;
            this.textBoxUserPhoneNumber.Text = "user phone number";
            this.textBoxUserPhoneNumber.Enter += new System.EventHandler(this.TextBoxUserPhoneNumber_Enter);
            this.textBoxUserPhoneNumber.Leave += new System.EventHandler(this.TextBoxUserPhoneNumber_Leave);
            // 
            // textBoxUserAddress
            // 
            this.textBoxUserAddress.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUserAddress.Location = new System.Drawing.Point(12, 183);
            this.textBoxUserAddress.Multiline = true;
            this.textBoxUserAddress.Name = "textBoxUserAddress";
            this.textBoxUserAddress.Size = new System.Drawing.Size(425, 20);
            this.textBoxUserAddress.TabIndex = 14;
            this.textBoxUserAddress.Text = "user address";
            this.textBoxUserAddress.Enter += new System.EventHandler(this.TextBoxUserAddress_Enter);
            this.textBoxUserAddress.Leave += new System.EventHandler(this.TextBoxUserAddress_Leave);
            // 
            // textBoxUserBirthday
            // 
            this.textBoxUserBirthday.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUserBirthday.Location = new System.Drawing.Point(12, 157);
            this.textBoxUserBirthday.Multiline = true;
            this.textBoxUserBirthday.Name = "textBoxUserBirthday";
            this.textBoxUserBirthday.Size = new System.Drawing.Size(425, 20);
            this.textBoxUserBirthday.TabIndex = 13;
            this.textBoxUserBirthday.Text = "user birthday";
            this.textBoxUserBirthday.Enter += new System.EventHandler(this.TextBoxUserBirthday_Enter);
            this.textBoxUserBirthday.Leave += new System.EventHandler(this.TextBoxUserBirthday_Leave);
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUserId.Location = new System.Drawing.Point(12, 131);
            this.textBoxUserId.Multiline = true;
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(425, 20);
            this.textBoxUserId.TabIndex = 12;
            this.textBoxUserId.Text = "user id";
            this.textBoxUserId.Enter += new System.EventHandler(this.TextBoxUserId_Enter);
            this.textBoxUserId.Leave += new System.EventHandler(this.TextBoxUserId_Leave);
            // 
            // textBoxPasswordconfirm
            // 
            this.textBoxPasswordconfirm.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPasswordconfirm.Location = new System.Drawing.Point(12, 287);
            this.textBoxPasswordconfirm.Name = "textBoxPasswordconfirm";
            this.textBoxPasswordconfirm.Size = new System.Drawing.Size(425, 20);
            this.textBoxPasswordconfirm.TabIndex = 11;
            this.textBoxPasswordconfirm.Text = "confirm password";
            this.textBoxPasswordconfirm.Enter += new System.EventHandler(this.TextBoxPasswordconfirm_Enter);
            this.textBoxPasswordconfirm.Leave += new System.EventHandler(this.TextBoxPasswordconfirm_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPassword.Location = new System.Drawing.Point(12, 261);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(425, 20);
            this.textBoxPassword.TabIndex = 10;
            this.textBoxPassword.Text = "password";
            this.textBoxPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.ForeColor = System.Drawing.Color.Gray;
            this.textBoxUsername.Location = new System.Drawing.Point(12, 235);
            this.textBoxUsername.Multiline = true;
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(425, 20);
            this.textBoxUsername.TabIndex = 9;
            this.textBoxUsername.Text = "user name";
            this.textBoxUsername.Enter += new System.EventHandler(this.TextBoxUsername_Enter);
            this.textBoxUsername.Leave += new System.EventHandler(this.TextBoxUsername_Leave);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEmail.Location = new System.Drawing.Point(12, 105);
            this.textBoxEmail.Multiline = true;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(425, 20);
            this.textBoxEmail.TabIndex = 8;
            this.textBoxEmail.Text = "email";
            this.textBoxEmail.Enter += new System.EventHandler(this.TextBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.TextBoxEmail_Leave);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(362, 324);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            this.buttonCancel.Leave += new System.EventHandler(this.ButtonCancel_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(245, 324);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "REGISTER";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxLastname.Location = new System.Drawing.Point(221, 79);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(216, 20);
            this.textBoxLastname.TabIndex = 4;
            this.textBoxLastname.Text = "last name";
            this.textBoxLastname.Enter += new System.EventHandler(this.TextBoxLastname_Enter);
            this.textBoxLastname.Leave += new System.EventHandler(this.TextBoxLastname_Leave);
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.ForeColor = System.Drawing.Color.Gray;
            this.textBoxFirstname.Location = new System.Drawing.Point(12, 79);
            this.textBoxFirstname.Multiline = true;
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(203, 20);
            this.textBoxFirstname.TabIndex = 3;
            this.textBoxFirstname.Text = "first name";
            this.textBoxFirstname.Enter += new System.EventHandler(this.TextBoxFirstname_Enter);
            this.textBoxFirstname.Leave += new System.EventHandler(this.TextBoxFirstname_Leave);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 360);
            this.Controls.Add(this.panel1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.TextBox textBoxPasswordconfirm;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUserPhoneNumber;
        private System.Windows.Forms.TextBox textBoxUserAddress;
        private System.Windows.Forms.TextBox textBoxUserBirthday;
        private System.Windows.Forms.TextBox textBoxUserId;
    }
}