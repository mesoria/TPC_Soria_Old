using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;
using AccesoDatos;

namespace Negocio
{
    public class PersonaNegocio
    {
        public List<Persona> listarPersonas()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Persona> listado = new List<Persona>();
            Persona persona;
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "Select p.ID, p.Nombre, p.Apellido, p.DNI, p.Nacimiento, p.Email, p.Calle, p.Numero, " +
                    "p.Contraseña, u.Perfil From PERSONAS as p INNER JOIN INSCRIPCIONES AS INST ON INST.IDP=p.ID " +
                    "INNER JOIN USUARIOS AS U ON U.ID=INST.IDU";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    persona                     = new Persona();
                    persona.ID                  = lector.GetInt32(0);
                    persona.Nombre              = lector.GetString(1);
                    persona.Apellido            = lector.GetString(2);
                    persona.DNI                 = lector.GetString(3);
                    persona.Nacimiento          = lector.GetDateTime(4);
                    persona.Email               = lector.GetString(5);
                    persona.Direccion = new Direccion();
                    persona.Direccion.Calle     = lector.GetString(6);
                    persona.Direccion.Numero    = (int)lector["Numero"];
                    persona.Usuario = new Usuario();
                    persona.Usuario.Contraseña  = lector["Contraseña"].ToString();
                    persona.Usuario.Perfil      = lector["Perfil"].ToString();
                    //persona.Usuario.Contraseña  = lector.GetString(5);
                    //persona.Usuario.Perfil      = lector.GetString(6);

                    /*
                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.
                    if (!Convert.IsDBNull(lector["Debilidad"]))
                        nuevo.Debilidad = lector.GetString(2);

                    if (!Convert.IsDBNull(lector["UsaCapa"]))
                        nuevo.UsaCapa = (bool)lector["UsaCapa"];

                    if (!Convert.IsDBNull(lector["Volador"]))
                        nuevo.Volador = (bool)lector["Volador"];
                        */

                    listado.Add(persona);
                }

                return listado;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void agregarPersona(Persona persona)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: le agregué todas las columnas. Teniendo en cuenta inclusive lo que elegimos en el combo de selección..
                comando.CommandText = "insert into PERSONAS (Nombre, Apellido, DNI, Nacimiento, Email, Calle, Numero, Contraseña) values";
                comando.CommandText += "('" + persona.Nombre.ToString() + "', '" + persona.Apellido.ToString() + "', '" + persona.DNI.ToString()
                + "','" + persona.Nacimiento.ToString() + "', '" + persona.Email.ToString() + "', '"+ persona.Direccion.Calle.ToString()
                + "'," + persona.Direccion.Numero + ",'" + persona.Usuario.Contraseña.ToString() + "' )";
                comando.Connection = conexion;
                conexion.Open();

                comando.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void modificarPersona(Persona modificar)
        {
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("update PERSONAS Set Nombre=@Nombre, Apellido=@Apellido, DNI=@dni, EMAIL=@email," +
                    " Nacimiento=@Nac, Contraseña=@Contraseña Where ID=" + modificar.ID);
                accesoDatos.Comando.Parameters.Clear();
                accesoDatos.Comando.Parameters.AddWithValue("@Nombre", modificar.Nombre);
                accesoDatos.Comando.Parameters.AddWithValue("@Apellido", modificar.Apellido);
                accesoDatos.Comando.Parameters.AddWithValue("@dni", modificar.DNI);
                accesoDatos.Comando.Parameters.AddWithValue("@Nac", modificar.Nacimiento);
                accesoDatos.Comando.Parameters.AddWithValue("@email", modificar.Email);
                accesoDatos.Comando.Parameters.AddWithValue("@Contraseña", modificar.Usuario.Contraseña);
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
        public Persona isUser(string DNI, string Pass)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            Persona persona = new Persona();
            try
            {
                conexion.ConnectionString = AccesoDatosManager.cadenaConexion;
                comando.CommandType = System.Data.CommandType.Text;
                //MSF-20190420: agregué todos los datos del heroe. Incluso su universo, que lo traigo con join.
                comando.CommandText = "Select p.ID, p.Nombre, p.Apellido, p.DNI, p.Nacimiento, p.Email, p.Calle, p.Numero, " +
                    "p.Contraseña, u.Perfil From PERSONAS as p INNER JOIN INSCRIPCIONES AS INST ON INST.IDP=p.ID " +
                    "INNER JOIN USUARIOS AS U ON U.ID=INST.IDU where DNI='" + DNI + "' and Contraseña='" + Pass + "'";
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    persona.ID                  = lector.GetInt32(0);
                    persona.Nombre              = lector.GetString(1);
                    persona.Apellido            = lector.GetString(2);
                    persona.DNI                 = lector.GetString(3);
                    persona.Nacimiento          =(DateTime)lector["Nacimiento"];
                    persona.Email               = lector.GetString(5);
                    /*Direccion direccion = new Direccion
                    {
                        Calle = lector.GetString(5),
                        Numero = (int)lector["Numero"]
                    };*/
                    persona.Direccion = new Direccion
                    {
                        Calle = lector.GetString(6),
                        Numero = (int)lector["Numero"]
                    };
                    persona.Usuario = new Usuario();
                    persona.Usuario.Contraseña  = lector.GetString(8);
                    persona.Usuario.Perfil      = lector.GetString(9);

                    /*
                    //MSF-20190420: acá manejamos un posible nulo desde la DB. Recuerdan que la otra vez nos falló?
                    //Era porque en la DB estaba nulo y acá lo queríamos tomar y no le gustaba.
                    //Ojo... en la tabla no todas las columnas van a ser nuleables... en nuestro caso porque no le dimos
                    //importancia casi al diseño de la misma. Pero si está bien armada la tabla, serán pocas las columnas
                    //que sean nulleables. Solo a esa deberían agregarles ésta validación. Que de hecho pueden meter en un método
                    //para no tener que escribirla completa cada vez, por ejemplo.
                    if (!Convert.IsDBNull(lector["Debilidad"]))
                        nuevo.Debilidad = lector.GetString(2);

                    if (!Convert.IsDBNull(lector["UsaCapa"]))
                        nuevo.UsaCapa = (bool)lector["UsaCapa"];

                    if (!Convert.IsDBNull(lector["Volador"]))
                        nuevo.Volador = (bool)lector["Volador"];

                    nuevo.Universo = new Universo();
                    nuevo.Universo.Id = (int)lector["IdUniverso"];
                    nuevo.Universo.Nombre = lector["Descripcion"].ToString();
                    */
                    //listado.Add(persona);
                }
                return persona;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
        }
        public void AgregarInscripcion(Persona persona)
        {
            //SqlConnection conexion = new SqlConnection();
            //SqlCommand comando = new SqlCommand();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            try
            {
                accesoDatos.setearConsulta("insert into INSCRIPCIONES (IDP, IDU, INICIO) values ('" + persona.ID.ToString() +
                "','" + persona.Usuario.ID.ToString() + "', '" + persona.Email.ToString() + "')");
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

    }
}
