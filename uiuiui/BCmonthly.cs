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
    public partial class BCmonthly : Form
    {
        public BCmonthly()
        {
            InitializeComponent();
        }

        private void imgb_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BCmonthly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeDataSet.BILL' table. You can move, or remove it, as needed.
            this.bILLTableAdapter.Fill(this.coffeeDataSet.BILL);

        }
    }
}
