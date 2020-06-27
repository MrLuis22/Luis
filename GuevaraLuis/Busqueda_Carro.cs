using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuevaraLuis
{
    public partial class Busqueda_Carro : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _IdVehiculo;
        public Busqueda_Carro()
        {
            InitializeComponent();
        }

        private void Busqueda_Carro_Load(object sender, EventArgs e)
        {
            GrdBusquedaCarro.DataSource = objConexion.obtener_datos().Tables["tbl_vehiculos"].DefaultView;
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaCarro.DataSource;
            bs.Filter = "(Nombre + Modelo   + Marca + Año) like '%" + valor + "%'";
            GrdBusquedaCarro.DataSource = bs;

        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaCarro.RowCount > 0)
            {
                _IdVehiculo = int.Parse(GrdBusquedaCarro.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(TxtBuscar.Text);
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
