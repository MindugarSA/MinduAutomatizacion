using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class TipoItemDALC
    {
        public List<TipoItem> GetTipoItems()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return db.TipoItem.ToList();
            }
        }
    }
}
