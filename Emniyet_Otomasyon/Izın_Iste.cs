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
    public partial class Izın_Iste : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        public Izın_Iste()
        {
            InitializeComponent();
        }

        private void kayıtBut_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into izin (izin_nedeni,baslangıc,bitis,EkleyenID,Durum) values('" + izinText.Text + "','" + baslangic.Value.ToString() + "','" + bitis.Value.ToString() + "','"+Giriş.EmniyetID+"',"+false+")";
                //cmd.Parameters.AddWithValue("@izin_nedeni", izinText.Text);
                //cmd.Parameters.AddWithValue("@baslangıc", baslangic.Text);
                //cmd.Parameters.AddWithValue("@bitis", bitis.Text);
                //cmd.Parameters.AddWithValue("@emniyetID", Giriş.EmniyetID);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarı ile kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           
        }

        private void Izın_Iste_Load(object sender, EventArgs e)
        {
            
        }

        private void izinText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar)&&!char.IsDigit(e.KeyChar);
        }
    }
}
