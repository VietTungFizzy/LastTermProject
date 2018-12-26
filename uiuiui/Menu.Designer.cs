namespace uiuiui
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.toptab = new System.Windows.Forms.Panel();
            this.imgb_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.qlnvBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.slideoptions = new System.Windows.Forms.Panel();
            this.slider = new System.Windows.Forms.PictureBox();
            this.bcnBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.qlspBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.toptab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgb_Exit)).BeginInit();
            this.slideoptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider)).BeginInit();
            this.SuspendLayout();
            // 
            // toptab
            // 
            this.toptab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.toptab.Controls.Add(this.imgb_Exit);
            this.toptab.Dock = System.Windows.Forms.DockStyle.Top;
            this.toptab.Location = new System.Drawing.Point(0, 0);
            this.toptab.Name = "toptab";
            this.toptab.Size = new System.Drawing.Size(760, 30);
            this.toptab.TabIndex = 0;
            // 
            // imgb_Exit
            // 
            this.imgb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("imgb_Exit.Image")));
            this.imgb_Exit.ImageActive = null;
            this.imgb_Exit.Location = new System.Drawing.Point(734, 4);
            this.imgb_Exit.Name = "imgb_Exit";
            this.imgb_Exit.Size = new System.Drawing.Size(21, 21);
            this.imgb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgb_Exit.TabIndex = 1;
            this.imgb_Exit.TabStop = false;
            this.imgb_Exit.Zoom = 10;
            this.imgb_Exit.Click += new System.EventHandler(this.imgb_Exit_Click);
            // 
            // qlnvBtn
            // 
            this.qlnvBtn.Active = false;
            this.qlnvBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.qlnvBtn.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.qlnvBtn.BackColor = System.Drawing.Color.Transparent;
            this.qlnvBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.qlnvBtn.BorderRadius = 0;
            this.qlnvBtn.ButtonText = "QLNV";
            this.qlnvBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qlnvBtn.DisabledColor = System.Drawing.Color.Transparent;
            this.qlnvBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlnvBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.qlnvBtn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.qlnvBtn.Iconimage = null;
            this.qlnvBtn.Iconimage_right = null;
            this.qlnvBtn.Iconimage_right_Selected = null;
            this.qlnvBtn.Iconimage_Selected = null;
            this.qlnvBtn.IconMarginLeft = 0;
            this.qlnvBtn.IconMarginRight = 0;
            this.qlnvBtn.IconRightVisible = true;
            this.qlnvBtn.IconRightZoom = 0D;
            this.qlnvBtn.IconVisible = true;
            this.qlnvBtn.IconZoom = 90D;
            this.qlnvBtn.IsTab = false;
            this.qlnvBtn.Location = new System.Drawing.Point(3, 7);
            this.qlnvBtn.Margin = new System.Windows.Forms.Padding(4);
            this.qlnvBtn.Name = "qlnvBtn";
            this.qlnvBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.qlnvBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.qlnvBtn.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qlnvBtn.selected = false;
            this.qlnvBtn.Size = new System.Drawing.Size(149, 36);
            this.qlnvBtn.TabIndex = 1;
            this.qlnvBtn.Text = "QLNV";
            this.qlnvBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qlnvBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.qlnvBtn.TextFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlnvBtn.Click += new System.EventHandler(this.qlnvBtn_Click);
            // 
            // slideoptions
            // 
            this.slideoptions.BackColor = System.Drawing.Color.WhiteSmoke;
            this.slideoptions.Controls.Add(this.slider);
            this.slideoptions.Controls.Add(this.bcnBtn);
            this.slideoptions.Controls.Add(this.qlspBtn);
            this.slideoptions.Controls.Add(this.qlnvBtn);
            this.slideoptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.slideoptions.Location = new System.Drawing.Point(0, 30);
            this.slideoptions.Name = "slideoptions";
            this.slideoptions.Size = new System.Drawing.Size(760, 50);
            this.slideoptions.TabIndex = 2;
            // 
            // slider
            // 
            this.slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.slider.Location = new System.Drawing.Point(-2, 43);
            this.slider.Name = "slider";
            this.slider.Size = new System.Drawing.Size(151, 4);
            this.slider.TabIndex = 2;
            this.slider.TabStop = false;
            // 
            // bcnBtn
            // 
            this.bcnBtn.Active = false;
            this.bcnBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.bcnBtn.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.bcnBtn.BackColor = System.Drawing.Color.Transparent;
            this.bcnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bcnBtn.BorderRadius = 0;
            this.bcnBtn.ButtonText = "BCN";
            this.bcnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bcnBtn.DisabledColor = System.Drawing.Color.Transparent;
            this.bcnBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcnBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.bcnBtn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.bcnBtn.Iconimage = null;
            this.bcnBtn.Iconimage_right = null;
            this.bcnBtn.Iconimage_right_Selected = null;
            this.bcnBtn.Iconimage_Selected = null;
            this.bcnBtn.IconMarginLeft = 0;
            this.bcnBtn.IconMarginRight = 0;
            this.bcnBtn.IconRightVisible = true;
            this.bcnBtn.IconRightZoom = 0D;
            this.bcnBtn.IconVisible = true;
            this.bcnBtn.IconZoom = 90D;
            this.bcnBtn.IsTab = false;
            this.bcnBtn.Location = new System.Drawing.Point(316, 7);
            this.bcnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bcnBtn.Name = "bcnBtn";
            this.bcnBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.bcnBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.bcnBtn.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bcnBtn.selected = false;
            this.bcnBtn.Size = new System.Drawing.Size(149, 36);
            this.bcnBtn.TabIndex = 4;
            this.bcnBtn.Text = "BCN";
            this.bcnBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bcnBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.bcnBtn.TextFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bcnBtn.Click += new System.EventHandler(this.bcnBtn_Click);
            // 
            // qlspBtn
            // 
            this.qlspBtn.Active = false;
            this.qlspBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.qlspBtn.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.qlspBtn.BackColor = System.Drawing.Color.Transparent;
            this.qlspBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.qlspBtn.BorderRadius = 0;
            this.qlspBtn.ButtonText = "QLSP";
            this.qlspBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.qlspBtn.DisabledColor = System.Drawing.Color.Transparent;
            this.qlspBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlspBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.qlspBtn.Iconcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.qlspBtn.Iconimage = null;
            this.qlspBtn.Iconimage_right = null;
            this.qlspBtn.Iconimage_right_Selected = null;
            this.qlspBtn.Iconimage_Selected = null;
            this.qlspBtn.IconMarginLeft = 0;
            this.qlspBtn.IconMarginRight = 0;
            this.qlspBtn.IconRightVisible = true;
            this.qlspBtn.IconRightZoom = 0D;
            this.qlspBtn.IconVisible = true;
            this.qlspBtn.IconZoom = 90D;
            this.qlspBtn.IsTab = false;
            this.qlspBtn.Location = new System.Drawing.Point(159, 7);
            this.qlspBtn.Margin = new System.Windows.Forms.Padding(4);
            this.qlspBtn.Name = "qlspBtn";
            this.qlspBtn.Normalcolor = System.Drawing.Color.Transparent;
            this.qlspBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.qlspBtn.OnHoverTextColor = System.Drawing.SystemColors.ButtonHighlight;
            this.qlspBtn.selected = false;
            this.qlspBtn.Size = new System.Drawing.Size(149, 36);
            this.qlspBtn.TabIndex = 3;
            this.qlspBtn.Text = "QLSP";
            this.qlspBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.qlspBtn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(8)))), ((int)(((byte)(20)))));
            this.qlspBtn.TextFont = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qlspBtn.Click += new System.EventHandler(this.qlkhBtn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.toptab;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 443);
            this.panel1.TabIndex = 3;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(760, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.slideoptions);
            this.Controls.Add(this.toptab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.toptab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgb_Exit)).EndInit();
            this.slideoptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.slider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toptab;
        private Bunifu.Framework.UI.BunifuFlatButton qlnvBtn;
        private System.Windows.Forms.Panel slideoptions;
        private System.Windows.Forms.PictureBox slider;
        private Bunifu.Framework.UI.BunifuFlatButton bcnBtn;
        private Bunifu.Framework.UI.BunifuFlatButton qlspBtn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuImageButton imgb_Exit;
    }
}