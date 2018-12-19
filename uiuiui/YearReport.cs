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

    public partial class YearReport : UserControl
    {
        private static YearReport baocaonam;
        public static YearReport Baocaonam
        {
            get
            {
                if (baocaonam == null)
                    baocaonam = new YearReport();
                return baocaonam;
            }
        }
        public YearReport()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
