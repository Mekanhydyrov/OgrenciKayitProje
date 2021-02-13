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
    public partial class FrmTalypBellik : Form
    {
        public FrmTalypBellik()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti(); 

        private void FrmTalypBellik_Load(object sender, EventArgs e)
        {
            // Böümleri Listeleme Komutları!!!
            //baglanty.Open();
            SqlCommand komut = new SqlCommand("Select BolumAd From Bolumler", bgl.baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                comBolum.Items.Add(oku[0].ToString());
            }
            bgl.baglanti().Close();

            // Boş Odaları listeleme Komutları!!!!

           // baglanty.Open();
            SqlCommand komut2 = new SqlCommand("Select OtagNo From OtaglarTalp where OtagKapasite!= OdaAktiw", bgl.baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                comOtagNo.Items.Add(oku2[0].ToString());
            }
            bgl.baglanti().Close();
        }

        private void BtnYatdaSakla_Click(object sender, EventArgs e)
        {
            // Ögrenci Bilgilerinin Kayıt edilme Komutu 
            try
            {
                //baglanty.Open();
                SqlCommand komutyatdasakla = new SqlCommand("insert into Talyp (TalypAd,TalypSoyad,TalypPasNo,TalypTelefon,TalypDogum,TalypBolum,TalypMail,TalypOtagNo,TalypEneAtaAdy,TalypEneAtaTel,TalypMasgalaAdrs) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.baglanti());
                komutyatdasakla.Parameters.AddWithValue("@p1", TxbAd.Text);
                komutyatdasakla.Parameters.AddWithValue("@p2", TxbFamilya.Text);
                komutyatdasakla.Parameters.AddWithValue("@p3", maskdPasNo.Text);
                komutyatdasakla.Parameters.AddWithValue("@p4", maskdTelNo.Text);
                komutyatdasakla.Parameters.AddWithValue("@p5", maskdDoglanYil.Text);
                komutyatdasakla.Parameters.AddWithValue("@p6", comBolum.Text);
                komutyatdasakla.Parameters.AddWithValue("@p7", TxbMail.Text);
                komutyatdasakla.Parameters.AddWithValue("@p8", comOtagNo.Text);
                komutyatdasakla.Parameters.AddWithValue("@p9", TxbEneAtaAd.Text);
                komutyatdasakla.Parameters.AddWithValue("@p10", maskdEneAtaTel.Text);
                komutyatdasakla.Parameters.AddWithValue("@p11", richAdres.Text);
                komutyatdasakla.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Talyp Başaryly Şekilde Bilgileri Alyndy !!! ");


                // Ögrenci id yi Labele çekme
                SqlCommand komut = new SqlCommand("select Talypid from Talyp", bgl.baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.baglanti().Close();

                // Ögrenci Borç Alanı oluşturma 
                SqlCommand komutyatdasakla2 = new SqlCommand("insert into Borclar(Talypid,TalypAd,TalypSoyad) values(@b1,@b2,@b3)", bgl.baglanti());
                komutyatdasakla2.Parameters.AddWithValue("@b1", label12.Text);
                komutyatdasakla2.Parameters.AddWithValue("@b2", TxbAd.Text);
                komutyatdasakla2.Parameters.AddWithValue("@b3", TxbFamilya.Text);
                komutyatdasakla2.ExecuteNonQuery();
                bgl.baglanti().Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ýalňyşlyk !!!! TAlyp Bilgileri Alynmady !!!");
            }
            /*
             TxbAd.Clear();
             TxbFamilya.Clear();
             maskdPasNo.Clear();
             maskdTelNo.Clear();
             maskdDoglanYil.Clear();
             comBolum.Text = "";
             TxbMail.Clear();
             comOtagNo.Text = "";
             TxbEneAtaAd.Clear();
             maskdEneAtaTel.Clear();
             richAdres.Clear();
             */

            // Komnatyn Yatak Kontenjanyny Artdtrma

            SqlCommand komutoda = new SqlCommand("update OtaglarTalp set OdaAktiw=OdaAktiw+1 where OtagNo=@oda1", bgl.baglanti());
            komutoda.Parameters.AddWithValue("@oda1", comOtagNo.Text);
            komutoda.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
// SQl de Dosyanin içindeki verileri Sıfırlama kodu          truncate table Talyp
// Data Source=DESKTOP-0K1CF3Q\SQLEXPRESS;Initial Catalog=TalyplarOyi;Integrated Security=True
