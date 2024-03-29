﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Direccion
    {
        public string       Calle { get; set; }
        public int          Numero { get; set; }
        public string       Departamento { get; set; }
        public int          Piso { get; set; }
        public CodigoPostal CP { get; set; }
        public override string ToString()
        {
            return Calle+", "+Numero;
        }
    }
}
