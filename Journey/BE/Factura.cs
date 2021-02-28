using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Factura
    {
        private int id_factura;
        private int id_cliente;
        private int id_tipofactura;
        private string fechaRealizacion;
        private string horaRealizacion;
        private float precio;

        public int Id_factura { get => id_factura; set => id_factura = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string FechaRealizacion { get => fechaRealizacion; set => fechaRealizacion = value; }
        public string HoraRealizacion { get => horaRealizacion; set => horaRealizacion = value; }
        public float Precio { get => precio; set => precio = value; }
        public int Id_tipofactura { get => id_tipofactura; set => id_tipofactura = value; }
    }
}
