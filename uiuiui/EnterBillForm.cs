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
    public partial class EnterBillForm : Form
    {
        public EnterBillForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void imgb_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SoTienNhan = Int32.Parse(tbNhantien.Text);
            int Tongtien = Int32.Parse(tongtienLbl.Text);
            int a = SoTienNhan - Tongtien;
            lbTienThua.Text = a.ToString();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Phin Sua");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            
            switch(dataGridView1.Rows[index].Cells[0].Value)
            {
                case "Phin Sua":
                    dataGridView1.Rows[index].Cells[3].Value = 59000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp = Convert.ToInt32(tongtienLbl.Text);
                    temp += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp.ToString();
                    break;
                case "Phin Den":
                    dataGridView1.Rows[index].Cells[3].Value = 59000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp1 = Convert.ToInt32(tongtienLbl.Text);
                    temp1 += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp1.ToString();
                    break;
                case "Mocha":
                    dataGridView1.Rows[index].Cells[3].Value = 59000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp2 = Convert.ToInt32(tongtienLbl.Text);
                    temp2 += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp2.ToString();
                    break;
                case "Latte":
                    dataGridView1.Rows[index].Cells[3].Value = 59000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp3 = Convert.ToInt32(tongtienLbl.Text);
                    temp3 += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp3.ToString();
                    break;
                case "Caramel Macchiato":
                    dataGridView1.Rows[index].Cells[3].Value = 89000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp4 = Convert.ToInt32(tongtienLbl.Text);
                    temp4 += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp4.ToString();
                    break;
                case "Cappuccino":
                    dataGridView1.Rows[index].Cells[3].Value = 79000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp5 = Convert.ToInt32(tongtienLbl.Text);
                    temp5 += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp5.ToString();
                    break;
                case "Espresso":
                    dataGridView1.Rows[index].Cells[3].Value = 69000 * Convert.ToInt32(dataGridView1.Rows[index].Cells[2].Value);
                    int temp6 = Convert.ToInt32(tongtienLbl.Text);
                    temp6 += Convert.ToInt32(dataGridView1.Rows[index].Cells[3].Value);
                    tongtienLbl.Text = temp6.ToString();
                    break;
            }
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Phin Den");
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Mocha");
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Latte");
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Caramel Macchiato");
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Cappuccino");
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("Expresso");
        }
    }
}
