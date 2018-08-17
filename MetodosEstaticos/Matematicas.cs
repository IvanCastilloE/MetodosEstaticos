using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosEstaticos
{
    class Matematicas
    {
        //2 
        public static int Potencia(int numeroBase, int exponente)
        {
            int resultado = 1;
            for (int i= 0; i<exponente; i++)
            {
                resultado = resultado * numeroBase;
            }
            return resultado;
        }
    }
}
