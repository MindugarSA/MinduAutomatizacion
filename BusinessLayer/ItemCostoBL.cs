using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public class ItemCostoBL
    {
        public static List<ItemCosto> GetItemCostos()
        {
            ItemCostoDALC obj = new ItemCostoDALC();
            return obj.GetItemCostos();
        }

        public static DataTable GetItemCostoId(int IdItem)
        {
            ItemCostoDALC obj = new ItemCostoDALC();
            return obj.GetItemCostoId(IdItem);
        }

        //public static List<Item> GetItemsTipo(string sTipo)
        //{
        //    ItemsDALC obj = new ItemsDALC();
        //    return obj.GetItemsTipo(sTipo);
        //}
        public static void InsertItemCostos(List<ItemCosto> ListaIC)
        {
            ItemCostoDALC obj = new ItemCostoDALC();
            foreach (ItemCosto ItenC in ListaIC)
            {
                obj.InsertItemCosto(ItenC);
            }
        }

        public static void UpdateItemCostos(List<ItemCosto> ListaIC)
        {
            ItemCostoDALC obj = new ItemCostoDALC();
            foreach (ItemCosto ItenC in ListaIC)
            {
                obj.UpdateItemCosto(ItenC);
            }
        }

        public static void UpdateItemCostosID(int CostoID)
        {
            ItemCostoDALC obj = new ItemCostoDALC();

            obj.UpdateItemCostoID(CostoID);
        }

        public static void DeleteItemCostos(List<ItemCosto> ListaIC)
        {
            ItemCostoDALC obj = new ItemCostoDALC();
            foreach (ItemCosto ItenC in ListaIC)
            {
                obj.DeleteItemCosto(ItenC);
            }
        }
    }
}
