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
    public partial class FrmNuevoUsuario : Form
    {
        PersonaNegocio negocio = new PersonaNegocio();
        Persona personaLocal = null;
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }
        public FrmNuevoUsuario(Persona persona)
        {
            personaLocal = persona;
            InitializeComponent();
        }
        private void FrmAgragarUsuario_Load(object sender, EventArgs e)
        {
            //UsuarioNegocio usuarioNegocio = new UsuarioNegocio();
            //DireccionNegocio direccionNegocio = new DireccionNegocio();
            try
            {
                //Fernando Gaitan
                //cboPerfil.DataSource = usuarioNegocio.listarUsuarios();

                if (personaLocal != null)
                {
                    tbxName.Text    = personaLocal.Nombre;
                    tbxSurname.Text = personaLocal.Apellido;
                    tbxDNI.Text     = personaLocal.DNI;
                    dateNac.Value   = personaLocal.Nacimiento;
                    tbxEmail.Text   = personaLocal.Email;
                    tbxDirec.Text   = personaLocal.Direccion.Calle;
                    tbxNumber.Text  = personaLocal.Direccion.Numero.ToString();

                    //ckbCapa.Checked = heroeLocal.UsaCapa;
                    //cboPerfil.SelectedIndex = cboPerfil.FindString(personaLocal.Usuario.Perfil);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Heroe heroe = new Heroe();
            try
            {
                //MSF-20190420: ahora pasamos a usar siempre la variable heroeLocal, si vino algo de afuera, lo usamos
                //pero sino, tenemos que crear un heroe nuevo.
                if (personaLocal == null)
                {
                    personaLocal = new Persona();
                }
                personaLocal.Nombre = tbxName.Text;
                personaLocal.Apellido = tbxSurname.Text;
                personaLocal.DNI = tbxDNI.Text;
                personaLocal.Nacimiento = dateNac.Value;
                personaLocal.Email = tbxEmail.Text;

                personaLocal.Direccion = new Direccion()
                {
                    Calle = tbxDirec.Text,
                    Numero = int.Parse(tbxNumber.Text)
                };
                    //personaLocal.Email = (Universo)cboUniverso.SelectedItem;
                //MSF-20190420: si el heroe tienen ID es porque vino uno existente de afuera, entonces lo modifico.
                //Sino, es porque lo acabo de crear, entonces lo mando a agregar.
                //if (personaLocal.ID != 0)
                //{
                 //   negocio.modificarPersona(personaLocal);
                //}
                //else
                //{
                    //InscripcionNegocio incripcion = new InscripcionNegocio();
                    FrmPerfil frmPerfil = new FrmPerfil(personaLocal);
                    frmPerfil.ShowDialog();
                    //negocio.agregarPersona(personaLocal);
                    //incripcion.AgregarInscripcion(personaLocal);
                //}

                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
