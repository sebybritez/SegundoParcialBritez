using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class Tipo
    {
        private MP_Tipo mp = new MP_Tipo();

        public List<BE.Tipo> Listar()
        {
            return mp.Listar();
        }
    }
}

