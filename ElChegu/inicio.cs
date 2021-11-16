using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;
using System.Drawing.Configuration;
namespace ElChegu
{
    public struct carrito
    {
        public string nombre;
        public string producto;
        public string ingredientesArr;
        public Decimal precio;
    }
    public partial class inicio : Form
    {
        //instancio los objetos 
        private Decimal total = 0;
        private int NumeroItem;
        private List<carrito> nuevo;
        private carrito Obj;
        private String[] productos;
        private List<String> ingrediente;
        private string valorcomida = "";
        private Decimal precioAnterior = 0;
        //multiplicador anterior para controlar la cantidad
        private int MultiplicadorAn = 1;
        private Decimal SumPrecio;
        private Decimal prodcutoCosto;
        private Decimal ingeedientesCosto;
        private conexion con;
        public inicio()
        {
            con = new conexion();
            //Numerp que utilizo para 
            this.SumPrecio = 0;
            //el numero el cual uso para numero de pedido
            this.NumeroItem = 0;
            //Lista donde se contendra los productos agregados 
            this.nuevo = new List<carrito>();
            //objeto carrito
            this.Obj = new carrito();
            //lista de ingredientes 
            this.ingrediente = new List<string>();
            //añado producto y precio
            this.productos = new string[] { "Milanesa,350", "Ternera,400", "Fiambres,500", "COLITA,150" };
            InitializeComponent();
        }
        //########################################################################################
        private void inicio_Load(object sender, EventArgs e)
        {
            //conexion con = new conexion();
            //con.abrir();
            //con.trarDatos();
            //dgvlistado = con.trarDatos();
            //dgvlistado.DataSource = con.trarDatos();
            int i = 1;
            
            foreach (String a in productos)
            {
                i++;
                cboProducto.Items.Add(a.Split(',')[0]);
            }
            for (int x = 1; x <= 10; x++)
            {
                cboCantidad.Items.Add(x);
            }
        }
        //########################################################################################
        private void cboProducto_MouseCaptureChanged(object sender, EventArgs e)
        {
            string productoName = "";
            int SelectProductos = cboProducto.SelectedIndex;
            productoName = productos[SelectProductos];
            if (valorcomida == "")
            {
                prodcutoCosto += Convert.ToDecimal(productoName.Split(',')[1]);
            }
            else
            {
                prodcutoCosto = prodcutoCosto - precioAnterior;
                prodcutoCosto += Convert.ToDecimal(productoName.Split(',')[1]);

            }
            precioAnterior = Convert.ToDecimal(productoName.Split(',')[1]);
            valorcomida = productoName.Split(',')[0];
        }
        //#########################################################################################
        private void chequeos(object sender, EventArgs e)
        {
            CheckBox ing = (CheckBox)sender;
            if (ing.Checked == true) {
                ingrediente.Add(ing.Text);
                ingeedientesCosto += Convert.ToDecimal(ing.Tag);
            }
            else
            {
                ingeedientesCosto = ingeedientesCosto - Convert.ToDecimal(ing.Tag);
                ingrediente.Remove(ing.Text);
            }
        }
        //########################################################################################
        private void btnAddCarrito_Click(object sender, EventArgs e)
        {



            if ( cboCantidad.Text=="" ) {

                MessageBox.Show("ingresa cantidad primero");


            }
            else
            {
                String ingredientes = "";

                for (int x = 0; x < ingrediente.Count; x++)
                {
                    ingredientes += " ," + ingrediente[x];
                }
                Obj.nombre = txtNombre.Text != "" ? txtNombre.Text : "Anonimo";
                Obj.precio = SumPrecio;
                Obj.producto = cboProducto.Text;
                Obj.ingredientesArr = ingredientes;
                nuevo.Add(Obj);
                for (int h = 0; h < nuevo.Count; h++)
                {
                    total += nuevo[h].precio;
                }
                lstChegu.Font = new Font("Arial", 10, FontStyle.Italic);
                lstChegu.Items.Add("--------------------------------------");
                lstChegu.Items.Add("NOMBRE: " + nuevo[NumeroItem].nombre);
                lstChegu.Items.Add("--------------------------------------");
                lstChegu.Items.Add("PRODUCTO: " + nuevo[NumeroItem].producto + " $" + prodcutoCosto);
                lstChegu.Items.Add("--------------------------------------");
                lstChegu.Items.Add("INGREDIENTES:");
                lstChegu.Items.Add(nuevo[NumeroItem].ingredientesArr);
                lstChegu.Items.Add("$" + ingeedientesCosto);
                lstChegu.Items.Add("--------------------------------------");
                lstChegu.Items.Add("PRECIO: $" + nuevo[NumeroItem].precio);
                lstChegu.Items.Add("total: $" + total);
                lstChegu.Items.Add("---------------------------------------");
                lstChegu.Items.Add("##########-Numero de pedido-###########");
                lstChegu.Items.Add(NumeroItem + 1);
                lstChegu.Items.Add("---------------------------------------");
                NumeroItem = NumeroItem + 1;
                //nuevo[i].nombre;
                //nuevo[i].producto
                //nuevo[i].ingredientesArr
                //nuevo.count
                //total

            }

        }
        private void cboCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            Decimal SumPrecio2 = ingeedientesCosto + prodcutoCosto;
            int multiplicador = Convert.ToInt32(cboCantidad.SelectedItem);
            if (multiplicador != MultiplicadorAn)
            {
                if (MultiplicadorAn > 0)
                {
                    SumPrecio = SumPrecio2 / MultiplicadorAn;
                }

            }
            SumPrecio = SumPrecio2 * multiplicador;
            MultiplicadorAn = multiplicador;
            LblPrecioParcial.Text = Convert.ToString(SumPrecio);
        }

        private void btnCompltarCompra_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(total));
            
            //nuevo[i].nombre;
            //nuevo[i].producto
            //nuevo[i].ingredientesArr
            //nuevo.count
            //total
            String pr="";
            String ing = "";
            for (int i = 0; i < nuevo.Count; i++)
            {
                pr += ","+nuevo[i].producto;
                ing += "," + nuevo[i].ingredientesArr;
            }
            MessageBox.Show("Productos: "+pr);
            MessageBox.Show("Ingredientes: "+ing);
            MessageBox.Show("Precio total: "+total);
            MessageBox.Show(Convert.ToString(nuevo.Count));
            con.insertarDatos(nuevo[0].nombre,pr,ing,Convert.ToInt32(nuevo.Count),total);
        }

        private void integrantes_Click(object sender, EventArgs e)
        {
            frmIntegrantes integrantes = new frmIntegrantes();
            integrantes.Show();
            //this.Hide();
            this.Hide();
            //Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVentas ventas = new frmVentas();
            ventas.Show();
            this.Hide();
        }
    }
   
    }