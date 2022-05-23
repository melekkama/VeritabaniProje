namespace veritabanidemo1
{
    partial class CustomerForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtp_checkout = new System.Windows.Forms.DateTimePicker();
            this.dtp_checkin = new System.Windows.Forms.DateTimePicker();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_changeDate = new MaterialSkin.Controls.MaterialButton();
            this.btn_cancel = new MaterialSkin.Controls.MaterialButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.tb_IDnumber = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_lastName = new MaterialSkin.Controls.MaterialTextBox();
            this.tb_firstName = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_profile = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(740, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(732, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Reservation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.materialCard1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.materialButton1, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(726, 369);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.dtp_checkout);
            this.materialCard1.Controls.Add(this.dtp_checkin);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(50, 50);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(625, 267);
            this.materialCard1.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.Location = new System.Drawing.Point(75, 133);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(147, 24);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Check-Out Date:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(75, 50);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(132, 24);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Check-In Date:";
            // 
            // dtp_checkout
            // 
            this.dtp_checkout.Location = new System.Drawing.Point(307, 130);
            this.dtp_checkout.Name = "dtp_checkout";
            this.dtp_checkout.Size = new System.Drawing.Size(250, 27);
            this.dtp_checkout.TabIndex = 1;
            // 
            // dtp_checkin
            // 
            this.dtp_checkin.Location = new System.Drawing.Point(307, 47);
            this.dtp_checkin.Name = "dtp_checkin";
            this.dtp_checkin.Size = new System.Drawing.Size(250, 27);
            this.dtp_checkin.TabIndex = 0;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(40, 337);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(645, 26);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Go to Reservation";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_changeDate);
            this.tabPage2.Controls.Add(this.btn_cancel);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(732, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservation Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_changeDate
            // 
            this.btn_changeDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_changeDate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_changeDate.Depth = 0;
            this.btn_changeDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_changeDate.HighEmphasis = true;
            this.btn_changeDate.Icon = null;
            this.btn_changeDate.Location = new System.Drawing.Point(3, 3);
            this.btn_changeDate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_changeDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_changeDate.Name = "btn_changeDate";
            this.btn_changeDate.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_changeDate.Size = new System.Drawing.Size(726, 36);
            this.btn_changeDate.TabIndex = 1;
            this.btn_changeDate.Text = "Change Dates";
            this.btn_changeDate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_changeDate.UseAccentColor = false;
            this.btn_changeDate.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancel.Depth = 0;
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cancel.HighEmphasis = true;
            this.btn_cancel.Icon = null;
            this.btn_cancel.Location = new System.Drawing.Point(3, 336);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancel.Size = new System.Drawing.Size(726, 36);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "Cancel Reservation";
            this.btn_cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancel.UseAccentColor = false;
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.materialCard2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(732, 375);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Profile";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.tb_IDnumber);
            this.materialCard2.Controls.Add(this.tb_lastName);
            this.materialCard2.Controls.Add(this.tb_firstName);
            this.materialCard2.Controls.Add(this.btn_profile);
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialLabel4);
            this.materialCard2.Controls.Add(this.materialLabel5);
            this.materialCard2.Depth = 0;
            this.materialCard2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(3, 3);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(726, 369);
            this.materialCard2.TabIndex = 0;
            // 
            // tb_IDnumber
            // 
            this.tb_IDnumber.AnimateReadOnly = false;
            this.tb_IDnumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_IDnumber.Depth = 0;
            this.tb_IDnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_IDnumber.LeadingIcon = null;
            this.tb_IDnumber.Location = new System.Drawing.Point(358, 207);
            this.tb_IDnumber.MaxLength = 50;
            this.tb_IDnumber.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_IDnumber.Multiline = false;
            this.tb_IDnumber.Name = "tb_IDnumber";
            this.tb_IDnumber.Size = new System.Drawing.Size(228, 50);
            this.tb_IDnumber.TabIndex = 13;
            this.tb_IDnumber.Text = "";
            this.tb_IDnumber.TrailingIcon = null;
            // 
            // tb_lastName
            // 
            this.tb_lastName.AnimateReadOnly = false;
            this.tb_lastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_lastName.Depth = 0;
            this.tb_lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_lastName.LeadingIcon = null;
            this.tb_lastName.Location = new System.Drawing.Point(358, 109);
            this.tb_lastName.MaxLength = 50;
            this.tb_lastName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_lastName.Multiline = false;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(228, 50);
            this.tb_lastName.TabIndex = 12;
            this.tb_lastName.Text = "";
            this.tb_lastName.TrailingIcon = null;
            // 
            // tb_firstName
            // 
            this.tb_firstName.AnimateReadOnly = false;
            this.tb_firstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_firstName.Depth = 0;
            this.tb_firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tb_firstName.LeadingIcon = null;
            this.tb_firstName.Location = new System.Drawing.Point(358, 28);
            this.tb_firstName.MaxLength = 50;
            this.tb_firstName.MouseState = MaterialSkin.MouseState.OUT;
            this.tb_firstName.Multiline = false;
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(228, 50);
            this.tb_firstName.TabIndex = 11;
            this.tb_firstName.Text = "";
            this.tb_firstName.TrailingIcon = null;
            // 
            // btn_profile
            // 
            this.btn_profile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_profile.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_profile.Depth = 0;
            this.btn_profile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_profile.HighEmphasis = true;
            this.btn_profile.Icon = null;
            this.btn_profile.Location = new System.Drawing.Point(14, 319);
            this.btn_profile.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_profile.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_profile.Size = new System.Drawing.Size(698, 36);
            this.btn_profile.TabIndex = 10;
            this.btn_profile.Text = "S  A  V  E";
            this.btn_profile.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_profile.UseAccentColor = false;
            this.btn_profile.UseVisualStyleBackColor = true;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.Location = new System.Drawing.Point(120, 233);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(150, 24);
            this.materialLabel3.TabIndex = 9;
            this.materialLabel3.Text = "Identıty Number:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel4.Location = new System.Drawing.Point(120, 135);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(103, 24);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Last Name:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel5.Location = new System.Drawing.Point(120, 54);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(104, 24);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "First Name:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private DateTimePicker dtp_checkout;
        private DateTimePicker dtp_checkin;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton btn_changeDate;
        private MaterialSkin.Controls.MaterialButton btn_cancel;
        private TabPage tabPage3;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox tb_IDnumber;
        private MaterialSkin.Controls.MaterialTextBox tb_lastName;
        private MaterialSkin.Controls.MaterialTextBox tb_firstName;
        private MaterialSkin.Controls.MaterialButton btn_profile;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}