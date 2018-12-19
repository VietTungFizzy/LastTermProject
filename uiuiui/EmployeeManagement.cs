using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiuiui
{
    public partial class EmployeeManagement : UserControl
    {
        private static EmployeeManagement nhanvien;
        public static EmployeeManagement Nhanvien
        {
            get
            {
                if (nhanvien == null)
                    nhanvien = new EmployeeManagement();
                return nhanvien;
            }
        }
        public EmployeeManagement()
        {
            InitializeComponent();
        }

        private void KhupdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void KhinsertBtn_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
