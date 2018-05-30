using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ItemsBL
    {
        public static List<Item> GetItems()
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItems();
        }

        public static List<Item> GetItemsTipo(string sTipo)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItemsTipo(sTipo);
        }

        public static List<Item> GetItemId(int ItemId)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItemId(ItemId);
        }


    }
}
