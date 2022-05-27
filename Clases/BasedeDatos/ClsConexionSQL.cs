using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Examen_Final_Programacion_I.Clases.BasedeDatos
{
   public class ClsConexionSQL
   {
        public SqlConnection conexion;
        private String _conexion { get; }

        public ClsConexionSQL()
        {

            _conexion = "Data Source=UMG-VM\\SQLEXPRESS;Initial Catalog=dbProgra1A;Integrated Security=True";
        }
        public void cerrarConexionBD()
        {
            conexion.Close();
        }

        public void abrirConexion()
        {
            conexion = new SqlConnection(_conexion);
            conexion.Open();
        }
        public DataTable consultaTablaDirecta(String sqll)
        {
            abrirConexion();
            SqlDataReader dr;
            SqlCommand comm = new SqlCommand(sqll, conexion);
            dr = comm.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarConexionBD();
            return dataTable;
        }

        public void EjecutaSQLDirecto(String sqll)
        {
            abrirConexion();
            try
            {

                SqlCommand comm = new SqlCommand(sqll, conexion);
                comm.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            finally
            {
                cerrarConexionBD();
            }

        }
    }
}
