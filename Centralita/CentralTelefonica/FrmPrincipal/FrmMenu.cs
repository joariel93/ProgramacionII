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
    public partial class FormPrincipal : Form
    {
        Centralita unicaCentralita=new Centralita();

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerarLlamada_Click(object sender, EventArgs e)
        {
           new FrmLlamador(unicaCentralita).ShowDialog();
        }

        private void btnFacTotal_Click(object sender, EventArgs e)
        {
            new FrmMostrar(unicaCentralita, TipoLlamada.Todas).ShowDialog();
        }

        private void btnFactLoc_Click(object sender, EventArgs e)
        {
            new FrmMostrar(unicaCentralita, TipoLlamada.Local).ShowDialog();
        }

        private void btnFactProv_Click(object sender, EventArgs e)
        {
            new FrmMostrar(unicaCentralita, TipoLlamada.Provincial).ShowDialog();
        }
    }
}
