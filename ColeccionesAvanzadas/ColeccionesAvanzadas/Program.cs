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

        private static void PruebaDiccionario()
        {
            Dictionary<int, Cliente> DiccionarioClientes = new Dictionary<int, Cliente>();

            DiccionarioClientes.Add(1, new Cliente() { Nombre = "Cristian", Edad = 30 });
            foreach (KeyValuePair<int, Cliente> item in DiccionarioClientes)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value.Nombre);
                Console.WriteLine(item.Value.Edad);
            }
        }
        private static void PruebaLista()
        {
            List<Cliente> listadoCliente = new List<Cliente>();

            listadoCliente.Add(new Cliente { Nombre = "Pedro", Edad = 32 });
            Console.WriteLine(listadoCliente[0].Nombre);
        }
        private static void PruebaPila()
        {
            Stack<Cliente> PilaCliente = new Stack<Cliente>();
            var NuevoCliente = new Cliente() { Nombre = "Pedro", Edad = 32 };
            PilaCliente.Push(NuevoCliente);


            Console.WriteLine(PilaCliente.Pop().Nombre);
        }
        private static void PruebaColas()
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
