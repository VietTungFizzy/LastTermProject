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
    public partial class ProductManagement : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GHHO2NF;Initial Catalog=Coffee;Integrated Security=True");
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
        private void load_data()
        {
            string query = " select * from PRODUCTS";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            conn.Close();
          
        }

        private void KhinsertBtn_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string query = "insert into PRODUCTS (MASP,TENSP,GIA,DANHMUC)values('" + tbmaSP.Text + "','" + tbTenSP.Text + "','" + tbgiaSP.Text + "','" + comboBox1.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            load_data();
        }

        private void KhupdateBtn_Click(object sender, EventArgs e)
        {
           
            string query = "update PRODUCTS set TENSP='" + tbTenSP.Text + "',GIA='" + tbgiaSP.Text + "',DANHMUC='" + comboBox1.Text + "'where  MSNV='" + tbmaSP.Text + "' ";
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            load_data();
        }

        private void KHdeleteBtn_Click(object sender, EventArgs e)
        {
            string query = "delete from PRODUCTS where MASP='" + tbmaSP.Text + "'";
            conn.Open();
            SqlDataAdapter sda  = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            load_data();
        }


        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tbmaSP.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbTenSP.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbgiaSP.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void ProductManagement_Load(object sender, EventArgs e)
        {
            load_data();
        }
    }
}
