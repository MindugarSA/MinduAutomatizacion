using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
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

        public void InsertPropiedad(Propiedades Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    db.Propiedades.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdatePropiedad(Propiedades Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    Propiedades Entidad = (from n in db.Propiedades
                                           where n.id == Obj.id
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
