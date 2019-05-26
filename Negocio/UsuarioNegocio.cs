using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        public List<Usuario> listarUsuarios()
        {
            List<Usuario> listado = new List<Usuario>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Usuario uni = new Usuario();
            try
            {
                accesoDatos.setearConsulta("Select Id, Perfil from USUARIOS");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    uni = new Usuario();
                    uni.ID = (int)accesoDatos.Lector["Id"];
                    //uni.Inicio = (DateTime)accesoDatos.Lector["Inicio"];
                    uni.Perfil = accesoDatos.Lector["Perfil"].ToString();
                    listado.Add(uni);
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
        public int GetId(Usuario usuario)
        {
            int res = 2;
            switch (usuario.Perfil)
            {
                case "Administrador":
                    res = 1;
                    break;
                case "Cliente":
                    res = 2;
                    break;
                case "Usuario":
                    res = 3;
                    break;
                case "Proveedor":
                    res = 4;
                    break;
                default:
                    res = 2;
                    break;
            }
            return res;
        }
        public void AgregarInscripcion(Persona persona)
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                DateTime ahora = new DateTime();
                accesoDatos.setearConsulta("insert into INSCRIPCIONES (IDP, IDU, INICIO) values ('" + persona.ID +
                "','" + persona.Usuario.ID + "', '" +  ahora.ToString() + "')");
                //conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                //comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                //comando.CommandText = "insert into PERSONAS (Nombre, Apellido, DNI, Nacimiento, Email, Calle, Numero, Contraseña) values";
                //comando.CommandText += "('" + persona.Nombre.ToString() + "', '" + persona.Apellido.ToString() + "', '" + persona.DNI.ToString()
                //+ "','" + persona.Nacimiento.ToString() + "', '" + persona.Email.ToString() + "', '" + persona.Direccion.Calle.ToString()
                //+ "','" + persona.Direccion.Numero.ToString() + "','" + persona.Usuario.Contraseña.ToString() + "' )";
                accesoDatos.abrirConexion();
                //comando.Connection = conexion;
                //conexion.Open();
                
                accesoDatos.ejecutarAccion();
                //comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

        public void modificarInscripcion(Persona modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update INSCRIPCIONES Set IDP=@idp," +
                    " IDU=@idu Where IDP=" + modificar.ID);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IDP", modificar.ID);
                accesoDatos.Comando.Parameters.AddWithValue("@IDU", modificar.Usuario.ID);
                //accesoDatos.Comando.Parameters.AddWithValue("@INICIO", modificar.Usuario.Inicio);
                //accesoDatos.Comando.Parameters.AddWithValue("@Perfil", modificar.Usuario.ID);
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarAccion();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }

    }
}
