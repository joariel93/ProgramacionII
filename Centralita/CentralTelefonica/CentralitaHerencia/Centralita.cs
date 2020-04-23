using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }
        public Centralita(string nombreEmpresa) : this()
        {
            this.razonSocial = nombreEmpresa;
        }

        public float GananciasPorLocal 
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Local);
            }
        }
        public float GananciaPorProvincial
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return this.CalcularGanancia(TipoLlamada.Todas);
            }
        }

        private float CalcularGanancia (TipoLlamada tipo)
        {
            float retorno=default;
            switch(tipo)
            {
                case TipoLlamada.Local:
                    foreach (Llamada item in this.listaDeLlamadas)
                    {
                        if(item is Local)
                            retorno += ((Local)item).CostoLlamada;
                    }
                    break;
                case TipoLlamada.Provincial:
                    foreach(Llamada item in this.listaDeLlamadas)
                    {
                        if (item is Provincial)
                            retorno += ((Provincial)item).CostoLlamada;
                    }
                    break;
                case TipoLlamada.Todas:
                    foreach (Llamada item in this.listaDeLlamadas)
                    {
                        if (item is Local)
                            retorno += ((Local)item).CostoLlamada;
                        else
                            retorno += ((Provincial)item).CostoLlamada;
                    }
                    break;
            }

            return retorno;

        }
        public string Mostrar ()
        {
            StringBuilder retorno=default;

            retorno.AppendLine($"Empresa {this.razonSocial}");
            retorno.AppendLine($"Ganancia total {this.GananciaPorTotal}");
            retorno.AppendLine($"Ganancia por llamados locales {this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancia por llamados provinciales {this.GananciaPorProvincial}");
            foreach (Llamada item in this.listaDeLlamadas)
            {
                retorno.AppendLine(item.Mostrar());
            }


            return retorno.ToString();

        }

    }
}
