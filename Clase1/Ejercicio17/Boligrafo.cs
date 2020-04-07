using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boligrafos
{
    class Boligrafo
    {

        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color=new ConsoleColor();
        private short tinta;

        public Boligrafo (short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;

        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        private short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            int auxTinta;
            auxTinta = this.GetTinta() + tinta;
            if (auxTinta >= 0 && auxTinta <= cantidadTintaMaxima)
                this.SetTinta((short)auxTinta);

        }
        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar (short gasto, out string dibujo)
        {
            bool pinte=default;
            StringBuilder asterisco=new StringBuilder();
            int i,auxTinta;
            dibujo = "";
            
            if (gasto < this.GetTinta() && (this.GetTinta() - gasto) >= 0)
            {
                for (i = 0; i < gasto; i++)
                {
                    asterisco.Append("*");
                }
                auxTinta = this.tinta-gasto;
                dibujo = asterisco.ToString();
                this.SetTinta((short)auxTinta);
                pinte = true;
            }
            else if (gasto > this.GetTinta())
            {
                for (i = 0; i < this.GetTinta(); i++)
                {
                    asterisco.Append("*");
                }
                dibujo = asterisco.ToString();
                this.SetTinta(0);
                pinte = true;
            }
            else if (this.GetTinta() == 0)
                pinte = false;

            return pinte;

        }
    }
}
