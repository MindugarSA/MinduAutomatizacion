﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataAccessLayer
{
    public class ItemsDALC
    {
        public List<Item> GetItems()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return (List<Item>)db.Item.ToList()
                                          .OrderBy(c => c.Codigo)
                                          .ToList();
            }
        }

        public List<Item> GetItemsTipo(string sItemTipo)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return (List<Item>)db.Item.ToList()
                                          .Where(c => c.TipoItem == sItemTipo)
                                          .OrderBy(c => c.Codigo)
                                          .ToList();
            }
        }

        public List<Item> GetItemId(int idItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return (List<Item>)db.Item.ToList()
                                          .Where(c => c.Id == idItem)
                                          .ToList();
            }
        }

        public DataTable GetItemsBusqueda(int? idItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_GetItemBusqueda_Result> result = db.SP_GetItemBusqueda(idItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable GetItemsDespendencias(int? idItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_GetItemDependeceID_Result> result = db.SP_GetItemDependeceID(idItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsResumen()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_ListadoItemsResumen_Result> result = db.SP_ListadoItemsResumen().ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsCostoResumen()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_ListadoItemsCostosResumen_Result> result = db.SP_ListadoItemsCostosResumen().ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsCostoDetallado()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                DataTable dt = new DataTable();

                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "[dbo].[SP_ListadoItemsCostosDetallado]";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Connection.Open();
                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public DataTable ListadoItemsTipoCostoFactor(string TipoItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_ListadoItemTipoCostoFactor_Result> result = db.SP_ListadoItemTipoCostoFactor(TipoItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public Item InsertItem(Item Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    db.Item.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
                return Obj;
            }
        }

        public Item UpdateItem(Item Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    Item Entidad = (from n in db.Item
                                    where n.Id == Obj.Id
                                       select n).FirstOrDefault();
                    db.Entry(Entidad).CurrentValues.SetValues(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
                return Obj;
            }
        }

        public Item DeleteItem(Item Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    Item Entidad = (from n in db.Item
                                    where n.Id == Obj.Id
                                    select n).FirstOrDefault();
                    db.Item.Remove(Entidad);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
                return Obj;
            }
        }
    }
}

