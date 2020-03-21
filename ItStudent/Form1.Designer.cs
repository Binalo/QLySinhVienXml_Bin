namespace ItStudent
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
            this.btnDocFile = new System.Windows.Forms.Button();
            this.dataviewSV = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.abc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLop = new System.Windows.Forms.TextBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnTK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnDocFile.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDocFile.Location = new System.Drawing.Point(39, 377);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(150, 58);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = false;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // dataviewSV
            // 
            this.dataviewSV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataviewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.lop,
            this.tuoi,
            this.sdt,
            this.diachi});
            this.dataviewSV.Location = new System.Drawing.Point(39, 53);
            this.dataviewSV.Name = "dataviewSV";
            this.dataviewSV.RowHeadersWidth = 51;
            this.dataviewSV.RowTemplate.Height = 24;
            this.dataviewSV.Size = new System.Drawing.Size(941, 303);
            this.dataviewSV.TabIndex = 1;
            this.dataviewSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button1.Location = new System.Drawing.Point(39, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.ForeColor = System.Drawing.Color.LavenderBlush;
            this.button2.Location = new System.Drawing.Point(39, 520);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(811, 377);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(70, 205);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cập nhật DTB";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnXoa.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnXoa.Location = new System.Drawing.Point(39, 590);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(151, 58);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // abc
            // 
            this.abc.AutoSize = true;
            this.abc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.abc.ForeColor = System.Drawing.Color.Black;
            this.abc.Location = new System.Drawing.Point(252, 381);
            this.abc.Name = "abc";
            this.abc.Size = new System.Drawing.Size(21, 17);
            this.abc.TabIndex = 6;
            this.abc.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(252, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ Và Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(252, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(252, 515);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tuổi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(252, 606);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Địa Chỉ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(361, 381);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(379, 22);
            this.txtId.TabIndex = 11;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(361, 417);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(379, 22);
            this.txtTen.TabIndex = 12;
            // 
            // txtLop
            // 
            this.txtLop.Location = new System.Drawing.Point(361, 468);
            this.txtLop.Name = "txtLop";
            this.txtLop.Size = new System.Drawing.Size(379, 22);
            this.txtLop.TabIndex = 13;
            // 
            // txtTuoi
            // 
            this.txtTuoi.Location = new System.Drawing.Point(361, 515);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(379, 22);
            this.txtTuoi.TabIndex = 14;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(361, 601);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(379, 22);
            this.txtDiachi.TabIndex = 15;
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.Red;
            this.btnDong.ForeColor = System.Drawing.Color.LavenderBlush;
            this.btnDong.Location = new System.Drawing.Point(811, 578);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(70, 55);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(361, 561);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(379, 22);
            this.txtSdt.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(252, 561);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(348, 32);
            this.label6.TabIndex = 19;
            this.label6.Text = "Bảng Quản Lý Sinh Viên";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 50;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 150;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 140;
            // 
            // tuoi
            // 
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.MinimumWidth = 6;
            this.tuoi.Name = "tuoi";
            this.tuoi.Width = 70;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 120;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(653, 19);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(215, 22);
            this.txtTK.TabIndex = 21;
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Times", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(874, 10);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(106, 39);
            this.btnTK.TabIndex = 22;
            this.btnTK.Text = "Tìm Kiếm";
            this.btnTK.UseVisualStyleBackColor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 689);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSdt);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTuoi);
            this.Controls.Add(this.txtLop);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.abc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataviewSV);
            this.Controls.Add(this.btnDocFile);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataviewSV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.DataGridView dataviewSV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label abc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtLop;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnTK;
    }
}

