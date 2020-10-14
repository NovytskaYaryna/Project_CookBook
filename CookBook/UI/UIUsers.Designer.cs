namespace CookBook.UI
{
    partial class UIUsers
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIUsers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.surnameTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.nameTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.ageTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.loginTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.oldPasswordTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.newPasswordTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chgBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.UsersDG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDG)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(696, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 53);
            this.label1.TabIndex = 31;
            this.label1.Text = "Змінити власні дані";
            // 
            // surnameTB
            // 
            this.surnameTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.surnameTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.surnameTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.surnameTB.BorderThickness = 3;
            this.surnameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.surnameTB.isPassword = false;
            this.surnameTB.Location = new System.Drawing.Point(653, 132);
            this.surnameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnameTB.Name = "surnameTB";
            this.surnameTB.Size = new System.Drawing.Size(212, 49);
            this.surnameTB.TabIndex = 42;
            this.surnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // nameTB
            // 
            this.nameTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.nameTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.nameTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.nameTB.BorderThickness = 3;
            this.nameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.nameTB.isPassword = false;
            this.nameTB.Location = new System.Drawing.Point(922, 132);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(212, 49);
            this.nameTB.TabIndex = 43;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ageTB
            // 
            this.ageTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.ageTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.ageTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.ageTB.BorderThickness = 3;
            this.ageTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ageTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.ageTB.isPassword = false;
            this.ageTB.Location = new System.Drawing.Point(653, 223);
            this.ageTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ageTB.Name = "ageTB";
            this.ageTB.Size = new System.Drawing.Size(212, 49);
            this.ageTB.TabIndex = 44;
            this.ageTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.loginTB.Location = new System.Drawing.Point(922, 223);
            this.loginTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(212, 49);
            this.loginTB.TabIndex = 45;
            this.loginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // oldPasswordTB
            // 
            this.oldPasswordTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.oldPasswordTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.oldPasswordTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.oldPasswordTB.BorderThickness = 3;
            this.oldPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.oldPasswordTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oldPasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.oldPasswordTB.isPassword = false;
            this.oldPasswordTB.Location = new System.Drawing.Point(653, 314);
            this.oldPasswordTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.oldPasswordTB.Name = "oldPasswordTB";
            this.oldPasswordTB.Size = new System.Drawing.Size(212, 49);
            this.oldPasswordTB.TabIndex = 46;
            this.oldPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // newPasswordTB
            // 
            this.newPasswordTB.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.newPasswordTB.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.newPasswordTB.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.newPasswordTB.BorderThickness = 3;
            this.newPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.newPasswordTB.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newPasswordTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.newPasswordTB.isPassword = false;
            this.newPasswordTB.Location = new System.Drawing.Point(922, 314);
            this.newPasswordTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.newPasswordTB.Name = "newPasswordTB";
            this.newPasswordTB.Size = new System.Drawing.Size(212, 49);
            this.newPasswordTB.TabIndex = 47;
            this.newPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label2.Location = new System.Drawing.Point(648, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "Прізвище:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label3.Location = new System.Drawing.Point(917, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 29);
            this.label3.TabIndex = 49;
            this.label3.Text = "Ім\'я:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label4.Location = new System.Drawing.Point(648, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 29);
            this.label4.TabIndex = 50;
            this.label4.Text = "Вік:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label5.Location = new System.Drawing.Point(917, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Логін:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label6.Location = new System.Drawing.Point(648, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Старий пароль:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label7.Location = new System.Drawing.Point(917, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 29);
            this.label7.TabIndex = 53;
            this.label7.Text = "Новий пароль:";
            // 
            // chgBtn
            // 
            this.chgBtn.ActiveBorderThickness = 1;
            this.chgBtn.ActiveCornerRadius = 20;
            this.chgBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.chgBtn.ActiveForecolor = System.Drawing.Color.White;
            this.chgBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.chgBtn.BackColor = System.Drawing.SystemColors.Window;
            this.chgBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chgBtn.BackgroundImage")));
            this.chgBtn.ButtonText = "Змінити дані";
            this.chgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chgBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgBtn.IdleBorderThickness = 1;
            this.chgBtn.IdleCornerRadius = 20;
            this.chgBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.chgBtn.IdleForecolor = System.Drawing.Color.White;
            this.chgBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.chgBtn.Location = new System.Drawing.Point(796, 373);
            this.chgBtn.Margin = new System.Windows.Forms.Padding(5);
            this.chgBtn.Name = "chgBtn";
            this.chgBtn.Size = new System.Drawing.Size(196, 59);
            this.chgBtn.TabIndex = 54;
            this.chgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chgBtn.Click += new System.EventHandler(this.chgBtn_Click);
            // 
            // UsersDG
            // 
            this.UsersDG.AllowUserToAddRows = false;
            this.UsersDG.AllowUserToDeleteRows = false;
            this.UsersDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.UsersDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UsersDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersDG.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.UsersDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsersDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.UsersDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UsersDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDG.DoubleBuffered = true;
            this.UsersDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.UsersDG.EnableHeadersVisualStyles = false;
            this.UsersDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.UsersDG.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.UsersDG.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.UsersDG.Location = new System.Drawing.Point(25, 23);
            this.UsersDG.Name = "UsersDG";
            this.UsersDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UsersDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.UsersDG.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.UsersDG.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersDG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.UsersDG.RowTemplate.DividerHeight = 1;
            this.UsersDG.RowTemplate.Height = 25;
            this.UsersDG.RowTemplate.ReadOnly = true;
            this.UsersDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UsersDG.Size = new System.Drawing.Size(578, 433);
            this.UsersDG.TabIndex = 29;
            // 
            // UIUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.chgBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newPasswordTB);
            this.Controls.Add(this.oldPasswordTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.ageTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.surnameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UsersDG);
            this.Font = new System.Drawing.Font("Sitka Text", 13F);
            this.Name = "UIUsers";
            this.Size = new System.Drawing.Size(1220, 487);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox surnameTB;
        private Bunifu.Framework.UI.BunifuThinButton2 chgBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox newPasswordTB;
        private Bunifu.Framework.UI.BunifuMetroTextbox oldPasswordTB;
        private Bunifu.Framework.UI.BunifuMetroTextbox loginTB;
        private Bunifu.Framework.UI.BunifuMetroTextbox ageTB;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameTB;
        private Bunifu.Framework.UI.BunifuCustomDataGrid UsersDG;
    }
}
