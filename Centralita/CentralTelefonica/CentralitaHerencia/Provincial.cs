using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    
    public class Provincial : Llamada
    {
        public enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
        protected Franja franjaHoraria;

        public override float CostoLlamada 
        { 
            get
            {
                return CalcularCosto();
            }
        }

        public Provincial (Franja miFranja, Llamada llamada): this(llamada.NroOrigen,miFranja,llamada.Duracion,llamada.NroDestino)
        {
           
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        private float CalcularCosto()
        {
            float retorno=default;
           switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    retorno = (float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    retorno = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    retorno = (float)(this.Duracion * 0.66);
                    break;
            }
            return retorno;
        }
        protected override string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.Mostrar());
            retorno.AppendLine($"La franja horaria es {this.franjaHoraria}");
            retorno.AppendLine($"El costo de la llamada fue {this.CostoLlamada}");

            return retorno.ToString();
        }
        public override bool Equals(object obj)
        {
            if (obj is Provincial)
                return true;

            return false;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }

    }
}
