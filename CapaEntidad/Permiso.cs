﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    internal class Permiso
    {
        public int IdPermiso { get; set; }
        public Rol oRol { get; set; }
        public string NombreMenu { get; set; }
    }
}