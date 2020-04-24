using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public enum TipoLlamada
    {
        Local,
        Provincial,
        Todas
    }
    public class Llamada
    {
        
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion 
        { 
            get 
            {
                return this.duracion;
            }
        }
        public string NroDestino 
        { 
            get 
            {
                return this.nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        public string Mostrar ()
        {
            StringBuilder retorno = new StringBuilder();
            
            retorno.AppendLine($"Duracion de la llamada {this.Duracion}");
            retorno.AppendLine($"Recibida en {this.NroDestino}");
            retorno.AppendLine($"Realizada desde {this.NroOrigen}");
            return retorno.ToString();
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            if (llamada1.Duracion > llamada2.Duracion)
                return 1;            
            else
                return -1;

        }
    }
}
