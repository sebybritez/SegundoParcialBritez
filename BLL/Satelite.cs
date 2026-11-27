using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class Satelite
    {
        private MP_Satelite mp = new MP_Satelite();

        public List<BE.Satelite> Listar()
        {
            return mp.Listar();
        }

        public string Insertar(BE.CuerpoCeleste planeta, BE.CuerpoCeleste satelite)
        {
            if (planeta == null || satelite == null)
            {
                return "Debe seleccionar un planeta y un satélite.";
            }

            if (planeta.Tipo == null || planeta.Tipo.Nombre != "Planeta")
            {
                return "Solamente puede darse de alta un satélite alrededor de un Planeta.";
            }

            if (satelite.Tipo == null || satelite.Tipo.Nombre != "Satelite")
            {
                return "El cuerpo seleccionado como satélite debe ser de tipo Satelite.";
            }

            List<BE.Satelite> existentes = mp.Listar();
            foreach (BE.Satelite s in existentes)
            {
                if (s.Planeta.ID == planeta.ID && s.CuerpoSatelite.ID == satelite.ID)
                {
                    return "Ese satélite ya está asociado a ese planeta.";
                }
            }

            BE.Satelite nuevo = new BE.Satelite();
            nuevo.Planeta = planeta;
            nuevo.CuerpoSatelite = satelite;
            mp.Insertar(nuevo);

            return "";
        }
    }
}

