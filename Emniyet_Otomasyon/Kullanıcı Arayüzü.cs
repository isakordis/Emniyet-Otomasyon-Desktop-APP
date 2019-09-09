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
    public partial class Kullanıcı_Arayüzü : Form
    {
        public void girebilirMi()
        {
            
            string vtyolu = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Emniyet.accdb";
            OleDbConnection baglanti = new OleDbConnection(vtyolu);
            baglanti.Open();
            OleDbCommand komut2 = new OleDbCommand("Select *From emniyet", baglanti);
            OleDbDataReader oku;
            oku = komut2.ExecuteReader();
            while (oku.Read())
            {
                if (Convert.ToInt32(oku["rutbe"].ToString()) < 3)
                {
                    MessageBox.Show("Giremezsiniz.");
                    Application.Exit();
                }
            }
        }
        public Kullanıcı_Arayüzü()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            girebilirMi();
            Savcılık_İzni si = new Savcılık_İzni();
            si.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            girebilirMi();
            Sabıka_Kaydı sk = new Sabıka_Kaydı();
            sk.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sabıka_Ara sa =new Sabıka_Ara();
            sa.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            girebilirMi();
            Nobet_Yaz ny = new Nobet_Yaz();
            ny.ShowDialog();
        }

        private void Kullanıcı_Arayüzü_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Gorev_Nobet_Kontrol gnk = new Gorev_Nobet_Kontrol();
            gnk.ShowDialog();
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            girebilirMi();
            Talep_Istek ti = new Talep_Istek();
            ti.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Izın_Iste is1 = new Izın_Iste();
            is1.ShowDialog();
        }

        private void cıkısBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SorguAra sa = new SorguAra();
            sa.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SorguKaydı sk = new SorguKaydı();
            sk.ShowDialog();
        }

      
    }
}
