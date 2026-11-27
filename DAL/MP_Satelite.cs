using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class MP_Satelite
    {
        private Acceso acceso = new Acceso();

        public List<BE.Satelite> Listar()
        {
            List<BE.Satelite> satelites = new List<BE.Satelite>();
            acceso.Abrir();
            DataTable tabla = acceso.Leer("Satelite_Listar");
            acceso.Cerrar();

            foreach (DataRow fila in tabla.Rows)
            {
                BE.Satelite sat = new BE.Satelite();
                sat.Planeta = new BE.CuerpoCeleste
                {
                    ID = int.Parse(fila["ID_PLANETA"].ToString()),
                    Nombre = fila["NOMBRE_PLANETA"].ToString()
                };
                sat.CuerpoSatelite = new BE.CuerpoCeleste
                {
                    ID = int.Parse(fila["ID_SATELITE"].ToString()),
                    Nombre = fila["NOMBRE_SATELITE"].ToString()
                };
                satelites.Add(sat);
            }

            return satelites;
        }

        public void Insertar(BE.Satelite satelite)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(acceso.CrearParametro("@id_planeta", satelite.Planeta.ID));
            parametros.Add(acceso.CrearParametro("@id_satelite", satelite.CuerpoSatelite.ID));
            acceso.Abrir();
            acceso.Escribir("Satelite_Insertar", parametros);
            acceso.Cerrar();
        }
    }
}

