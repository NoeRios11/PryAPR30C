using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteria2.cafeteria
{
    internal class BebidaFria:Bebida
    {
        private int hielos;

        public int Hielos
        {
            get { return hielos; }
            set { hielos = value; }
        }

        public BebidaFria(string _nombre, string _tamaño, float _precio, int _hielos) : base(_nombre, _tamaño, _precio)
        {
            Hielos = _hielos;
        }
        public override string Preparar()
        {
            return "Estamos preparando un: " + Nombre + " Helado" + " (Con " + Hielos + " cubos de hielo) tamaño:" + Tamaño;
        }
    }
}
