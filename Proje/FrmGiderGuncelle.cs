using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TalyplarOyiSystema
{
    public partial class FrmGiderGuncelle : Form
    {
        public FrmGiderGuncelle()
        {
            InitializeComponent();
        }
        public string elektrik, suw, gaz, internet, azyk, beylekiler, personal, id;

        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmGiderGuncelle_Load(object sender, EventArgs e)
        {
            TxtCykdajyid.Text = id;
            TxtElektrik.Text = elektrik;
            TxtSuw.Text = suw;
            TxtGaz.Text = gaz;
            Txtinternet.Text = internet;
            TxtAzyk.Text = azyk;
            TxtPersonal.Text = personal;
            TxtBasgalar.Text = beylekiler;

        }

        private void BtnTazele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Cykdayjylar set Elektrik=@p1,Suw=@p2,Gaz=@p3,internet=@p4,Azyk=@p5,Personal=@p6,Beylekiler=@p7 where Odemeid=@p8", bgl.baglanti());
                komut.Parameters.AddWithValue("@p8", TxtCykdajyid.Text);
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSuw.Text);
                komut.Parameters.AddWithValue("@p3", TxtGaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtAzyk.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonal.Text);
                komut.Parameters.AddWithValue("@p7", TxtBasgalar.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bilgliler Täzelendi !!! ");
                //  this.cykdayjylarTableAdapter.Fill(this.talyplarOyiDataSet4.Cykdayjylar);
            }
            catch (Exception)
            {
                MessageBox.Show("Ýalňyşlyk Täzeden Barlap Görüň !!!");
            }
        }
    }
}
