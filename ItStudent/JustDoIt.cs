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
    class JustDoIt
    {
        XmlDocument doc;
        XmlElement root;

        string filename;
        public JustDoIt()
        {
            doc = new XmlDocument();
            filename = @"C:\Users\ADMIN\Desktop\Train C#\ItStudent\ItStudent\sinhvien.xml";
            doc.Load(filename);

            root = doc.DocumentElement; // lay  phan tu goc trong tai lieu

        }

        public void DocFile(DataGridView d)
        {
            d.Rows.Clear();
            d.ColumnCount = 6; // dat 4 cot cho du lieu
            XmlNodeList li = root.SelectNodes("sinhvien"); // lay du lieu da nhap o file xml

            int index = 0;
            foreach (XmlNode item in li)
            {
                d.Rows.Add(); // hang nay rong , chua co du lieu

                // them cot mot la id , lay thuoc tinh cua id
                d.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                d.Rows[index].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                d.Rows[index].Cells[2].Value = item.SelectSingleNode("lop").InnerText;
                d.Rows[index].Cells[3].Value = item.SelectSingleNode("tuoi").InnerText;
                d.Rows[index].Cells[4].Value = item.SelectSingleNode("sdt").InnerText;
                d.Rows[index].Cells[5].Value = item.SelectSingleNode("diachi").InnerText;

                index++;
            }
        }



        public void Add(sinhvien s)
        {
            // Them du lieu vao xml
            XmlElement sv = doc.CreateElement("sinhvien");
            sv.SetAttribute("masv", s.id);

            XmlElement hoten = doc.CreateElement("hoten");
            hoten.InnerText = s.Ten;

            XmlElement lop = doc.CreateElement("lop");
            lop.InnerText = s.Lop;

            XmlElement tuoi = doc.CreateElement("tuoi");
            tuoi.InnerText = s.Tuoi;

            XmlElement sdt = doc.CreateElement("sdt");
            sdt.InnerText = s.Sdt;

            XmlElement diachi = doc.CreateElement("diachi");
            diachi.InnerText = s.Diachi;

            sv.AppendChild(hoten);
            sv.AppendChild(lop);
            sv.AppendChild(tuoi);
            sv.AppendChild(sdt);
            sv.AppendChild(diachi);

            root.AppendChild(sv);
            doc.Save(filename);


        }
        public void Update(sinhvien s)
        {
            XmlNode Svcansua=root.SelectSingleNode("sinhvien[@masv='" + s.id + "']");
            if (Svcansua != null)
            {
                XmlElement sv = doc.CreateElement("sinhvien");
                sv.SetAttribute("masv", s.id);

                XmlElement hoten = doc.CreateElement("hoten");
                hoten.InnerText = s.Ten;

                XmlElement lop = doc.CreateElement("lop");
                lop.InnerText = s.Lop;

                XmlElement tuoi = doc.CreateElement("tuoi");
                tuoi.InnerText = s.Tuoi;

                XmlElement sdt = doc.CreateElement("sdt");
                sdt.InnerText = s.Sdt;

                XmlElement diachi = doc.CreateElement("diachi");
                diachi.InnerText = s.Diachi;

                sv.AppendChild(hoten);
                sv.AppendChild(lop);
                sv.AppendChild(tuoi);
                sv.AppendChild(sdt);
                sv.AppendChild(diachi);

                root.ReplaceChild(sv, Svcansua);
                doc.Save(filename);
            }

        }
        public void Delete(sinhvien s)
        {
            XmlNode svcantim = root.SelectSingleNode("sinhvien[@masv='" + s.id + "']");
            if (svcantim != null) // de xoa node hien tai ta phai sd nut cha cua no
            {
                root.RemoveChild(svcantim);
                doc.Save(filename);
                MessageBox.Show("Xóa Thành Công");

            }
            else
            {
                MessageBox.Show("Không có sinh viên mã " + s.id + " để xóa");
            }
        }
    }
}
