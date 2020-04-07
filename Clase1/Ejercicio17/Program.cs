using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Boligrafos;


namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo azul = new Boligrafo (100, ConsoleColor.Blue);
            Boligrafo rojo = new Boligrafo(50, ConsoleColor.Red);
            string dibujo;


           
            rojo.Pintar(20, out dibujo);
            Console.ForegroundColor=rojo.GetColor();
            Console.WriteLine(dibujo);
            azul.Pintar(20, out dibujo);
            Console.ForegroundColor = azul.GetColor();
            Console.WriteLine(dibujo);
            rojo.Pintar(20, out dibujo);
            Console.ForegroundColor = rojo.GetColor();
            Console.WriteLine(dibujo);

            Console.ReadKey();


        }
    }
}
