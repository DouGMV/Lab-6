using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__6
{
    internal class DatAlquileres
    {
        int nit;
        string placa;
        DateTime fecha_alquiler;
        DateTime fecha_devolucion;
        int precio_kilometraje;

        public int Nit { get => nit; set => nit = value; }
        public string Placa { get => placa; set => placa = value; }
        public DateTime Fecha_alquiler { get => fecha_alquiler; set => fecha_alquiler = value; }
        public DateTime Fecha_devolucion { get => fecha_devolucion; set => fecha_devolucion = value; }
        public int Precio_kilometraje { get => precio_kilometraje; set => precio_kilometraje = value; }
    }
}
