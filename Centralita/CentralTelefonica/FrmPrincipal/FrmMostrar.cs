using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CentralitaHerencia;

namespace FrmPrincipal
{
    public partial class FrmMostrar : Form
    {
        Centralita centralita = new Centralita();
        TipoLlamada tipo;
        public FrmMostrar(Centralita centralTelefonica,TipoLlamada tipoLlamada)
        {
            this.centralita = centralTelefonica;
            tipo = tipoLlamada;
            InitializeComponent();
           
        }

        private void FrmMostrar_Load(object sender, EventArgs e)
        {
            StringBuilder muestra = new StringBuilder();
            switch (this.tipo)
            {
                case TipoLlamada.Todas:
                    muestra.Append(this.centralita.Mostrar());
                    break;
                case TipoLlamada.Provincial:
                    muestra.AppendLine($"Ganancia por llamadas provinciales {centralita.GananciaPorProvincial}");
                    muestra.AppendLine("");
                    foreach (Llamada item in centralita.Llamadas)
                    {
                        if (item is Provincial)
                            muestra.AppendLine(item.ToString());

                    }
                    break;
                case TipoLlamada.Local:
                    muestra.AppendLine($"Ganancia por llamadas Locales {centralita.GananciasPorLocal}");
                    muestra.AppendLine("");
                    foreach (Llamada item in centralita.Llamadas)
                    {
                        if (item is Local)
                            muestra.AppendLine(item.ToString());

                    }
                    break;
            }
            this.richTextBox.Text = muestra.ToString();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
