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
        public static DataTable GetItemsBusqueda(int? ItemId)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItemsBusqueda(ItemId);
        }
        public static DataTable GetItemsDependencias(int? ItemId)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItemsDespendencias(ItemId);
        }

        public static Item InsertItem(Item ObjItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.InsertItem(ObjItem);
        }

        public static Item UpdateItem(Item ObjItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.UpdateItem(ObjItem);
        }
        public static Item DeleteItem(Item ObjItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.DeleteItem(ObjItem);
        }
    }
}
