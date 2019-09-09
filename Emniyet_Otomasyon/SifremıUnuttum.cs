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
    public partial class SifremıUnuttum : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public SifremıUnuttum()
        {
            InitializeComponent();
        }

        private void gosterBut_Click(object sender, EventArgs e)
        {
            try
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                ds = new DataSet();
                da = new OleDbDataAdapter("SElect *from emniyet where SicilNo like '" + sicilText.Text + "%'", con);
                da.Fill(ds, "emniyet");
                gosterGrid.DataSource = ds.Tables["emniyet"];
                
                gosterGrid.Columns[0].Visible = false;
                gosterGrid.Columns[1].Visible = false;
                gosterGrid.Columns[2].Visible = false;
                gosterGrid.Columns[3].Visible = false;
                gosterGrid.Columns[5].Visible = false;
                gosterGrid.Columns[6].Visible = false;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void sicilText_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            if (sicilText.TextLength == 11)
            {
                e.Handled = true;
            }
        }
    }
}
