namespace GuevaraLuis
{
    partial class Carro
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
            this.GrbDatosCarro = new System.Windows.Forms.GroupBox();
            this.TxtPlaca = new System.Windows.Forms.TextBox();
            this.TxtAño = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblAño = new System.Windows.Forms.Label();
            this.LblModelo = new System.Windows.Forms.Label();
            this.lblidvl = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.GrbNavegacion = new System.Windows.Forms.GroupBox();
            this.lblidvehiculo = new System.Windows.Forms.Label();
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
            this.lblTipo = new System.Windows.Forms.Label();
            this.TxtTipo = new System.Windows.Forms.TextBox();
            this.GrbDatosCarro.SuspendLayout();
            this.GrbNavegacion.SuspendLayout();
            this.grbEdicion.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbDatosCarro
            // 
            this.GrbDatosCarro.Controls.Add(this.TxtTipo);
            this.GrbDatosCarro.Controls.Add(this.lblTipo);
            this.GrbDatosCarro.Controls.Add(this.TxtPlaca);
            this.GrbDatosCarro.Controls.Add(this.TxtAño);
            this.GrbDatosCarro.Controls.Add(this.TxtModelo);
            this.GrbDatosCarro.Controls.Add(this.TxtMarca);
            this.GrbDatosCarro.Controls.Add(this.LblPlaca);
            this.GrbDatosCarro.Controls.Add(this.LblAño);
            this.GrbDatosCarro.Controls.Add(this.LblModelo);
            this.GrbDatosCarro.Controls.Add(this.lblidvl);
            this.GrbDatosCarro.Controls.Add(this.LblMarca);
            this.GrbDatosCarro.Location = new System.Drawing.Point(24, 24);
            this.GrbDatosCarro.Name = "GrbDatosCarro";
            this.GrbDatosCarro.Size = new System.Drawing.Size(618, 274);
            this.GrbDatosCarro.TabIndex = 1;
            this.GrbDatosCarro.TabStop = false;
            this.GrbDatosCarro.Enter += new System.EventHandler(this.GrbDatosCarro_Enter);
            // 
            // TxtPlaca
            // 
            this.TxtPlaca.Location = new System.Drawing.Point(162, 195);
            this.TxtPlaca.Name = "TxtPlaca";
            this.TxtPlaca.Size = new System.Drawing.Size(100, 20);
            this.TxtPlaca.TabIndex = 21;
            // 
            // TxtAño
            // 
            this.TxtAño.Location = new System.Drawing.Point(162, 149);
            this.TxtAño.Name = "TxtAño";
            this.TxtAño.Size = new System.Drawing.Size(100, 20);
            this.TxtAño.TabIndex = 20;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(162, 95);
            this.TxtModelo.Multiline = true;
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(282, 39);
            this.TxtModelo.TabIndex = 19;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(162, 69);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(268, 20);
            this.TxtMarca.TabIndex = 18;
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca.Location = new System.Drawing.Point(26, 195);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(43, 13);
            this.LblPlaca.TabIndex = 17;
            this.LblPlaca.Text = "Placa:";
            // 
            // LblAño
            // 
            this.LblAño.AutoSize = true;
            this.LblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAño.Location = new System.Drawing.Point(26, 149);
            this.LblAño.Name = "LblAño";
            this.LblAño.Size = new System.Drawing.Size(33, 13);
            this.LblAño.TabIndex = 16;
            this.LblAño.Text = "Año:";
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblModelo.Location = new System.Drawing.Point(26, 107);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(52, 13);
            this.LblModelo.TabIndex = 8;
            this.LblModelo.Text = "Modelo:";
            // 
            // lblidvl
            // 
            this.lblidvl.AutoSize = true;
            this.lblidvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidvl.Location = new System.Drawing.Point(239, 28);
            this.lblidvl.Name = "lblidvl";
            this.lblidvl.Size = new System.Drawing.Size(90, 13);
            this.lblidvl.TabIndex = 5;
            this.lblidvl.Text = "ID VEHICULO:";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMarca.Location = new System.Drawing.Point(26, 69);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(46, 13);
            this.LblMarca.TabIndex = 4;
            this.LblMarca.Text = "Marca:";
            // 
            // GrbNavegacion
            // 
            this.GrbNavegacion.Controls.Add(this.lblidvehiculo);
            this.GrbNavegacion.Controls.Add(this.lblnregistros);
            this.GrbNavegacion.Controls.Add(this.Bbtnultimo);
            this.GrbNavegacion.Controls.Add(this.Btnsiguiente);
            this.GrbNavegacion.Controls.Add(this.Btnanterior);
            this.GrbNavegacion.Controls.Add(this.Btnprimero);
            this.GrbNavegacion.Location = new System.Drawing.Point(24, 349);
            this.GrbNavegacion.Margin = new System.Windows.Forms.Padding(1);
            this.GrbNavegacion.Name = "GrbNavegacion";
            this.GrbNavegacion.Padding = new System.Windows.Forms.Padding(1);
            this.GrbNavegacion.Size = new System.Drawing.Size(222, 57);
            this.GrbNavegacion.TabIndex = 9;
            this.GrbNavegacion.TabStop = false;
            this.GrbNavegacion.Text = "Navegacion";
            // 
            // lblidvehiculo
            // 
            this.lblidvehiculo.AutoSize = true;
            this.lblidvehiculo.Location = new System.Drawing.Point(88, 26);
            this.lblidvehiculo.Name = "lblidvehiculo";
            this.lblidvehiculo.Size = new System.Drawing.Size(0, 13);
            this.lblidvehiculo.TabIndex = 14;
            // 
            // lblnregistros
            // 
            this.lblnregistros.AutoSize = true;
            this.lblnregistros.Location = new System.Drawing.Point(83, 26);
            this.lblnregistros.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnregistros.Name = "lblnregistros";
            this.lblnregistros.Size = new System.Drawing.Size(0, 13);
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
            this.grbEdicion.Location = new System.Drawing.Point(286, 349);
            this.grbEdicion.Margin = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Name = "grbEdicion";
            this.grbEdicion.Padding = new System.Windows.Forms.Padding(1);
            this.grbEdicion.Size = new System.Drawing.Size(236, 57);
            this.grbEdicion.TabIndex = 10;
            this.grbEdicion.TabStop = false;
            this.grbEdicion.Text = "Edicion de Categroias";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(171, 16);
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
            this.BtnDelete.Location = new System.Drawing.Point(109, 16);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(1);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(62, 33);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Eliminar";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(45, 16);
            this.BtnModificar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(62, 33);
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
            this.BtnNuevo.Size = new System.Drawing.Size(40, 33);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(702, 343);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 63);
            this.button1.TabIndex = 11;
            this.button1.Text = "Volver al menu principal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(26, 225);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(36, 13);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo:";
            // 
            // TxtTipo
            // 
            this.TxtTipo.Location = new System.Drawing.Point(162, 225);
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Size = new System.Drawing.Size(100, 20);
            this.TxtTipo.TabIndex = 23;
            // 
            // Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grbEdicion);
            this.Controls.Add(this.GrbNavegacion);
            this.Controls.Add(this.GrbDatosCarro);
            this.Name = "Carro";
            this.Text = "Carro";
            this.Load += new System.EventHandler(this.Carro_Load);
            this.GrbDatosCarro.ResumeLayout(false);
            this.GrbDatosCarro.PerformLayout();
            this.GrbNavegacion.ResumeLayout(false);
            this.GrbNavegacion.PerformLayout();
            this.grbEdicion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDatosCarro;
        private System.Windows.Forms.TextBox TxtPlaca;
        private System.Windows.Forms.TextBox TxtAño;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblAño;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label lblidvl;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.GroupBox GrbNavegacion;
        private System.Windows.Forms.Label lblidvehiculo;
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
        private System.Windows.Forms.TextBox TxtTipo;
        private System.Windows.Forms.Label lblTipo;
    }
}