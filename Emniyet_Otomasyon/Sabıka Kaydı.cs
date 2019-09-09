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
    public partial class Sabıka_Kaydı : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Sabıka_Kaydı()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void kayıtBut_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into sabıka (suclu_adı_soyadı,suc_tarihi,suclu_kimlik_no,sucu) values ('" + adıText.Text + "','" + sucTarih.Value.ToString() + "'," + kimlikText.Text + ",'" + sucText.Text + "')";
                cmd.Parameters.AddWithValue("@suclu_adı_soyadı", adıText.Text);
                cmd.Parameters.AddWithValue("@suc_tarihi", sucTarih.Text);
                cmd.Parameters.AddWithValue("@suclu_kimlik_no", kimlikText.Text);
                cmd.Parameters.AddWithValue("@sucu", sucText.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarı ile Kaydedildi..!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
          
        }

        private void kimlikText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
           
        }
    }
}
