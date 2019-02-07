using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class GlosarioBL
    {
        public static List<Glosario> GetGlosario()
        {
            GlosarioDALC obj = new GlosarioDALC();
            return obj.GetGlosario();
        }

        public static void InserCostos(List<Glosario> ListaCosto)
        {
            GlosarioDALC obj = new GlosarioDALC();
            foreach (Glosario Cost in ListaCosto)
            {
                obj.InsertGlosario(Cost);
            }
        }

        public static void UpdateCostos(List<Glosario> ListaCosto)
        {
            GlosarioDALC obj = new GlosarioDALC();
            foreach (Glosario Cost in ListaCosto)
            {
                obj.UpdateGlosario(Cost);
            }
        }
    }
}
