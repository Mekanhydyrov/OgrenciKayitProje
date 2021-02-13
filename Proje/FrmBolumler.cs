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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmBolumler_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet.Bolumler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.bolumlerTableAdapter.Fill(this.talyplarOyiDataSet.Bolumler);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pcbEkle_Click(object sender, EventArgs e)
        {
            try
            {

                SqlCommand komut1 = new SqlCommand("insert into Bolumler(BolumAd)values (@p1)", bgl.baglanti());
                komut1.Parameters.AddWithValue("@p1", textBolumAd.Text);
                komut1.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bölüm Kabul Edildi !!! ");
                this.bolumlerTableAdapter.Fill(this.talyplarOyiDataSet.Bolumler);
            }
            catch
            {
                MessageBox.Show("Ýalňyşlyk !!! Bölüm kabul Edilmedi !!!");
            }
        }

        private void pcbSil_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand komut2 = new SqlCommand("delete from Bolumler where Bolumid=@p1",bgl.baglanti());
                komut2.Parameters.AddWithValue("@p1", txtBolumid.Text);
                komut2.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Arassalama Işleri Geçirildi !!! ");
                this.bolumlerTableAdapter.Fill(this.talyplarOyiDataSet.Bolumler);
            }
            catch (Exception)
            {
                MessageBox.Show("Ýalňyşlyk !!!");
            }
        }

        int saylanan;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumad;
            saylanan = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[saylanan].Cells[0].Value.ToString();
            bolumad = dataGridView1.Rows[saylanan].Cells[1].Value.ToString();


            txtBolumid.Text = id;
            textBolumAd.Text = bolumad;
        }

        private void pcbDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
          
                SqlCommand komut3 = new SqlCommand("update Bolumler Set BolumAd=@p1 where Bolumid=@p2",bgl.baglanti());
                komut3.Parameters.AddWithValue("@p2", txtBolumid.Text);
                komut3.Parameters.AddWithValue("@p1", textBolumAd.Text);
                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Systema Täzelendirildi !!!");
                this.bolumlerTableAdapter.Fill(this.talyplarOyiDataSet.Bolumler);

            }
            catch (Exception)
            {
                MessageBox.Show("Ýalňyşlyk !!!");
            }

        }
    }
}
