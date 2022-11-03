namespace _57Application
{
    partial class ApplicationList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationList));
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.dtTarih = new MetroFramework.Controls.MetroDateTime();
            this.txtCourseName = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPhone = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtMail = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtNameSurname = new MetroFramework.Controls.MetroTextBox();
            this.GridApplication = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnExcel = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtGorusenKisi = new MetroFramework.Controls.MetroTextBox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridApplication)).BeginInit();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtGorusenKisi);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel7);
            this.grpSearch.Controls.Add(this.dtTarih);
            this.grpSearch.Controls.Add(this.txtCourseName);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel6);
            this.grpSearch.Controls.Add(this.txtDetail);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel5);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel4);
            this.grpSearch.Controls.Add(this.txtPhone);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel3);
            this.grpSearch.Controls.Add(this.txtMail);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel2);
            this.grpSearch.Controls.Add(this.bunifuCustomLabel1);
            this.grpSearch.Controls.Add(this.txtNameSurname);
            this.grpSearch.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.grpSearch.Location = new System.Drawing.Point(6, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1104, 75);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Arama Ekranı";
            // 
            // dtTarih
            // 
            this.dtTarih.CustomFormat = "dd-MM-yyyy";
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarih.Location = new System.Drawing.Point(913, 9);
            this.dtTarih.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(143, 29);
            this.dtTarih.Style = MetroFramework.MetroColorStyle.Silver;
            this.dtTarih.TabIndex = 12;
            this.dtTarih.ValueChanged += new System.EventHandler(this.dtTarih_ValueChanged);
            // 
            // txtCourseName
            // 
            // 
            // 
            // 
            this.txtCourseName.CustomButton.Image = null;
            this.txtCourseName.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtCourseName.CustomButton.Name = "";
            this.txtCourseName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCourseName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCourseName.CustomButton.TabIndex = 1;
            this.txtCourseName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCourseName.CustomButton.UseSelectable = true;
            this.txtCourseName.CustomButton.Visible = false;
            this.txtCourseName.Lines = new string[0];
            this.txtCourseName.Location = new System.Drawing.Point(73, 43);
            this.txtCourseName.MaxLength = 32767;
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.PasswordChar = '\0';
            this.txtCourseName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCourseName.SelectedText = "";
            this.txtCourseName.SelectionLength = 0;
            this.txtCourseName.SelectionStart = 0;
            this.txtCourseName.ShortcutsEnabled = true;
            this.txtCourseName.Size = new System.Drawing.Size(121, 23);
            this.txtCourseName.TabIndex = 11;
            this.txtCourseName.UseSelectable = true;
            this.txtCourseName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCourseName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCourseName.TextChanged += new System.EventHandler(this.txtCourseName_TextChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(6, 49);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(46, 13);
            this.bunifuCustomLabel6.TabIndex = 10;
            this.bunifuCustomLabel6.Text = "Kurs Adı";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(598, 46);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(458, 26);
            this.txtDetail.TabIndex = 9;
            this.txtDetail.Text = "";
            this.txtDetail.TextChanged += new System.EventHandler(this.txtDetail_TextChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(499, 52);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(93, 13);
            this.bunifuCustomLabel5.TabIndex = 8;
            this.bunifuCustomLabel5.Text = "Yazılan Detayı Ara";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(817, 17);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel4.TabIndex = 6;
            this.bunifuCustomLabel4.Text = "Tarih";
            // 
            // txtPhone
            // 
            // 
            // 
            // 
            this.txtPhone.CustomButton.Image = null;
            this.txtPhone.CustomButton.Location = new System.Drawing.Point(103, 1);
            this.txtPhone.CustomButton.Name = "";
            this.txtPhone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhone.CustomButton.TabIndex = 1;
            this.txtPhone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhone.CustomButton.UseSelectable = true;
            this.txtPhone.CustomButton.Visible = false;
            this.txtPhone.Lines = new string[0];
            this.txtPhone.Location = new System.Drawing.Point(296, 43);
            this.txtPhone.MaxLength = 32767;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.PasswordChar = '\0';
            this.txtPhone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhone.SelectedText = "";
            this.txtPhone.SelectionLength = 0;
            this.txtPhone.SelectionStart = 0;
            this.txtPhone.ShortcutsEnabled = true;
            this.txtPhone.Size = new System.Drawing.Size(125, 23);
            this.txtPhone.TabIndex = 5;
            this.txtPhone.UseSelectable = true;
            this.txtPhone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhone.Click += new System.EventHandler(this.txtPhone_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(248, 46);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(43, 13);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Telefon";
            // 
            // txtMail
            // 
            // 
            // 
            // 
            this.txtMail.CustomButton.Image = null;
            this.txtMail.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtMail.CustomButton.Name = "";
            this.txtMail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtMail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMail.CustomButton.TabIndex = 1;
            this.txtMail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMail.CustomButton.UseSelectable = true;
            this.txtMail.CustomButton.Visible = false;
            this.txtMail.Lines = new string[0];
            this.txtMail.Location = new System.Drawing.Point(283, 14);
            this.txtMail.MaxLength = 32767;
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMail.SelectedText = "";
            this.txtMail.SelectionLength = 0;
            this.txtMail.SelectionStart = 0;
            this.txtMail.ShortcutsEnabled = true;
            this.txtMail.Size = new System.Drawing.Size(156, 23);
            this.txtMail.TabIndex = 3;
            this.txtMail.UseSelectable = true;
            this.txtMail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(252, 17);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(26, 13);
            this.bunifuCustomLabel2.TabIndex = 2;
            this.bunifuCustomLabel2.Text = "Mail";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 17);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 13);
            this.bunifuCustomLabel1.TabIndex = 1;
            this.bunifuCustomLabel1.Text = "isim Soyisim";
            // 
            // txtNameSurname
            // 
            // 
            // 
            // 
            this.txtNameSurname.CustomButton.Image = null;
            this.txtNameSurname.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.txtNameSurname.CustomButton.Name = "";
            this.txtNameSurname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNameSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNameSurname.CustomButton.TabIndex = 1;
            this.txtNameSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNameSurname.CustomButton.UseSelectable = true;
            this.txtNameSurname.CustomButton.Visible = false;
            this.txtNameSurname.Lines = new string[0];
            this.txtNameSurname.Location = new System.Drawing.Point(73, 14);
            this.txtNameSurname.MaxLength = 32767;
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.PasswordChar = '\0';
            this.txtNameSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNameSurname.SelectedText = "";
            this.txtNameSurname.SelectionLength = 0;
            this.txtNameSurname.SelectionStart = 0;
            this.txtNameSurname.ShortcutsEnabled = true;
            this.txtNameSurname.Size = new System.Drawing.Size(121, 23);
            this.txtNameSurname.TabIndex = 0;
            this.txtNameSurname.UseSelectable = true;
            this.txtNameSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNameSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtNameSurname.TextChanged += new System.EventHandler(this.txtNameSurname_TextChanged);
            // 
            // GridApplication
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GridApplication.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.GridApplication.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridApplication.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.GridApplication.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridApplication.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Honeydew;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridApplication.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridApplication.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridApplication.DoubleBuffered = true;
            this.GridApplication.EnableHeadersVisualStyles = false;
            this.GridApplication.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.GridApplication.HeaderForeColor = System.Drawing.Color.Honeydew;
            this.GridApplication.Location = new System.Drawing.Point(6, 84);
            this.GridApplication.Name = "GridApplication";
            this.GridApplication.ReadOnly = true;
            this.GridApplication.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridApplication.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridApplication.Size = new System.Drawing.Size(1104, 302);
            this.GridApplication.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Aramayı Temizle ve Listele";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(467, 394);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(298, 48);
            this.btnClear.TabIndex = 3;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorderThickness = 1;
            this.btnDelete.ActiveCornerRadius = 20;
            this.btnDelete.ActiveFillColor = System.Drawing.Color.RosyBrown;
            this.btnDelete.ActiveForecolor = System.Drawing.Color.Gainsboro;
            this.btnDelete.ActiveLineColor = System.Drawing.Color.Sienna;
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.ButtonText = "Seçili Kaydı Sil";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Maroon;
            this.btnDelete.IdleBorderThickness = 1;
            this.btnDelete.IdleCornerRadius = 20;
            this.btnDelete.IdleFillColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDelete.IdleForecolor = System.Drawing.Color.Silver;
            this.btnDelete.IdleLineColor = System.Drawing.Color.SeaShell;
            this.btnDelete.Location = new System.Drawing.Point(806, 391);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(304, 49);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.ActiveBorderThickness = 1;
            this.btnExcel.ActiveCornerRadius = 20;
            this.btnExcel.ActiveFillColor = System.Drawing.Color.Turquoise;
            this.btnExcel.ActiveForecolor = System.Drawing.Color.White;
            this.btnExcel.ActiveLineColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnExcel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExcel.BackgroundImage")));
            this.btnExcel.ButtonText = "Excel\'e Aktar";
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExcel.IdleBorderThickness = 1;
            this.btnExcel.IdleCornerRadius = 20;
            this.btnExcel.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.btnExcel.IdleForecolor = System.Drawing.Color.MintCream;
            this.btnExcel.IdleLineColor = System.Drawing.Color.DodgerBlue;
            this.btnExcel.Location = new System.Drawing.Point(15, 394);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(5);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(412, 48);
            this.btnExcel.TabIndex = 5;
            this.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // txtGorusenKisi
            // 
            // 
            // 
            // 
            this.txtGorusenKisi.CustomButton.Image = null;
            this.txtGorusenKisi.CustomButton.Location = new System.Drawing.Point(134, 1);
            this.txtGorusenKisi.CustomButton.Name = "";
            this.txtGorusenKisi.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtGorusenKisi.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtGorusenKisi.CustomButton.TabIndex = 1;
            this.txtGorusenKisi.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtGorusenKisi.CustomButton.UseSelectable = true;
            this.txtGorusenKisi.CustomButton.Visible = false;
            this.txtGorusenKisi.Lines = new string[0];
            this.txtGorusenKisi.Location = new System.Drawing.Point(598, 11);
            this.txtGorusenKisi.MaxLength = 32767;
            this.txtGorusenKisi.Name = "txtGorusenKisi";
            this.txtGorusenKisi.PasswordChar = '\0';
            this.txtGorusenKisi.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtGorusenKisi.SelectedText = "";
            this.txtGorusenKisi.SelectionLength = 0;
            this.txtGorusenKisi.SelectionStart = 0;
            this.txtGorusenKisi.ShortcutsEnabled = true;
            this.txtGorusenKisi.Size = new System.Drawing.Size(156, 23);
            this.txtGorusenKisi.TabIndex = 14;
            this.txtGorusenKisi.UseSelectable = true;
            this.txtGorusenKisi.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtGorusenKisi.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtGorusenKisi.TextChanged += new System.EventHandler(this.txtGorusenKisi_TextChanged);
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(499, 15);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(66, 13);
            this.bunifuCustomLabel7.TabIndex = 13;
            this.bunifuCustomLabel7.Text = "Görüşen Kişi";
            // 
            // ApplicationList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1122, 459);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.GridApplication);
            this.Controls.Add(this.grpSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ApplicationList";
            this.Text = "Başvuru Listesi & Düzenleme Ekranı";
            this.Load += new System.EventHandler(this.ApplicationList_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridApplication)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private MetroFramework.Controls.MetroTextBox txtPhone;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private MetroFramework.Controls.MetroTextBox txtMail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private MetroFramework.Controls.MetroTextBox txtNameSurname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private System.Windows.Forms.RichTextBox txtDetail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomDataGrid GridApplication;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private MetroFramework.Controls.MetroTextBox txtCourseName;
        private MetroFramework.Controls.MetroDateTime dtTarih;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExcel;
        private MetroFramework.Controls.MetroTextBox txtGorusenKisi;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
    }
}