using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DataAccessLayer
{
    public class ReglasFamiliaDALC
    {
        public List<ReglasFamilia> GetReglasFamilia()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return db.ReglasFamilia.ToList();
            }
        }
    }
}
