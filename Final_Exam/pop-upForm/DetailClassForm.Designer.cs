﻿namespace NQH_Application.pop_upForm {
    partial class DetailClassForm {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.subjedtLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.numberOfSessionLabel = new System.Windows.Forms.Label();
            this.numberOfStudentLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.teacherLabel = new System.Windows.Forms.Label();
            this.removeBtn = new CustomControls.RJControls.RJButton();
            this.cancelBtn = new CustomControls.RJControls.RJButton();
            this.classGridView = new NQH_Application.RoundedGridView();
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Font = new System.Drawing.Font("Quicksand SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.classNameLabel.Location = new System.Drawing.Point(12, 9);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(139, 50);
            this.classNameLabel.TabIndex = 0;
            this.classNameLabel.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 35);
            this.label2.TabIndex = 12;
            this.label2.Text = "Môn học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label3.Location = new System.Drawing.Point(15, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 35);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ca học:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label4.Location = new System.Drawing.Point(195, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Lớp:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label5.Location = new System.Drawing.Point(195, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 35);
            this.label5.TabIndex = 12;
            this.label5.Text = "Học phí:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label6.Location = new System.Drawing.Point(416, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 35);
            this.label6.TabIndex = 12;
            this.label6.Text = "Số buổi học: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label7.Location = new System.Drawing.Point(416, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Số học sinh:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label8.Location = new System.Drawing.Point(653, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 35);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tình trạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Quicksand SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            this.label9.Location = new System.Drawing.Point(653, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 35);
            this.label9.TabIndex = 12;
            this.label9.Text = "Giáo viên:";
            this.label9.Visible = false;
            // 
            // subjedtLabel
            // 
            this.subjedtLabel.AutoSize = true;
            this.subjedtLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjedtLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.subjedtLabel.Location = new System.Drawing.Point(114, 62);
            this.subjedtLabel.Name = "subjedtLabel";
            this.subjedtLabel.Size = new System.Drawing.Size(54, 32);
            this.subjedtLabel.TabIndex = 12;
            this.subjedtLabel.Text = "null";
            // 
            // shiftLabel
            // 
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.shiftLabel.Location = new System.Drawing.Point(114, 112);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(54, 32);
            this.shiftLabel.TabIndex = 12;
            this.shiftLabel.Text = "null";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gradeLabel.Location = new System.Drawing.Point(284, 62);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(54, 32);
            this.gradeLabel.TabIndex = 12;
            this.gradeLabel.Text = "null";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.priceLabel.Location = new System.Drawing.Point(284, 112);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(54, 32);
            this.priceLabel.TabIndex = 12;
            this.priceLabel.Text = "null";
            // 
            // numberOfSessionLabel
            // 
            this.numberOfSessionLabel.AutoSize = true;
            this.numberOfSessionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSessionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numberOfSessionLabel.Location = new System.Drawing.Point(544, 62);
            this.numberOfSessionLabel.Name = "numberOfSessionLabel";
            this.numberOfSessionLabel.Size = new System.Drawing.Size(54, 32);
            this.numberOfSessionLabel.TabIndex = 12;
            this.numberOfSessionLabel.Text = "null";
            // 
            // numberOfStudentLabel
            // 
            this.numberOfStudentLabel.AutoSize = true;
            this.numberOfStudentLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfStudentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.numberOfStudentLabel.Location = new System.Drawing.Point(544, 112);
            this.numberOfStudentLabel.Name = "numberOfStudentLabel";
            this.numberOfStudentLabel.Size = new System.Drawing.Size(54, 32);
            this.numberOfStudentLabel.TabIndex = 12;
            this.numberOfStudentLabel.Text = "null";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(764, 62);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(54, 32);
            this.statusLabel.TabIndex = 12;
            this.statusLabel.Text = "null";
            // 
            // teacherLabel
            // 
            this.teacherLabel.AutoSize = true;
            this.teacherLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.teacherLabel.Location = new System.Drawing.Point(764, 112);
            this.teacherLabel.Name = "teacherLabel";
            this.teacherLabel.Size = new System.Drawing.Size(54, 32);
            this.teacherLabel.TabIndex = 12;
            this.teacherLabel.Text = "null";
            this.teacherLabel.Visible = false;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.removeBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            this.removeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.removeBtn.BorderRadius = 0;
            this.removeBtn.BorderSize = 0;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.ForeColor = System.Drawing.Color.White;
            this.removeBtn.Location = new System.Drawing.Point(1034, 55);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(150, 40);
            this.removeBtn.TabIndex = 13;
            this.removeBtn.Text = "Xóa lớp";
            this.removeBtn.TextColor = System.Drawing.Color.White;
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cancelBtn.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.cancelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cancelBtn.BorderRadius = 0;
            this.cancelBtn.BorderSize = 0;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(1034, 105);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(150, 40);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Thoát";
            this.cancelBtn.TextColor = System.Drawing.Color.Black;
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // classGridView
            // 
            this.classGridView.AllowUserToAddRows = false;
            this.classGridView.AllowUserToDeleteRows = false;
            this.classGridView.AllowUserToResizeColumns = false;
            this.classGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.classGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.classGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.classGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.classGridView.BorderRadius = 7;
            this.classGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.classGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.classGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(181)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(49)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classGridView.ColumnHeadersHeight = 50;
            this.classGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(64)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.classGridView.EnableHeadersVisualStyles = false;
            this.classGridView.GridColor = System.Drawing.Color.GhostWhite;
            this.classGridView.Location = new System.Drawing.Point(17, 151);
            this.classGridView.MultiSelect = false;
            this.classGridView.Name = "classGridView";
            this.classGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classGridView.RowHeadersVisible = false;
            this.classGridView.RowHeadersWidth = 51;
            this.classGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.classGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.classGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.classGridView.RowTemplate.DividerHeight = 1;
            this.classGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.classGridView.Size = new System.Drawing.Size(1167, 529);
            this.classGridView.TabIndex = 14;
            // 
            // ChiTietLopHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 727);
            this.ControlBox = false;
            this.Controls.Add(this.classGridView);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.removeBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.teacherLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.numberOfStudentLabel);
            this.Controls.Add(this.numberOfSessionLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.subjedtLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classNameLabel);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChiTietLopHocForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ChiTietLopHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label subjedtLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label numberOfSessionLabel;
        private System.Windows.Forms.Label numberOfStudentLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label teacherLabel;
        private CustomControls.RJControls.RJButton removeBtn;
        private CustomControls.RJControls.RJButton cancelBtn;
        private RoundedGridView classGridView;
    }
}