using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuatrimestral_Soria
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            FrmAgragarUsuario frmNewU = new FrmAgragarUsuario();
            //frmNewU.MdiParent = this;
            frmNewU.Show();
        }
    }
}
