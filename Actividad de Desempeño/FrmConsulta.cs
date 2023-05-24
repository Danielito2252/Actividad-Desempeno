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
using System.Data.SqlTypes;


namespace Actividad_de_Desempeño
{
    
    public partial class FrmConsulta : Form
    {
        //Conexion a la BD
        SqlConnection conn = new SqlConnection(@" Data Source = localhost; Initial Catalog = DBprueba; Integrated Security = True");
       
        public FrmConsulta()
        {
            InitializeComponent();
        }

        

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*
        private void FrmConsulta_Load(object sender, EventArgs e)
        {

            ConexionBD conexion = new ConexionBD();
            conexion.abrir();
            string cadena = "Select * from PERSONAS";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando); 

            DataTable tabla = new DataTable();  
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;   
        }
        */

        /*
        private void BtnConfirmarconsulta_Click(object sender, EventArgs e)
        {
           cargarDatos();
        }
        private void cargarDatos()
        {
           SqlDataAdapter da = new SqlDataAdapter("select * from Personas ", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            this.dataGridView1.DataSource = dt;
      }
        */

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnConfirmarconsulta_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.abrir();
            string cadena = "Select * from PERSONAS";
            SqlCommand comando = new SqlCommand(cadena, conexion.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
        }
    }

   /* internal class ver
    {
        public static DataTable DataSource { get; internal set; }
    }
   */
}
