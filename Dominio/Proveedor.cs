using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Proveedor
    {
        public string ID { get; set; }
        public Direccion Direc { get; set; }
        public Telefono Telefono { get; set; }

    }
}
