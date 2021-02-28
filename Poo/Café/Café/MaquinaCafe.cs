using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Café
{
    public class MaquinaCafe
    {
        public Vaso vaso = new Vaso();

        public String _TipoCafe { get; set; }

        public float _PrecioCafe { get; set; }

        public String _NombreMaquina { get; set; }

        public float _Capacidad { get; set; }

        public float _CapacidadRestante { get; set; }

        public float _Total { get; set; }

        public float comprarCafe()
        {
            restarCapacidad();
            calculoTotal();
            return _PrecioCafe * vaso._TamañoVaso;
        }

        public void restarCapacidad()
        {
            _CapacidadRestante -= vaso._TamañoVaso;
        }

        public void calculoTotal()
        {
            _Total += _PrecioCafe * vaso._TamañoVaso;
        }

        public float recargarMaquina()
        {
            return _CapacidadRestante = _Capacidad;
        }
    }
}
