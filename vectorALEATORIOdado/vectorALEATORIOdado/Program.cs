using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectorALEATORIOdado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            int resultado = 0;
            resultado = dado.Next(1, 100);
            Console.WriteLine("el numero ganador es {0}",resultado);
            Console.ReadKey();
        }
    }
}
