using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class UnidadesDALC
    {
        public List<Unidades> GetUnidades()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return db.Unidades.ToList();
            }
        }
    }
}
