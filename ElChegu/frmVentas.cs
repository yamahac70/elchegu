using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElChegu
{
    public partial class frmVentas : Form
    {
        conexion con;
        int indice;
        public frmVentas()
        {
            con = new conexion();
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            render();
           
        }
        private void render()
        {
            DataTable dtventas = new DataTable();

            DataColumn columna;
            DataRow row;

            //id cliente
            columna = new DataColumn();

            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Id";
            dtventas.Columns.Add(columna);
            //Nombre cliente
            columna = new DataColumn();

            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Nombre de cliente";
            dtventas.Columns.Add(columna);

            //producto
            columna = new DataColumn();

            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Producto";
            dtventas.Columns.Add(columna);

            //ingregientes

            columna = new DataColumn();

            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Ingredientes";
            dtventas.Columns.Add(columna);

            //cantidad
            columna = new DataColumn();

            columna.DataType = System.Type.GetType("System.Int32");
            columna.ColumnName = "Cantidad";
            dtventas.Columns.Add(columna);
            //precio
            columna = new DataColumn();

            columna.DataType = System.Type.GetType("System.Decimal");
            columna.ColumnName = "Precio Total";
            dtventas.Columns.Add(columna);
            //cargando datatable
            for (int i = 0; i < con.trarDatos().Rows.Count; i++)
            {

                row = dtventas.NewRow();
                row["Id"] = con.trarDatos().Rows[i]["id"];
                row["Nombre de cliente"] = con.trarDatos().Rows[i]["nombre"].ToString();
                row["Producto"] = con.trarDatos().Rows[i]["productos"].ToString();
                row["Ingredientes"] = con.trarDatos().Rows[i]["ingredientes"].ToString();
                row["Cantidad"] = con.trarDatos().Rows[i]["cantidad"];
                row["Precio Total"] = con.trarDatos().Rows[i]["preciototal"];
                dtventas.Rows.Add(row);
            }

            dgvlistado.DataSource = dtventas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.eliminar(Convert.ToInt32(tbId.Text));
            render();
            
            tbId.Text = "";
        }

        private void dgvlistado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          indice=  dgvlistado.CurrentCell.RowIndex;
            MessageBox.Show(Convert.ToString(indice));

        }
    }
}
