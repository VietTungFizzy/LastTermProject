namespace uiuiui
{
    partial class ProductManagement
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.KHdeleteBtn = new System.Windows.Forms.Button();
            this.KhupdateBtn = new System.Windows.Forms.Button();
            this.KhinsertBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbgiaSP = new System.Windows.Forms.TextBox();
            this.tbmaSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.KHdeleteBtn);
            this.panel1.Controls.Add(this.KhupdateBtn);
            this.panel1.Controls.Add(this.KhinsertBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 50);
            this.panel1.TabIndex = 0;
            // 
            // KHdeleteBtn
            // 
            this.KHdeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KHdeleteBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KHdeleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.KHdeleteBtn.Location = new System.Drawing.Point(507, 9);
            this.KHdeleteBtn.Name = "KHdeleteBtn";
            this.KHdeleteBtn.Size = new System.Drawing.Size(236, 31);
            this.KHdeleteBtn.TabIndex = 2;
            this.KHdeleteBtn.Text = "Xóa SP";
            this.KHdeleteBtn.UseVisualStyleBackColor = true;
            this.KHdeleteBtn.Click += new System.EventHandler(this.KHdeleteBtn_Click);
            // 
            // KhupdateBtn
            // 
            this.KhupdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhupdateBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhupdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.KhupdateBtn.Location = new System.Drawing.Point(250, 9);
            this.KhupdateBtn.Name = "KhupdateBtn";
            this.KhupdateBtn.Size = new System.Drawing.Size(251, 31);
            this.KhupdateBtn.TabIndex = 1;
            this.KhupdateBtn.Text = "Edit SP";
            this.KhupdateBtn.UseVisualStyleBackColor = true;
            this.KhupdateBtn.Click += new System.EventHandler(this.KhupdateBtn_Click);
            // 
            // KhinsertBtn
            // 
            this.KhinsertBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KhinsertBtn.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KhinsertBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.KhinsertBtn.Location = new System.Drawing.Point(16, 9);
            this.KhinsertBtn.Name = "KhinsertBtn";
            this.KhinsertBtn.Size = new System.Drawing.Size(228, 31);
            this.KhinsertBtn.TabIndex = 0;
            this.KhinsertBtn.Text = "Thêm SP";
            this.KhinsertBtn.UseVisualStyleBackColor = true;
            this.KhinsertBtn.Click += new System.EventHandler(this.KhinsertBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.tbTenSP);
            this.panel2.Controls.Add(this.tbgiaSP);
            this.panel2.Controls.Add(this.tbmaSP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 91);
            this.panel2.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "CF Traditional",
            "CF Expresso"});
            this.comboBox1.Location = new System.Drawing.Point(174, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 26);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.Text = "CF Traditional";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenSP.Location = new System.Drawing.Point(174, 19);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(183, 21);
            this.tbTenSP.TabIndex = 0;
            // 
            // tbgiaSP
            // 
            this.tbgiaSP.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgiaSP.Location = new System.Drawing.Point(521, 19);
            this.tbgiaSP.Name = "tbgiaSP";
            this.tbgiaSP.Size = new System.Drawing.Size(183, 21);
            this.tbgiaSP.TabIndex = 7;
            // 
            // tbmaSP
            // 
            this.tbmaSP.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmaSP.Location = new System.Drawing.Point(521, 51);
            this.tbmaSP.Name = "tbmaSP";
            this.tbmaSP.Size = new System.Drawing.Size(183, 21);
            this.tbmaSP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11F);
            this.label4.Location = new System.Drawing.Point(421, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giá SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên SP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh mục SP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã SP";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 141);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(760, 287);
            this.panel3.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.dataGridView1.Location = new System.Drawing.Point(17, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(727, 264);
            this.dataGridView1.TabIndex = 0;
 
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ProductManagement";
            this.Size = new System.Drawing.Size(760, 428);
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button KhinsertBtn;
        private System.Windows.Forms.Button KHdeleteBtn;
        private System.Windows.Forms.Button KhupdateBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbgiaSP;
        private System.Windows.Forms.TextBox tbmaSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
