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

        public static DataTable GetItemCostosId(int IdItem)
        {
            ItemCostoDALC obj = new ItemCostoDALC();
            return obj.GetItemCostosId(IdItem);
        }
    }
}
