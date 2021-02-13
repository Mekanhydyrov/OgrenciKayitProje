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
    public partial class FrmTalypHasabat : Form
    {
        public FrmTalypHasabat()
        {
            InitializeComponent();
        }

        private void FrmTalypHasabat_Load(object sender, EventArgs e)
        {
            reportViewer1.Show();
        }
    }
}
