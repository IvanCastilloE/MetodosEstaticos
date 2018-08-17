using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            int dosElevadoATres =
                Matematicas.Potencia(2, 3);
            Console.WriteLine("Resultado: " + dosElevadoATres);
            Console.ReadLine();
        }
    }
}
