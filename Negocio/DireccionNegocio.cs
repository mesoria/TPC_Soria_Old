using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Dominio;

namespace Negocio
{
    public class DireccionNegocio
    {
        public List<Direccion> ListarDirecciones()
        {
            List<Direccion> listado = new List<Direccion>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Direccion direc = new Direccion();
            try
            {
                accesoDatos.setearConsulta("Select calle, Numero from Personas");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();
                while (accesoDatos.Lector.Read())
                {
                    direc = new Direccion();
                    direc.Calle = accesoDatos.Lector.GetString(0);
                    direc.Numero = (int)accesoDatos.Lector["Numero"];
                    listado.Add(direc);
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
    }
}