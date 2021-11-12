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
    public partial class frmIntegrantes : Form
    {
        public frmIntegrantes()
        {
            InitializeComponent();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            inicio inicio = new inicio();
            inicio.Show();
            this.Hide();
           Application.Exit();
        }
    }
}
