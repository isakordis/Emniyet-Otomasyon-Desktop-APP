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
    public partial class Savcılık_İzni : Form
    {
       
        public Savcılık_İzni()
        {
            InitializeComponent();
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void gonderBut_Click(object sender, EventArgs e)
        {
            try
            {
               
                OleDbConnection con;
                OleDbCommand cmd;
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "insert into savcılık (izin_nedeni,izin_baslangıc,izin_bitis) values ('" + izintext.Text + "','" + baslangıctarih.Value.ToString() + "','" + bitistarih.Value.ToString() + "')";
                if (izintext.Text != "" && baslangıctarih.Text != "" && bitistarih.Text != "")
                {
                    cmd.Parameters.AddWithValue("@izin_nedeni", izintext.Text);
                    cmd.Parameters.AddWithValue("@izin_baslangıc", baslangıctarih.Text);
                    cmd.Parameters.AddWithValue("@izin_bitis", bitistarih.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Başarı ile kaydedildi.");
                }
                else
                {
                    MessageBox.Show("Tüm alanları doldurduğunuza emin olunuz.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Savcılık_İzni_Load(object sender, EventArgs e)
        {

        }
    }
}
