using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patron_Bridge
{
    class Program
    {
        public interface IRenderer
        {
            void HacerForma(string NombreForma, string color);
        }
        public class VectorRender : IRenderer
        {
            public void HacerForma(string NombreForma, string color)
            {
                Console.WriteLine($"Vector Cambia para crear {NombreForma} con color {color}");
            }
        }
        public class CambioTrama : IRenderer
        {
            public void HacerForma(string NombreForma, string color)
            {
                Console.WriteLine($"Trama Cambia para crear {NombreForma} con color {color}");
            }
        }
        public abstract class Forma
        {
            protected IRenderer Rederer { get; set; }
            public string Color { get; set; }

            public Forma (IRenderer renderer)
            {
                this.Rederer = renderer;
            }
            public abstract void Dibujar();
        }
        public class linea : Forma
        {
            public linea(IRenderer renderer, string color) : base(renderer)
            {
                this.Color = color;
            }
            public override void Dibujar()
            {
                this.Rederer.HacerForma(this.GetType().Name, Color);
            }
        }
        static void Main(string[] args)
        {
            IRenderer hacer = new CambioTrama();
            Forma linea = new linea(hacer,"rojo");
            linea.Dibujar();
        }
    }
}
