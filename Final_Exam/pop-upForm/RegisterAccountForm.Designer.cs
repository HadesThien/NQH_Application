﻿namespace NQH_Application.pop_upForm {
    partial class RegisterAccountForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.accountTextBox = new CustomControls.RJControls.RJTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.emailTextBox = new CustomControls.RJControls.RJTextBox();
            this.passwordTextBox = new CustomControls.RJControls.RJTextBox();
            this.numberPhoneTextBox = new CustomControls.RJControls.RJTextBox();
            this.nameTextBox = new CustomControls.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roleComboBox = new CustomControls.RJControls.RJComboBox();
            this.alertEmail = new System.Windows.Forms.Label();
            this.alertAccount = new System.Windows.Forms.Label();
            this.alertName = new System.Windows.Forms.Label();
            this.alertNumberphone = new System.Windows.Forms.Label();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.saveBtn = new CustomControls.RJControls.RJButton();
            this.passwordFormattingAlert = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng ký tài khoản :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.accountTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.emailTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numberPhoneTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameTextBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.roleComboBox, 2, 1);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.SlateBlue;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1159, 519);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // accountTextBox
            // 
            this.accountTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.accountTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.accountTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.accountTextBox.BorderRadius = 20;
            this.accountTextBox.BorderSize = 2;
            this.accountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.accountTextBox.Location = new System.Drawing.Point(4, 90);
            this.accountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.accountTextBox.Multiline = false;
            this.accountTextBox.Name = "accountTextBox";
            this.accountTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.accountTextBox.PasswordChar = false;
            this.accountTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.accountTextBox.PlaceholderText = "";
            this.accountTextBox.Size = new System.Drawing.Size(378, 36);
            this.accountTextBox.TabIndex = 0;
            this.accountTextBox.Texts = "";
            this.accountTextBox.UnderlinedStyle = false;
            this.accountTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.accountTextBox_KeyPress);
            this.accountTextBox.Leave += new System.EventHandler(this.accountTextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label3.Location = new System.Drawing.Point(3, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label5.Location = new System.Drawing.Point(389, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số điện thoại:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label6.Location = new System.Drawing.Point(775, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quyền:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label7.Location = new System.Drawing.Point(775, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tên người dùng:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.emailTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.emailTextBox.BorderRadius = 20;
            this.emailTextBox.BorderSize = 2;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTextBox.Location = new System.Drawing.Point(4, 348);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Multiline = false;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.emailTextBox.PasswordChar = false;
            this.emailTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTextBox.PlaceholderText = "";
            this.emailTextBox.Size = new System.Drawing.Size(378, 36);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Texts = "";
            this.emailTextBox.UnderlinedStyle = false;
            this.emailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.emailTextBox_KeyPress);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.passwordTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.passwordTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.passwordTextBox.BorderRadius = 20;
            this.passwordTextBox.BorderSize = 2;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTextBox.Location = new System.Drawing.Point(390, 90);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextBox.Multiline = false;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.passwordTextBox.PasswordChar = false;
            this.passwordTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passwordTextBox.PlaceholderText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(378, 36);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.Texts = "";
            this.passwordTextBox.UnderlinedStyle = false;
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // numberPhoneTextBox
            // 
            this.numberPhoneTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.numberPhoneTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.numberPhoneTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.numberPhoneTextBox.BorderRadius = 20;
            this.numberPhoneTextBox.BorderSize = 2;
            this.numberPhoneTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPhoneTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numberPhoneTextBox.Location = new System.Drawing.Point(390, 348);
            this.numberPhoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numberPhoneTextBox.Multiline = false;
            this.numberPhoneTextBox.Name = "numberPhoneTextBox";
            this.numberPhoneTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.numberPhoneTextBox.PasswordChar = false;
            this.numberPhoneTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.numberPhoneTextBox.PlaceholderText = "";
            this.numberPhoneTextBox.Size = new System.Drawing.Size(378, 36);
            this.numberPhoneTextBox.TabIndex = 4;
            this.numberPhoneTextBox.Texts = "";
            this.numberPhoneTextBox.UnderlinedStyle = false;
            this.numberPhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberPhoneTextBox_KeyPress);
            this.numberPhoneTextBox.Leave += new System.EventHandler(this.numberPhoneTextBox_Leave);
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nameTextBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.nameTextBox.BorderFocusColor = System.Drawing.Color.HotPink;
            this.nameTextBox.BorderRadius = 20;
            this.nameTextBox.BorderSize = 2;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nameTextBox.Location = new System.Drawing.Point(776, 348);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameTextBox.Multiline = false;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nameTextBox.PasswordChar = false;
            this.nameTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameTextBox.PlaceholderText = "";
            this.nameTextBox.Size = new System.Drawing.Size(379, 36);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.Texts = "";
            this.nameTextBox.UnderlinedStyle = false;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBox_KeyPress);
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(184)))), ((int)(((byte)(67)))));
            this.label4.Location = new System.Drawing.Point(389, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu:";
            // 
            // roleComboBox
            // 
            this.roleComboBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.roleComboBox.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.roleComboBox.BorderSize = 1;
            this.roleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleComboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleComboBox.ForeColor = System.Drawing.Color.DimGray;
            this.roleComboBox.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.roleComboBox.Items.AddRange(new object[] {
            "Quản lý ",
            "Nhân viên"});
            this.roleComboBox.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.roleComboBox.ListTextColor = System.Drawing.Color.DimGray;
            this.roleComboBox.Location = new System.Drawing.Point(775, 89);
            this.roleComboBox.MinimumSize = new System.Drawing.Size(200, 30);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Padding = new System.Windows.Forms.Padding(1);
            this.roleComboBox.Size = new System.Drawing.Size(380, 30);
            this.roleComboBox.TabIndex = 2;
            this.roleComboBox.Texts = "";
            // 
            // alertEmail
            // 
            this.alertEmail.AutoSize = true;
            this.alertEmail.BackColor = System.Drawing.Color.White;
            this.alertEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.alertEmail.Location = new System.Drawing.Point(25, 503);
            this.alertEmail.Name = "alertEmail";
            this.alertEmail.Size = new System.Drawing.Size(223, 21);
            this.alertEmail.TabIndex = 0;
            this.alertEmail.Text = "*Định dạng email không đúng ";
            this.alertEmail.Visible = false;
            // 
            // alertAccount
            // 
            this.alertAccount.AutoSize = true;
            this.alertAccount.BackColor = System.Drawing.Color.White;
            this.alertAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.alertAccount.Location = new System.Drawing.Point(29, 243);
            this.alertAccount.Name = "alertAccount";
            this.alertAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alertAccount.Size = new System.Drawing.Size(169, 21);
            this.alertAccount.TabIndex = 0;
            this.alertAccount.Text = "*Tên Account đã tồn tại";
            this.alertAccount.Visible = false;
            // 
            // alertName
            // 
            this.alertName.AutoSize = true;
            this.alertName.BackColor = System.Drawing.Color.White;
            this.alertName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.alertName.Location = new System.Drawing.Point(797, 503);
            this.alertName.Name = "alertName";
            this.alertName.Size = new System.Drawing.Size(280, 21);
            this.alertName.TabIndex = 0;
            this.alertName.Text = "*Tên người dùng không được để trống!";
            this.alertName.Visible = false;
            // 
            // alertNumberphone
            // 
            this.alertNumberphone.AutoSize = true;
            this.alertNumberphone.BackColor = System.Drawing.Color.White;
            this.alertNumberphone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alertNumberphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.alertNumberphone.Location = new System.Drawing.Point(411, 503);
            this.alertNumberphone.Name = "alertNumberphone";
            this.alertNumberphone.Size = new System.Drawing.Size(348, 21);
            this.alertNumberphone.TabIndex = 0;
            this.alertNumberphone.Text = "*Số điện thoại người dùng không được để trống!";
            this.alertNumberphone.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.cancelBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(241)))));
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(91)))), ((int)(((byte)(147)))));
            this.cancelBtn.Location = new System.Drawing.Point(860, 660);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 40);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(91)))), ((int)(((byte)(147)))));
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.saveBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.saveBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.saveBtn.BorderRadius = 0;
            this.saveBtn.BorderSize = 0;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(1028, 660);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(150, 40);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Lưu";
            this.saveBtn.TextColor = System.Drawing.Color.White;
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // passwordFormattingAlert
            // 
            this.passwordFormattingAlert.AutoSize = true;
            this.passwordFormattingAlert.BackColor = System.Drawing.Color.White;
            this.passwordFormattingAlert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordFormattingAlert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.passwordFormattingAlert.Location = new System.Drawing.Point(411, 243);
            this.passwordFormattingAlert.Name = "passwordFormattingAlert";
            this.passwordFormattingAlert.Size = new System.Drawing.Size(230, 21);
            this.passwordFormattingAlert.TabIndex = 0;
            this.passwordFormattingAlert.Text = "*Mật khẩu phải đúng định dạng";
            this.passwordFormattingAlert.Visible = false;
            // 
            // RegisterAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.ControlBox = false;
            this.Controls.Add(this.alertAccount);
            this.Controls.Add(this.passwordFormattingAlert);
            this.Controls.Add(this.alertNumberphone);
            this.Controls.Add(this.alertName);
            this.Controls.Add(this.alertEmail);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegisterAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton saveBtn;
        private CustomControls.RJControls.RJButton cancelBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CustomControls.RJControls.RJTextBox accountTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private CustomControls.RJControls.RJTextBox emailTextBox;
        private CustomControls.RJControls.RJTextBox passwordTextBox;
        private CustomControls.RJControls.RJTextBox numberPhoneTextBox;
        private CustomControls.RJControls.RJTextBox nameTextBox;
        private System.Windows.Forms.Label alertEmail;
        private System.Windows.Forms.Label alertAccount;
        private CustomControls.RJControls.RJComboBox roleComboBox;
        private System.Windows.Forms.Label alertName;
        private System.Windows.Forms.Label alertNumberphone;
        private System.Windows.Forms.Label passwordFormattingAlert;
    }
}