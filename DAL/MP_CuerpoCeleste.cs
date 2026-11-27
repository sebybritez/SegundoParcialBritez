using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_CuerpoCeleste
    {
        private Acceso acceso = new Acceso();

        public List<BE.CuerpoCeleste> Listar()
        {
            List<BE.CuerpoCeleste> cuerpos = new List<BE.CuerpoCeleste>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("Cuerpo_Listar");
            acceso.Cerrar();
            foreach (DataRow fila in tabla.Rows)
            {
                BE.CuerpoCeleste cuerpo = new BE.CuerpoCeleste();
                cuerpo.ID = int.Parse(fila["ID_CUERPO"].ToString());
                cuerpo.Nombre = fila["NOMBRE"].ToString();
                cuerpo.Tipo = new BE.Tipo
                {
                    ID = int.Parse(fila["ID_TIPO"].ToString()),
                    Nombre = fila["TIPO"].ToString().Trim()
                };
                cuerpos.Add(cuerpo);
            }
            
            return cuerpos;
        }

        public void Insertar(BE.CuerpoCeleste cuerpo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@nombre", cuerpo.Nombre));
            parametros.Add(acceso.CrearParametro("@id_tipo", cuerpo.Tipo.ID));
            acceso.Abrir();
            acceso.Escribir("Cuerpo_Insertar", parametros);
            acceso.Cerrar();
        }

        public void Editar(BE.CuerpoCeleste cuerpo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", cuerpo.ID));
            parametros.Add(acceso.CrearParametro("@nombre", cuerpo.Nombre));
            parametros.Add(acceso.CrearParametro("@id_tipo", cuerpo.Tipo.ID));
            acceso.Abrir();
            acceso.Escribir("Cuerpo_Editar", parametros);
            acceso.Cerrar();

        }

        public void Baja(BE.CuerpoCeleste cuerpo)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id", cuerpo.ID));
            acceso.Abrir();
            acceso.Escribir("Cuerpo_Baja", parametros);
            acceso.Cerrar();
        }
    }
}

