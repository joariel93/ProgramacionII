using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Agua:Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML) : base(marca, capacidadML, contenidoML)
        {

        }

        protected new string GenerarInforme()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.Append(base.ToString());
            retorno.AppendLine(MEDIDA.ToString());

            return retorno.ToString();
        }

        public override int ServirMedida()
        {
            return ServirMedida(MEDIDA);
        }

        public int ServirMedida(int medida)
        {
            int retorno;
            if (medida >= this.Contenido)
                retorno = this.Contenido;
            else
                retorno = medida;

            this.Contenido -= retorno;
            return retorno;
        }
    }
}
