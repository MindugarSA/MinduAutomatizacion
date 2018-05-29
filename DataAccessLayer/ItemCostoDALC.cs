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
    public class ItemCostoDALC
    {
        public List<ItemCosto> GetItemCostos()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return db.ItemCosto.ToList();
            }
        }

        public DataTable GetItemCostosId(int IdItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {

                List<SP_GetItemCostoID_Result> result = db.SP_GetItemCostoID(IdItem).ToList();



                return new DataTable().ListToDataTable(result);
            }
        }

        public void InsertItemCosto(ItemCosto Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    db.ItemCosto.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdateItemCosto(ItemCosto Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    ItemCosto Entidad = (from n in db.ItemCosto
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
    }
}
