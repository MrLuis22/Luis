namespace GuevaraLuis
{
    partial class Busqueda_Carro
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
            this.lblbuscar = new System.Windows.Forms.Label();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.GrdBusquedaCarro = new System.Windows.Forms.DataGridView();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrdBusquedaCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblbuscar
            // 
            this.lblbuscar.AutoSize = true;
            this.lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbuscar.Location = new System.Drawing.Point(28, 33);
            this.lblbuscar.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblbuscar.Name = "lblbuscar";
            this.lblbuscar.Size = new System.Drawing.Size(61, 13);
            this.lblbuscar.TabIndex = 29;
            this.lblbuscar.Text = "BUSCAR:";
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(136, 33);
            this.TxtBuscar.Margin = new System.Windows.Forms.Padding(1);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(295, 20);
            this.TxtBuscar.TabIndex = 30;
            this.TxtBuscar.TextChanged += new System.EventHandler(this.TxtBuscar_TextChanged);
            // 
            // GrdBusquedaCarro
            // 
            this.GrdBusquedaCarro.AllowUserToAddRows = false;
            this.GrdBusquedaCarro.AllowUserToDeleteRows = false;
            this.GrdBusquedaCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdBusquedaCarro.Location = new System.Drawing.Point(31, 64);
            this.GrdBusquedaCarro.Margin = new System.Windows.Forms.Padding(1);
            this.GrdBusquedaCarro.Name = "GrdBusquedaCarro";
            this.GrdBusquedaCarro.ReadOnly = true;
            this.GrdBusquedaCarro.RowHeadersWidth = 102;
            this.GrdBusquedaCarro.RowTemplate.Height = 40;
            this.GrdBusquedaCarro.Size = new System.Drawing.Size(742, 333);
            this.GrdBusquedaCarro.TabIndex = 31;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(31, 409);
            this.BtnSeleccionar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(118, 31);
            this.BtnSeleccionar.TabIndex = 32;
            this.BtnSeleccionar.Text = "SELECCIONAR";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(180, 409);
            this.BtnCancelar.Margin = new System.Windows.Forms.Padding(1);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(94, 31);
            this.BtnCancelar.TabIndex = 33;
            this.BtnCancelar.Text = "CANCELAR";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // Busqueda_Carro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.GrdBusquedaCarro);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.lblbuscar);
            this.Name = "Busqueda_Carro";
            this.Text = "Busqueda_Carro";
            this.Load += new System.EventHandler(this.Busqueda_Carro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrdBusquedaCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.DataGridView GrdBusquedaCarro;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}