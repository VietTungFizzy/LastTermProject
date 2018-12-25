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
    public partial class EmployeeManagement : UserControl
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FBKFN4T\SQLEXPRESS;Initial Catalog=NEW;Integrated Security=True");
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
        private void load_data()
        {
            string query = " select * from EMPLOYEE";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;
            conn.Close();

        }
        private void KhupdateBtn_Click(object sender, EventArgs e)
        {
            string query = "update EMPLOYEE set HOTENN='" + tbtennv.Text + "',CMND='" + tbcmnd.Text + "',GIOITINH'" + comboBoxsex.Text + "',SDT='" + tbsdt.Text + "',LUONG'" + tbluong.Text + "',CALV='" + comboBoxcalv.Text + "',CHUCVU='" + comboBoxvitri.Text + "' where MANV='"+tbmanv.Text+"'";
            conn.Open();
            SqlDataAdapter SDA = new SqlDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            load_data();
        }

        private void KhinsertBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "insert into EMPLOYEE (MANV,HOTEN,CMND,GIOITINH,SDT,LUONG,CALV, CHUCVU)values('" + tbmanv.Text + "','" + tbtennv.Text + "','" + tbcmnd.Text + "','" + comboBoxsex.Text + "','" + tbsdt.Text + "','" + tbluong.Text + "',,'" + comboBoxcalv.Text + "','" + comboBoxvitri.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            load_data();
        }
        
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            tbmanv.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tbtennv.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            tbcmnd.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBoxsex.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            tbsdt.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            tbluong.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            comboBoxcalv.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBoxvitri.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void KHdeleteBtn_Click(object sender, EventArgs e)
        {
            string query = "delete from EMPLOYEE where MANV='" + tbmanv.Text + "'";
            conn.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            sda.SelectCommand.ExecuteNonQuery();
            conn.Close();
            load_data();
        }
    }
}
