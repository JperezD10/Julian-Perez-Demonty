using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vuelo
    {
        private int id_vuelo;
        private int id_ciudadOrigen;
        private int id_ciudadDestino;
        private string fechaSalida;
        private string fechaLlegada;
        private string horaSalida;
        private string horaLlegada;
        private float precio;

        public int Id_vuelo { get => id_vuelo; set => id_vuelo = value; }
        public int Id_ciudadOrigen { get => id_ciudadOrigen; set => id_ciudadOrigen = value; }
        public int Id_ciudadDestino { get => id_ciudadDestino; set => id_ciudadDestino = value; }
        public string FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public string FechaLlegada { get => fechaLlegada; set => fechaLlegada = value; }
        public string HoraSalida { get => horaSalida; set => horaSalida = value; }
        public string HoraLlegada { get => horaLlegada; set => horaLlegada = value; }
        public float Precio { get => precio; set => precio = value; }
    }
}
