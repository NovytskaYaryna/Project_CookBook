namespace CookBook
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.minBtn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.exitBtn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnHeader = new System.Windows.Forms.Panel();
            this.extBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.usersBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.recipesBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.mainPanel = new System.Windows.Forms.Panel();
            this.bunifuTransition2 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.minBtn);
            this.headerPanel.Controls.Add(this.exitBtn);
            this.headerPanel.Controls.Add(this.btnHeader);
            this.headerPanel.Controls.Add(this.extBtn);
            this.headerPanel.Controls.Add(this.usersBtn);
            this.headerPanel.Controls.Add(this.recipesBtn);
            this.bunifuTransition2.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.headerPanel, BunifuAnimatorNS.DecorationType.None);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1220, 113);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.headerpanel_MouseUp);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 182);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // minBtn
            // 
            this.minBtn.AutoSize = true;
            this.minBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.minBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.minBtn, BunifuAnimatorNS.DecorationType.None);
            this.minBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.minBtn.Location = new System.Drawing.Point(1167, 7);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(17, 19);
            this.minBtn.TabIndex = 7;
            this.minBtn.Text = "_";
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.exitBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this.exitBtn, BunifuAnimatorNS.DecorationType.None);
            this.exitBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.exitBtn.Location = new System.Drawing.Point(1188, 9);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(20, 19);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // btnHeader
            // 
            this.btnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.bunifuTransition2.SetDecoration(this.btnHeader, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.btnHeader, BunifuAnimatorNS.DecorationType.None);
            this.btnHeader.Location = new System.Drawing.Point(251, 103);
            this.btnHeader.Name = "btnHeader";
            this.btnHeader.Size = new System.Drawing.Size(196, 5);
            this.btnHeader.TabIndex = 4;
            // 
            // extBtn
            // 
            this.extBtn.ActiveBorderThickness = 1;
            this.extBtn.ActiveCornerRadius = 2;
            this.extBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.extBtn.ActiveForecolor = System.Drawing.Color.White;
            this.extBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.extBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.extBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extBtn.BackgroundImage")));
            this.extBtn.ButtonText = "Вийти";
            this.extBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.extBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.extBtn, BunifuAnimatorNS.DecorationType.None);
            this.extBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.extBtn.IdleBorderThickness = 1;
            this.extBtn.IdleCornerRadius = 2;
            this.extBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.extBtn.IdleForecolor = System.Drawing.Color.White;
            this.extBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.extBtn.Location = new System.Drawing.Point(1024, 57);
            this.extBtn.Margin = new System.Windows.Forms.Padding(5);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(196, 59);
            this.extBtn.TabIndex = 3;
            this.extBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.extBtn.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // usersBtn
            // 
            this.usersBtn.ActiveBorderThickness = 1;
            this.usersBtn.ActiveCornerRadius = 2;
            this.usersBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.usersBtn.ActiveForecolor = System.Drawing.Color.White;
            this.usersBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.usersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.usersBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("usersBtn.BackgroundImage")));
            this.usersBtn.ButtonText = "Користувачі";
            this.usersBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.usersBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.usersBtn, BunifuAnimatorNS.DecorationType.None);
            this.usersBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.usersBtn.IdleBorderThickness = 1;
            this.usersBtn.IdleCornerRadius = 2;
            this.usersBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.usersBtn.IdleForecolor = System.Drawing.Color.White;
            this.usersBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.usersBtn.Location = new System.Drawing.Point(455, 57);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(5);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(196, 59);
            this.usersBtn.TabIndex = 2;
            this.usersBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.usersBtn.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // recipesBtn
            // 
            this.recipesBtn.ActiveBorderThickness = 1;
            this.recipesBtn.ActiveCornerRadius = 2;
            this.recipesBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.recipesBtn.ActiveForecolor = System.Drawing.Color.White;
            this.recipesBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.recipesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.recipesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("recipesBtn.BackgroundImage")));
            this.recipesBtn.ButtonText = "Рецепти";
            this.recipesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition2.SetDecoration(this.recipesBtn, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.recipesBtn, BunifuAnimatorNS.DecorationType.None);
            this.recipesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipesBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.recipesBtn.IdleBorderThickness = 1;
            this.recipesBtn.IdleCornerRadius = 2;
            this.recipesBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.recipesBtn.IdleForecolor = System.Drawing.Color.White;
            this.recipesBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.recipesBtn.Location = new System.Drawing.Point(249, 57);
            this.recipesBtn.Margin = new System.Windows.Forms.Padding(5);
            this.recipesBtn.Name = "recipesBtn";
            this.recipesBtn.Size = new System.Drawing.Size(196, 59);
            this.recipesBtn.TabIndex = 1;
            this.recipesBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recipesBtn.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // mainPanel
            // 
            this.bunifuTransition2.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition1.SetDecoration(this.mainPanel, BunifuAnimatorNS.DecorationType.None);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 113);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1220, 487);
            this.mainPanel.TabIndex = 1;
            // 
            // bunifuTransition2
            // 
            this.bunifuTransition2.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition2.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.bunifuTransition2.DefaultAnimation = animation2;
            this.bunifuTransition2.MaxAnimationTime = 1000;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1220, 600);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTransition2.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 recipesBtn;
        private System.Windows.Forms.Panel btnHeader;
        private Bunifu.Framework.UI.BunifuThinButton2 extBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 usersBtn;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition2;
        private Bunifu.Framework.UI.BunifuCustomLabel minBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel exitBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel mainPanel;
    }
}

