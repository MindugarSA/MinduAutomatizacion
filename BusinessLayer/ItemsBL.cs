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
        //public static List<Item> GetItemsProductosParte() // productos parte
        //{
        //    ItemsDALC obj = new ItemsDALC();
        //    return obj.GetItemsProductosParte();//modificar
        //}
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

        public static DataTable ListadoItemsResumen()
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.ListadoItemsResumen();
        }

        public static DataTable ListadoItemsCostoResumen()
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.ListadoItemsCostoResumen();
        }

        public static DataTable ListadoItemsCostoDetallado()
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.ListadoItemsCostoDetallado();
        }

        public static DataTable ListadoItemsTipoCostoFactor(string TipoItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.ListadoItemsTipoCostoFactor(TipoItem);
        }

        public static DataTable ListadoItemsTipoCostoFactorRES(string TipoItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.ListadoItemsTipoCostoFactorRES(TipoItem);
        }
        public static DataTable GetItemsProductosParte(string TipoItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItemsProductosParte(TipoItem);
        }

        public static DataTable ListadoItemsAutorizacion()
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.ListadoItemsAutorizacion();
        }
        public static DataTable EstadoProductosTerminados(string TipoItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.GetItemsEstadoProductosTerminados(TipoItem);
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

        public static void UpdateItemCostoTotalRelacionados(int ItemID)
        {
            ItemsDALC obj = new ItemsDALC();
            obj.UpdateItemCostoTotalRelacionados(ItemID);
        }

        public static Item DeleteItem(Item ObjItem)
        {
            ItemsDALC obj = new ItemsDALC();
            return obj.DeleteItem(ObjItem);
        }
    }
}
