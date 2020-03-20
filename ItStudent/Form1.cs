using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.IO;

namespace ItStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        JustDoIt j = new JustDoIt();
        private void btnDocFile_Click(object sender, EventArgs e)
        {
            j.DocFile(dataviewSV);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataviewSV.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataviewSV.Rows[i];
            txtId.Text = Convert.ToString(row.Cells["id"].Value);
            txtTen.Text = Convert.ToString(row.Cells["ten"].Value);

            txtLop.Text = Convert.ToString(row.Cells["lop"].Value);

            txtTuoi.Text = Convert.ToString(row.Cells["tuoi"].Value);
            txtSdt.Text = Convert.ToString(row.Cells["sdt"].Value);
            txtDiachi.Text = Convert.ToString(row.Cells["diachi"].Value);


        }
        public void ThemVaoDtb()
        {
                ConnectSql cn = new ConnectSql();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = cn.kn; //lay chuoi ket noi
                cn.Connect();// mo ket noi

                for (int i = 0; i < dataviewSV.Rows.Count-1; i++)
                {
                    string sql = @"INSERT INTO LyLichSV VALUES (N'"
                                 + dataviewSV.Rows[i].Cells["id"].Value + "',N'"
                                 + dataviewSV.Rows[i].Cells["ten"].Value + "',N'"
                                 + dataviewSV.Rows[i].Cells["lop"].Value + "',N'"
                                 + dataviewSV.Rows[i].Cells["tuoi"].Value + "',N'"
                                 + dataviewSV.Rows[i].Cells["sdt"].Value + "',N'"
                                 + dataviewSV.Rows[i].Cells["diachi"].Value + "');";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
            }
            
            cn.kn.Close(); //dong ket noi
            
        }




        private void button3_Click(object sender, EventArgs e)
        {
            ThemVaoDtb();            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();

            // tao moi tu cac thong tin trong text box
            sv.id = txtId.Text;
            sv.Ten = txtTen.Text;
            sv.Lop = txtLop.Text;
            sv.Tuoi = txtTuoi.Text;
            sv.Sdt = txtSdt.Text;
            sv.Diachi = txtDiachi.Text;

            j.Update(sv);

            j.DocFile(dataviewSV);


            ConnectSql cn = new ConnectSql();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.kn; //lay chuoi ket noi
            cn.Connect();// mo ket noi

            string sql = @"UPDATE LyLichSV SET 
                            ID = N'" + txtId.Text + @"',Name='" + txtTen.Text
                            + @"',Class='" + txtLop.Text + @"',Age='" + txtTuoi.Text
                            + @"',Number='" + txtSdt.Text + @"',Address='" + txtDiachi.Text
                            + @"'WHERE (ID= N'" + txtId.Text + @"')";


            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();


            cn.kn.Close(); //dong ket noi
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            sinhvien sv = new sinhvien();

            // tao moi tu cac thong tin trong text box
            sv.id = txtId.Text;
            j.Delete(sv);
            j.DocFile(dataviewSV);

            ConnectSql cn = new ConnectSql();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.kn; //lay chuoi ket noi
            cn.Connect();// mo ket noi

            string sql = @"DELETE FROM LyLichSV WHERE (ID= '" + txtId.Text + @"')";


            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();

            cn.kn.Close(); //dong ket noi
        }


        //Them DU LIEu

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "" || txtTen.Text == "" || txtLop.Text == "" || txtTuoi.Text == "" || txtSdt.Text == "" || txtDiachi.Text == "")
            {
                MessageBox.Show("Please enter all details about employee");
                return;
            }
            sinhvien sv = new sinhvien();
            // tao moi tu cac thong tin trong text box
            sv.id = txtId.Text;
            sv.Ten = txtTen.Text;
            sv.Lop = txtLop.Text;
            sv.Tuoi = txtTuoi.Text;
            sv.Sdt = txtSdt.Text;
            sv.Diachi = txtDiachi.Text;

            j.Add(sv);

            j.DocFile(dataviewSV);



            ConnectSql cn = new ConnectSql();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = cn.kn; //lay chuoi ket noi
            cn.Connect();// mo ket noi

            string sql = @"INSERT INTO LyLichSV VALUES (N'"
                            + txtId.Text + "',N'" + txtTen.Text 
                            + "',N'" + txtLop.Text + "',N'" 
                            + txtTuoi.Text + "',N'" + txtSdt.Text 
                            + "',N'" + txtDiachi.Text + "')";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
            

            cn.kn.Close(); //dong ket noi


        }

    }
}
