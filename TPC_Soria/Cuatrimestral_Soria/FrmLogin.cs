using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace Cuatrimestral_Soria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbxDNI.Text.Trim() == "" || tbxPass.Text.Trim() == "")
            {
                    MessageBox.Show("Debes completar todos los campos");
                    return;
            }
            else
            {
                FrmHome frmhome = new FrmHome();
                //frmhome.MdiParent = this;
                frmhome.Show();
            }
        }
    }
}
