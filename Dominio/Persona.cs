﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Persona
    {
        public int          ID { get; set; }
        public string       Nombre { get; set; }
        public string       Apellido { get; set; }
        public string       DNI { get; set; }
        public DateTime     Nacimiento { get; set; }
        public Direccion    Direccion { get; set; }
        public Telefono     Telefono { get; set; }
        public string       Email { get; set; }
        public Usuario      Usuario { get; set; }

    }
}
