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
    public partial class FrmGirdejiStatistik : Form
    {
        public FrmGirdejiStatistik()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmGirdejiStatistik_Load(object sender, EventArgs e)
        {
            // Burada Sum  komutu Veri Tabanındaki verileri yani sayıarı toplamamıza yarar

            SqlCommand komut = new SqlCommand("select Sum(OdemeMikdar)from Kassa", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkassa.Text = oku[0].ToString() + " TMT ";

            }
            bgl.baglanti().Close();

            // Aýlyk Gazanç Manuel
            /* this.chart1.Series["Aýlyk"].Points.AddXY("Fewral", 300);
             this.chart1.Series["Aýlyk"].Points.AddXY("Mart", 420);
             this.chart1.Series["Aýlyk"].Points.AddXY("Aprel", 800);
             */

            // Grafiklere VeriTbanyndan Veri çekmek

            SqlCommand komut3 = new SqlCommand("select OdemeAy,sum (OdemeMikdar) from kassa group by OdemeAy", bgl.baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aýlyk"].Points.AddXY(oku3[0],oku3[1]);
            }
            bgl.baglanti().Close();

            // Tekrarsız olarak Ayları yenileme 
            SqlCommand komut2 = new SqlCommand("select distinct(OdemeAy)from Kassa", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                combAy.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void combAy_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select sum(OdemeMikdar)From Kassa where OdemeAy=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", combAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblSaylananAy.Text = oku[0].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
