using AbstractFactory.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public abstract class Fabrica
    {
        public abstract Celular CrearCelular();
        public abstract Notebook CrearNotebook();
    }
}
