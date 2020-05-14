using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    class MiClase
    {


        public MiClase()
        {
            try
            {
                MetodoEstatico();
            }
            catch (Exception)
            {
                throw ;
            }

        }

        public MiClase (string hola):this()
        {

        }

        public static void MetodoEstatico()
        {
            throw new DivideByZeroException();
            
        }

    }
}
