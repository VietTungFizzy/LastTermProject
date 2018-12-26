using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uiuiui
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void qlnvBtn_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            if (!panel1.Controls.Contains(EmployeeManagement.Nhanvien))
            {
                panel1.Controls.Add(EmployeeManagement.Nhanvien);
                EmployeeManagement.Nhanvien.BringToFront();
            }
            else
                EmployeeManagement.Nhanvien.BringToFront();
        }

        private void qlkhBtn_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;
           
            if (!panel1.Controls.Contains(ProductManagement.Khohang))
            {
                panel1.Controls.Add(ProductManagement.Khohang);
                ProductManagement.Khohang.BringToFront();
            }
            else
                ProductManagement.Khohang.BringToFront();
        }

        private void bcnBtn_Click(object sender, EventArgs e)
        {
            slider.Left = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Left;
            slider.Width = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Width;

            if (!panel1.Controls.Contains(YearReport.Baocaonam))
            {
                panel1.Controls.Add(YearReport.Baocaonam);
                YearReport.Baocaonam.BringToFront();
            }
            else
                YearReport.Baocaonam.BringToFront();

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
         
            if (!panel1.Controls.Contains(EmployeeManagement.Nhanvien))
            {
                panel1.Controls.Add(EmployeeManagement.Nhanvien);
                EmployeeManagement.Nhanvien.BringToFront();
            }
            else
                EmployeeManagement.Nhanvien.BringToFront();
        }

        private void imgb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
