using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class CostosDALC
    {
        public List<Costos> GetCostos()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return (List<Costos>)db.Costos.ToList().OrderByDescending(c => c.Categoria).ThenBy(c => c.Id).ToList();
            }
        }
    }
}
