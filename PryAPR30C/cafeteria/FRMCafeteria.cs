using pryCafeteria2.cafeteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAPR30C.cafeteria
{
    public partial class FRMCafeteria : Form
    {
        private List<Bebida> bebidas;

        public FRMCafeteria()
        {
            InitializeComponent();
            bebidas = new List<Bebida>();

        }

        private void FRMCafeteria_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (rbCaliente.Checked == true)
            {
                lblExtra.Text = "Temperatura (°C)";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtBebida.Text;
                float precio = float.Parse(txtPrecio.Text.Trim());
                string tamaño = cmTamaño.Text;

                
                float extra = float.Parse(txtExtra.Text.Trim());

                if (rbCaliente.Checked == true)
                {

                    bebidas.Add(new BebidaCaliente(nombre, tamaño, precio, (int)extra));
                }
                else if (rbFria.Checked == true)
                {
                    bebidas.Add(new BebidaFria(nombre, tamaño, precio, (int)extra));
                }
                else if (rbAlcoholica.Checked == true)
                {
                   
                    bool importada = chkImportada.Checked;

                    bebidas.Add(new BebidaAlcoholica(nombre, tamaño, precio, extra, importada));
                }
                listBox1.Items.Add(txtBebida.Text);
                lblContador.Text = "LLEVAS " + bebidas.Count + " Bebidas(s) RegistradaA(s)";
                MessageBox.Show("Bebida agregada correctamente, tienes: " + bebidas.Count + " bebidas registradas", "Éxito");
                LimpiaCajas();
            }
            catch (FormatException)
            {
               
                MessageBox.Show("Por favor, ingresa solo números en el Precio y en el campo Extra.", "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
        private void LimpiaCajas()
        { 
            txtBebida.Clear();
            txtPrecio.Clear();
            txtExtra.Clear();
            cmTamaño.SelectedIndex = -1;
            rbFria.Checked = false;
            rbCaliente.Checked = false;
            rbAlcoholica.Checked = false;
            chkImportada.Checked = false;
        }

        private void lblExtra_Click(object sender, EventArgs e)
        {

        }

        private void rbFria_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFria.Checked == true)
            {
                lblExtra.Text = "Cantidad de Hielos";
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {

                int posicion = listBox1.SelectedIndex;


                int indice = listBox1.SelectedIndex;
                lblPreparacion.Text = bebidas[indice].Preparar();
            }
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAlcoholica.Checked == true)
            {
                lblExtra.Text = "Grados de Alcohol (%)";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblPreparacion_Click(object sender, EventArgs e)
        {

        }
    }
}
