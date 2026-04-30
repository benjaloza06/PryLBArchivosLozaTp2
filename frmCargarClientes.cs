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
    public partial class frmCargarClientes : Form
    {
        public frmCargarClientes()
        {
            InitializeComponent();
        }

        ClsArchivoClientes x = new ClsArchivoClientes();

        private void BtnGrabar_Click(object sender, EventArgs e)
        {
            x.Grabar(TxtCodigo.Text,TxtNombreApellido.Text,TxtDeuda.Text,TxtLimiteCredito.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            x.Grabar(TxtCodigo.Text, TxtNombreApellido.Text, TxtDeuda.Text, TxtLimiteCredito.Text);
        }
    }
}
