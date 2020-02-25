﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria.BL
{
    public class Productos
    {
        public Productos()
        {
            Activo = true;
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }
    }
}
