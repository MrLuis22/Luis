namespace GuevaraLuis
{
    partial class Parqueo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parqueo));
            this.GrbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblidcliente = new System.Windows.Forms.Label();
            this.lblnregistros = new System.Windows.Forms.Label();
            this.Bbtnultimo = new System.Windows.Forms.Button();
            this.Btnsiguiente = new System.Windows.Forms.Button();
            this.Btnanterior = new System.Windows.Forms.Button();
            this.Btnprimero = new System.Windows.Forms.Button();
            this.grbEdicion = new System.Windows.Forms.GroupBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.GrbDatosParqueo = new System.Windows.Forms.GroupBox();
            this.lblIdPar = new System.Windows.Forms.Label();
            this.btnVehiculo = new System.Windows.Forms.Button();
            this.BtnCliente = new System.Windows.Forms.Button();
            this.lblPago = new System.Windows.Forms.Label();
            this.TxtEntrada = new System.Windows.Forms.TextBox();
            this.CboVehiculo = new System.Windows.Forms.ComboBox();
            this.lblVehiculo = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.TxtTotal = new System.Windows.Forms.TextBox();
            this.TxtSalida = new System.Windows.Forms.TextBox();
            this.LblEmail = new System.Windows.Forms.Label();
            this.LblSalida = new System.Windows.Forms.Label();
            this.LblEntrada = new System.Windows.Forms.Label();
            this.lblidpq = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.GrbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.GrbDatosParqueo.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbNavegacion
            // 
            this.GrbNavegacion.Controls.Add(this.lblidcliente);
            this.GrbNavegacion.Controls.Add(this.lblnregistros);
            this.GrbNavegacion.Controls.Add(this.Bbtnultimo);
            this.GrbNavegacion.Controls.Add(this.Btnsiguiente);
            this.GrbNavegacion.Controls.Add(this.Btnanterior);
            this.GrbNavegacion.Controls.Add(this.Btnprimero);
            this.GrbNavegacion.Font = new System.Drawing.Font("Perpetua Titling MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrbNavegacion.Location = new System.Drawing.Point(28, 352);
            this.GrbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.GrbNavegacion.Name = "GrbNavegacion";
            this.GrbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.GrbNavegacion.Size = new System.Drawing.Size(222, 57);
            this.GrbNavegacion.TabIndex = 9;
            this.GrbNavegacion.TabStop = false;
            this.GrbNavegacion.Text = "Navegacion";
            // 
            // lblidcliente
            // 
            this.lblidcliente.AutoSize = true;
            this.lblidcliente.Location = new System.Drawing.Point(88, 26);
            this.lblidcliente.Name = "lblidcliente";
            this.lblidcliente.Size = new System.Drawing.Size(0, 16);
            this.lblidcliente.TabIndex = 14;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(83, 26);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 16);
            this.lblnregistros.TabIndex = 13;
            // 
            // Bbtnultimo
            // 
            this.Bbtnultimo.Location = new System.Drawing.Point(182, 16);
            this.Bbtnultimo.Margin = new System.Windows.Forms.Padding(1);
            this.Bbtnultimo.Name = "Bbtnultimo";
            this.Bbtnultimo.Size = new System.Drawing.Size(40, 33);
            this.Bbtnultimo.TabIndex = 3;
            this.Bbtnultimo.Text = ">|";
            this.Bbtnultimo.UseVisualStyleBackColor = true;
            this.Bbtnultimo.Click += new System.EventHandler(this.Bbtnultimo_Click);
            // 
            // Btnsiguiente
            // 
            this.Btnsiguiente.Location = new System.Drawing.Point(143, 16);
            this.Btnsiguiente.Margin = new System.Windows.Forms.Padding(1);
            this.Btnsiguiente.Name = "Btnsiguiente";
            this.Btnsiguiente.Size = new System.Drawing.Size(40, 33);
            this.Btnsiguiente.TabIndex = 2;
            this.Btnsiguiente.Text = ">";
            this.Btnsiguiente.UseVisualStyleBackColor = true;
            this.Btnsiguiente.Click += new System.EventHandler(this.Btnsiguiente_Click);
            // 
            // Btnanterior
            // 
            this.Btnanterior.Location = new System.Drawing.Point(41, 16);
            this.Btnanterior.Margin = new System.Windows.Forms.Padding(1);
            this.Btnanterior.Name = "Btnanterior";
            this.Btnanterior.Size = new System.Drawing.Size(40, 33);
            this.Btnanterior.TabIndex = 1;
            this.Btnanterior.Text = "<";
            this.Btnanterior.UseVisualStyleBackColor = true;
            this.Btnanterior.Click += new System.EventHandler(this.Btnanterior_Click);
            // 
            // Btnprimero
            // 
            this.Btnprimero.Location = new System.Drawing.Point(2, 16);
            this.Btnprimero.Margin = new System.Windows.Forms.Padding(1);
            this.Btnprimero.Name = "Btnprimero";
            this.Btnprimero.Size = new System.Drawing.Size(40, 33);
            this.Btnprimero.TabIndex = 0;
            this.Btnprimero.Text = "|<";
            this.Btnprimero.UseVisualStyleBackColor = true;
            this.Btnprimero.Click += new System.EventHandler(this.Btnprimero_Click);
            // 
            // grbEdicion
            // 
            this.grbEdicion.Controls.Add(this.BtnBuscar);
            this.grbEdicion.Controls.Add(this.BtnDelete);
            this.grbEdicion.Controls.Add(this.BtnModificar);
            this.grbEdicion.Controls.Add(this.BtnNuevo);
            this.grbEdicion.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEdicion.Location = new System.Drawing.Point(295, 352);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(309, 70);
            this.grbEdicion.TabIndex = 10;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Categroias";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(219, 18);
            this.BtnBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(62, 33);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(144, 18);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(73, 33);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(63, 16);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(79, 33);
            this.BtnModificar.TabIndex = 3;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Location = new System.Drawing.Point(2, 16);
            this.BtnNuevo.Margin = new System.Windows.Forms.Padding(1);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(59, 33);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(664, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 85);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrbDatosParqueo
            // 
            this.GrbDatosParqueo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GrbDatosParqueo.BackgroundImage")));
            this.GrbDatosParqueo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GrbDatosParqueo.Controls.Add(this.lblIdPar);
            this.GrbDatosParqueo.Controls.Add(this.btnVehiculo);
            this.GrbDatosParqueo.Controls.Add(this.BtnCliente);
            this.GrbDatosParqueo.Controls.Add(this.lblPago);
            this.GrbDatosParqueo.Controls.Add(this.TxtEntrada);
            this.GrbDatosParqueo.Controls.Add(this.CboVehiculo);
            this.GrbDatosParqueo.Controls.Add(this.lblVehiculo);
            this.GrbDatosParqueo.Controls.Add(this.CboCliente);
            this.GrbDatosParqueo.Controls.Add(this.TxtTotal);
            this.GrbDatosParqueo.Controls.Add(this.TxtSalida);
            this.GrbDatosParqueo.Controls.Add(this.LblEmail);
            this.GrbDatosParqueo.Controls.Add(this.LblSalida);
            this.GrbDatosParqueo.Controls.Add(this.LblEntrada);
            this.GrbDatosParqueo.Controls.Add(this.lblidpq);
            this.GrbDatosParqueo.Controls.Add(this.LblNombre);
            this.GrbDatosParqueo.Location = new System.Drawing.Point(28, 23);
            this.GrbDatosParqueo.Name = "GrbDatosParqueo";
            this.GrbDatosParqueo.Size = new System.Drawing.Size(740, 274);
            this.GrbDatosParqueo.TabIndex = 12;
            this.GrbDatosParqueo.TabStop = false;
            this.GrbDatosParqueo.Enter += new System.EventHandler(this.GrbDatosCliente_Enter);
            // 
            // lblIdPar
            // 
            this.lblIdPar.AutoSize = true;
            this.lblIdPar.Location = new System.Drawing.Point(345, 120);
            this.lblIdPar.Name = "lblIdPar";
            this.lblIdPar.Size = new System.Drawing.Size(0, 13);
            this.lblIdPar.TabIndex = 29;
            // 
            // btnVehiculo
            // 
            this.btnVehiculo.Location = new System.Drawing.Point(615, 49);
            this.btnVehiculo.Margin = new System.Windows.Forms.Padding(1);
            this.btnVehiculo.Name = "btnVehiculo";
            this.btnVehiculo.Size = new System.Drawing.Size(62, 33);
            this.btnVehiculo.TabIndex = 28;
            this.btnVehiculo.Text = "Buscar";
            this.btnVehiculo.UseVisualStyleBackColor = true;
            this.btnVehiculo.Click += new System.EventHandler(this.btnVehiculo_Click);
            // 
            // BtnCliente
            // 
            this.BtnCliente.Location = new System.Drawing.Point(296, 52);
            this.BtnCliente.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCliente.Name = "BtnCliente";
            this.BtnCliente.Size = new System.Drawing.Size(62, 33);
            this.BtnCliente.TabIndex = 27;
            this.BtnCliente.Text = "Buscar";
            this.BtnCliente.UseVisualStyleBackColor = true;
            this.BtnCliente.Click += new System.EventHandler(this.BtnCliente_Click);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPago.Location = new System.Drawing.Point(26, 199);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(40, 13);
            this.lblPago.TabIndex = 26;
            this.lblPago.Text = "Total:";
            // 
            // TxtEntrada
            // 
            this.TxtEntrada.Location = new System.Drawing.Point(143, 104);
            this.TxtEntrada.Name = "TxtEntrada";
            this.TxtEntrada.Size = new System.Drawing.Size(100, 20);
            this.TxtEntrada.TabIndex = 25;
            // 
            // CboVehiculo
            // 
            this.CboVehiculo.FormattingEnabled = true;
            this.CboVehiculo.Location = new System.Drawing.Point(468, 59);
            this.CboVehiculo.Name = "CboVehiculo";
            this.CboVehiculo.Size = new System.Drawing.Size(121, 21);
            this.CboVehiculo.TabIndex = 24;
            // 
            // lblVehiculo
            // 
            this.lblVehiculo.AutoSize = true;
            this.lblVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehiculo.Location = new System.Drawing.Point(378, 62);
            this.lblVehiculo.Name = "lblVehiculo";
            this.lblVehiculo.Size = new System.Drawing.Size(60, 13);
            this.lblVehiculo.TabIndex = 23;
            this.lblVehiculo.Text = "Vehiculo:";
            // 
            // CboCliente
            // 
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(143, 59);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(121, 21);
            this.CboCliente.TabIndex = 22;
            // 
            // TxtTotal
            // 
            this.TxtTotal.Location = new System.Drawing.Point(143, 192);
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(100, 20);
            this.TxtTotal.TabIndex = 21;
            // 
            // TxtSalida
            // 
            this.TxtSalida.Location = new System.Drawing.Point(143, 142);
            this.TxtSalida.Name = "TxtSalida";
            this.TxtSalida.Size = new System.Drawing.Size(100, 20);
            this.TxtSalida.TabIndex = 20;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(26, 181);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(0, 13);
            this.LblEmail.TabIndex = 17;
            // 
            // LblSalida
            // 
            this.LblSalida.AutoSize = true;
            this.LblSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalida.Location = new System.Drawing.Point(26, 142);
            this.LblSalida.Name = "LblSalida";
            this.LblSalida.Size = new System.Drawing.Size(93, 13);
            this.LblSalida.TabIndex = 16;
            this.LblSalida.Text = "Hora de salida:";
            // 
            // LblEntrada
            // 
            this.LblEntrada.AutoSize = true;
            this.LblEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEntrada.Location = new System.Drawing.Point(26, 107);
            this.LblEntrada.Name = "LblEntrada";
            this.LblEntrada.Size = new System.Drawing.Size(103, 13);
            this.LblEntrada.TabIndex = 8;
            this.LblEntrada.Text = "Hora de entrada:";
            // 
            // lblidpq
            // 
            this.lblidpq.AutoSize = true;
            this.lblidpq.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidpq.Location = new System.Drawing.Point(314, 120);
            this.lblidpq.Name = "lblidpq";
            this.lblidpq.Size = new System.Drawing.Size(24, 13);
            this.lblidpq.TabIndex = 5;
            this.lblidpq.Text = "ID:";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(26, 59);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(50, 13);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "Cliente:";
            // 
            // Parqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrbDatosParqueo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.GrbNavegacion);
            this.Name = "Parqueo";
            this.Text = "Parqueo";
            this.Load += new System.EventHandler(this.Parqueo_Load);
            this.GrbNavegacion.ResumeLayout(false);
            this.GrbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.GrbDatosParqueo.ResumeLayout(false);
            this.GrbDatosParqueo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbNavegacion;
        private System.Windows.Forms.Label lblidcliente;
        private System.Windows.Forms.Label lblnregistros;
        private System.Windows.Forms.Button Bbtnultimo;
        private System.Windows.Forms.Button Btnsiguiente;
        private System.Windows.Forms.Button Btnanterior;
        private System.Windows.Forms.Button Btnprimero;
        private System.Windows.Forms.GroupBox grbEdicion;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox GrbDatosParqueo;
        private System.Windows.Forms.Button btnVehiculo;
        private System.Windows.Forms.Button BtnCliente;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.TextBox TxtEntrada;
        private System.Windows.Forms.ComboBox CboVehiculo;
        private System.Windows.Forms.Label lblVehiculo;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.TextBox TxtTotal;
        private System.Windows.Forms.TextBox TxtSalida;
        private System.Windows.Forms.Label LblEmail;
        private System.Windows.Forms.Label LblSalida;
        private System.Windows.Forms.Label LblEntrada;
        private System.Windows.Forms.Label lblidpq;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label lblIdPar;
    }
}