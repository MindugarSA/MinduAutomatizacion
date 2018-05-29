using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace DataAccessLayer
{
    public class PropiedadesDALC
    {
        public List<Propiedades> GetPropiedades()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return (List<Propiedades>)db.Propiedades.ToList().OrderBy(c => c.Codigo).ToList();
            }
        }
    }
}
