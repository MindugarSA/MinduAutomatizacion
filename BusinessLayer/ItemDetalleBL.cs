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
    public class ItemDetalleBL
    {
        public static List<ItemDetalle> GetItemCostos()
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            return obj.GetItemDetalle();
        }

        public static DataTable GetItemCostosId(int IdItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            return obj.GetItemDetalleId(IdItem);
        }

        public static void InsertFamilias(List<ItemDetalle> ListaItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            foreach (ItemDetalle item in ListaItem)
            {
                obj.InsertItemDetalle(item);
            }
        }

        public static void UpdateFamilias(List<ItemDetalle> ListaItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            foreach (ItemDetalle item in ListaItem)
            {
                obj.UpdateItemDetalle(item);
            }
        }
    }
}
