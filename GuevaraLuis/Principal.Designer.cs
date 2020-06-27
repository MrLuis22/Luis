namespace GuevaraLuis
{
    partial class Principal
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
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnParqueo = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(83, 171);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(81, 39);
            this.btnCarro.TabIndex = 0;
            this.btnCarro.Text = "Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.btnCarro_Click);
            // 
            // btnParqueo
            // 
            this.btnParqueo.Location = new System.Drawing.Point(325, 278);
            this.btnParqueo.Name = "btnParqueo";
            this.btnParqueo.Size = new System.Drawing.Size(81, 39);
            this.btnParqueo.TabIndex = 1;
            this.btnParqueo.Text = "Parqueo";
            this.btnParqueo.UseVisualStyleBackColor = true;
            this.btnParqueo.Click += new System.EventHandler(this.btnParqueo_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(649, 171);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(81, 39);
            this.btnCliente.TabIndex = 2;
            this.btnCliente.Text = "Cliente";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(637, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnParqueo);
            this.Controls.Add(this.btnCarro);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnParqueo;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button button1;
    }
}

