using PRAC_2_MAQUINA_EXPENDEDORA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAPR30C.Maquina_Expendedora
{
    public partial class FMRMaquinaExpendedora : Form
    {
        Producto[] vitrina = new Producto[4];
        public FMRMaquinaExpendedora()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void FMRMaquinaExpendedora_Load(object sender, EventArgs e)
        {
           
            vitrina[0] = new Producto("CHETOS AZULES", 17.50f, 5);
            vitrina[1] = new Producto("COCA COLA", 22.00f, 6);
            vitrina[2] = new Producto("GALLETAS OREO", 19.00f, 7);
            vitrina[3] = new Producto("BOING DE MANZANA", 15.00f, 8);

            comboBox1.Items.Add(vitrina[0].Nombre);
            comboBox1.Items.Add(vitrina[1].Nombre);
            comboBox1.Items.Add(vitrina[2].Nombre);
            comboBox1.Items.Add(vitrina[3].Nombre);

            ActualizarStockVisual();

        }
        private void ActualizarStockVisual()
        {
            label3.Text = vitrina[0].Nombre + " - $" + vitrina[0].Precio + " - Disponibles: " + vitrina[0].Existencia;
            label4.Text = vitrina[1].Nombre + " - $" + vitrina[1].Precio + " - Disponibles: " + vitrina[1].Existencia;
            label5.Text = vitrina[2].Nombre + " - $" + vitrina[2].Precio + " - Disponibles: " + vitrina[2].Existencia;
            label6.Text = vitrina[3].Nombre + " - $" + vitrina[3].Precio + " - Disponibles: " + vitrina[3].Existencia;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex;


            if (indice != -1)
            {
                int cantidad = (int)numericUpDown1.Value;

                string resultado = vitrina[indice].Comprar(cantidad);
                MessageBox.Show(resultado, "Aviso de la Máquina");
                ActualizarStockVisual();
            }
            else
            { 
                MessageBox.Show("Por favor, seleccione un producto de la lista primero.", "Error");
            }
        }
    }
}
