using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaHerencia;

namespace CentralitaHerencia
{
    public class Centralita
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

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
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

        private float CalcularGanancia(TipoLlamada tipo)
        {
            float retorno = default;
            foreach (Llamada item in listaDeLlamadas)
            {

                switch (tipo)
                {
                    case TipoLlamada.Local:
                        if (item is Local)
                            retorno += ((Local)item).CostoLlamada;

                        break;
                    case TipoLlamada.Provincial:
                        if (item is Provincial)
                            retorno += ((Provincial)item).CostoLlamada;

                        break;
                    case TipoLlamada.Todas:

                        if (item is Local)
                            retorno += ((Local)item).CostoLlamada;
                        else if (item is Provincial)
                            retorno += ((Provincial)item).CostoLlamada;

                        break;
                }
            }

            return retorno;

        }
        public string Mostrar()
        {
            StringBuilder retorno = new StringBuilder();

            retorno.AppendLine($"Empresa {this.razonSocial}");
            retorno.AppendLine($"Ganancia total {this.GananciaPorTotal}");
            retorno.AppendLine($"Ganancia por llamados locales {this.GananciasPorLocal}");
            retorno.AppendLine($"Ganancia por llamados provinciales {this.GananciaPorProvincial}");
            retorno.AppendLine("---------------------------------------------------");
            foreach (Llamada item in this.listaDeLlamadas)
            {
                retorno.AppendLine(item.Mostrar());
            }


            return retorno.ToString();

        }

        public void OrdenarLlamadas()
        {
            //int i;
            //bool flag=default;
            //List<Llamada> listaAuxiliar = this.listaDeLlamadas;
            //Llamada aux ;

            //do
            //{
            //    flag = false;
            //    for (i = 0; i < listaAuxiliar.Count-1; i++)
            //    {
            //        if(this.Llamadas[i].OrdenarPorDuracion(this.Llamadas[i],this.Llamadas[i+1])>0)
            //        {
            //            aux = this.Llamadas[i];
            //            listaAuxiliar[i] = listaAuxiliar[i+1];
            //            listaAuxiliar[i + 1] = aux;
            //            flag = true;
            //        }
            //    }

            //    } while (flag==true);

            //this.listaDeLlamadas = listaAuxiliar;
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);

        }

    }
}
