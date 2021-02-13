using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalyplarOyiSystema
{
    public partial class FrmTalypList : Form
    {
        public FrmTalypList()
        {
            InitializeComponent();
        }

        private void FrmTalypList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet3.Talyp' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.talypTableAdapter.Fill(this.talyplarOyiDataSet3.Talyp);

        }

        int saylanan;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            saylanan = dataGridView1.SelectedCells[0].RowIndex;
            FrmTalypTazele fr = new FrmTalypTazele();
            fr.id = dataGridView1.Rows[saylanan].Cells[0].Value.ToString();
            fr.ad = dataGridView1.Rows[saylanan].Cells[1].Value.ToString();
            fr.familya = dataGridView1.Rows[saylanan].Cells[2].Value.ToString();
            fr.pasNo = dataGridView1.Rows[saylanan].Cells[3].Value.ToString();
            fr.TalpTel = dataGridView1.Rows[saylanan].Cells[4].Value.ToString();
            fr.Dyil = dataGridView1.Rows[saylanan].Cells[5].Value.ToString();
            fr.bolum = dataGridView1.Rows[saylanan].Cells[6].Value.ToString();
            fr.mail = dataGridView1.Rows[saylanan].Cells[7].Value.ToString();
            fr.Otagno = dataGridView1.Rows[saylanan].Cells[8].Value.ToString();
            fr.EneAtaAd = dataGridView1.Rows[saylanan].Cells[9].Value.ToString();
            fr.EneAtaTel = dataGridView1.Rows[saylanan].Cells[10].Value.ToString();
            fr.masgaAdres = dataGridView1.Rows[saylanan].Cells[11].Value.ToString();


            fr.ShowDialog();
        }
    }
}
// id, ad, familya, pasNo, TalpTel, Dyil, bolum, mail, Otagno, EneAtaAd, EneAtaTel, masgaAdres; 
