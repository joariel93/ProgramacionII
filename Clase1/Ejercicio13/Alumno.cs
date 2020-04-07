using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public void CalcularFinal()
        {
            Random num = new Random();
            int auxNum;

            if ((int)nota1 >= 4 && (int)nota2 >= 4)
            { 
                auxNum = num.Next(4, 10);
                this.notaFinal = (float)auxNum;
            }
            else
                this.notaFinal = -1;
                   
        }
        public string Mostrar()
        {
            string retorno=default;
            string auxNota = default;

            if (this.notaFinal == -1)
                auxNota="Alumno desaprobado";
            else
                auxNota = string.Format("{0:N2}",notaFinal);

            retorno = this.nombre + "\n" + this.apellido +"\n"+auxNota+"\n";
           
            return retorno;

        }



    }
}
