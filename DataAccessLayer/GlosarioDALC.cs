using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class GlosarioDALC
    {
        public List<Glosario> GetGlosario()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return (List<Glosario>)db.Glosario.ToList();
                //¿Como hacer la consulta simple de todas las palabras dentro del glosario con esto-^?
            }
        }

        public void InsertToGlosario(Glosario Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    db.Glosario.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdateGlosario(Glosario Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    Glosario Entidad = (from n in db.Glosario
                                        where n.Nombre == Obj.Nombre
                                        select n).SingleOrDefault();
                    //db.Entry(Entidad).CurrentValues.SetValues(Obj);

                    Console.WriteLine(default(Glosario));
                    if (Entidad != default(Glosario))
                    {
                        Entidad.Descripcion = Obj.Descripcion;
                        
                    }
                    db.SaveChanges();
                    
                    
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void DeleteGlosario(Glosario Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    Glosario Entidad = (from n in db.Glosario
                                         where n.Nombre == Obj.Nombre
                                         select n).FirstOrDefault();
                    db.Glosario.Remove(Entidad);
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

