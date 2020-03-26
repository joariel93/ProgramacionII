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
            string linea = "--------------------------";

            int numEjercicio1 = default,numEjercicio3=default;
            int maximo = default;
            int minimo = default;
            int acumulador = default;
            float promedio = default;
            string numeroString = default;
            bool flagEj1 = false, flagEj2=false,flagEj3=false;
            int i ,j;
            double numEjercicio2 = default;
            double cuadradoEj2 = default;
            double cuboEj2 = default;

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

            //string aux = Console.ReadLine();
            //Console.WriteLine(aux);

            //Console.ReadKey();

            //Console.WriteLine(linea);
            //Console.WriteLine("Ejercicio 1");
            //i = 0;
            //do
            //{
            //    Console.WriteLine("Ingrese un numero: ");
            //    numeroString = Console.ReadLine();
            //    if (int.TryParse(numeroString, out numEjercicio1))
            //    {
            //        numEjercicio1 = int.Parse(numeroString);
            //        if (flagEj1 == false)
            //        {
            //            maximo = numEjercicio1;
            //            minimo = numEjercicio1;
            //            acumulador = numEjercicio1;
            //            flagEj1 = true;

            //        }
            //        else
            //        {
            //            if (numEjercicio1 < minimo)
            //            {
            //                minimo = numEjercicio1;
            //            }
            //            if (numEjercicio1 > maximo)
            //            {
            //                maximo = numEjercicio1;
            //            }
            //            acumulador = acumulador + numEjercicio1;
            //        }
            //        i++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error debe ingresar un numero. ");
            //    }
            //} while (i < 5);

            //promedio = (float)acumulador / 5;
            //Console.WriteLine("Maximo: {0}",maximo);
            //Console.WriteLine("Minimo: {0}", minimo);
            //Console.WriteLine("Promedio: {0}", promedio);
            Console.WriteLine(linea);
            Console.WriteLine(linea);
            //Console.WriteLine("Ejercicio 2");
            //do
            //{
            //    Console.Write("Ingrese un numero: ");
            //    numeroString = Console.ReadLine();
            //    Console.WriteLine("");
            //    if (double.TryParse(numeroString, out numEjercicio2)||double.Parse(numeroString)<=0)
            //    {
            //        numEjercicio2 = double.Parse(numeroString);
            //        cuadradoEj2 = Math.Pow(numEjercicio2, 2);
            //        cuboEj2 = Math.Pow(numEjercicio2, 3);
            //        flagEj2 = true;

            //    }
            //    else
            //    {
            //        Console.WriteLine("Error debe ingresar un numero mayor a 0. ");
            //    }
            //} while (flagEj2 == false);
            //Console.WriteLine("El numero ingresado fue: {0}", numEjercicio2);
            //Console.WriteLine("El cuadrado del numero es: {0}", cuadradoEj2);
            //Console.WriteLine("El cubo del numero es: {0}", cuboEj2);
            //Console.WriteLine(linea);
            //Console.WriteLine(linea);

            Console.WriteLine("Ejercicio 3");
            do
            {
                Console.Write("Ingrese un numero: ");
                numeroString = Console.ReadLine();
                Console.WriteLine("");
                if (int.TryParse(numeroString, out numEjercicio3) && int.Parse(numeroString) >= 2)
                {
                    numEjercicio3 = int.Parse(numeroString);
                    for (j = 2; j <= numEjercicio3; j++)
                    {
                        if ((j%2>0 ||j==2 )&& (j % 3 > 0 || j == 3 )&&( j % 5 > 0 || j == 5) && (j % 7 > 0 || j == 7) && (j % 11 > 0 || j == 11))
                        {
                            Console.Write("{0}, ", j);
                        }
                        
                    }

                    flagEj3 = true;

                }
                else
                {
                    Console.WriteLine("Error debe ingresar un numero mayor a 1.");
                }
            } while (flagEj3 == false);
            Console.ReadKey();

        }
    }
}
