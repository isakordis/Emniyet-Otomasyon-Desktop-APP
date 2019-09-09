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
    public partial class SorguKaydı : Form
    {
        OleDbCommand cmd;
        OleDbConnection con;

        public SorguKaydı()
        {
            InitializeComponent();
        }

       

        private void SorguKaydı_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kimlikText_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
           
        }

        private void kayıtBut_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into sorgu (sorgu,suclu_adı,suclu_kimlik_no,tarih) values('" + sorguText.Text + "'," + adText.Text + ",'" + kimlikText.Text + "','" + tarih.Value.ToString() + "')";


                cmd.Parameters.AddWithValue("@sorgu", sorguText.Text);
                cmd.Parameters.AddWithValue("@suclu_adı", adText.Text);
                cmd.Parameters.AddWithValue("@suclu_kimlik_no", kimlikText.Text);
                cmd.Parameters.AddWithValue("@tarih", tarih.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarı ile Kaydedildi..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
