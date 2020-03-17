using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
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
            d.ColumnCount = 4; // dat 4 cot cho du lieu
            XmlNodeList li = root.SelectNodes("sinhvien"); // lay du lieu da nhap o file xml

            int index = 0;
            foreach (XmlNode item in li)
            {
                d.Rows.Add(); // hang nay rong , chua co du lieu

                // them cot mot la id , lay thuoc tinh cua id
                d.Rows[index].Cells[0].Value = item.Attributes[0].InnerText;
                d.Rows[index].Cells[1].Value = item.SelectSingleNode("hoten").InnerText;
                d.Rows[index].Cells[2].Value = item.SelectSingleNode("lop").InnerText;
                d.Rows[index].Cells[3].Value = item.SelectSingleNode("diachi").InnerText;

                index++;
            }
        }
    }
}
