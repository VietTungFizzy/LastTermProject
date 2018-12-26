using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHHO2NF;Initial Catalog=Coffee;Integrated Security=True");

        private void YearReport_Load(object sender, EventArgs e)
        {
           
            this.chartYearly.Series["Doanh thu theo tháng"].Points.AddXY("t6", 32424);
            this.chartYearly.Series["Doanh thu theo tháng"].Points.AddXY("t7", 54434);
            this.chartYearly.Series["Doanh thu theo tháng"].Points.AddXY("t8", 6567);
          
        }

        private void xemTKmonthlyBtn_Click(object sender, EventArgs e)
        {
            BCmonthly a = new BCmonthly();
            a.Show();
        }
    }
}
