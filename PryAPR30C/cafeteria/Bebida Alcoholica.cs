using pryCafeteria2.cafeteria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryAPR30C.cafeteria
{
    internal class BebidaAlcoholica : Bebida
    {
        private float GradosAlcohol;
        private bool EsImportada;

        public float gradosAlcohol
        {
            get { return GradosAlcohol; }
            set { GradosAlcohol = value; }
        }

        public bool esImportada
        {
            get { return EsImportada; }
            set { EsImportada = value; }
        }


        public BebidaAlcoholica(string nom, string tam, float prec, float grados, bool importada)
            : base(nom, tam, prec) 
        {
            GradosAlcohol = grados;
            EsImportada = importada;
        }


        public override string Preparar()
        {
            string origen = EsImportada ? "Importada" : "Nacional";
            return "Preparando: " + Nombre + " (" + Tamaño + ", " + origen + ", " + GradosAlcohol + "%)";
        }

        public string Listar()
        {
            return "Un/a " + Nombre + " Alcohólica";
        }

    }
}
