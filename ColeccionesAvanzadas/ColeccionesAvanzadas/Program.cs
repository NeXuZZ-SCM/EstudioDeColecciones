using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesAvanzadas
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Read();
        }

        public static void PruebaColas()
        {
            Queue<Cliente> ejemplar = new Queue<Cliente>();

            var nuevoCliente = new Cliente() { Nombre = "Juan", Edad = 21 };
            var nuevoCliente2 = new Cliente() { Nombre = "Pedro", Edad = 33 };
            ejemplar.Enqueue(nuevoCliente);
            ejemplar.Enqueue(nuevoCliente2);

            Console.WriteLine(ejemplar.Dequeue().Nombre);
            Console.WriteLine(ejemplar.Contains(nuevoCliente));
        }
    }
    public class Cliente
    {
        public string Nombre{ get; set; }
        public int Edad { get; set; }
    }
}
