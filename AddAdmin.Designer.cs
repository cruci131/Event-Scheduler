namespace WindowsFormsApp2
{
    partial class AddAdmin
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
            this.AdminSignUpTextAge = new System.Windows.Forms.TextBox();
            this.SignUpAge = new System.Windows.Forms.Label();
            this.AdminAdd = new System.Windows.Forms.Button();
            this.AdminSignUpTextAddress = new System.Windows.Forms.TextBox();
            this.AdminSignUpTextPass = new System.Windows.Forms.TextBox();
            this.AdminSignUpTextEmail = new System.Windows.Forms.TextBox();
            this.AdminSignUpTextLname = new System.Windows.Forms.TextBox();
            this.AdminSignUpTextFname = new System.Windows.Forms.TextBox();
            this.AdminGenderFemale = new System.Windows.Forms.RadioButton();
            this.AdminGenderMale = new System.Windows.Forms.RadioButton();
            this.SignUpAddress = new System.Windows.Forms.Label();
            this.SignUpPass = new System.Windows.Forms.Label();
            this.SignUpEmail = new System.Windows.Forms.Label();
            this.SignUpLname = new System.Windows.Forms.Label();
            this.SignUpFname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AdminSignUpTextAge
            // 
            this.AdminSignUpTextAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUpTextAge.Location = new System.Drawing.Point(725, 299);
            this.AdminSignUpTextAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSignUpTextAge.Name = "AdminSignUpTextAge";
            this.AdminSignUpTextAge.Size = new System.Drawing.Size(60, 38);
            this.AdminSignUpTextAge.TabIndex = 30;
            // 
            // SignUpAge
            // 
            this.SignUpAge.AutoSize = true;
            this.SignUpAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpAge.Location = new System.Drawing.Point(591, 305);
            this.SignUpAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpAge.Name = "SignUpAge";
            this.SignUpAge.Size = new System.Drawing.Size(65, 32);
            this.SignUpAge.TabIndex = 29;
            this.SignUpAge.Text = "Age";
            // 
            // AdminAdd
            // 
            this.AdminAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminAdd.Location = new System.Drawing.Point(419, 514);
            this.AdminAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminAdd.Name = "AdminAdd";
            this.AdminAdd.Size = new System.Drawing.Size(180, 50);
            this.AdminAdd.TabIndex = 28;
            this.AdminAdd.Text = "Add Admin";
            this.AdminAdd.UseVisualStyleBackColor = true;
            this.AdminAdd.Click += new System.EventHandler(this.AdminAdd_Click);
            // 
            // AdminSignUpTextAddress
            // 
            this.AdminSignUpTextAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUpTextAddress.Location = new System.Drawing.Point(326, 299);
            this.AdminSignUpTextAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSignUpTextAddress.Name = "AdminSignUpTextAddress";
            this.AdminSignUpTextAddress.Size = new System.Drawing.Size(162, 38);
            this.AdminSignUpTextAddress.TabIndex = 27;
            // 
            // AdminSignUpTextPass
            // 
            this.AdminSignUpTextPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUpTextPass.Location = new System.Drawing.Point(725, 200);
            this.AdminSignUpTextPass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSignUpTextPass.Name = "AdminSignUpTextPass";
            this.AdminSignUpTextPass.Size = new System.Drawing.Size(162, 38);
            this.AdminSignUpTextPass.TabIndex = 26;
            // 
            // AdminSignUpTextEmail
            // 
            this.AdminSignUpTextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUpTextEmail.Location = new System.Drawing.Point(707, 115);
            this.AdminSignUpTextEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSignUpTextEmail.Name = "AdminSignUpTextEmail";
            this.AdminSignUpTextEmail.Size = new System.Drawing.Size(287, 38);
            this.AdminSignUpTextEmail.TabIndex = 25;
            // 
            // AdminSignUpTextLname
            // 
            this.AdminSignUpTextLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUpTextLname.Location = new System.Drawing.Point(326, 208);
            this.AdminSignUpTextLname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSignUpTextLname.Name = "AdminSignUpTextLname";
            this.AdminSignUpTextLname.Size = new System.Drawing.Size(162, 38);
            this.AdminSignUpTextLname.TabIndex = 24;
            // 
            // AdminSignUpTextFname
            // 
            this.AdminSignUpTextFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSignUpTextFname.Location = new System.Drawing.Point(326, 105);
            this.AdminSignUpTextFname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminSignUpTextFname.Name = "AdminSignUpTextFname";
            this.AdminSignUpTextFname.Size = new System.Drawing.Size(162, 38);
            this.AdminSignUpTextFname.TabIndex = 23;
            // 
            // AdminGenderFemale
            // 
            this.AdminGenderFemale.AutoSize = true;
            this.AdminGenderFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminGenderFemale.Location = new System.Drawing.Point(565, 384);
            this.AdminGenderFemale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminGenderFemale.Name = "AdminGenderFemale";
            this.AdminGenderFemale.Size = new System.Drawing.Size(140, 36);
            this.AdminGenderFemale.TabIndex = 22;
            this.AdminGenderFemale.Text = "Female";
            this.AdminGenderFemale.UseVisualStyleBackColor = true;
            // 
            // AdminGenderMale
            // 
            this.AdminGenderMale.AutoSize = true;
            this.AdminGenderMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminGenderMale.Location = new System.Drawing.Point(431, 384);
            this.AdminGenderMale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AdminGenderMale.Name = "AdminGenderMale";
            this.AdminGenderMale.Size = new System.Drawing.Size(107, 36);
            this.AdminGenderMale.TabIndex = 21;
            this.AdminGenderMale.Text = "Male";
            this.AdminGenderMale.UseVisualStyleBackColor = true;
            // 
            // SignUpAddress
            // 
            this.SignUpAddress.AutoSize = true;
            this.SignUpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpAddress.Location = new System.Drawing.Point(155, 303);
            this.SignUpAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpAddress.Name = "SignUpAddress";
            this.SignUpAddress.Size = new System.Drawing.Size(118, 32);
            this.SignUpAddress.TabIndex = 20;
            this.SignUpAddress.Text = "Address";
            // 
            // SignUpPass
            // 
            this.SignUpPass.AutoSize = true;
            this.SignUpPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpPass.Location = new System.Drawing.Point(591, 205);
            this.SignUpPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpPass.Name = "SignUpPass";
            this.SignUpPass.Size = new System.Drawing.Size(138, 32);
            this.SignUpPass.TabIndex = 19;
            this.SignUpPass.Text = "Password";
            // 
            // SignUpEmail
            // 
            this.SignUpEmail.AutoSize = true;
            this.SignUpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpEmail.Location = new System.Drawing.Point(591, 115);
            this.SignUpEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpEmail.Name = "SignUpEmail";
            this.SignUpEmail.Size = new System.Drawing.Size(95, 32);
            this.SignUpEmail.TabIndex = 18;
            this.SignUpEmail.Text = "E-mail";
            // 
            // SignUpLname
            // 
            this.SignUpLname.AutoSize = true;
            this.SignUpLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpLname.Location = new System.Drawing.Point(155, 208);
            this.SignUpLname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpLname.Name = "SignUpLname";
            this.SignUpLname.Size = new System.Drawing.Size(146, 32);
            this.SignUpLname.TabIndex = 17;
            this.SignUpLname.Text = "Last name";
            // 
            // SignUpFname
            // 
            this.SignUpFname.AutoSize = true;
            this.SignUpFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFname.Location = new System.Drawing.Point(155, 108);
            this.SignUpFname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUpFname.Name = "SignUpFname";
            this.SignUpFname.Size = new System.Drawing.Size(147, 32);
            this.SignUpFname.TabIndex = 16;
            this.SignUpFname.Text = "First name";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 614);
            this.Controls.Add(this.AdminSignUpTextAge);
            this.Controls.Add(this.SignUpAge);
            this.Controls.Add(this.AdminAdd);
            this.Controls.Add(this.AdminSignUpTextAddress);
            this.Controls.Add(this.AdminSignUpTextPass);
            this.Controls.Add(this.AdminSignUpTextEmail);
            this.Controls.Add(this.AdminSignUpTextLname);
            this.Controls.Add(this.AdminSignUpTextFname);
            this.Controls.Add(this.AdminGenderFemale);
            this.Controls.Add(this.AdminGenderMale);
            this.Controls.Add(this.SignUpAddress);
            this.Controls.Add(this.SignUpPass);
            this.Controls.Add(this.SignUpEmail);
            this.Controls.Add(this.SignUpLname);
            this.Controls.Add(this.SignUpFname);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdminSignUpTextAge;
        private System.Windows.Forms.Label SignUpAge;
        private System.Windows.Forms.Button AdminAdd;
        private System.Windows.Forms.TextBox AdminSignUpTextAddress;
        private System.Windows.Forms.TextBox AdminSignUpTextPass;
        private System.Windows.Forms.TextBox AdminSignUpTextEmail;
        private System.Windows.Forms.TextBox AdminSignUpTextLname;
        private System.Windows.Forms.TextBox AdminSignUpTextFname;
        private System.Windows.Forms.RadioButton AdminGenderFemale;
        private System.Windows.Forms.RadioButton AdminGenderMale;
        private System.Windows.Forms.Label SignUpAddress;
        private System.Windows.Forms.Label SignUpPass;
        private System.Windows.Forms.Label SignUpEmail;
        private System.Windows.Forms.Label SignUpLname;
        private System.Windows.Forms.Label SignUpFname;
    }
}