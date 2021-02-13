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
    public partial class FrmPersonal : Form
    {
        public FrmPersonal()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet7.Personal' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personalTableAdapter.Fill(this.talyplarOyiDataSet7.Personal);

        }

        private void Btnytsak_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Personal (PersonelAdSoyad,PersonelDepartman) values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonalAtFa.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonalWezipe.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ýönetiji Goşuldy ! ");
            this.personalTableAdapter.Fill(this.talyplarOyiDataSet7.Personal);

        }

        private void BtnPersonalPoz_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from Personal where Personelid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtPerid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ýönetiji Systemadan Aýyryldy !!! ");
            this.personalTableAdapter.Fill(this.talyplarOyiDataSet7.Personal);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int saylanan;
            saylanan = dataGridView1.SelectedCells[0].RowIndex;
            string ad, wezipe, id;
            id = dataGridView1.Rows[saylanan].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[saylanan].Cells[1].Value.ToString();
            wezipe = dataGridView1.Rows[saylanan].Cells[2].Value.ToString();

            TxtPerid.Text = id;
            txtPersonalAtFa.Text = ad;
            TxtPersonalWezipe.Text = wezipe;
        }

        private void BtnPersonalTazele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update Personal set PersonelAdSoyad=@p1, PersonelDepartman=@p2 where Personelid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtPersonalAtFa.Text);
            komut.Parameters.AddWithValue("@p2", TxtPersonalWezipe.Text);
            komut.Parameters.AddWithValue("@p3", TxtPerid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Täzeleme Işlemiňiz Ýapyldy ");
            this.personalTableAdapter.Fill(this.talyplarOyiDataSet7.Personal);
        }
    }
}
