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

        public static void InserPropiedades(List<Propiedades> ListaPropiedades)
        {
            PropiedadesDALC obj = new PropiedadesDALC();
            foreach (Propiedades Prop in ListaPropiedades)
            {
                obj.InsertPropiedad(Prop);
            }
        }

        public static void UpdatePropiedades(List<Propiedades> ListaPropiedades)
        {
            PropiedadesDALC obj = new PropiedadesDALC();
            foreach (Propiedades Prop in ListaPropiedades)
            {
                obj.UpdatePropiedad(Prop);
            }
        }
    }
}
