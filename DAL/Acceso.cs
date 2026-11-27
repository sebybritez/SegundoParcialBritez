using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    internal class Acceso
    {
        private SqlConnection conexion;

        public void Abrir()
        {
            conexion = new SqlConnection("Integrated Security=SSPI; Data Source=.; Initial Catalog=Parcial2");
            conexion.Open();
        }

        public void Cerrar()
        {
            if (conexion != null && conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            conexion = null;
            GC.Collect();
        }

        private SqlCommand CrearComando(string sql, List<SqlParameter> parametros = null)
        {
            SqlCommand cmd = new SqlCommand(sql, conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            if (parametros != null)
            {
                cmd.Parameters.AddRange(parametros.ToArray());
            }
            return cmd;
        }

        public SqlParameter CrearParametro(string nombre, string valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.String;
            return p;
        }

        public SqlParameter CrearParametro(string nombre, int valor)
        {
            SqlParameter p = new SqlParameter(nombre, valor);
            p.DbType = DbType.Int32;
            return p;
        }

        public int Escribir(string sql, List<SqlParameter> parametros = null)
        {
            int filas;
            using (SqlCommand cmd = CrearComando(sql, parametros))
            {
                filas = cmd.ExecuteNonQuery();
                cmd.Parameters.Clear();
            }
            return filas;
        }

        public DataTable Leer(string sql, List<SqlParameter> parametros = null)
        {
            DataTable tabla = new DataTable();
            using (SqlDataAdapter da = new SqlDataAdapter())
            {
                da.SelectCommand = CrearComando(sql, parametros);
                da.Fill(tabla);
            }
            return tabla;
        }
    }
}

