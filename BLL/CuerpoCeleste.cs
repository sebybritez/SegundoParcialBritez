using System;
using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class CuerpoCeleste
    {
        private MP_CuerpoCeleste mp = new MP_CuerpoCeleste();

        public void Grabar(BE.CuerpoCeleste cuerpo)
        {
            if (cuerpo.ID == 0)
            {
                mp.Insertar(cuerpo);
            }
            else
            {
                mp.Editar(cuerpo);
            }
        }

        public void Baja(BE.CuerpoCeleste cuerpo)
        { 
            mp.Baja(cuerpo);
        }

        public List<BE.CuerpoCeleste> Listar(BE.CuerpoCeleste filtro = null)
        {
            List<BE.CuerpoCeleste> cuerpos = mp.Listar();
            if (filtro != null)
            {
                cuerpos = (from BE.CuerpoCeleste c in cuerpos
                           where c.ID == filtro.ID
                           select c).ToList();
            }
            return cuerpos;
        }
    }
}

