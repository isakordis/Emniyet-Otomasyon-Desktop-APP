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
    public partial class Gorev_Nobet_Kontrol : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        DataSet ds;
        public Gorev_Nobet_Kontrol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                da = new OleDbDataAdapter("SElect *from nobet_listesi", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "nobet_listesi");
                gorevdata.DataSource = ds.Tables["nobet_listesi"];
                gorevdata.Columns[0].HeaderText = "İsim";
                gorevdata.Columns[1].HeaderText = "Mahalle";
                gorevdata.Columns[2].HeaderText = "Mekan";
                gorevdata.Columns[3].HeaderText = "İlçe";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Gorev_Nobet_Kontrol_Load(object sender, EventArgs e)
        {

        }
    }
}
