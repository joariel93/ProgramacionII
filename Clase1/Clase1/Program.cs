using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Hello World");
            string[] nombres = new string[3] { "Hola", "salio", "bien." };

            //foreach (var item in nombres)
            //{
            //    Console.WriteLine(item);

            //}

            for(int i=0;i<nombres.Length;i++)
            {
                string elem = nombres[i];
                Console.WriteLine(elem);
            }
          
            string miTexto = "Hola!";

            Console.WriteLine("Acá iría mi texto: {0}", miTexto);

        }
    }
}