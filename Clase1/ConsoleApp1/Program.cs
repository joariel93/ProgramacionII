using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            string[] nombres = new string[3] { "Hola", "salio", "bien." };

            //foreach (var item in nombres)
            //{
            //    Console.WriteLine(item);

            //}

            //for(int i=0;i<nombres.Length;i++)
            //{
            //    string elem = nombres[i];
            //    Console.WriteLine(elem);
            //}

            //string miTexto = "Hola!";

            //Console.WriteLine("Acá iría mi texto: {0}", miTexto);

            string aux = Console.ReadLine();
            Console.WriteLine(aux);

            Console.ReadKey();


        }
    }
}
