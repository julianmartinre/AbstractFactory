using AbstractFactory.Factory;
using AbstractFactory.Producto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Produccion
    {
        private static Produccion instance;
        
        public static Produccion GetInstance()
        {
            return instance == null ? instance = new Produccion() : instance;
        }

        public Celular ProducirCelular(Fabrica f)
        {
            return f.CrearCelular();
        }

        public Notebook ProducirNotebook(Fabrica f)
        {
            return f.CrearNotebook();
        }
    }
}
