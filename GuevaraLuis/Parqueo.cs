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
    public partial class Parqueo : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Parqueo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Principal Principal = new Principal();
            Principal.Show();
        }

        private void GrbDatosCliente_Enter(object sender, EventArgs e)
        {

        }

        private void Parqueo_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            CboCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboCliente.AutoCompleteSource = AutoCompleteSource.ListItems;

            CboVehiculo.AutoCompleteMode = AutoCompleteMode.Suggest;
            CboVehiculo.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["Parqueo"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["IdParqueo"] };

            CboCliente.DataSource = objConexion.obtener_datos().Tables["cliente"];
            CboCliente.DisplayMember = "nombre";
            CboCliente.ValueMember = "clientes.IdCliente";

            CboVehiculo.DataSource = objConexion.obtener_datos().Tables["tbl_vehiculos"];
            CboVehiculo.DisplayMember = "Marca";
            CboVehiculo.ValueMember = "tbl_vehiculos.IdVehiculo";


        }

        void mostrarDatos()
        {
            try
            {
                CboCliente.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();

                CboVehiculo.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();

                lblIdPar.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                TxtEntrada.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                TxtSalida.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                TxtTotal.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Parqueo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }

        }

        private void Btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void Btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros De Parqueo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Btnsiguiente_Click(object sender, EventArgs e)
        {
            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Parqueo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Bbtnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        void limpiar_cajas()
        {
            TxtEntrada.Text = "";
            TxtSalida.Text = "";
            TxtTotal.Text = "";
        }

        void controles(Boolean valor)
        {
            GrbNavegacion.Enabled = valor;
            BtnDelete.Enabled = valor;
            BtnBuscar.Enabled = valor;
            GrbDatosParqueo.Enabled = !valor;
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            if (BtnNuevo.Text == "Nuevo")
            {//boton de nuevo
                BtnNuevo.Text = "Guardar";
                BtnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {

              lblidpq.Text,
              CboCliente.SelectedValue.ToString(),
             CboVehiculo.SelectedValue.ToString(),
              TxtEntrada.Text,
              TxtSalida.Text,
              TxtTotal.Text

                };
                objConexion.mantenimiento_datos_parqueo(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                BtnNuevo.Text = "Nuevo";
                BtnModificar.Text = "Editar";
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (BtnModificar.Text == "Editar")
            {//boton de modificar
                BtnNuevo.Text = "Guardar";
                BtnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                BtnNuevo.Text = "Guardar";
                BtnModificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                BtnNuevo.Text = "Nuevo";
                BtnModificar.Text = "Editar";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + TxtEntrada.Text, "Registro de Parqueo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidcliente.Text };
                objConexion.mantenimiento_datos_parqueo(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Busqueda_Parqueo buscarparqueo = new Busqueda_Parqueo();
            buscarparqueo.ShowDialog();

            if (buscarparqueo._IdParqueo > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscarparqueo._IdParqueo));
                mostrarDatos();
            }
        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            Busqueda_Cliente buscarcliente = new Busqueda_Cliente();
            buscarcliente.ShowDialog();

            if (buscarcliente._IdCliente > 0)
            {
                CboCliente.SelectedValue = buscarcliente._IdCliente;
            }
        }

        private void btnVehiculo_Click(object sender, EventArgs e)
        {
            Busqueda_Carro frmBusqueda = new Busqueda_Carro();
            frmBusqueda.ShowDialog();

            if (frmBusqueda._IdVehiculo > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusqueda._IdVehiculo));
                mostrarDatos();
            }
        }
    }
}


