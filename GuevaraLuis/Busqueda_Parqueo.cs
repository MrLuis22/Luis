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
    public partial class Busqueda_Parqueo : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _IdParqueo;
        public Busqueda_Parqueo()
        {
            InitializeComponent();
        }

        private void Busqueda_Parqueo_Load(object sender, EventArgs e)
        {
            GrdBusquedaParqueo.DataSource = objConexion.obtener_datos().Tables["Parqueo_Cliente_tbl_vehiculos"].DefaultView;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            if (GrdBusquedaParqueo.RowCount > 0)
            {
                _IdParqueo = int.Parse(GrdBusquedaParqueo.CurrentRow.Cells["IdParqueo"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("No hay datos que seleccionar", "Busqueda de Alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }

        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = GrdBusquedaParqueo.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%' or Modelo like '%" + valor + "%' or Marca like '%" + valor + "%'";
            GrdBusquedaParqueo.DataSource = bs;
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
