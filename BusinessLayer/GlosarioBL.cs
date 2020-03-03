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

        public static void InsertToGlosario(List<Glosario> ListaGlosario)
        {
            GlosarioDALC obj = new GlosarioDALC();
            foreach (Glosario glo in ListaGlosario)
            {
                obj.InsertToGlosario(glo);
            }
        }

        public static void UpdateGlosario(List<Glosario> ListaGlosario)
        {
            GlosarioDALC obj = new GlosarioDALC();
            foreach (Glosario glo in ListaGlosario)//---
            {
                obj.UpdateGlosario(glo);
            }
        }
        public static void DeleteGlosario(List<Glosario> ListaGlosario)
        {
            GlosarioDALC obj = new GlosarioDALC();
            foreach (Glosario glo in ListaGlosario)//---
            {
                obj.DeleteGlosario(glo);
            }
        }
    }
}
