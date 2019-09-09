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
using System.Media;
namespace Emniyet_Otomasyon
{
    public partial class Giriş : Form
    {
        public static int EmniyetID { get; set; }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Giriş()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KullanıcıKayıt kk = new KullanıcıKayıt();
            kk.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string ad = sicilText.Text;
                //string sifre = sifreText.Text;
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM emniyet where SicilNo=" + sicilText.Text + " AND Sifre='" + sifreText.Text + "'";
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    EmniyetID = (int)dr["ID"];
                    Kullanıcı_Arayüzü f2 = new Kullanıcı_Arayüzü();
                    f2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SifremıUnuttum su = new SifremıUnuttum();
            su.Show();


        }

        private void Giriş_Load(object sender, EventArgs e)
        {
            
        }

        private void sicilText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
            
        }
    }
}
