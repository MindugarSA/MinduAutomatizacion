using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class UnidadesBL
    {
        public static List<Unidades> GetUnidades()
        {
            UnidadesDALC obj = new UnidadesDALC();
            return obj.GetUnidades();
        }
    }
}
