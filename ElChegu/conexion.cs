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
        public void insertarDatos(String nombre, String producto,String ingredientes,Int32 cantidad,Decimal precioTotal)
        {
            try {
                //String q = "INSERT INTO elchegudb(nombre,producto,ingredientes,cantidad,precio)VALUE('" + nombre + "','" + producto + "','" + ingredientes + "','" + cantidad + "','" + precioTotal + "')";
                String q = "INSERT INTO elchegudb(nombre,productos,ingredientes,cantidad,preciototal)VALUES(@nombre, @producto, @ingredientes, @cantidad, @precioTotal)";
                con.Open();
                SqlCommand com = new SqlCommand(q, con);
                com.Parameters.AddWithValue("@nombre",nombre);
                com.Parameters.AddWithValue("@producto", producto);
                com.Parameters.AddWithValue("@ingredientes", ingredientes);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                com.Parameters.AddWithValue("@precioTotal", precioTotal);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception err){ Console.WriteLine(err); }
            }
        public void eliminar(Int32 id)
        {

            String q = "DELETE FROM elchegudb WHERE id=@id ";
            con.Open();
            SqlCommand com = new SqlCommand(q,con);
            com.Parameters.AddWithValue("@id", id);
            com.ExecuteNonQuery();


        }




    }

}
