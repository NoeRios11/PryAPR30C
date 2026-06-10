using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCafeteria2.cafeteria
{
    internal class Bebida
    {
        protected string nombre;
        protected float precio;
        protected string tamaño;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Tamaño
        {
            get { return tamaño;  }
            set { tamaño = value; }
        }
        public float Precio
        {
            get { return precio; }
            set 
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    precio = -1;
                }
            }
        }

        //Constructor Vacio
        public Bebida()
        {
            Precio = 0;
            Nombre = "";
            Tamaño = "";        
        }

        //Constructor de parametros
        public Bebida(string _nombre, string _tamaño, float _precio)
        {
            this.Nombre = _nombre;
            Precio = _precio;
            Tamaño = _tamaño;
        }
        //metodo preparar
        public virtual string Preparar()
        { 
            return "Estamos preparando un: " + Nombre + " de tamaño" + Tamaño; 
        }

        public void Descuento(float descuento)
        {
            Precio = Precio + (1 - (descuento / 100));
        }
    }
}
