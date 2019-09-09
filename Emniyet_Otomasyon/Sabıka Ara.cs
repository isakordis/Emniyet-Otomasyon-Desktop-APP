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
    public partial class Sabıka_Ara : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        OleDbDataAdapter da;
        DataSet ds;
        public Sabıka_Ara()
        {
            InitializeComponent();
        }
        

        private void araBut_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");

                con.Open();
                da = new OleDbDataAdapter(
                    "Select * from sabıka where suclu_adı_soyadı Like '" + adText.Text + "%'", con);
                ds = new DataSet();


                da.Fill(ds, "tablo");
                con.Close();
                dataSuc.DataSource = ds.Tables["tablo"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Sabıka_Ara_Load(object sender, EventArgs e)
        {

        }
    }
}
