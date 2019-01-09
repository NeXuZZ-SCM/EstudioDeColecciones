using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionesAvanzadas
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Cliente> ejemplar = new Queue<Cliente>();
        }
    }
    public class Cliente
    {
        public string Nombre{ get; set; }
        public int Edad { get; set; }
    }
}
