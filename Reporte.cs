using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__6
{
    internal class Reporte
    {
        string nombre;
        string marca;
        string modelo;
        DateTime fechaDevuelto;
        decimal totalPagar;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public DateTime FechaDevuelto { get => fechaDevuelto; set => fechaDevuelto = value; }
        public decimal TotalPagar { get => totalPagar; set => totalPagar = value; }
    }
}
