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
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        ClsArchivoClientes x = new ClsArchivoClientes();
        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            x.Listar(DgvClientes);
            LblClientes.Text = x.CantidadClientes().ToString();
            LblDeuda.Text = x.DuedaClientes().ToString();
            LblPromedio.Text = x.PromedioDeudas().ToString();
            //LblPromedio.Text = x.PromedioDeudas2().ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            x.GenerarReporte();
            MessageBox.Show("Reporte Generado Correctamente");
        }

        private void BtnOrdenar_Click(object sender, EventArgs e)
        {
            x.OrdenarArchivo();
            MessageBox.Show("Archivo Ordenado");
            x.Listar(DgvClientes);

        }

        private void LblPromedio_Click(object sender, EventArgs e)
        {

        }
    }
}
