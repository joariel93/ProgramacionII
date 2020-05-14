namespace FrmCantina
{
    partial class Frmcantina
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmcantina));
            this.barra1 = new ControlCantina.Barra();
            this.checkBirra = new System.Windows.Forms.RadioButton();
            this.checkAgua = new System.Windows.Forms.RadioButton();
            this.textBoxMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxCapacidad = new System.Windows.Forms.NumericUpDown();
            this.boxContenido = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBotellaTipo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.botonagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxCapacidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxContenido)).BeginInit();
            this.SuspendLayout();
            // 
            // barra1
            // 
            this.barra1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("barra1.BackgroundImage")));
            this.barra1.Location = new System.Drawing.Point(12, 12);
            this.barra1.Name = "barra1";
            this.barra1.Size = new System.Drawing.Size(551, 368);
            this.barra1.TabIndex = 0;
            // 
            // checkBirra
            // 
            this.checkBirra.AutoSize = true;
            this.checkBirra.Location = new System.Drawing.Point(45, 438);
            this.checkBirra.Name = "checkBirra";
            this.checkBirra.Size = new System.Drawing.Size(64, 17);
            this.checkBirra.TabIndex = 1;
            this.checkBirra.TabStop = true;
            this.checkBirra.Text = "Cerveza";
            this.checkBirra.UseVisualStyleBackColor = true;
            // 
            // checkAgua
            // 
            this.checkAgua.AutoSize = true;
            this.checkAgua.Location = new System.Drawing.Point(45, 473);
            this.checkAgua.Name = "checkAgua";
            this.checkAgua.Size = new System.Drawing.Size(50, 17);
            this.checkAgua.TabIndex = 2;
            this.checkAgua.TabStop = true;
            this.checkAgua.Text = "Agua";
            this.checkAgua.UseVisualStyleBackColor = true;
            // 
            // textBoxMarca
            // 
            this.textBoxMarca.Location = new System.Drawing.Point(168, 438);
            this.textBoxMarca.Name = "textBoxMarca";
            this.textBoxMarca.Size = new System.Drawing.Size(171, 20);
            this.textBoxMarca.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 422);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Marca";
            // 
            // boxCapacidad
            // 
            this.boxCapacidad.Location = new System.Drawing.Point(168, 501);
            this.boxCapacidad.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.boxCapacidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxCapacidad.Name = "boxCapacidad";
            this.boxCapacidad.Size = new System.Drawing.Size(95, 20);
            this.boxCapacidad.TabIndex = 6;
            this.boxCapacidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // boxContenido
            // 
            this.boxContenido.Location = new System.Drawing.Point(289, 501);
            this.boxContenido.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.boxContenido.Name = "boxContenido";
            this.boxContenido.Size = new System.Drawing.Size(89, 20);
            this.boxContenido.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Capacidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contenido";
            // 
            // cmbBotellaTipo
            // 
            this.cmbBotellaTipo.FormattingEnabled = true;
            this.cmbBotellaTipo.Location = new System.Drawing.Point(391, 438);
            this.cmbBotellaTipo.Name = "cmbBotellaTipo";
            this.cmbBotellaTipo.Size = new System.Drawing.Size(121, 21);
            this.cmbBotellaTipo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Botella Tipo";
            // 
            // botonagregar
            // 
            this.botonagregar.Location = new System.Drawing.Point(400, 494);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(140, 55);
            this.botonagregar.TabIndex = 12;
            this.botonagregar.Text = "Agregar";
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // Frmcantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 601);
            this.Controls.Add(this.botonagregar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbBotellaTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxContenido);
            this.Controls.Add(this.boxCapacidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMarca);
            this.Controls.Add(this.checkAgua);
            this.Controls.Add(this.checkBirra);
            this.Controls.Add(this.barra1);
            this.Name = "Frmcantina";
            this.Text = "Alumno Joaquin Calero";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxCapacidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxContenido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ControlCantina.Barra barra1;
        private System.Windows.Forms.RadioButton checkBirra;
        private System.Windows.Forms.RadioButton checkAgua;
        private System.Windows.Forms.TextBox textBoxMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown boxCapacidad;
        private System.Windows.Forms.NumericUpDown boxContenido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBotellaTipo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button botonagregar;
    }
}

