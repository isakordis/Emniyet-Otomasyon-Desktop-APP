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
    public partial class Talep_Istek : Form
    {
        public int izinid { get; set; }



        public Talep_Istek()
        {
            InitializeComponent();
            izinid = 0;
        }

        private void Talep_Istek_Load(object sender, EventArgs e)
        {

        }

        private void talepBut_Click(object sender, EventArgs e)
        {
            try
            {
               
                OleDbConnection con;
                

                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                
                con.Open();
                
                OleDbDataReader okuyucu = new OleDbCommand("Select*From izin", con).ExecuteReader();
                List<IzinType> izinlistem=new List<IzinType>();
                while (okuyucu.Read())
                {
                    IzinType izin = new IzinType()
                    {

                        Baslangic = (DateTime)okuyucu["baslangıc"],
                        Bitis = (DateTime)okuyucu["bitis"],
                        Durum = bool.Parse(okuyucu["Durum"].ToString()) == true ? "İzin verildi" : "Onay bekliyor",
                        EkleyenID = (int)okuyucu["EkleyenID"],
                        ID = (int)okuyucu["ID"],
                        IzinNedeni = okuyucu["izin_nedeni"].ToString()
                    };
                    izinlistem.Add(izin);
                }
                con.Close();
                talepdata.DataSource = izinlistem.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void izinBut_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection con;
                OleDbCommand cmd;
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emniyet.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "Update izin set Durum=@drm Where ID=@id";
                cmd.Parameters.AddWithValue("@drm", true);
                cmd.Parameters.AddWithValue("@id", izinid);
                cmd.ExecuteNonQuery();
                
                con.Close();
                MessageBox.Show("Başarılı");
                talepBut_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void talepdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow item in talepdata.SelectedRows)
            {
                if (item.Selected)
                {
                    izinid = (int)item.Cells[3].Value;
                    izinBut.Enabled = true;
                }
            }
        }

        private void talepdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            izinBut.Enabled = false;

        }
    }
    class IzinType
    {
        public string IzinNedeni { get; set; }
        public DateTime Baslangic { get; set; }
        public DateTime Bitis { get; set; }
        public int ID { get; set; }
        public int EkleyenID { get; set; }
        public string Durum { get; set; }
    }
}