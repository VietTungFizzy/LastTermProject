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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            EnterBillForm a = new EnterBillForm();
            a.Show();
            this.Hide();
        }

        private void imgb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
