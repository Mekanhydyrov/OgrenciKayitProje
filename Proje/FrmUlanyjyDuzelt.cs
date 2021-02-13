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
    public partial class FrmUlanyjyDuzelt : Form
    {
        public FrmUlanyjyDuzelt()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet5.AdminParol' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.adminParolTableAdapter.Fill(this.talyplarOyiDataSet5.AdminParol);

        }

        private void BtnYatdaSakla_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into AdminParol (YoneticiAd,YoneticiParol)values (@p1,@p2)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", texUlanyjyAdy.Text);
            komut.Parameters.AddWithValue("@p2", txtParol.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Byr Ulanyjy Goşuldy ! ");
            this.adminParolTableAdapter.Fill(this.talyplarOyiDataSet5.AdminParol);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int saylanan;
            saylanan = dataGridView1.SelectedCells[0].RowIndex;
            string ad, parol, id;
            id = dataGridView1.Rows[saylanan].Cells[0].Value.ToString();
            ad = dataGridView1.Rows[saylanan].Cells[1].Value.ToString();
            parol = dataGridView1.Rows[saylanan].Cells[2].Value.ToString();

            TxtUlanyjyid.Text = id;
            texUlanyjyAdy.Text = ad;
            txtParol.Text = parol;

        }

        private void BtnPoz_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from AdminParol where Yoneticiid=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtUlanyjyid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Parol Systemadan Aýyryldy !!! ");
            this.adminParolTableAdapter.Fill(this.talyplarOyiDataSet5.AdminParol);
        }

        private void BtnTazele_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update AdminParol set YoneticiAd=@g1,YoneticiParol=@g2 where Yoneticiid=@g3", bgl.baglanti());
            komut.Parameters.AddWithValue("@g1", texUlanyjyAdy.Text);
            komut.Parameters.AddWithValue("@g2", txtParol.Text);
            komut.Parameters.AddWithValue("@g3", TxtUlanyjyid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Täzeleme Işlemiňiz Ýapyldy ");
            this.adminParolTableAdapter.Fill(this.talyplarOyiDataSet5.AdminParol);
        }
    }
}
