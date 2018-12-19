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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text=="Tìm kiếm")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tìm kiếm";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /* private void Form3_Shown(object sender, EventArgs e)
 {

     bunifuVScrollBar1.Maximum = 231;
     bunifuVScrollBar1.ThumbLength = 50;

 */
    }
}
