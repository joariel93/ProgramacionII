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
    public partial class FrmLlamador : Form
    {
        StringBuilder numero = new StringBuilder();
        Centralita centralita = new Centralita();

        public FrmLlamador(Centralita centralTelefonica)  
        {
            InitializeComponent();
            this.centralita = centralTelefonica;
        }
        public Centralita Centralita
        {
            get
            {
                return this.centralita;
            }
        }
        private void FrmLlamador_Load(object sender, EventArgs e)
        {
            this.cmbFranja.DataSource = Enum.GetValues(typeof(Provincial.Franja));
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Panel

        private void btn1_Click(object sender, EventArgs e)
        {
            this.numero.Append(1);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.numero.Append(2);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.numero.Append(3);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.numero.Append(4);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.numero.Append(5);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.numero.Append(6);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.numero.Append(7);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            this.numero.Append(8);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.numero.Append(9);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            this.numero.Append("*");
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.numero.Append(0);
            this.txtNroDestino.Text = this.numero.ToString();
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            this.numero.Append("#");
            this.txtNroDestino.Text = this.numero.ToString();
        }
        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtNroDestino.Text = "Nro Destino";
            this.txtNroOrigen.Text = "Nro Origen";
            this.numero.Clear();
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random duracion = new Random(1);

            if (this.txtNroDestino.Text == "Nro Destino")
            {
                MessageBox.Show("Debe ingresar el numero al que desea llamar");
            }
            else
            {

                if (this.txtNroDestino.Text.StartsWith("#"))
                {
                    Provincial.Franja franjas;
                    Enum.TryParse<Provincial.Franja>(cmbFranja.SelectedValue.ToString(), out franjas);

                    this.txtNroOrigen.Text = "#" + VoltearString(this.txtNroDestino.Text.Remove(0, 1));

                    this.centralita += new Provincial(this.txtNroOrigen.Text, franjas, (float)duracion.Next(1, 50), this.txtNroDestino.Text);
                }
                else
                {
                    Random costo = new Random();
                    this.txtNroOrigen.Text = VoltearString(this.txtNroDestino.Text);
                    this.centralita += new Local(this.txtNroOrigen.Text, (float)duracion.Next(50), this.txtNroDestino.Text, (float)costo.Next((int)0.5, (int)5.6));
                }
            }

        }
        private string VoltearString(string bufferString)
        {
            char[] bufferChar = bufferString.ToCharArray();
            char[] retorno = bufferChar.Reverse().ToArray();
            string retornoString = new string(retorno);

            return retornoString;
        }
    }
}
