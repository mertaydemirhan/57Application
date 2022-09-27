using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _57Application
{
    public partial class ApplicationList : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds;
        public ApplicationList()
        {
            InitializeComponent();
        }

        private void ApplicationList_Load(object sender, EventArgs e)
        {
            ToList();
            GridApplication.Columns[0].Visible = false;
            GridApplication.Columns[8].Visible = false; //ID
            /*dataGridView1.Columns[2].Visible = false; //Durum
            dataGridView1.Columns[3].HeaderText = "Adı"; //Adı
            dataGridView1.Columns[4].HeaderText = "Soyadı"; //Soyadı*/
        }
        public void ara(string ara, string yer)
        {
            //MetroFramework.MetroMessageBox.Show(this,yer,"Harika");
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            if (yer.Trim() == "")
            {
                ToList();
            }
            else
            {
                DataTable tablo = new DataTable();
                tablo.Clear();
                ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter("select B.ID,AdSoyad,Yas,Email,Telefon,Tarih,K.KursAdi,Yorum,B.Silindi From Basvuru B Join Kurslar K ON(K.ID=B.KursID) where B.Silindi=0 AND " + ara + " like '%" + yer + "%'", baglanti);
                adapter.Fill(tablo);
                ds.Merge(tablo);
                GridApplication.DataSource = tablo;
            }
        }
        private void ToList()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            DataTable tablo = new DataTable();
            tablo.Clear();
            ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter("select B.ID,AdSoyad,Yas,Email,Telefon,Tarih,K.KursAdi,Yorum,B.Silindi From Basvuru B Join Kurslar K ON(K.ID=B.KursID) where B.Silindi=0", baglanti);
            adapter.Fill(tablo);
            ds.Merge(tablo);
            GridApplication.DataSource = tablo;
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseName.Text = "";
            txtNameSurname.Text = "";
            txtDetail.Text = "";
            txtMail.Text = "";
            txtPhone.Text = "";
            ToList();
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "BaşvuruListesi.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                        //    sw.WriteLine("Hello World!");
                        StreamWriter wr = new StreamWriter(savefile.FileName, false, Encoding.UTF32);
                        for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(ds.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                            {
                                if (ds.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(ds.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Excel Dosyanız başarıyla kaydedilmiştir. Dosya adı :  " + savefile.FileName, "Başarıyla Kaydedildi.", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Excel'e aktarılacak kayıt bulunamadı... ", "Çok üzgünüz...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (GridApplication.SelectedCells.Count > 0)
            {
                int selectedrowindex = GridApplication.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = GridApplication.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["ID"].Value);
                if (cellValue != "")
                {
                    baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                    baglanti.Open();
                    komut = new SqlCommand($"UPDATE Basvuru SET Silindi=1 WHERE ID={cellValue}", baglanti);
                    komut.ExecuteScalar();
                    baglanti.Close();
                    ToList();
                }
            }
        }
        private void txtNameSurname_TextChanged(object sender, EventArgs e)
        {
            string al = txtNameSurname.Text;
            ara("AdSoyad", al);
        }
        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            string al = txtMail.Text;
            ara("Email", al);
        }
        private void txtPhone_Click(object sender, EventArgs e)
        {
            string al = txtPhone.Text;
            ara("Telefon", al);
        }
        private void dtTarih_ValueChanged(object sender, EventArgs e)
        {
            string al;
            al = dtTarih.Value.ToString("yyyy-MM-dd");
            ara("CONVERT(VARCHAR(25), Tarih, 126)", al);
        }
        private void txtCourseName_TextChanged(object sender, EventArgs e)
        {
            string al = txtCourseName.Text;
            ara("K.KursAdi", al);
        }
        private void txtDetail_TextChanged(object sender, EventArgs e)
        {
            string al = txtDetail.Text;
            ara("Yorum", al);
        }


    }
}
