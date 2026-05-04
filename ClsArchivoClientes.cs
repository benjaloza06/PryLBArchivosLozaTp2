using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PryLBArchivosLoza
{
    internal class ClsArchivoClientes
    {
        public string NombreArchivo = "Clientes,csv";
        Decimal Total = 0;
        Int32 C = 0;

        public struct RegClientes
        {
            public Int32 Codigo;
            public String Nombre;
            public Decimal Deuda;
            public Decimal Limite;
        }

        private RegClientes[] VecClientes = new RegClientes[1500];
        private Int32 IND = 0;


        private void CargarVector()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            IND = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();

            
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                VecClientes[IND].Codigo = Convert.ToInt32(VecDatos[0]);
                VecClientes[IND].Nombre = VecDatos[1];
                VecClientes[IND].Deuda = Convert.ToDecimal(VecDatos[2]);
                VecClientes[IND].Limite = Convert.ToDecimal(VecDatos[3]);
                IND++;

                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();
        }


        private void OrdenarVector()
        {
            RegClientes Aux;
            for (Int32 c = 0; c < IND - 1; c++) //Contador de Vueltas
                    {

                 for (Int32 i = 0; i < IND - 1; i++) //Recorre el Vector 
                 {
                    if (VecClientes[1].Codigo > VecClientes[i + 1].Codigo)
                    {
                        Aux = VecClientes[i];
                        VecClientes[i] = VecClientes[i + 1];
                        VecClientes[i + 1] = Aux;
                    }
                 }
            }
        }

        private void ReescribirArchivo()
        {
            StreamWriter AD = new StreamWriter(NombreArchivo, false);

            for (Int32 i = 0; i < IND; i++)
            {
                AD.Write(VecClientes[i].Codigo);
                AD.Write(";"); //Separador de Campos
                AD.Write(VecClientes[i].Nombre);
                AD.Write(";");
                AD.Write(VecClientes[i].Deuda);
                AD.Write(";");
                AD.WriteLine(VecClientes[i].Limite);
            }
            AD.Close();
            AD.Dispose();
        }


        public void OrdenarArchivo()
        {
            CargarVector();
            OrdenarVector();
            ReescribirArchivo();
        }
        


        public void Grabar(string cod, string nom, string deu, string lim)
        {
            //Abrir
            StreamWriter AD = new StreamWriter(NombreArchivo, true);
            //Cargar o leer
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.Write(deu);
            AD.Write(";");
            AD.WriteLine(lim);
            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        public void Listar(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);
                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();
        }

        public Int32 CantidadClientes()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];
            //Int32 C = 0;
            int Cant = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                Cant++;

                DatosLeidos = AD.ReadLine();
            }

            //Cerrar
            AD.Close();
            AD.Dispose();


            return Cant;
        }

        public Decimal DuedaClientes()
        {
            string[] VecDatos = new string[4];

            string DatosLeidos;
            //Decimal Total = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }

            //Cerrar
            AD.Close();
            AD.Dispose();


            return Total;
        }

        public Decimal PromedioDeudas()
        {
            string[] VecDatos = new string[4];

            string DatosLeidos;
            //Decimal Total = 0;
            //Int32 C = 0;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);

                DatosLeidos = AD.ReadLine();
            }

            //Cerrar
            AD.Close();
            AD.Dispose();


            return Total / C;

        }

       

        public void ListarDeudores(DataGridView Grilla)
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();

            Grilla.Rows.Clear();
            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(VecDatos[2]) > 0)
                {
                    Grilla.Rows.Add(VecDatos[0], VecDatos[1], VecDatos[2], VecDatos[3]);

                }


                DatosLeidos = AD.ReadLine();
            }
            //Cerrar
            AD.Close();
            AD.Dispose();

        }


        public Decimal PromedioDeuda()
        {
            string[] VecDatos = new string[4];

            string DatosLeidos;
            Decimal Promedio = 0;


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                C++;
                VecDatos = DatosLeidos.Split(';');
                Total = Total + Convert.ToDecimal(VecDatos[2]);

                if (C > 0)
                {
                    Promedio = Total / C;
                }

                DatosLeidos = AD.ReadLine();
            }


            //Cerrar
            AD.Close();
            AD.Dispose();


            return Total / C;

        }


        public Int32 ClientesDeudores()
        {
            string DatosLeidos;
            int CantDeuda = 0;
            string[] VecDatos;

            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //Leer
            DatosLeidos = AD.ReadLine();

            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                if (Convert.ToInt32(VecDatos[2]) > 0)
                    
                {
                    CantDeuda++;
                }
                DatosLeidos = AD.ReadLine();
            }


            //Cerrar
            AD.Close();
            AD.Dispose();


            return CantDeuda;

        }


        public void GenerarReporte()
        {
            string DatosLeidos;
            string[] VecDatos = new string[4];

            Int32 Cantidad = 0;
            Decimal Total = 0;

            StreamWriter Reporte = new StreamWriter("Reporte.csv");

            Reporte.WriteLine("Listado de Clientes");
            Reporte.WriteLine("");
            Reporte.WriteLine("Codigo;Nombre;Deuda;Limite");


            //Abrir
            StreamReader AD = new StreamReader(NombreArchivo);
            //leer
            DatosLeidos = AD.ReadLine();


            while (DatosLeidos != null)
            {
                VecDatos = DatosLeidos.Split(';');

                Reporte.Write(VecDatos[0]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[1]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[3]);
                Reporte.Write(";");
                Reporte.Write(VecDatos[2]);
                Reporte.WriteLine(";");


                DatosLeidos = AD.ReadLine();

                Cantidad++; //Contador
                Total = Total + Convert.ToDecimal(VecDatos[2]); //Acumulador 


            }
            //Cerrar
            AD.Close();
            AD.Dispose();
            Reporte.WriteLine("");
            Reporte.Write("Total de Deudas:;;");
            Reporte.WriteLine(Total);
            Reporte.Write("Cantidad de Clientes:;;");
            Reporte.WriteLine(Cantidad);
            Reporte.Write("Promedio de Deudas:;;");
            Reporte.WriteLine(Cantidad/Total);


            Reporte.Close();
            Reporte.Dispose();
        }
    }   
}