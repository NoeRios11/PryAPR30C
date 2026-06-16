using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRAC_2_MAQUINA_EXPENDEDORA
{
    internal class Program
    {
        static void Mainsecundario(string[] args)
        {
             /*
            TIPOS DE DATOS  
            USE FLOAT PARA EL PRECIO PQ EN AVECES COBRAN CON CENTAVOS 
            PARA MI INVENTARIO USE INT PORQUE LS PRODUCTOS NO SE PUEDEN VENDER POR MITAD NO PUEDO COMPRAR MEDIA SABRITA DE CHETOS 
             
            ENCAPSULAMIENTO 
            MIS VARIABLES EN PRIVATE PARA DARLE PROTECCION A MI MAQUINA 
            EN EL MENU PRINCIPAL NO SE PUEDE METER LA MANO AL LO QUE VENDO O PONER NUMEROS NEGATIVOS POR ERROR
            SI ALGUIEN EN EL MENU QUIERE CAMBIAR UN DATO A FUERZA DEBE TIENE QUE USAR OPCIONES DE COMPRA O SURTIR DONDE YA LOS PUSE
            */
            Producto[] vitrina = new Producto[4];


            vitrina[0] = new Producto("CHETOS AZULES", 17.50f, 5);
            vitrina[1] = new Producto("COCA COLA", 22.00f, 6);
            vitrina[2] = new Producto("GALLETAS OREO", 19.00f, 7);
            vitrina[3] = new Producto("BOING DE MANZANA", 15.00f, 8);

            int cantidad = 0;
            bool ejecutar = true;
            while (ejecutar)
            {
               
                Console.WriteLine(" BIENVENIDO ALA MAQUINA EXPENDEDORA");
             ;

             
                for (int i = 0; i < vitrina.Length; i++)
                {
                    Console.WriteLine((i + 1) + "- " + vitrina[i].Nombre + " \t- $" + vitrina[i].Precio + " CANTIDAD DISPONIBLE: " + vitrina[i].Existencia );
                }
                Console.WriteLine("5- SURTIR LOS PRODUCTOS");
                Console.WriteLine("6- SALIR");
                Console.Write("SELECCIONA UNA OPCION: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion >= 1 && opcion <= vitrina.Length)
                {
                    Console.Write("¿QUE CANTIDAD DESEA COMPRAR?");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                    string resultado = vitrina[opcion - 1].Comprar(cantidad);
                    Console.WriteLine("\n" + resultado);
                }
                else if (opcion == 5)
                {
                    Console.Write("¿QUE NUMERO DE PRODUCTO VAS A SURTIR? 1 AL 4: ");
                    int id = Convert.ToInt32(Console.ReadLine());

                    if (id >= 1 && id <= vitrina.Length)
                    {
                        Console.Write("¿CUANTAS PIEZAS VAS INTRODUCIR?: ");
                        int piezas = Convert.ToInt32(Console.ReadLine());

                        string mensaje = vitrina[id - 1].Surtir(piezas);
                        Console.WriteLine("\n" + mensaje);
                    }
                    else
                    {
                        Console.WriteLine("\n PRODUCTO NO ENCONTRADO.");
                    }
                }

                else if (opcion == 6)
                {
                    ejecutar = false;
                    Console.WriteLine("\nGRACIAS POR USAR LA MAQUINA EXPENDEDORA");
                }
                // Si mete un número que no existe
                else
                {
                    Console.WriteLine("\n OPCION INCORRECTA.. INGRESE UN NUEMERO VALIDO");
                }
                if (ejecutar)
                {
                    Console.WriteLine("\nPRESIONA UNA TECLA CUALQUIERA PARA SEGUIR COMPRANDO..");
                    Console.ReadKey(); 
                    Console.Clear();   
                }

            }
        }    
    }
}
