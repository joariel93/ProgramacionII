using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno("Joaquin", "Calero", 1);
            Alumno b = new Alumno("Karen", "Sotelo", 2);
            Alumno c = new Alumno("Homero", "Simpson", 3);
        
            a.Estudiar(3, 4);
            b.Estudiar(6, 8);
            c.Estudiar(9, 8);

            a.CalcularFinal();
            b.CalcularFinal();
            c.CalcularFinal();

            Console.WriteLine(a.Mostrar());
            Console.WriteLine(b.Mostrar());
            Console.WriteLine(c.Mostrar());

            Console.ReadKey();
        }
    }
}
