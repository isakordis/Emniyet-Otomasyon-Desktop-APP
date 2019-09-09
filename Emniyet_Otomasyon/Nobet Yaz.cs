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
    public partial class Nobet_Yaz : Form
    {
        OleDbCommand cmd;
        OleDbConnection con; 
        public Nobet_Yaz()
        {
            InitializeComponent();
        }
        

        private void Nobet_Yaz_Load(object sender, EventArgs e)
        {
            mahalle();
            ilce();
            mekan();
        }
        private void mahalle()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from nobet";
            OleDbDataReader dr = cmd.ExecuteReader();
            //MAHALLE
            while (dr.Read())
            {
                mahalleCombo.Items.Add(dr["mahalle"]);
            }
            con.Close();

        }
        private void ilce()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from nobet";
            OleDbDataReader dr = cmd.ExecuteReader();
            //İlçe
            while (dr.Read())
            {
                ililceCombo.Items.Add(dr["İlçe"]);
            }
            con.Close();

        }
        private void mekan()
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "Select * from nobet";
            OleDbDataReader dr = cmd.ExecuteReader();
            //Mekan
            while (dr.Read())
            {
                mekanCombo.Items.Add(dr["Mekan"]);
            }
            con.Close();

        }

        private void mahalleCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void kaydetBut_Click(object sender, EventArgs e)
        {
            try
            {
                
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into nobet_listesi(isim,gorev_mahalle,gorev_mekan,gorev_ilce)values('" + adText.Text + "','" + mahalleCombo.Text + "','" + mekanCombo.Text + "','" + ililceCombo.Text.ToString() + "')";
                cmd.Parameters.AddWithValue("@isim", adText.Text);
                cmd.Parameters.AddWithValue("@gorev_mahalle", mahalleCombo.Text);
                cmd.Parameters.AddWithValue("@gorev_mekan", mekanCombo.Text);
                cmd.Parameters.AddWithValue("@gorev_ilce", ililceCombo.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Gorev Dağılımı gerçekleşmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
