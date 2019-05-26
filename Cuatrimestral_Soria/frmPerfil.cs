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
    public partial class FrmPerfil : Form
    {
        Persona personaLocal = null;
        public FrmPerfil()
        {
            InitializeComponent();
        }
        public FrmPerfil(Persona persona)
        {
            personaLocal = persona;
            InitializeComponent();
        }

        private void FrmPerfil_Load(object sender, EventArgs e)
        {
            UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            DireccionNegocio direccionNegocio = new DireccionNegocio();
            btnAceptar.Hide();
            
            try
            {
                cbxPerfil.DataSource = usuarioNegocio.listarUsuarios();
                if(personaLocal != null)
                {
                    lblNombreCompleto.Text = personaLocal.Nombre + ", " + personaLocal.Apellido;
                    DNI.Text = personaLocal.DNI;
                    //cbxPerfil.SelectedIndex = cbxPerfil.FindString(personaLocal.Usuario.Perfil);
                }
                //tbxDNI.Text = personaLocal.DNI;
                //dateNac.Value = personaLocal.Nacimiento;
                //tbxEmail.Text = personaLocal.Email;
                //tbxDirec.Text = personaLocal.Direccion.Calle;
                //tbxNumber.Text = personaLocal.Direccion.Numero.ToString();
                //ckbCapa.Checked = heroeLocal.UsaCapa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Heroe heroe = new Heroe();
            PersonaNegocio negocio = new PersonaNegocio();
            UsuarioNegocio usuario = new UsuarioNegocio();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable heroeLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (personaLocal.Usuario == null)
                {
                    personaLocal.Usuario = new Usuario();
                }
                personaLocal.Usuario = new Usuario();

                DateTime inicio = new DateTime();
                inicio = DateTime.Today;
                personaLocal.Usuario.Inicio = inicio;
                personaLocal.Usuario.Contraseña = tbxContraseña.Text;
                personaLocal.Usuario.Perfil = cbxPerfil.SelectedItem.ToString();
                
                //personaLocal.Direccion.Numero = tbxNumber;
                //personaLocal.Email = (Universo)cboUniverso.SelectedItem;
                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                if (personaLocal.ID != 0)
                {
                    negocio.modificarPersona(personaLocal);
                }
                else
                {
                    negocio.agregarPersona(personaLocal);
                    personaLocal = negocio.isUser(personaLocal.DNI, personaLocal.Usuario.Contraseña);
                    int IDU = usuario.GetId(personaLocal.Usuario);
                    personaLocal.Usuario.ID = IDU;
                    negocio.AgregarInscripcion(personaLocal);
                }

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxContraseña_TextChanged(object sender, EventArgs e)
        {
            CompararContraseña();
        }
        private void tbxContraseña2_TextChanged(object sender, EventArgs e)
        {
            CompararContraseña();
        }
        private void CompararContraseña()
        {
            if (tbxContraseña.Text.Trim() == tbxContraseña2.Text.Trim() && tbxContraseña.Text.Trim() != "")
            {
                btnAceptar.Visible = true;
            }
        }

    }
}
