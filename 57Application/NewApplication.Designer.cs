namespace _57Application
{
    partial class NewApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewApplication));
            this.grpNew = new System.Windows.Forms.GroupBox();
            this.txtGorusen = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtDetail = new System.Windows.Forms.RichTextBox();
            this.dtDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtPhone = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtMail = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtAge = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txtNameSurname = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.grpNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNew
            // 
            this.grpNew.Controls.Add(this.cmbKonu);
            this.grpNew.Controls.Add(this.txtGorusen);
            this.grpNew.Controls.Add(this.bunifuCustomLabel8);
            this.grpNew.Controls.Add(this.txtDetail);
            this.grpNew.Controls.Add(this.dtDate);
            this.grpNew.Controls.Add(this.txtPhone);
            this.grpNew.Controls.Add(this.txtMail);
            this.grpNew.Controls.Add(this.txtAge);
            this.grpNew.Controls.Add(this.txtNameSurname);
            this.grpNew.Controls.Add(this.bunifuCustomLabel7);
            this.grpNew.Controls.Add(this.bunifuCustomLabel6);
            this.grpNew.Controls.Add(this.bunifuCustomLabel5);
            this.grpNew.Controls.Add(this.bunifuCustomLabel4);
            this.grpNew.Controls.Add(this.bunifuCustomLabel3);
            this.grpNew.Controls.Add(this.bunifuCustomLabel2);
            this.grpNew.Controls.Add(this.bunifuCustomLabel1);
            this.grpNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpNew.Location = new System.Drawing.Point(8, 8);
            this.grpNew.Name = "grpNew";
            this.grpNew.Size = new System.Drawing.Size(408, 481);
            this.grpNew.TabIndex = 0;
            this.grpNew.TabStop = false;
            this.grpNew.Text = "Yeni Başvuru";
            // 
            // txtGorusen
            // 
            this.txtGorusen.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtGorusen.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGorusen.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtGorusen.BorderThickness = 3;
            this.txtGorusen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGorusen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtGorusen.ForeColor = System.Drawing.Color.White;
            this.txtGorusen.isPassword = false;
            this.txtGorusen.Location = new System.Drawing.Point(88, 196);
            this.txtGorusen.Margin = new System.Windows.Forms.Padding(4);
            this.txtGorusen.Name = "txtGorusen";
            this.txtGorusen.Size = new System.Drawing.Size(248, 37);
            this.txtGorusen.TabIndex = 15;
            this.txtGorusen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(6, 207);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(75, 13);
            this.bunifuCustomLabel8.TabIndex = 14;
            this.bunifuCustomLabel8.Text = "Görüşen  Kişi: ";
            // 
            // txtDetail
            // 
            this.txtDetail.Location = new System.Drawing.Point(6, 340);
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.Size = new System.Drawing.Size(395, 121);
            this.txtDetail.TabIndex = 13;
            this.txtDetail.Text = "";
            // 
            // dtDate
            // 
            this.dtDate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.dtDate.BorderRadius = 0;
            this.dtDate.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.dtDate.ForeColor = System.Drawing.Color.Black;
            this.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtDate.FormatCustom = null;
            this.dtDate.Location = new System.Drawing.Point(97, 249);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(239, 31);
            this.dtDate.TabIndex = 11;
            this.dtDate.Value = new System.DateTime(2022, 9, 26, 14, 23, 23, 286);
            // 
            // txtPhone
            // 
            this.txtPhone.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtPhone.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtPhone.BorderThickness = 3;
            this.txtPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPhone.ForeColor = System.Drawing.Color.White;
            this.txtPhone.isPassword = false;
            this.txtPhone.Location = new System.Drawing.Point(88, 153);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(248, 37);
            this.txtPhone.TabIndex = 10;
            this.txtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtMail
            // 
            this.txtMail.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtMail.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMail.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtMail.BorderThickness = 3;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtMail.ForeColor = System.Drawing.Color.White;
            this.txtMail.isPassword = false;
            this.txtMail.Location = new System.Drawing.Point(88, 107);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(247, 38);
            this.txtMail.TabIndex = 9;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtAge
            // 
            this.txtAge.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtAge.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAge.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtAge.BorderThickness = 3;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtAge.ForeColor = System.Drawing.Color.White;
            this.txtAge.isPassword = false;
            this.txtAge.Location = new System.Drawing.Point(88, 66);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(164, 35);
            this.txtAge.TabIndex = 8;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAge_KeyPress);
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.BorderColorFocused = System.Drawing.Color.Blue;
            this.txtNameSurname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNameSurname.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txtNameSurname.BorderThickness = 3;
            this.txtNameSurname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameSurname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNameSurname.ForeColor = System.Drawing.Color.White;
            this.txtNameSurname.isPassword = false;
            this.txtNameSurname.Location = new System.Drawing.Point(88, 20);
            this.txtNameSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(247, 38);
            this.txtNameSurname.TabIndex = 7;
            this.txtNameSurname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(6, 324);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(109, 13);
            this.bunifuCustomLabel7.TabIndex = 6;
            this.bunifuCustomLabel7.Text = "Detay var ise belirtiniz";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(3, 294);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(88, 13);
            this.bunifuCustomLabel6.TabIndex = 5;
            this.bunifuCustomLabel6.Text = "Görüşme Konusu";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(8, 258);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(37, 13);
            this.bunifuCustomLabel5.TabIndex = 4;
            this.bunifuCustomLabel5.Text = "Tarih :";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(6, 162);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel4.TabIndex = 3;
            this.bunifuCustomLabel4.Text = "Telefon : ";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(6, 122);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(42, 13);
            this.bunifuCustomLabel3.TabIndex = 2;
            this.bunifuCustomLabel3.Text = "E-Mail :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(8, 78);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Yaş :";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 32);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(62, 13);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Ad Soyad : ";
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnClear.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveLineColor = System.Drawing.Color.Black;
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Temizle";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(170, 497);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(111, 47);
            this.btnClear.TabIndex = 2;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveBorderThickness = 1;
            this.btnAdd.ActiveCornerRadius = 20;
            this.btnAdd.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnAdd.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.ActiveLineColor = System.Drawing.Color.Black;
            this.btnAdd.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.ButtonText = "Ekle ve Kapat (F3)";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleBorderThickness = 1;
            this.btnAdd.IdleCornerRadius = 20;
            this.btnAdd.IdleFillColor = System.Drawing.Color.White;
            this.btnAdd.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnAdd.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Location = new System.Drawing.Point(6, 497);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(159, 47);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.Honeydew;
            this.btnClose.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.ActiveLineColor = System.Drawing.Color.Black;
            this.btnClose.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = "Kapat (ESC)";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.Color.White;
            this.btnClose.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(286, 497);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 47);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cmbKonu
            // 
            this.cmbKonu.DisplayMember = "KursAdi";
            this.cmbKonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.cmbKonu.Location = new System.Drawing.Point(97, 291);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(238, 25);
            this.cmbKonu.TabIndex = 16;
            this.cmbKonu.ValueMember = "ID";
            // 
            // NewApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(421, 556);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewApplication";
            this.Text = "Yeni Başvuru Ekranı";
            this.Load += new System.EventHandler(this.NewApplication_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewApplication_KeyDown);
            this.grpNew.ResumeLayout(false);
            this.grpNew.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNew;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtNameSurname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtPhone;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtMail;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtAge;
        private Bunifu.Framework.UI.BunifuDatepicker dtDate;
        private System.Windows.Forms.RichTextBox txtDetail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuMetroTextbox txtGorusen;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private System.Windows.Forms.ComboBox cmbKonu;
    }
}