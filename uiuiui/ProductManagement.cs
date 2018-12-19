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
    public partial class ProductManagement : UserControl
    {
        private static ProductManagement khohang;
        public static ProductManagement Khohang
        {
            get
            {
                if (khohang == null)
                    khohang = new ProductManagement();
                return khohang;
            }
        }
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void KhinsertBtn_Click(object sender, EventArgs e)
        {
           panel2.Enabled = true;
        }
    }
}
