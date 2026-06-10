using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAPR30C.HOLA_MUNDO
{
    public partial class FRMCalculadora : Form
    {
        public FRMCalculadora()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {

            try
            {
                float valor1 = float.Parse(txtvalor1.Text);
                float valor2 = float.Parse(txtvalor2.Text);
                float resultado = valor1 + valor2;

                lblresultado.Text = "Resultado: " + resultado;
                lblresultado.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("se presento el error:" + ex.Message);
            }
            

            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
