using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class PropiedadesBL
    {
        public static List<Propiedades> GetPropiedades()
        {
            PropiedadesDALC obj = new PropiedadesDALC();
            return obj.GetPropiedades();
        }
    }
}
