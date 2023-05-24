using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_de_Desempeño
{
     class ConexionBD
    {
        string cadena = "Data Source=localhost;Initial Catalog=DBprueba;Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }
        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex.Message);
            }
            
            
        }
         public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
