using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace _57Application
{
    public partial class NewApplication : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter sqlAdapter;
        SqlCommand komut;
        SqlDataReader dr;
        public NewApplication()
        {
            InitializeComponent();
        }

        private void NewApplication_Load(object sender, EventArgs e)
        {

            txtNameSurname.Focus();
            BindDataKonu();
        }

        private void NewApplication_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
                this.Dispose();
            }
            if(e.KeyCode == Keys.F3)
            {

                if (!string.IsNullOrEmpty(txtNameSurname.Text.Trim()) && !string.IsNullOrEmpty(txtPhone.Text.Trim()))
                    Ekle();
                else
                    MetroMessageBox.Show(this, "isim soyisim alanı veya telefon alanı boş olmamalıdır...", "Boş Alan Tespit edildi.");
            }
        }

        private void Ekle()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            komut = new SqlCommand
            {
                Connection = baglanti,
                CommandText = $"INSERT INTO Basvuru (AdSoyad,Yas,Email,Telefon,Tarih,KursID,Yorum,Gorusen) VALUES ('{txtNameSurname.Text.Trim()}',{txtAge.Text.Trim()},'{txtMail.Text.Trim()}','{txtPhone.Text.Trim()}'" +
                $",convert(date,'{dtDate.Value}',103),'{cmbKonu.SelectedValue}','{txtDetail.Text.Trim()}','{txtGorusen.Text.Trim()}')"
            };

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            this.Close();
            MetroMessageBox.Show(this, "Kayıt başarı ile eklendi....", "Harikasınız !!");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
        public void BindDataKonu()
        {

            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            baglanti.Open();
            DataTable table1 = new DataTable();
            sqlAdapter = new SqlDataAdapter("select KursAdi,ID from Kurslar", baglanti);
            sqlAdapter.Fill(table1);
            cmbKonu.DataSource = table1;
            baglanti.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAge.Text = "";
            txtDetail.Text = "";
            txtMail.Text = "";
            txtNameSurname.Text = "";
            txtPhone.Text = "";

        }

        private void cmbCourse_Load(object sender, EventArgs e)
        {
            BindDataKonu();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNameSurname.Text.Trim()) && !string.IsNullOrEmpty(txtPhone.Text.Trim()))
                Ekle();
            else
                MetroMessageBox.Show(this, "isim soyisim alanı veya telefon alanı boş olmamalıdır...", "Boş Alan Tespit edildi.");
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
              (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cmbCourse_onItemSelected(object sender, EventArgs e)
        {

        }
    }
}
