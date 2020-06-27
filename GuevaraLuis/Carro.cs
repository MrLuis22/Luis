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
    public partial class Carro : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public Carro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Principal Principal = new Principal();
            Principal.Show();
        }

        private void GrbDatosCarro_Enter(object sender, EventArgs e)
        {

        }

        private void Carro_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["tbl_vehiculos"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["tbl_vehiculos"] };
        }

        void mostrarDatos()
        {
            try
            {
                lblidvehiculo.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                TxtMarca.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                TxtModelo.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                TxtAño.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                TxtPlaca.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                TxtTipo.Text = tbl.Rows[posicion].ItemArray[5].ToString();



                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de Cliente",
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
                MessageBox.Show("Primer Registro...", "Registros De Vehiculo",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Vehiculo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Bbtnultimo_Click(object sender, EventArgs e)
        {
            {
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();
            }
        }

        void limpiar_cajas()
        {
            TxtMarca.Text = "";
            TxtModelo.Text = "";
            TxtAño.Text = "";
            TxtPlaca.Text = "";
            TxtTipo.Text = "";
        }

        void controles(Boolean valor)
        {
            GrbNavegacion.Enabled = valor;
            BtnDelete.Enabled = valor;
            BtnBuscar.Enabled = valor;
            GrbDatosCarro.Enabled = !valor;
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

              lblidvehiculo.Text,
              TxtMarca.Text,
              TxtModelo.Text,
              TxtAño.Text,
              TxtPlaca.Text,
              TxtTipo.Text

                };
                objConexion.mantenimiento_datos_vehiculo(valores, accion);
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
            if (MessageBox.Show("Esta seguro de eliminar a " + TxtMarca.Text, "Registro de Clientes",
               MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidvehiculo.Text };
                objConexion.mantenimiento_datos_vehiculo(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
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
