using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;
            string input;
            string deseaContinuar=default;
            bool continuar = default;
            bool flagNumero = default;

            do
            {
                
                while (flagNumero == false)
                {
                    Console.Write("Ingrese un numero: ");
                    input = Console.ReadLine();
                    Console.WriteLine("");
                    if (int.TryParse(input, out numero))
                    {
                        flagNumero = true;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un numero");
                    }
                }
                flagNumero = false;

                Console.WriteLine("Desea ingresar otro numero?");
                deseaContinuar= Console.ReadLine();
                continuar= ValidarRespuesta.ValidaS_N(deseaContinuar[0]);

             } while (continuar!=false);

            Console.ReadKey();

        }
    }
}
