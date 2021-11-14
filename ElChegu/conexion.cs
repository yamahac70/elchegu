using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ElChegu
{
    class conexion
    {
         String conexiond= "Data Source=DESKTOP-OCQK3I5;Initial Catalog=elchegu; Integrated Security=true";
        public SqlConnection con = new SqlConnection();
        public  conexion()
             {
                con.ConnectionString = conexiond;
            
            }
        public void abrir()
        {
            try {
                con.Open();
                Console.WriteLine("conectado");
            } catch (Exception err) {
                Console.WriteLine(err);
            }
        }

        //fin de abrir

        //***
        //* inicia consulta
        public DataTable trarDatos()
        {
        
                
                String q = "SELECT * FROM elChegudb";
                SqlCommand com = new SqlCommand(q, con);
                SqlDataAdapter data = new SqlDataAdapter(com);
                DataTable d = new DataTable();
            data.Fill(d);
            return d;

                // int nombre = com.ExecuteNonQuery();

            // Console.WriteLine(nombre);


        }
    }
}
