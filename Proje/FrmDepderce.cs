using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TalyplarOyiSystema
{
    public partial class FrmDepderce : Form
    {
        public FrmDepderce()
        {
            InitializeComponent();
        }

        private void BtnSakla_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Title = " Şeýle Ýatda Sakla";
                saveFileDialog1.Filter = "Täze Tekst Resminama | *.txt";
                saveFileDialog1.InitialDirectory = @"E:\Guvanç Yazgulyyew Program Kod\60 Ders SQL C# Talyplar öyi systemasy\TalyplarOyiSystema\bin\Debug\Notlar";
                saveFileDialog1.ShowDialog();
                StreamWriter sakla = new StreamWriter(saveFileDialog1.FileName);
                sakla.WriteLine(richTextBox1.Text);
                sakla.Close();
                MessageBox.Show(" İşlemiňiz Ýerine Ýetirildi !!! ");
            }
            catch (Exception)
            {
                MessageBox.Show("Not Ýazylmady !!!");
            }
        }
    }
}
// Şeýle Ýatda Sakla
