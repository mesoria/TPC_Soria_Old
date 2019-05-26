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
        public delegate void pasar(Persona persona);
        public event pasar Atras;
        private PersonaNegocio personaNLocal = new PersonaNegocio();
        private Persona personaLocal = new Persona();
        public FrmLogin()
        {
            InitializeComponent();
        }
        public FrmLogin(Persona persona)
        {
            InitializeComponent();
            personaLocal = persona;
        }
        
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbxDNI.Text.Trim() == "" || tbxPass.Text.Trim() == "")
            {
                    MessageBox.Show("Debes completar todos los campos");
                    //return;
            }
            else
            {
                personaLocal = personaNLocal.isUser(tbxDNI.Text, tbxPass.Text);
                if ( (personaLocal.DNI == tbxDNI.Text) && (personaLocal.Usuario.Contraseña == tbxPass.Text ) )
                {
                    //FrmHome frmhome = new FrmHome();
                    //frmhome.MdiParent = this;
                    //frmhome.Show();
                    Atras(personaLocal);
                    Close();
                    //return persona;
                }
                else
                {
                    MessageBox.Show("DNI o Contraseña incorrecta.");
                    tbxDNI.Text = "";
                    tbxPass.Text = "";
                }
            }
        }
    }
}
