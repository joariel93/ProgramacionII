using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    enum Franja
    {
        Franja_1,
        Franja_2,
        Franja_3
    }
    class Provincial : Llamada
    {
        protected Franja franjaHoraria;

        public float CostoLlamada 
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
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine(base.Mostrar());
            retorno.AppendLine($"El costo de la llamada fue {this.CostoLlamada}");

            return retorno.ToString();
        }

    }
}
