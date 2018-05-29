using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class FamiliaBL
    {
        public static List<Familia> GetFamilias()
        {
            FamiliaDALC obj = new FamiliaDALC();
            return obj.GetFamilias();
        }

        public static void InsertFamilias(List<Familia> ListaFami)
        {
            FamiliaDALC obj = new FamiliaDALC();
            foreach (Familia Fami in ListaFami)
            {
                obj.InsertFamilia(Fami);
            }
        }

        public static void UpdateFamilias(List<Familia> ListaFami)
        {
            FamiliaDALC obj = new FamiliaDALC();
            foreach (Familia Fami in ListaFami)
            {
                obj.UpdateFamilia(Fami);
            }
        }
    }
}
