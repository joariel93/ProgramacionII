using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio29;


namespace Ejercicio29
{
    class Program
    {
        static void Main(string[] args)
        {

            Equipo ferro = new Equipo(3, "Ferro");
            Jugador j1 = new Jugador(1, "Joaquin", 10, 5);
            Jugador j2 = new Jugador(2, "Karen", 3, 4);
            Jugador j3 = new Jugador(3, "Pupi Salmeron", 5, 3);

            //Console.WriteLine(j1.MostrarDatos());
            //Console.WriteLine(j2.MostrarDatos());
            //Console.WriteLine(j3.MostrarDatos());

            if (ferro + j1)
                Console.WriteLine("Se agrego a {0} \n{1}",ferro.nombre ,j1.MostrarDatos());
            else
                Console.WriteLine("No lo pude agregar");

            if (ferro + j1)
                Console.WriteLine("Se agrego a {0} \n{1}", ferro.nombre, j1.MostrarDatos());
            else
                Console.WriteLine("No lo pude agregar");

            Console.ReadKey();
        }
    }
}
