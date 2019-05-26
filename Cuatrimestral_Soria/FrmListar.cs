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
    public partial class FrmListar : Form
    {
        private List<Persona> listaPersonaLocal;
        public FrmListar()
        {
            InitializeComponent();
        }
        private void FrmListar_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }
        private void CargarGrilla()
        {
            PersonaNegocio personaNeg = new PersonaNegocio();
            try
            {
                listaPersonaLocal = personaNeg.listarPersonas();
                dgvPersonas.DataSource = listaPersonaLocal;
                //dgvPersonas.Columns[0].Visible = false;
                //dgvPersonas.Columns[1].Visible = false;
                //dgvPersonajes.Columns[4].Visible = false;
                //dgvPersonajes.Columns[5].Visible = false;
                //dgvPersonajes.Columns[5].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                dgvPersonas.DataSource = listaPersonaLocal;
            }
            else
            {
                if (txtBuscar.Text.Length >= 3)
                {
                    List<Persona> lista;
                    lista = listaPersonaLocal.FindAll(X => X.Nombre.Contains(txtBuscar.Text) || X.DNI.Contains(txtBuscar.Text) || X.Apellido.Contains(txtBuscar.Text));
                    dgvPersonas.DataSource = lista;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil();
            frmPerfil.ShowDialog();
            CargarGrilla();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmEdit = new FrmNuevoUsuario( (Persona)dgvPersonas.CurrentRow.DataBoundItem );
            frmEdit.ShowDialog( );
            CargarGrilla();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            FrmNuevoUsuario frmAgragar = new FrmNuevoUsuario();
            frmAgragar.ShowDialog();
            CargarGrilla();
        }

        private void btnEditPerfil_Click(object sender, EventArgs e)
        {
            FrmPerfil frmPerfil = new FrmPerfil( (Persona)dgvPersonas.CurrentRow.DataBoundItem );
            frmPerfil.ShowDialog();
            Close();
        }
    }
}
