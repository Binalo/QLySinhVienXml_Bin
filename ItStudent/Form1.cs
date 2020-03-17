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
    }
}
