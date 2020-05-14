using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
 
    public abstract class Botella
    {
        public enum Tipo
        {
            Vidrio,
            Plastico
        }
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

       
        protected  Botella(string marca, int capacidadML, int contenidoML)
        {
            this.capacidadML = capacidadML;
            this.Contenido = contenidoML;
            this.marca = marca;

        }

        public int CapacidadLitros 
        {
            get
            {
                return this.capacidadML / 1000;
            } 
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                if (value >= this.CapacidadLitros * 1000)
                    this.contenidoML = this.CapacidadLitros * 1000;
                else
                    this.contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (Contenido / (CapacidadLitros * 1000))*100;
            }
        }

        protected string GenerarInforme ()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Botella marca {this.marca}");
            retorno.AppendLine($"Capacidad de la botella {this.CapacidadLitros} lts.");
            retorno.AppendLine($"Contenido de la botella {this.Contenido} mls.");
            retorno.AppendLine($"Porcentaje de la botella utilizado {this.PorcentajeContenido} %");

            return retorno.ToString();
        }

        public abstract int ServirMedida();

        public new string ToString()
        {
            return GenerarInforme();
        }
    }
}
