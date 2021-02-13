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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'talyplarOyiDataSet1.Talyp' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.talypTableAdapter.Fill(this.talyplarOyiDataSet1.Talyp);
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();

        }

        private void kalkulýatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.Exe");
        }

        private void radýo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " http://kralpopwmp.radyotvonline.com:80/";
        }

        private void radýo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://37.247.98.8/stream/166/ ";
        }

        private void radýo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://powerdance.listenpowerapp.com/powerdance/mpeg/icecast.audio";
        }

        private void talypBelligeAlyşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTalypBellik fr = new FrmTalypBellik();
            fr.ShowDialog();
            //this.Hide();
        }

        private void talypSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTalypList frl = new FrmTalypList();
            frl.ShowDialog();
        }

        private void talypRedaktirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTalypList fr = new FrmTalypList();
            fr.ShowDialog();
        }

        private void bölümGoşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.ShowDialog();
        }

        private void bölümDüzeltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.ShowDialog();
        }

        private void tölegiAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler fr = new FrmOdemeler();
            fr.ShowDialog();
        }

        private void goşmaçaÇykdaýjyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCykdayjy fr = new FrmCykdayjy();
            fr.ShowDialog();
        }

        private void çykdaýjySpisogyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderList fr = new FrmGiderList();
            fr.ShowDialog();
        }

        private void girdejiStatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGirdejiStatistik fr = new FrmGirdejiStatistik();
            fr.ShowDialog();
        }

        private void çykdaýjyStatistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGiderList fr = new FrmGiderList();
            fr.ShowDialog();
        }

        private void parolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUlanyjyDuzelt fr = new FrmUlanyjyDuzelt();
            fr.ShowDialog();
        }

        private void personalRedaktirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonal fr = new FrmPersonal();
            fr.ShowDialog();
        }

        private void ýazuwDepderçesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepderce fr = new FrmDepderce();
            fr.ShowDialog();
        }

        private void talypBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTalypHasabat fr = new FrmTalypHasabat();
            fr.ShowDialog();
        }

        private void bizHakyndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu programy Talyplar Öyi üçin yagny Yaşayyş jayynda işleyanler üçin yenillik hökminde bu program yazyldy Program yazary Guwanç Yazgulyyew 03.25.2020 ", "Umumy Yaşayyş Jayy", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void çykyşToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
