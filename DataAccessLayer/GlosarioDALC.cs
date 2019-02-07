using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;

namespace DataAccessLayer
{
    public class GlosarioDALC
    {
        public List<Glosario> GetGlosario()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                return db.Glosario.ToList();
            }
        }
    }
}
