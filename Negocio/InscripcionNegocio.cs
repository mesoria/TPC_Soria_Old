using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class InscripcionNegocio
    {
        public void AgregarInscripcion(Persona persona)
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("insert into INSCRIPCIONES (IDP, IDU, INICIO) values ('" + persona.Nombre.ToString() +
                "','" + persona.Nacimiento.ToString() + "', '" + persona.Email.ToString() + "')");
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
                    " IDU=@idu, INICIO=@inicio Where IDP=" + modificar.ID);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@IDP", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@IDU", modificar.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@INICIO", modificar.DNI);
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
