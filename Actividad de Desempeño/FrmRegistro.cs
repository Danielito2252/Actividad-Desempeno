using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Actividad_de_Desempeño
{
    public partial class FrmRegistro : Form
    {


        public FrmRegistro()
        {
            InitializeComponent();
        }

        

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
           /* Generamos una instancia hacia el Formulario consulta
            FrmPrincipal fp = new FrmPrincipal();
            this.Hide(); //Oculto el formulario registro
            fp.ShowDialog();   //Muestro el formulario
           this.Show();      //Muestro el formulario actual
           */

            ConexionBD conexion = new ConexionBD();
            conexion.abrir();

            string Nombre = TxtNombres.Text;
            string Apellido = TxtApellidos.Text;    
            string Cui = TxtCUI.Text;   
            string Fecha_Nacimiento = TxtFechadenacimiento.Text;    

            string Correo = TxtCorreo.Text; 
            string Direccion = TxtDireccion.Text;   
            string Ciudad = TxtCiudad.Text; 
            string Telefono = TxtNumerodetelefono.Text;


            string cadena = "insert into    PERSONAS  (Nombres, Apellidos, Cui, Fecha_Nacimiento, Correo, Direccion, Ciudad, Telefono) values ('" + TxtNombres.Text + "', '" + TxtApellidos.Text + "','" + TxtCUI.Text + "','" + TxtFechadenacimiento.Text + "', '" + TxtCorreo.Text + "', '" + TxtDireccion.Text + "', '" + TxtCiudad.Text + "', '" + TxtNumerodetelefono + "')";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha empadronado");
            TxtNombres.Text = "";
            TxtApellidos.Text = "";
            TxtCUI.Text = "";
            TxtFechadenacimiento.Text = "";

            TxtCorreo.Text = "";
            TxtDireccion.Text = "";
            TxtCiudad.Text = "";
            TxtNumerodetelefono.Text = "";



        }

        private void FrmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
             //Generamos una instancia hacia el Formulario consulta
          FrmConsulta fp = new FrmConsulta();
          this.Hide(); //Oculto el formulario registro
          fp.ShowDialog();   //Muestro el formulario
         this.Show();      //Muestro el formulario actual
         
        }
    }
}

