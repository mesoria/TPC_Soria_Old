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
    public partial class FrmHome : Form
    {
        Persona personaLocal = new Persona();
        public FrmHome()
        {
            InitializeComponent();
        }

        private void validar()
        {
            if(personaLocal.Usuario.Perfil == "Proveedor")
            {
                btnCatalogo.Hide();
                btnNewInvoice.Hide();
            }
            else if(personaLocal.Usuario.Perfil == "Cliente")
            {
                btnProveedor.Hide();
                btnNewInvoice.Hide();
                //btnNewInvoice.Enabled = false;
            }
            else if (personaLocal.Usuario.Perfil == "Usuario")
            {
                btnProveedor.Hide();
                //btnProveedor.Enabled = false;
            }
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
        private void ejecutar(Persona persona)
        {
            personaLocal = persona;
            lblPerfil.Text = personaLocal.Usuario.Perfil;
            lblNomyApe.Text = personaLocal.Apellido+" "+ persona.Nombre;
            validar();
        }
        private void FrmHome_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Atras += new FrmLogin.pasar(ejecutar);
            frmLogin.ShowDialog();

            //Persona persona = new Persona();
            //lblNombre.Text = persona.Nombre;
            //lblApellido.Text = persona.Apellido;
        }

        private void MenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuListarUsuario_Click(object sender, EventArgs e)
        {
            FrmListar frmListar = new FrmListar();
            frmListar.Show();
        }

        private void MenuListarProductos_Click(object sender, EventArgs e)
        {
            FrmListar frmListar = new FrmListar();
            frmListar.Show();
        }

        private void MenuCerrarSesion_Click(object sender, EventArgs e)
        {
            //FrmHome_Load(object sender, EventArgs e);
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Atras += new FrmLogin.pasar(ejecutar);
            frmLogin.ShowDialog();
        }
    }
}
