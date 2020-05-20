namespace FrmPrincipal
{
    partial class FormPrincipal
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
            this.btnGenerarLlamada = new System.Windows.Forms.Button();
            this.btnFactLoc = new System.Windows.Forms.Button();
            this.btnFactProv = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnFacTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarLlamada
            // 
            this.btnGenerarLlamada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerarLlamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarLlamada.Location = new System.Drawing.Point(12, 12);
            this.btnGenerarLlamada.Name = "btnGenerarLlamada";
            this.btnGenerarLlamada.Size = new System.Drawing.Size(260, 49);
            this.btnGenerarLlamada.TabIndex = 0;
            this.btnGenerarLlamada.Text = "Generar Llamada";
            this.btnGenerarLlamada.UseVisualStyleBackColor = true;
            this.btnGenerarLlamada.Click += new System.EventHandler(this.btnGenerarLlamada_Click);
            // 
            // btnFactLoc
            // 
            this.btnFactLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactLoc.Location = new System.Drawing.Point(12, 151);
            this.btnFactLoc.Name = "btnFactLoc";
            this.btnFactLoc.Size = new System.Drawing.Size(260, 49);
            this.btnFactLoc.TabIndex = 1;
            this.btnFactLoc.Text = "Facturacion Local";
            this.btnFactLoc.UseVisualStyleBackColor = true;
            this.btnFactLoc.Click += new System.EventHandler(this.btnFactLoc_Click);
            // 
            // btnFactProv
            // 
            this.btnFactProv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFactProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactProv.Location = new System.Drawing.Point(12, 223);
            this.btnFactProv.Name = "btnFactProv";
            this.btnFactProv.Size = new System.Drawing.Size(260, 49);
            this.btnFactProv.TabIndex = 2;
            this.btnFactProv.Text = "Facturacion Provincial";
            this.btnFactProv.UseVisualStyleBackColor = true;
            this.btnFactProv.Click += new System.EventHandler(this.btnFactProv_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(12, 297);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(260, 49);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnFacTotal
            // 
            this.btnFacTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFacTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacTotal.Location = new System.Drawing.Point(12, 82);
            this.btnFacTotal.Name = "btnFacTotal";
            this.btnFacTotal.Size = new System.Drawing.Size(260, 49);
            this.btnFacTotal.TabIndex = 4;
            this.btnFacTotal.Text = "Facturacion Total";
            this.btnFacTotal.UseVisualStyleBackColor = true;
            this.btnFacTotal.Click += new System.EventHandler(this.btnFacTotal_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.btnFacTotal);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnFactProv);
            this.Controls.Add(this.btnFactLoc);
            this.Controls.Add(this.btnGenerarLlamada);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Central Telefónica";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarLlamada;
        private System.Windows.Forms.Button btnFactLoc;
        private System.Windows.Forms.Button btnFactProv;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnFacTotal;
    }
}

