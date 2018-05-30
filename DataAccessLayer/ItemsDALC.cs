using System;
using System.Collections.Generic;
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
    }
}
