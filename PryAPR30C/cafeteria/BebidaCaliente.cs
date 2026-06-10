using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteria2.cafeteria
{
    internal class BebidaCaliente: Bebida
    {
    
        private float Temperatura;

      
        public float temperatura
        {
            get { return Temperatura; } 
            set { Temperatura = value; }
        }

        public BebidaCaliente(string _nombre, string _tamaño, float _precio, float _temperatura) :base(_nombre, _tamaño, _precio)
        {
            Temperatura = _temperatura;    
        }
        public override string Preparar()
        {
            return "Preparando un: "+ Nombre + " de tamaño: "  + Tamaño + " Con Temperatura: " + Temperatura;
        }

      
    }
}
