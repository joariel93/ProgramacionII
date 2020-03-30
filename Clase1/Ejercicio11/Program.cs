using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int maximo, minimo, numero,i,acumulador,valorMinimo=default,valorMaximo=default;
            float promedio;
            string input;
            bool flagNumeros=false,flagValidacion;
            minimo = -100;
            maximo = 100;
            acumulador = 0;
            
            for(i=0;i<10;i++)
            {
                do
                {   Console.Write("Ingrese un numero: ");
                    input = Console.ReadLine();
                    Console.WriteLine("");
                    if (int.TryParse(input, out numero) && Validacion.ValidarNumeroConRango(int.Parse(input),minimo,maximo))
                    {
                        numero=int.Parse(input);
                        if (flagNumeros == false)
                        {
                            valorMinimo = numero;
                            valorMaximo = numero;
                            flagNumeros = true;
                        }
                        else
                        {
                            if (valorMinimo > numero)
                            { valorMinimo = numero; }

                            if (valorMaximo < numero)
                            { valorMaximo = numero; }

                        }
                       

                        acumulador = acumulador + numero;

                            flagValidacion = true;
                    }
                    else
                    {
                        Console.WriteLine("Debe ingresar un numero entre -100 y 100");
                        flagValidacion = false;
                    }

                } while (flagValidacion == false);
            }

            promedio = (float)acumulador / 10;

            Console.WriteLine("El numero mas bajo ingresado fue: {0}", valorMinimo);
            Console.WriteLine("El numero mas alto ingresado fue: {0}", valorMaximo);
            Console.WriteLine("El promedio de los numeros ingresados fue: {0}", promedio);
            Console.ReadKey();


        }
    }
}
