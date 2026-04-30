using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLBArchivosLoza
{
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }

        ClsArchivoClientes x = new ClsArchivoClientes();

        private void frmClientesDeudores_Load(object sender, EventArgs e)
        {
            x.ListarDeudores(DgvClientesDeudores);
            LblClientes.Text = x.ClientesDeudores().ToString();
            LblPromedio.Text = x.PromedioDeuda().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
