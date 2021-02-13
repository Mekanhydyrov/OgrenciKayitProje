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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet2.Borclar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.borclarTableAdapter.Fill(this.talyplarOyiDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int saylanan;
            string id, ad, familya, galan;
            saylanan = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[saylanan].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[saylanan].Cells[1].Value.ToString();
            familya = dataGridView1.Rows[saylanan].Cells[2].Value.ToString();
            galan = dataGridView1.Rows[saylanan].Cells[3].Value.ToString();

            TxtAdy.Text = ad;
            TxtFamilya.Text = familya;
            TxtKalnBorc.Text = galan;
            TxtTalpid.Text = id;



        }

        private void BtnOdemeAl_Click(object sender, EventArgs e)
        {
            // Ödenen Tutarı kalan Tutardan Düşme 

            int odenen, galan, tazeborc;
            odenen = Convert.ToInt16(TxtOdenen.Text);
            galan = Convert.ToInt16(TxtKalnBorc.Text);
            tazeborc = galan - odenen;
            TxtKalnBorc.Text = tazeborc.ToString();

            // Yeni Tutarı Veri Tabanına Kaydetme 

            SqlCommand komut = new SqlCommand("update Borclar set TalypGalanBorc=@p1 where Talypid=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p2", TxtTalpid.Text);
            komut.Parameters.AddWithValue("@p1", TxtKalnBorc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Borç Ödendi !!!");
            this.borclarTableAdapter.Fill(this.talyplarOyiDataSet2.Borclar);


           // TxtAdy.Clear();
           // TxtFamilya.Clear();
           // TxtKalnBorc.Clear();
            //TxtOdenen.Clear();
           // TxtTalpid.Clear();
            //TxtOdenenAy.Clear();

            // Kassa Tablosuna Ekleme Yapma
            SqlCommand komut2 = new SqlCommand("insert into Kassa (OdemeAy,OdemeMikdar) values(@k1,@k2)", bgl.baglanti());
            komut2.Parameters.AddWithValue("@k1", TxtOdenenAy.Text);
            komut2.Parameters.AddWithValue("@k2", TxtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
        }
    }
}
