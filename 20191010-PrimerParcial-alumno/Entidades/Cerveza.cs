using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Cerveza : Botella
    {
        protected const int MEDIDA = 330;

        private Tipo tipo;


        public Cerveza(int capacidadML, string marca, Tipo tipo, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

            this.tipo = tipo;
        }
        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, 0, contenidoML)
        {

        }

        public override int ServirMedida()
        {
            int retorno;

            if (this.Contenido < MEDIDA * 0.8)
                retorno = this.Contenido;
            else
                retorno = (int)(MEDIDA * 0.8);

            this.Contenido -= retorno;

            return retorno;
        }

        public static implicit operator Botella.Tipo(Cerveza cerveza)
            {
            return cerveza.tipo;
            }

    }
}
