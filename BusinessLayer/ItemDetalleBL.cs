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
    }
}
