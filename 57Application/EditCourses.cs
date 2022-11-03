using MetroFramework;
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

namespace _57Application
{
    public partial class EditCourses : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dr;
        DataSet ds;
        public EditCourses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Listele()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            baglanti.Open();
            tablo.Clear();
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select * From Kurslar where ID<>1 AND Silindi=0", baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            grdCourses.DataSource = tablo;
            grdCourses.Columns[0].Visible = false;
            grdCourses.Columns[2].Visible = false;
            grdCourses.Columns[1].HeaderText = "  Kurs Adı ";
            baglanti.Close();
        }

        private void EditCourses_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCourse.Text.Trim()))
                MetroMessageBox.Show(this, "Boş kurs eklenemez. (-.-) ", "Ekleme Başarısız");
            else
            {
                baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                baglanti.Open();
                komut = new SqlCommand($"INSERT INTO Kurslar(KursAdi,Silindi) VALUES('{txtCourse.Text.Trim()}',0)", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                txtCourse.Text = "";
                Listele();
            }


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (grdCourses.SelectedCells.Count > 0)
            {
                int selectedrowindex = grdCourses.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = grdCourses.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
                if(cellValue != "")
                {
                    baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                    baglanti.Open();
                    komut = new SqlCommand($"DELETE FROM Kurslar WHERE ID={cellValue}", baglanti);
                    komut.ExecuteScalar();
                    baglanti.Close();
                    Listele();
                }
            }
        }
    }
}
