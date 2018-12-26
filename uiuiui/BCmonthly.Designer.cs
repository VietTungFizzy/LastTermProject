namespace uiuiui
{
    partial class BCmonthly
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BCmonthly));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgb_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nEWDataSet = new uiuiui.NEWDataSet();
            this.mONTHLYDRINKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeDataSet = new uiuiui.CoffeeDataSet();
            this.bILLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bILLTableAdapter = new uiuiui.CoffeeDataSetTableAdapters.BILLTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHLYDRINKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.panel1.Controls.Add(this.imgb_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 37);
            this.panel1.TabIndex = 0;
            // 
            // imgb_Exit
            // 
            this.imgb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("imgb_Exit.Image")));
            this.imgb_Exit.ImageActive = null;
            this.imgb_Exit.Location = new System.Drawing.Point(851, 5);
            this.imgb_Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imgb_Exit.Name = "imgb_Exit";
            this.imgb_Exit.Size = new System.Drawing.Size(28, 26);
            this.imgb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgb_Exit.TabIndex = 2;
            this.imgb_Exit.TabStop = false;
            this.imgb_Exit.Zoom = 10;
            this.imgb_Exit.Click += new System.EventHandler(this.imgb_Exit_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.bILLBindingSource;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(16, 59);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.XValueMember = "TENSP";
            series1.YValueMembers = "TIMESSOLD";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(851, 506);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // nEWDataSet
            // 
            this.nEWDataSet.DataSetName = "NEWDataSet";
            this.nEWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONTHLYDRINKSBindingSource
            // 
            this.mONTHLYDRINKSBindingSource.DataMember = "MONTHLY.DRINKS";
            this.mONTHLYDRINKSBindingSource.DataSource = this.nEWDataSet;
            // 
            // coffeeDataSet
            // 
            this.coffeeDataSet.DataSetName = "CoffeeDataSet";
            this.coffeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bILLBindingSource
            // 
            this.bILLBindingSource.DataMember = "BILL";
            this.bILLBindingSource.DataSource = this.coffeeDataSet;
            // 
            // bILLTableAdapter
            // 
            this.bILLTableAdapter.ClearBeforeFill = true;
            // 
            // BCmonthly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 580);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "BCmonthly";
            this.Text = "BCmonthly";
            this.Load += new System.EventHandler(this.BCmonthly_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nEWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTHLYDRINKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bILLBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton imgb_Exit;
        private System.Windows.Forms.BindingSource mONTHLYDRINKSBindingSource;
        private NEWDataSet nEWDataSet;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private CoffeeDataSet coffeeDataSet;
        private System.Windows.Forms.BindingSource bILLBindingSource;
        private CoffeeDataSetTableAdapters.BILLTableAdapter bILLTableAdapter;
    }
}