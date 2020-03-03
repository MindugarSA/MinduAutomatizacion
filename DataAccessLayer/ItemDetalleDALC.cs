using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using Entities;

namespace DataAccessLayer
{
    public class ItemDetalleDALC
    {
        public List<ItemDetalle> GetItemDetalle()
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    return db.ItemDetalle.ToList();
            //}
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            List<ItemDetalle> lItem = new List<ItemDetalle>(); //Lista vacia

            try
            {
                string sp = "[SP_GetItemDetalle]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count > 0)
                {
                    lItem = (List<ItemDetalle>)DtResultado.ToList<ItemDetalle>();
                }

            }
            catch
            {
                DtResultado = null;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }
            return lItem;
        }

        public DataTable GetItemDetalleId(int IdItem)
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    List<SP_GetItemDetalleID_Result> result = db.SP_GetItemDetalleID(IdItem).ToList();

            //    return new DataTable().ListToDataTable(result);
            //}
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();


            try
            {
                string sp = "[SP_GetItemDetalleId]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@id_Item", IdItem));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);
            }
            catch
            {
                DtResultado = null;
            }
            finally
            {
                if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            }
            return DtResultado;
        }

        public void InsertItemDetalle(ItemDetalle Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    db.ItemDetalle.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdateItemDetalle(ItemDetalle Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    ItemDetalle Entidad = (from n in db.ItemDetalle
                                           where n.Id == Obj.Id
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

        public void DeleteItemDetalle(ItemDetalle Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    ItemDetalle Entidad = (from n in db.ItemDetalle
                                           where n.Id == Obj.Id
                                           select n).FirstOrDefault();
                    db.ItemDetalle.Remove(Entidad);
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
