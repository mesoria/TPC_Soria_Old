using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Telefono
    {
        public int      ID { get; set; }
        public int      Numero { get; set; }
        public TipoTel  Tipo { get; set; }
    }
}
