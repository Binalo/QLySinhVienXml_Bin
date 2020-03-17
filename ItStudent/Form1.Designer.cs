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
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataviewSV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDocFile
            // 
            this.btnDocFile.Location = new System.Drawing.Point(416, 407);
            this.btnDocFile.Name = "btnDocFile";
            this.btnDocFile.Size = new System.Drawing.Size(213, 70);
            this.btnDocFile.TabIndex = 0;
            this.btnDocFile.Text = "Đọc File";
            this.btnDocFile.UseVisualStyleBackColor = true;
            this.btnDocFile.Click += new System.EventHandler(this.btnDocFile_Click);
            // 
            // dataviewSV
            // 
            this.dataviewSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataviewSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ten,
            this.lop,
            this.diachi});
            this.dataviewSV.Location = new System.Drawing.Point(82, 27);
            this.dataviewSV.Name = "dataviewSV";
            this.dataviewSV.RowHeadersWidth = 51;
            this.dataviewSV.RowTemplate.Height = 24;
            this.dataviewSV.Size = new System.Drawing.Size(858, 318);
            this.dataviewSV.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // ten
            // 
            this.ten.HeaderText = "Tên";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 200;
            // 
            // lop
            // 
            this.lop.HeaderText = "Lớp";
            this.lop.MinimumWidth = 6;
            this.lop.Name = "lop";
            this.lop.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 567);
            this.Controls.Add(this.dataviewSV);
            this.Controls.Add(this.btnDocFile);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataviewSV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDocFile;
        private System.Windows.Forms.DataGridView dataviewSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn lop;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
    }
}

