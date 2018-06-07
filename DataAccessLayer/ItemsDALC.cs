using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public void InsertItem(Item Obj)
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
            }
        }

        public void UpdateItem(Item Obj)
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
            }
        }
    }
}

