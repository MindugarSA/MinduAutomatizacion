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
        public static List<ItemDetalle> GetItemDetalle()
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            return obj.GetItemDetalle();
        }

        public static DataTable GetItemDetalleId(int IdItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            return obj.GetItemDetalleId(IdItem);
        }

        public static void InsertItemDetalle(List<ItemDetalle> ListaItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            foreach (ItemDetalle item in ListaItem)
            {
                obj.InsertItemDetalle(item);
            }
        }

        public static void UpdateItemDetalle(List<ItemDetalle> ListaItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            foreach (ItemDetalle item in ListaItem)
            {
                obj.UpdateItemDetalle(item);
            }
        }

        public static void DeleteItemDetalle(List<ItemDetalle> ListaItem)
        {
            ItemDetalleDALC obj = new ItemDetalleDALC();
            foreach (ItemDetalle item in ListaItem)
            {
                obj.DeleteItemDetalle(item);

            }
        }
    }
}
