namespace CookBook.UI
{
    partial class UIRecipes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIRecipes));
            this.RecipesDG = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMetroTextbox1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.recipyTB = new System.Windows.Forms.TextBox();
            this.categoriesCB = new System.Windows.Forms.ComboBox();
            this.levelCB = new System.Windows.Forms.ComboBox();
            this.addBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.chgBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.delBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.addCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label6 = new System.Windows.Forms.Label();
            this.userCB = new System.Windows.Forms.ComboBox();
            this.searchBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.exportBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label7 = new System.Windows.Forms.Label();
            this.resipySearch = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.RecipesDG)).BeginInit();
            this.SuspendLayout();
            // 
            // RecipesDG
            // 
            this.RecipesDG.AllowUserToAddRows = false;
            this.RecipesDG.AllowUserToDeleteRows = false;
            this.RecipesDG.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            this.RecipesDG.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.RecipesDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecipesDG.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.RecipesDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecipesDG.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.RecipesDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Text", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipesDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.RecipesDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecipesDG.DoubleBuffered = true;
            this.RecipesDG.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.RecipesDG.EnableHeadersVisualStyles = false;
            this.RecipesDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.RecipesDG.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.RecipesDG.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.RecipesDG.Location = new System.Drawing.Point(14, 54);
            this.RecipesDG.Name = "RecipesDG";
            this.RecipesDG.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Text", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecipesDG.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.RecipesDG.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.RecipesDG.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecipesDG.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(43)))), ((int)(((byte)(60)))));
            this.RecipesDG.RowTemplate.DividerHeight = 1;
            this.RecipesDG.RowTemplate.Height = 25;
            this.RecipesDG.RowTemplate.ReadOnly = true;
            this.RecipesDG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RecipesDG.Size = new System.Drawing.Size(623, 345);
            this.RecipesDG.TabIndex = 30;
            this.RecipesDG.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RecipesDG_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label2.Location = new System.Drawing.Point(644, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 50;
            this.label2.Text = "Назва:";
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
            this.nameTB.Location = new System.Drawing.Point(649, 116);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(186, 36);
            this.nameTB.TabIndex = 49;
            this.nameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label1.Location = new System.Drawing.Point(644, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "Опис:";
            // 
            // bunifuMetroTextbox1
            // 
            this.bunifuMetroTextbox1.AutoScroll = true;
            this.bunifuMetroTextbox1.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.bunifuMetroTextbox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuMetroTextbox1.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.bunifuMetroTextbox1.BorderThickness = 3;
            this.bunifuMetroTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMetroTextbox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuMetroTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuMetroTextbox1.isPassword = false;
            this.bunifuMetroTextbox1.Location = new System.Drawing.Point(644, 191);
            this.bunifuMetroTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMetroTextbox1.Name = "bunifuMetroTextbox1";
            this.bunifuMetroTextbox1.Size = new System.Drawing.Size(572, 208);
            this.bunifuMetroTextbox1.TabIndex = 51;
            this.bunifuMetroTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label3.Location = new System.Drawing.Point(837, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "Категорія:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label4.Location = new System.Drawing.Point(1022, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 29);
            this.label4.TabIndex = 56;
            this.label4.Text = "Рівень складності:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Text", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(824, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 53);
            this.label5.TabIndex = 57;
            this.label5.Text = "Рецепт";
            // 
            // recipyTB
            // 
            this.recipyTB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.recipyTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.recipyTB.Location = new System.Drawing.Point(649, 196);
            this.recipyTB.Multiline = true;
            this.recipyTB.Name = "recipyTB";
            this.recipyTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.recipyTB.Size = new System.Drawing.Size(563, 199);
            this.recipyTB.TabIndex = 58;
            // 
            // categoriesCB
            // 
            this.categoriesCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.categoriesCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.categoriesCB.BackColor = System.Drawing.SystemColors.Window;
            this.categoriesCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoriesCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.categoriesCB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.categoriesCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.categoriesCB.FormattingEnabled = true;
            this.categoriesCB.ItemHeight = 21;
            this.categoriesCB.Location = new System.Drawing.Point(842, 120);
            this.categoriesCB.Name = "categoriesCB";
            this.categoriesCB.Size = new System.Drawing.Size(179, 29);
            this.categoriesCB.Sorted = true;
            this.categoriesCB.TabIndex = 59;
            // 
            // levelCB
            // 
            this.levelCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.levelCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.levelCB.BackColor = System.Drawing.SystemColors.Window;
            this.levelCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.levelCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.levelCB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.levelCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.levelCB.FormattingEnabled = true;
            this.levelCB.ItemHeight = 21;
            this.levelCB.Location = new System.Drawing.Point(1027, 120);
            this.levelCB.Name = "levelCB";
            this.levelCB.Size = new System.Drawing.Size(171, 29);
            this.levelCB.Sorted = true;
            this.levelCB.TabIndex = 60;
            // 
            // addBtn
            // 
            this.addBtn.ActiveBorderThickness = 1;
            this.addBtn.ActiveCornerRadius = 20;
            this.addBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addBtn.ActiveForecolor = System.Drawing.Color.White;
            this.addBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addBtn.BackColor = System.Drawing.SystemColors.Window;
            this.addBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addBtn.BackgroundImage")));
            this.addBtn.ButtonText = "Додати";
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.addBtn.IdleBorderThickness = 1;
            this.addBtn.IdleCornerRadius = 20;
            this.addBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addBtn.IdleForecolor = System.Drawing.Color.White;
            this.addBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addBtn.Location = new System.Drawing.Point(644, 409);
            this.addBtn.Margin = new System.Windows.Forms.Padding(5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(196, 59);
            this.addBtn.TabIndex = 61;
            this.addBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addBtn.Visible = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
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
            this.chgBtn.ButtonText = "Змінити";
            this.chgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chgBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chgBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.chgBtn.IdleBorderThickness = 1;
            this.chgBtn.IdleCornerRadius = 20;
            this.chgBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.chgBtn.IdleForecolor = System.Drawing.Color.White;
            this.chgBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.chgBtn.Location = new System.Drawing.Point(1020, 409);
            this.chgBtn.Margin = new System.Windows.Forms.Padding(5);
            this.chgBtn.Name = "chgBtn";
            this.chgBtn.Size = new System.Drawing.Size(196, 59);
            this.chgBtn.TabIndex = 62;
            this.chgBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chgBtn.Visible = false;
            this.chgBtn.Click += new System.EventHandler(this.chgBtn_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Window;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "+";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(649, 54);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(35, 39);
            this.bunifuThinButton21.TabIndex = 63;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // delBtn
            // 
            this.delBtn.ActiveBorderThickness = 1;
            this.delBtn.ActiveCornerRadius = 20;
            this.delBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.delBtn.ActiveForecolor = System.Drawing.Color.White;
            this.delBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.delBtn.BackColor = System.Drawing.SystemColors.Window;
            this.delBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("delBtn.BackgroundImage")));
            this.delBtn.ButtonText = "Видалити";
            this.delBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.delBtn.IdleBorderThickness = 1;
            this.delBtn.IdleCornerRadius = 20;
            this.delBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.delBtn.IdleForecolor = System.Drawing.Color.White;
            this.delBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.delBtn.Location = new System.Drawing.Point(822, 409);
            this.delBtn.Margin = new System.Windows.Forms.Padding(5);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(196, 59);
            this.delBtn.TabIndex = 64;
            this.delBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.delBtn.Visible = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // addCategory
            // 
            this.addCategory.ActiveBorderThickness = 1;
            this.addCategory.ActiveCornerRadius = 20;
            this.addCategory.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addCategory.ActiveForecolor = System.Drawing.Color.White;
            this.addCategory.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addCategory.BackColor = System.Drawing.SystemColors.Window;
            this.addCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCategory.BackgroundImage")));
            this.addCategory.ButtonText = "+";
            this.addCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.ForeColor = System.Drawing.Color.SeaGreen;
            this.addCategory.IdleBorderThickness = 1;
            this.addCategory.IdleCornerRadius = 20;
            this.addCategory.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addCategory.IdleForecolor = System.Drawing.Color.White;
            this.addCategory.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.addCategory.Location = new System.Drawing.Point(950, 79);
            this.addCategory.Margin = new System.Windows.Forms.Padding(5);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(35, 39);
            this.addCategory.TabIndex = 65;
            this.addCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 29);
            this.label6.TabIndex = 67;
            this.label6.Text = "Користувач:";
            // 
            // userCB
            // 
            this.userCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.userCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.userCB.BackColor = System.Drawing.SystemColors.Window;
            this.userCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userCB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.userCB.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.userCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.userCB.FormattingEnabled = true;
            this.userCB.ItemHeight = 21;
            this.userCB.Location = new System.Drawing.Point(146, 12);
            this.userCB.Name = "userCB";
            this.userCB.Size = new System.Drawing.Size(132, 29);
            this.userCB.Sorted = true;
            this.userCB.TabIndex = 68;
            // 
            // searchBtn
            // 
            this.searchBtn.ActiveBorderThickness = 1;
            this.searchBtn.ActiveCornerRadius = 20;
            this.searchBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.searchBtn.ActiveForecolor = System.Drawing.Color.White;
            this.searchBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.searchBtn.BackColor = System.Drawing.SystemColors.Window;
            this.searchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBtn.BackgroundImage")));
            this.searchBtn.ButtonText = "Шукати";
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.searchBtn.IdleBorderThickness = 1;
            this.searchBtn.IdleCornerRadius = 20;
            this.searchBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.searchBtn.IdleForecolor = System.Drawing.Color.White;
            this.searchBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.searchBtn.Location = new System.Drawing.Point(559, 5);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(125, 39);
            this.searchBtn.TabIndex = 69;
            this.searchBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.ActiveBorderThickness = 1;
            this.exportBtn.ActiveCornerRadius = 20;
            this.exportBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.exportBtn.ActiveForecolor = System.Drawing.Color.White;
            this.exportBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.exportBtn.BackColor = System.Drawing.SystemColors.Window;
            this.exportBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportBtn.BackgroundImage")));
            this.exportBtn.ButtonText = "Експортувати";
            this.exportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.exportBtn.IdleBorderThickness = 1;
            this.exportBtn.IdleCornerRadius = 20;
            this.exportBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.exportBtn.IdleForecolor = System.Drawing.Color.White;
            this.exportBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.exportBtn.Location = new System.Drawing.Point(14, 409);
            this.exportBtn.Margin = new System.Windows.Forms.Padding(5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(196, 59);
            this.exportBtn.TabIndex = 70;
            this.exportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Text", 15F);
            this.label7.Location = new System.Drawing.Point(284, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 29);
            this.label7.TabIndex = 71;
            this.label7.Text = "Рецепт:";
            // 
            // resipySearch
            // 
            this.resipySearch.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.resipySearch.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.resipySearch.BorderColorMouseHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(36)))), ((int)(((byte)(88)))));
            this.resipySearch.BorderThickness = 3;
            this.resipySearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.resipySearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resipySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(55)))), ((int)(((byte)(132)))));
            this.resipySearch.isPassword = false;
            this.resipySearch.Location = new System.Drawing.Point(368, 5);
            this.resipySearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.resipySearch.Name = "resipySearch";
            this.resipySearch.Size = new System.Drawing.Size(186, 36);
            this.resipySearch.TabIndex = 72;
            this.resipySearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // UIRecipes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.resipySearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.userCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.chgBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.levelCB);
            this.Controls.Add(this.categoriesCB);
            this.Controls.Add(this.recipyTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuMetroTextbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.RecipesDG);
            this.Name = "UIRecipes";
            this.Size = new System.Drawing.Size(1220, 487);
            ((System.ComponentModel.ISupportInitialize)(this.RecipesDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid RecipesDG;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox nameTB;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox bunifuMetroTextbox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox recipyTB;
        private System.Windows.Forms.ComboBox categoriesCB;
        private System.Windows.Forms.ComboBox levelCB;
        private Bunifu.Framework.UI.BunifuThinButton2 addBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 chgBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 delBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 addCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox userCB;
        private Bunifu.Framework.UI.BunifuThinButton2 searchBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 exportBtn;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMetroTextbox resipySearch;
    }
}
