﻿using AbstractFactory.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class FabricaSamsung : Fabrica
    {
        public override Celular CrearCelular()
        {
            return new CelularA70();
        }

        public override Notebook CrearNotebook()
        {
            return new NotebookX2040();
        }
    }
}
