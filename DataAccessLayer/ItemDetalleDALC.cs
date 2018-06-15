using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataAccessLayer
{
    public class ItemDetalleDALC
    {
        public List<ItemDetalle> GetItemDetalle()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return db.ItemDetalle.ToList();
            }
        }

        public DataTable GetItemDetalleId(int IdItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_GetItemDetalleID_Result1> result = db.SP_GetItemDetalleID(IdItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public void InsertItemDetalle(ItemDetalle Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    db.ItemDetalle.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdateItemDetalle(ItemDetalle Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    ItemDetalle Entidad = (from n in db.ItemDetalle
                                           where n.Id == Obj.Id
                                           select n).FirstOrDefault();
                    db.Entry(Entidad).CurrentValues.SetValues(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void DeleteItemDetalle(ItemDetalle Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    ItemDetalle Entidad = (from n in db.ItemDetalle
                                           where n.Id == Obj.Id
                                           select n).FirstOrDefault();
                    db.ItemDetalle.Remove(Entidad);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }
    }
}
