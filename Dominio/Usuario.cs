﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int      ID { get; set; }
        public          DateTime Inicio { get; set; }
        public string   Contraseña { get; set; }
        public string   Perfil { get; set; }

        public override string ToString()
        {
            return Perfil;
        }
    }
}
