using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MP_Tipo
    {
        private Acceso acceso = new Acceso();

        public List<BE.Tipo> Listar()
        {
            List<BE.Tipo> tipos = new List<BE.Tipo>();
           
            acceso.Abrir();
            DataTable tabla = acceso.Leer("Tipo_Listar");
            acceso.Cerrar();
            foreach (DataRow fila in tabla.Rows)
            {
                BE.Tipo tipo = new BE.Tipo();
                tipo.ID = int.Parse(fila["ID_TIPO"].ToString());
                tipo.Nombre = fila["TIPO"].ToString().Trim();
                tipos.Add(tipo);
            }
            return tipos;
        }
    }
}

