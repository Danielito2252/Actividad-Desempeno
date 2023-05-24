using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_de_Desempeño
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //Generamos una instancia hacia el Formulario Registro
            FrmRegistro fp = new FrmRegistro();
            this.Hide(); //Oculto el formulario principal
            fp.ShowDialog();   //Muestro el formulario
            this.Show();      //Muestro el formulario actual
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generamos una instancia hacia el Formulario Consulta
            FrmConsulta fp = new FrmConsulta();
            this.Hide(); //Oculto el Formulario Registro
            fp.ShowDialog();   //Muestro el formulario
            this.Show();      //Muestro el formulario actual
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Generamos una instancia hacia el formulario Registro
            FrmRegistro fp = new FrmRegistro();
            this.Hide(); //Oculto el Formulario Principal
            fp.ShowDialog();   //Muestro el formulario
            this.Show();      //Muestro el formulario actual
        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Generamos una instancia hacia el Formulario Consulta
            FrmConsulta fp = new FrmConsulta();
            this.Hide(); //Oculto el Formulario Registro
            fp.ShowDialog();   //Muestro el formulario
            this.Show();      //Muestro el formulario actual
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
