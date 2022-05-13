namespace veritabanidemo1
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_firstName = new MaterialSkin.Controls.MaterialLabel();
            this.lb_lastName = new MaterialSkin.Controls.MaterialLabel();
            this.lb_identityNumber = new MaterialSkin.Controls.MaterialLabel();
            this.lb_email = new MaterialSkin.Controls.MaterialLabel();
            this.lb_password = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_register = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lb_firstName
            // 
            this.lb_firstName.AutoSize = true;
            this.lb_firstName.Depth = 0;
            this.lb_firstName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_firstName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_firstName.Location = new System.Drawing.Point(38, 108);
            this.lb_firstName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_firstName.Name = "lb_firstName";
            this.lb_firstName.Size = new System.Drawing.Size(104, 24);
            this.lb_firstName.TabIndex = 0;
            this.lb_firstName.Text = "First Name:";
            // 
            // lb_lastName
            // 
            this.lb_lastName.AutoSize = true;
            this.lb_lastName.Depth = 0;
            this.lb_lastName.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_lastName.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_lastName.Location = new System.Drawing.Point(39, 181);
            this.lb_lastName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_lastName.Name = "lb_lastName";
            this.lb_lastName.Size = new System.Drawing.Size(103, 24);
            this.lb_lastName.TabIndex = 1;
            this.lb_lastName.Text = "Last Name:";
            // 
            // lb_identityNumber
            // 
            this.lb_identityNumber.AutoSize = true;
            this.lb_identityNumber.Depth = 0;
            this.lb_identityNumber.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_identityNumber.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_identityNumber.Location = new System.Drawing.Point(37, 250);
            this.lb_identityNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_identityNumber.Name = "lb_identityNumber";
            this.lb_identityNumber.Size = new System.Drawing.Size(150, 24);
            this.lb_identityNumber.TabIndex = 2;
            this.lb_identityNumber.Text = "Identity Number:";
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Depth = 0;
            this.lb_email.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_email.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_email.Location = new System.Drawing.Point(38, 321);
            this.lb_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(55, 24);
            this.lb_email.TabIndex = 3;
            this.lb_email.Text = "Email:";
            // 
            // lb_password
            // 
            this.lb_password.AutoSize = true;
            this.lb_password.Depth = 0;
            this.lb_password.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lb_password.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lb_password.Location = new System.Drawing.Point(37, 392);
            this.lb_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_password.Name = "lb_password";
            this.lb_password.Size = new System.Drawing.Size(94, 24);
            this.lb_password.TabIndex = 4;
            this.lb_password.Text = "Password:";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(333, 82);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(225, 50);
            this.materialTextBox1.TabIndex = 5;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(333, 366);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Password = true;
            this.materialTextBox2.Size = new System.Drawing.Size(225, 50);
            this.materialTextBox2.TabIndex = 6;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(333, 224);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(225, 50);
            this.materialTextBox3.TabIndex = 7;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(333, 155);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.Size = new System.Drawing.Size(225, 50);
            this.materialTextBox4.TabIndex = 8;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(333, 295);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.Size = new System.Drawing.Size(225, 50);
            this.materialTextBox5.TabIndex = 9;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // btn_register
            // 
            this.btn_register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_register.Depth = 0;
            this.btn_register.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_register.HighEmphasis = true;
            this.btn_register.Icon = null;
            this.btn_register.Location = new System.Drawing.Point(3, 518);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_register.Name = "btn_register";
            this.btn_register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_register.Size = new System.Drawing.Size(602, 36);
            this.btn_register.TabIndex = 10;
            this.btn_register.Text = "R E G I S T E R";
            this.btn_register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_register.UseAccentColor = false;
            this.btn_register.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 557);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.materialTextBox5);
            this.Controls.Add(this.materialTextBox4);
            this.Controls.Add(this.materialTextBox3);
            this.Controls.Add(this.materialTextBox2);
            this.Controls.Add(this.materialTextBox1);
            this.Controls.Add(this.lb_password);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_identityNumber);
            this.Controls.Add(this.lb_lastName);
            this.Controls.Add(this.lb_firstName);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REGISTER";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lb_firstName;
        private MaterialSkin.Controls.MaterialLabel lb_lastName;
        private MaterialSkin.Controls.MaterialLabel lb_identityNumber;
        private MaterialSkin.Controls.MaterialLabel lb_email;
        private MaterialSkin.Controls.MaterialLabel lb_password;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialButton btn_register;
    }
}