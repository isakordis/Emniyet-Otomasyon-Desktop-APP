using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Emniyet_Otomasyon
{
    public partial class KullanıcıKayıt : Form
    {
        bool ayniMi = true;
      
        public KullanıcıKayıt()
        {
            InitializeComponent();
        }
        private void kayıtKontrol()
        {
            ayniMi = true;
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Emniyet.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("Select *From emniyet", baglanti);
            OleDbDataReader oku;
            oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                if (sicilText.Text==oku["SicilNo"].ToString()||ıdText.Text==oku["ID"].ToString())
                {
                    ayniMi = false;
                }
            }
            baglanti.Close();
        }

        private void kaydetBut_Click(object sender, EventArgs e)
        {
            try
            {

                kayıtKontrol();
                if (ayniMi == true)
                {
                    string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Emniyet.accdb";
                    OleDbConnection baglanti = new OleDbConnection(vtyolu);
                    baglanti.Open();
                    string ekle = "insert into emniyet (ID,Ad,Soyad,SicilNo,Sifre,SifreTekrar,Rutbe) values (@ID,@Ad,@Soyad,@SicilNo,@Sifre,@SifreTekrar,@Rutbe)";
                    OleDbCommand komut = new OleDbCommand(ekle, baglanti);


                    if ((ıdText.Text != "" && adText.Text != "" && soyadText.Text != "" && sicilText.Text != "" && sifreText.Text != "" && sifTekText.Text != "" && rutText.Text != "") && sifreText.Text == sifTekText.Text)
                    {
                        komut.Parameters.AddWithValue("@ID", ıdText.Text);
                        komut.Parameters.AddWithValue("@Ad", adText.Text);
                        komut.Parameters.AddWithValue("@Soyad", soyadText.Text);
                        komut.Parameters.AddWithValue("@SicilNo", sicilText.Text);
                        komut.Parameters.AddWithValue("@Sifre", sifreText.Text);
                        komut.Parameters.AddWithValue("@SifreTekrar", sifTekText.Text);
                        komut.Parameters.AddWithValue("@Rutbe", rutText.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kayıt Başarıyla Eklendi");
                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşleşmiyor veya boş yer var!!");
                        baglanti.Close();
                    }
                }
                else
             
                    MessageBox.Show("Bu Sicil No:"+sicilText.Text+ " veya ID: "+ıdText.Text +"Kayıtlı ");
                }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void KullanıcıKayıt_Load(object sender, EventArgs e)
        {

        }

        private void sicilText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void ıdText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void rutText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }
        }
    
}
