using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//libreria DB
using System.Data;
//libreria DB con SQL Server
using System.Data.SqlClient;

namespace GuevaraLuis
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String Cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_parque_vehicular_guevara_rodriguez.mdf;Integrated Security=True";
            miConexion.ConnectionString = Cadena;
            miConexion.Open();
        }

        public DataSet obtener_datos()
        {

            ds.Clear();
            comandosSQL.Connection = miConexion;


            comandosSQL.CommandText = "select * from Parqueo";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Parqueo");


            comandosSQL.CommandText = "select * from tbl_vehiculos";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "tbl_vehiculos");


            comandosSQL.CommandText = "select * from Cliente";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Cliente");



            comandosSQL.CommandText = " select Cliente.nombre, Parqueo.IdParqueo, Parqueo.IdVehiculo, Parqueo.HoraEntrada, Parqueo.HoraSalida,  Parqueo.TotalPagar," +
                                      " tbl_vehiculos.marca, tbl_vehiculos.modelo " +
                                      " from Parqueo " +
                                      " inner join Cliente on(Cliente.IdCliente = Parqueo.IdClientes)" +
                                      " inner join tbl_vehiculos on(tbl_vehiculos.IdVehiculo = Parqueo.IdVehiculo)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Parqueo_Cliente_tbl_vehiculos");
            return ds;
        }

        public void mantenimiento_datos_parqueo(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO Parqueo" +
                    " (IdClientes, IdVehiculo, HoraEntrada, HoraSalida, TotalPagar) VALUES (" +

                "'" + datos[1] + "'," +
                "'" + datos[2] + "'," +
                "'" + datos[3] + "'," +
                "'" + datos[4] + "'," +
                "'" + datos[5] + "'" +
                ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE Parqueo SET" +

                " IdClientes             = '" + datos[1] + "'," +
                " IdVehiculo             = '" + datos[2] + "'," +
                " HoraEntrada          = '" + datos[3] + "'," +
                " HoraSalida        = '" + datos[4] + "'," +
                " TotalPagar                  = '" + datos[5] + "'" +
                 " WHERE IdParqueo      = '" + datos[0] + "'";
            }

            else if (accion == "eliminar")

            {
                sql = " DELETE FROM Parqueo WHERE IdParqueo = '" + datos[0] + "'";

            }
            procesarSQL(sql);
        }
        

            public void mantenimiento_datos_vehiculo(String[] datos, String accion)
            {
                String sql = "";
                if (accion == "nuevo")
                {

                    sql = "INSERT INTO tbl_vehiculos (marca, modelo, año, placa, tipo) VALUES(" +

                        "'" + datos[1] + "'," +
                        "'" + datos[2] + "'," +
                        "'" + datos[3] + "'," +
                        "'" + datos[4] + "'," +
                        "'" + datos[5] + "'" +
                        ")";

                }

                else if (accion == "modificar")
                {

                    sql = "UPDATE tbl_vehiculos SET " +
                    " marca            = '" + datos[1] + "'," +
                    " modelo               = '" + datos[2] + "'," +
                    " año                 = '" + datos[3] + "'," +
                    " placa               = '" + datos[4] + "'," +
                    " tipo               = '" + datos[5] + "'" +
                    "WHERE IdVehiculo         = '" + datos[0] + "'";





                }
                else if (accion == "eliminar")
                {
                    sql = "DELETE tbl_vehiculos FROM tbl_vehiculos WHERE IdVehiculo='" + datos[0] + "'";

                }
                procesarSQL(sql);
            }

        public void mantenimiento_datos_Cliente(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {

                sql = "INSERT INTO Cliente (nombre, direccion, telefono, dui) VALUES(" +

                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'" +
                    ")";

            }

            else if (accion == "modificar")
            {

                sql = "UPDATE Cliente SET " +
                " nombre              = '" + datos[1] + "'," +
                " direccion           = '" + datos[2] + "'," +
                " telefono            = '" + datos[3] + "'," +
                " dui                 = '" + datos[4] + "'" +
                " WHERE IdCliente     = '" + datos[0] + "'";


            }
            else if (accion == "eliminar")
            {
                sql = "DELETE Cliente FROM Cliente WHERE IdCliente='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }

        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }



    }

}






