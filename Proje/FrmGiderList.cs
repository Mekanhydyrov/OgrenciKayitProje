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
    public partial class FrmGiderList : Form
    {
        public FrmGiderList()
        {
            InitializeComponent();
        }

        private void FrmGiderList_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet4.Cykdayjylar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.cykdayjylarTableAdapter.Fill(this.talyplarOyiDataSet4.Cykdayjylar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int saylanan;
            FrmGiderGuncelle frg = new FrmGiderGuncelle();
            saylanan = dataGridView1.SelectedCells[0].RowIndex;
            frg.id = dataGridView1.Rows[saylanan].Cells[0].Value.ToString();
            frg.elektrik = dataGridView1.Rows[saylanan].Cells[1].Value.ToString();
            frg.suw = dataGridView1.Rows[saylanan].Cells[2].Value.ToString();
            frg.gaz = dataGridView1.Rows[saylanan].Cells[3].Value.ToString();
            frg.internet = dataGridView1.Rows[saylanan].Cells[4].Value.ToString();
            frg.azyk = dataGridView1.Rows[saylanan].Cells[5].Value.ToString();
            frg.personal = dataGridView1.Rows[saylanan].Cells[6].Value.ToString();
            frg.beylekiler = dataGridView1.Rows[saylanan].Cells[7].Value.ToString();
            frg.ShowDialog();

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
