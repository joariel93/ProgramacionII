using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
    
namespace FrmCantina
{
    public partial class Frmcantina : Form
    {
        public Frmcantina()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            cmbBotellaTipo.DataSource = Enum.GetValues(typeof(Botella.Tipo));
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo; 
            Enum.TryParse<Botella.Tipo>(cmbBotellaTipo.SelectedValue.ToString(), out tipo);
            if (this.checkBirra.Checked)
                this.barra1.AgregarBotella(new Cerveza((int)this.boxCapacidad.Value, this.textBoxMarca.Text, tipo, (int)this.boxContenido.Value));
            else
                this.barra1.AgregarBotella(new Agua((int)this.boxCapacidad.Value, this.textBoxMarca.Text, (int)this.boxContenido.Value));

        }
    }
}
