﻿using System;
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
        private void imgb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void but_Login_Click(object sender, EventArgs e)
        {
           Menu a = new Menu();
            a.Show();
            this.Hide();
        }
    }
}
