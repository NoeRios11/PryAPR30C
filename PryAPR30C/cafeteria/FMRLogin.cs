using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryAPR30C.cafeteria
{
    public partial class FMRLogin : Form
    {
        private Form1 principal;
        public FMRLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario=textBox1usuario.Text.Trim();
            string password = textBox2password.Text.Trim();
            if (usuario == "noe" && password == "rios") 
            {
                principal = new Form1();
                principal.Show();
                this.Hide();
            }
            else 
            {
                label4LEYENDA.Text = "CREDENCIALES INCORRECTAS/INTENTA DE NUEVO";
                label4LEYENDA.Visible = true;
                textBox1usuario.Clear();
                textBox2password.Clear();
                textBox1usuario.Focus();
            }
        }

        private void textBox1usuario_Enter(object sender, EventArgs e)
        {
            label4LEYENDA.Visible=false;
        }
    }
}
