using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__6
{
    public partial class Form1 : Form
    {
        //Cargar listas
        List<Cliente> clientes = new List<Cliente>();
        List<DatVehiculos> vehiculos = new List<DatVehiculos>();
        List<DatAlquileres> alquileres = new List<DatAlquileres>();
        List<Reporte> reportes = new List<Reporte>();

        public Form1()
        {
            InitializeComponent();
        }

        public void CargarClientes()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Clientes.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            while (reader.Peek() > -1)
            {
                //Leer los datos de un cliente
                Cliente cliente = new Cliente();
                cliente.Nit = Convert.ToInt32(reader.ReadLine());
                cliente.Nombre = reader.ReadLine();
                cliente.Direccion = reader.ReadLine();

                //Guardar al cliente en la lista de clientes
                clientes.Add(cliente);
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }

        public void CargarAlquileres()
        {
            //Leer el archivo y cargarlo a la lista
            string fileName = "Alquileres vehiculos.txt";

            //Abrimos el archivo, en este caso lo abrimos para lectura
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            //Un ciclo para leer el archivo hasta el final del archivo
            while (reader.Peek() > -1)
            {
                //Leer los datos de un alquiler
                DatAlquileres alquiler = new DatAlquileres();
                alquiler.Nit = Convert.ToInt32(reader.ReadLine());
                alquiler.Placa = reader.ReadLine();
                alquiler.Fecha_alquiler = Convert.ToDateTime(reader.ReadLine());
                alquiler.Fecha_devolucion = Convert.ToDateTime(reader.ReadLine());
                alquiler.Precio_kilometraje = Convert.ToInt32(reader.ReadLine());

                //Guardar el alquiler en la lista de alquileres
                alquileres.Add(alquiler);
            }
            //Cerrar el archivo, esta linea es importante porque sino despues de correr varias veces el programa daría error de que el archivo quedó abierto muchas veces. Entonces es necesario cerrarlo despues de terminar de leerlo.
            reader.Close();
        }

        public void MostrarClientes()
        {
            //Mostrar la lista de clientes en el DataGridView
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientes;
            dataGridViewClientes.Refresh();
        }

        public void MostrarAlquileres()
        {
            //Mostrar la lista de alquileres en el DataGridView
            dataGridViewAlquileres.DataSource = null;
            dataGridViewAlquileres.DataSource = alquileres;
            dataGridViewAlquileres.Refresh();
        }

        public void MostrarVehiculos()
        {
            //Mostrar la lista de DatVehiculos en el DataGridView
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculos;
            dataGridViewVehiculos.Refresh();
        }

        public void MostrarReporte()
        {
            //Mostrar la lista de Reporte en el DataGridView
            dataGridViewReporte.DataSource = null;
            dataGridViewReporte.DataSource = reportes;
            dataGridViewReporte.Refresh();
        }
        private void buttonLeerDatos_Click(object sender, EventArgs e)
        {
            MostrarAlquileres();
            MostrarClientes();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            //Ya deben estar llenas todas las listas
            reportes.Clear();
            //Recorre cada alquiler
            foreach (var alquiler in alquileres) 
            {
                //obtiene los datos del cliente que alquilo el vehiculo
                Cliente cliente = clientes.Find(c => c.Nit == alquiler.Nit);

                //obtener los datos del automovil que fue alquilado
                DatVehiculos vehiculo = vehiculos.Find(v => v.Placa == alquiler.Placa);

                //Meter todos los datos obtenidos a la lista reporte
                Reporte reporte = new Reporte();
                reporte.Nombre = cliente.Nombre;
                reporte.Marca = vehiculo.Marca;
                reporte.Modelo = vehiculo.Modelo;
                reporte.FechaDevuelto = alquiler.Fecha_devolucion;
                reporte.TotalPagar = vehiculo.Precio * alquiler.Precio_kilometraje;

                reportes.Add(reporte);
            }
            MostrarReporte();
        }

        private void GrabarVehiculos()
        {
            FileStream stream = new FileStream("Vehiculos.txt", FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream); 

            foreach(var vehiculo in vehiculos)
            {
                writer.WriteLine(vehiculo.Placa);
                writer.WriteLine(vehiculo.Marca);
                writer.WriteLine(vehiculo.Modelo);
                writer.WriteLine(vehiculo.Color);
                writer.WriteLine(vehiculo.Precio);
            }
            writer.Close();
        }
        private void buttonIngresarDatos_Click(object sender, EventArgs e)
        {
            DatVehiculos vehiculo = new DatVehiculos();
            vehiculo.Placa = textBoxPlaca.Text;
            vehiculo.Marca = textBoxMarca.Text; 
            vehiculo.Modelo = textBoxModelo.Text;
            vehiculo.Color = textBoxColor.Text;
            vehiculo.Precio = Convert.ToDecimal(textBoxPrecio.Text);

            vehiculos.Add(vehiculo);
            GrabarVehiculos();

            textBoxPlaca.Clear();
            textBoxMarca.Clear();
            textBoxModelo.Clear();
            textBoxColor.Clear();
            textBoxPrecio.Clear();

            MostrarVehiculos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            CargarClientes();
            CargarAlquileres();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilometrajeMayor = alquileres.Max(a => a.Precio_kilometraje);
            label1.Text = "Vehiculo con Mayor Kilometraje:";
            label2.Text = kilometrajeMayor.ToString();
            label1.Visible = true;
            label2.Visible = true;
        }
    }
}
