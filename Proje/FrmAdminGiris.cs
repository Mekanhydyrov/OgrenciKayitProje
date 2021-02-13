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
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();

        private void button1_Click(object sender, EventArgs e)
        {

            FrmAnaForm fr = new FrmAnaForm();
            fr.ShowDialog();
            this.Hide();

            //SqlCommand komut = new SqlCommand("Select * from AdminParol where YoneticiAd=@g1 and YoneticiParol=@g2", bgl.baglanti());
            //komut.Parameters.AddWithValue("@g1", TxtUlanyjyAdy.Text);
            //komut.Parameters.AddWithValue("@g2", TxtParol.Text);
            //SqlDataReader oku = komut.ExecuteReader();
            //if (oku.Read())
            //{
            //    FrmAnaForm fr = new FrmAnaForm();
            //    fr.ShowDialog();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Ýalňyş Parol Täzeden barlap görüň !!!");
            //    TxtUlanyjyAdy.Clear();
            //    TxtParol.Clear();
            //    TxtUlanyjyAdy.Focus();
            //}
            //bgl.baglanti().Close();
        }

        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
