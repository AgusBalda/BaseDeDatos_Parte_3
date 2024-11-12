using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos.Datos
{
    public class AccesoDatos
    {
        public SqlConnection conexion = new SqlConnection(@"Data Source=tpcine.cn0gmiyiwodt.us-east-2.rds.amazonaws.com;Initial Catalog=tp_cine_bdd;User ID=admin; Password=Tpcine123 ;Encrypt=False");
        public SqlCommand comando = new SqlCommand();

        public DataTable consultarBD(string consultaSQL)
        {
            DataTable tabla = new DataTable();

            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }
        public void Conectar()
        {
            conexion.Open();
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }
        public void Desconectar()
        {
            conexion.Close();
        }

    }
}
