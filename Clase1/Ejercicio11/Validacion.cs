using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Validacion
    {



        public static bool ValidarNumeroConRango (int valor,int min, int max)
        {
            if (valor > min && valor < max)
                return true;
            return false;


        }
        //public static bool ContinuacionDeIngresos (string respuesta)
        //{
        //    char primeraLetra;

        //    foreach (respuesta)

        //        return false;

        //}
    }
}
