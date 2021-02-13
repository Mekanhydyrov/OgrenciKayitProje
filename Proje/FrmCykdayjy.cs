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
    public partial class FrmCykdayjy : Form
    {
        public FrmCykdayjy()
        {
            InitializeComponent();
        }

        SqlBaglanti bgl = new SqlBaglanti();

        private void BtnBelligeAl_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("insert into Cykdayjylar(Elektrik,Suw,Gaz,internet,Azyk,Personal,Beylekiler)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", TxtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", TxtSuw.Text);
                komut.Parameters.AddWithValue("@p3", TxtGaz.Text);
                komut.Parameters.AddWithValue("@p4", Txtinternet.Text);
                komut.Parameters.AddWithValue("@p5", TxtAzyk.Text);
                komut.Parameters.AddWithValue("@p6", TxtPersonal.Text);
                komut.Parameters.AddWithValue("@p7", TxtBasgalar.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Bigiler Sistema Girildi !!! ");
            }
            catch (Exception)
            {
                MessageBox.Show("Näsazlyk !!!  Täzeden Barlap Görüň !!! ");
            }


        }
    }
}
