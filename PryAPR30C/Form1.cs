using PryAPR30C.HOLA_MUNDO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PryAPR30C.cafeteria;
using PryAPR30C.Maquina_Expendedora;

namespace PryAPR30C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form calculadora = Application.OpenForms["FMRCalculadora"];
            if (calculadora != null) 
            {
                if (calculadora.WindowState == FormWindowState.Minimized) 
                {
                    calculadora.WindowState = FormWindowState.Normal;
                }
            }
            else 
            {
                calculadora=new FRMCalculadora();
                calculadora .MdiParent = this;
                calculadora.FormClosed += (s,args)=> calculadora.Dispose();
                calculadora.Show();
            }
        }

        private void cAFETERIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cafeteria = Application.OpenForms["FMRCafeteria"];
            if (cafeteria != null)
            {
                if (cafeteria.WindowState == FormWindowState.Minimized)
                {
                    cafeteria.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                cafeteria = new FRMCafeteria();
                cafeteria.MdiParent = this;
                cafeteria.FormClosed += (s, args) => cafeteria.Dispose();
                cafeteria.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form maquina = Application.OpenForms["FMRMaquinaExpendedora"];
            if (maquina != null)
            {
                if (maquina.WindowState == FormWindowState.Minimized)
                {
                    maquina.WindowState = FormWindowState.Normal;
                }
            }
            else
            {
                maquina = new FMRMaquinaExpendedora();
                maquina.MdiParent = this;
                maquina.FormClosed += (s, args) => maquina.Dispose();
                maquina.Show();
            }
        }
    }
}
