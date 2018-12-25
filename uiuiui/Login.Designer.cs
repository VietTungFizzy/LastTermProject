namespace uiuiui
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pic_RedStripe = new System.Windows.Forms.PictureBox();
            this.pn_Bar = new System.Windows.Forms.Panel();
            this.imgb_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbl_Username = new System.Windows.Forms.Label();
            this.txt_Username = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pn_FormLogin = new System.Windows.Forms.Panel();
            this.but_Login = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_RedStripe)).BeginInit();
            this.pn_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgb_Exit)).BeginInit();
            this.pn_FormLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic_RedStripe
            // 
            this.pic_RedStripe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.pic_RedStripe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_RedStripe.BackgroundImage")));
            this.pic_RedStripe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pic_RedStripe.Location = new System.Drawing.Point(-7, -26);
            this.pic_RedStripe.Name = "pic_RedStripe";
            this.pic_RedStripe.Size = new System.Drawing.Size(553, 180);
            this.pic_RedStripe.TabIndex = 0;
            this.pic_RedStripe.TabStop = false;
            // 
            // pn_Bar
            // 
            this.pn_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(53)))), ((int)(((byte)(40)))));
            this.pn_Bar.Controls.Add(this.imgb_Exit);
            this.pn_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Bar.Location = new System.Drawing.Point(0, 0);
            this.pn_Bar.Name = "pn_Bar";
            this.pn_Bar.Size = new System.Drawing.Size(444, 30);
            this.pn_Bar.TabIndex = 4;
            // 
            // imgb_Exit
            // 
            this.imgb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("imgb_Exit.Image")));
            this.imgb_Exit.ImageActive = null;
            this.imgb_Exit.Location = new System.Drawing.Point(418, 5);
            this.imgb_Exit.Name = "imgb_Exit";
            this.imgb_Exit.Size = new System.Drawing.Size(21, 21);
            this.imgb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgb_Exit.TabIndex = 0;
            this.imgb_Exit.TabStop = false;
            this.imgb_Exit.Zoom = 10;
            this.imgb_Exit.Click += new System.EventHandler(this.imgb_Exit_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pn_Bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this;
            this.bunifuDragControl2.Vertical = true;
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.pic_RedStripe;
            this.bunifuDragControl3.Vertical = true;
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Black;
            this.lbl_Username.Location = new System.Drawing.Point(21, 16);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(66, 18);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Username";
            // 
            // txt_Username
            // 
            this.txt_Username.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Username.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Username.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Username.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.Gray;
            this.txt_Username.HintForeColor = System.Drawing.Color.Black;
            this.txt_Username.HintText = "";
            this.txt_Username.isPassword = false;
            this.txt_Username.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Username.LineIdleColor = System.Drawing.Color.Black;
            this.txt_Username.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(139)))), ((int)(((byte)(118)))));
            this.txt_Username.LineThickness = 2;
            this.txt_Username.Location = new System.Drawing.Point(22, 35);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(252, 35);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Black;
            this.lbl_Password.Location = new System.Drawing.Point(21, 84);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(61, 18);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // txt_Password
            // 
            this.txt_Password.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_Password.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_Password.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Password.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Gray;
            this.txt_Password.HintForeColor = System.Drawing.Color.Empty;
            this.txt_Password.HintText = "";
            this.txt_Password.isPassword = true;
            this.txt_Password.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_Password.LineIdleColor = System.Drawing.Color.Black;
            this.txt_Password.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(139)))), ((int)(((byte)(118)))));
            this.txt_Password.LineThickness = 2;
            this.txt_Password.Location = new System.Drawing.Point(21, 103);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(252, 33);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // pn_FormLogin
            // 
            this.pn_FormLogin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pn_FormLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_FormLogin.Controls.Add(this.txt_Password);
            this.pn_FormLogin.Controls.Add(this.lbl_Password);
            this.pn_FormLogin.Controls.Add(this.txt_Username);
            this.pn_FormLogin.Controls.Add(this.lbl_Username);
            this.pn_FormLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(56)))), ((int)(((byte)(44)))));
            this.pn_FormLogin.Location = new System.Drawing.Point(73, 125);
            this.pn_FormLogin.Name = "pn_FormLogin";
            this.pn_FormLogin.Size = new System.Drawing.Size(295, 169);
            this.pn_FormLogin.TabIndex = 1;
            // 
            // but_Login
            // 
            this.but_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(40)))), ((int)(((byte)(48)))));
            this.but_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.but_Login.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_Login.ForeColor = System.Drawing.Color.Black;
            this.but_Login.Location = new System.Drawing.Point(168, 284);
            this.but_Login.Name = "but_Login";
            this.but_Login.Padding = new System.Windows.Forms.Padding(2);
            this.but_Login.Size = new System.Drawing.Size(99, 37);
            this.but_Login.TabIndex = 2;
            this.but_Login.Text = "Login";
            this.but_Login.UseVisualStyleBackColor = false;
            this.but_Login.Click += new System.EventHandler(this.but_Login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(53)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(444, 343);
            this.Controls.Add(this.pn_Bar);
            this.Controls.Add(this.but_Login);
            this.Controls.Add(this.pn_FormLogin);
            this.Controls.Add(this.pic_RedStripe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_RedStripe)).EndInit();
            this.pn_Bar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgb_Exit)).EndInit();
            this.pn_FormLogin.ResumeLayout(false);
            this.pn_FormLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_RedStripe;
        private System.Windows.Forms.Panel pn_Bar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton imgb_Exit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Button but_Login;
        private System.Windows.Forms.Panel pn_FormLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Password;
        private System.Windows.Forms.Label lbl_Password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_Username;
        private System.Windows.Forms.Label lbl_Username;
    }
}

