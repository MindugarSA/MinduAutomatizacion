using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
