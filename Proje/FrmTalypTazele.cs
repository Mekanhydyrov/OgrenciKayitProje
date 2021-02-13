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
    public partial class FrmTalypTazele : Form
    {
        public FrmTalypTazele()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        public string id, ad, familya, pasNo, TalpTel, Dyil, bolum, mail, Otagno, EneAtaAd, EneAtaTel, masgaAdres;

        private void BtnPoz_Click(object sender, EventArgs e)
        {
            // Talyby Sanowdan çykarma

            SqlCommand komutpoz = new SqlCommand("delete from Talyp where Talypid=@b1", bgl.baglanti());
            komutpoz.Parameters.AddWithValue("@b1", TxtTalypid.Text);
            komutpoz.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Talyp Sanowdan Çykaryldy !!! ");

            // Otagda aktiw Talyplary azaltma

            SqlCommand komutotag = new SqlCommand("update OtaglarTalp set OdaAktiw=OdaAktiw-1 where OtagNo=@otag", bgl.baglanti());
            komutotag.Parameters.AddWithValue("@otag", comOtagNo.Text);
            komutotag.ExecuteNonQuery();
            bgl.baglanti().Close();
        }

        private void BtnTazele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Talyp set TalypAd=@g2,TalypSoyad=@g3,TalypPasNo=@g4,TalypTelefon=@g5,TalypDogum=@g6,TalypBolum=@g7,TalypMail=@g8,TalypOtagNo=@g9,TalypEneAtaAdy=@g10,TalypEneAtaTel=@g11,TalypMasgalaAdrs=@g12 where Talypid=@g1", bgl.baglanti());
                komut.Parameters.AddWithValue("@g1", TxtTalypid.Text);
                komut.Parameters.AddWithValue("@g2", TxbAd.Text);
                komut.Parameters.AddWithValue("@g3", TxbFamilya.Text);
                komut.Parameters.AddWithValue("@g4", maskdPasNo.Text);
                komut.Parameters.AddWithValue("@g5", maskdTelNo.Text);
                komut.Parameters.AddWithValue("@g6", maskdDoglanYil.Text);
                komut.Parameters.AddWithValue("@g7", comBolum.Text);
                komut.Parameters.AddWithValue("@g8", TxbMail.Text);
                komut.Parameters.AddWithValue("@g9", comOtagNo.Text);
                komut.Parameters.AddWithValue("@g10", TxbEneAtaAd.Text);
                komut.Parameters.AddWithValue("@g11", maskdEneAtaTel.Text);
                komut.Parameters.AddWithValue("@g12", richAdres.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Ýazgy Täzelendi !!!");

            }
            catch (Exception)
            {
                MessageBox.Show("Näsazlyk !!!  Täzeden Barlap Görüň !!!");
            }
        }

        private void FrmTalypTazele_Load(object sender, EventArgs e)
        {
            TxtTalypid.Text = id;
            TxbAd.Text = ad;
            TxbFamilya.Text = familya;
            maskdPasNo.Text = pasNo;
            maskdTelNo.Text = TalpTel;
            maskdDoglanYil.Text = Dyil;
            comBolum.Text = bolum;
            TxbMail.Text = mail;
            comOtagNo.Text = Otagno;
            TxbEneAtaAd.Text = EneAtaAd;
            maskdEneAtaTel.Text = EneAtaTel;
            richAdres.Text = masgaAdres;
        }
    }
}
