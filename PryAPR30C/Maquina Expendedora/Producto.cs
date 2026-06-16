using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_2_MAQUINA_EXPENDEDORA
{
    internal class Producto
    {
        private string nombre;
        private float precio;
        private int existencia;

        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public float Precio 
        {
            get { return precio; }
            set 
            {
                if (value >= 0)
                {
                    precio = value;
                }
                else
                {
                    precio = 0;
                }
            }
                
            
        }
        public int Existencia 
        {
            get { return existencia; }
            set 
            {
                if (value >= 0) 
                {
                    existencia = value;
                }
                else 
                {
                    existencia= 0;
                }
            }
        }

        public Producto(string nombre, float  precio, int existencia_inicial) 
        {
            this .nombre = nombre;
            this .precio = precio;
            this.existencia = existencia_inicial;
        }
        public string Comprar(int cantidad) 
        {
            if (existencia == 00) 
            {
                return "EL PRODUCTO" + nombre + "ESTA AGOTADO";
            }
            if (cantidad > existencia) 
            {
                return "NO HAY SUFICIENTES SOLO QUEDAN " + existencia + "DISPONIBLES";
            }
            else 
            {
                existencia = existencia - cantidad;
                float total = precio * cantidad;
                return "VENTA EXITOSA DE" + cantidad + nombre + "\n" + "EL TOTAL A PAGAR ES:" + total;
            }
        }
        public string Surtir(int cantidad)
        {
            if (cantidad > 0)
            {
                existencia = existencia + cantidad;
                return "SE AGREGARON " + cantidad + " PIEZAS  TOTAL DISPONIBLE: " + existencia;
            }
            else
            {
                return "ERROR INGRESA UNA CANTIDAD MAYOR A CERO";
            }
        }
    }
}
