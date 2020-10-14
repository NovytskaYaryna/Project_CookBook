namespace CookBook.Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loginTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.minBtn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitBtn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.loginBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.regBtn = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.label1.Location = new System.Drawing.Point(145, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 53);
            this.label1.TabIndex = 32;
            this.label1.Text = "Вхід";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label7.Location = new System.Drawing.Point(58, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 57;
            this.label7.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label5.Location = new System.Drawing.Point(58, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Логін:";
            // 
            // passwordTB
            // 
            this.passwordTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.passwordTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.passwordTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.passwordTB.BorderThickness = 3;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.passwordTB.isPassword = true;
            this.passwordTB.Location = new System.Drawing.Point(63, 278);
            this.passwordTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(271, 49);
            this.passwordTB.TabIndex = 55;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginTB
            // 
            this.loginTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.loginTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.loginTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.loginTB.BorderThickness = 3;
            this.loginTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.loginTB.isPassword = false;
            this.loginTB.Location = new System.Drawing.Point(63, 181);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(271, 49);
            this.loginTB.TabIndex = 54;
            this.loginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // minBtn
            // 
            this.minBtn.AutoSize = true;
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.minBtn.Location = new System.Drawing.Point(344, 9);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(17, 19);
            this.minBtn.TabIndex = 59;
            this.minBtn.Text = "_";
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.exitBtn.Location = new System.Drawing.Point(365, 11);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(20, 19);
            this.exitBtn.TabIndex = 58;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.ActiveBorderThickness = 1;
            this.loginBtn.ActiveCornerRadius = 20;
            this.loginBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.loginBtn.ActiveForecolor = System.Drawing.Color.White;
            this.loginBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.loginBtn.BackColor = System.Drawing.SystemColors.Window;
            this.loginBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBtn.BackgroundImage")));
            this.loginBtn.ButtonText = "Ввійти";
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginBtn.IdleBorderThickness = 1;
            this.loginBtn.IdleCornerRadius = 20;
            this.loginBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.loginBtn.IdleForecolor = System.Drawing.Color.White;
            this.loginBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.loginBtn.Location = new System.Drawing.Point(100, 351);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(196, 59);
            this.loginBtn.TabIndex = 60;
            this.loginBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // regBtn
            // 
            this.regBtn.AutoSize = true;
            this.regBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regBtn.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.regBtn.Location = new System.Drawing.Point(108, 408);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(180, 29);
            this.regBtn.TabIndex = 61;
            this.regBtn.Text = "Зареєструватися";
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(396, 522);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Text", 13F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMetroTextbox passwordTB;
        private Bunifu.Framework.UI.BunifuMetroTextbox loginTB;
        private Bunifu.Framework.UI.BunifuCustomLabel minBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel exitBtn;
        private System.Windows.Forms.Label regBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}