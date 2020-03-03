using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;

namespace DataAccessLayer
{
    public class ItemCostoDALC
    {
        public List<ItemCosto> GetItemCostos()
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    return db.ItemCosto.ToList();
            //}

            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            List<ItemCosto> lItemCosto = new List<ItemCosto>(); //Lista vacia

            try
            {
                string sp = "[SP_GetItemCosto]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count > 0)
                {
                    lItemCosto = (List<ItemCosto>)DtResultado.ToList<ItemCosto>();
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
            return lItemCosto;
        }

        public DataTable GetItemCostoId(int IdItem)
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    List<SP_GetItemCostoID_Result> result = db.SP_GetItemCostoID(IdItem).ToList();

            //    return new DataTable().ListToDataTable(result);
            //}

            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            //List<Item> lItem = new List<Item>(); //Lista vacia

            try
            {
                string sp = "[SP_GetItemCostoID]";

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

        public void InsertItemCosto(ItemCosto Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    db.ItemCosto.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdateItemCosto(ItemCosto Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    ItemCosto Entidad = (from n in db.ItemCosto
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
        //public ItemCosto UpdateItemCosto(ItemCosto Obj)
        //{
        //    using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
        //    {
        //        try
        //        {
        //            if (db.Database.Connection.State == ConnectionState.Closed)
        //                db.Database.Connection.Open();

        //            ItemCosto Entidad = (from n in db.ItemCosto
        //                                 where n.Id == Obj.Id
        //                            select n).FirstOrDefault();
        //            db.Entry(Entidad).CurrentValues.SetValues(Obj);
        //            db.SaveChanges();
        //        }
        //        catch (DbEntityValidationException ex)
        //        {
        //            EntityExceptionError.CatchError(ex);
        //        }
        //        return Obj;
        //    }
        //}


        public void UpdateItemCostoID(int CostoID)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "[dbo].[SP_ActualizarCostosItems]";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdCosto", CostoID));

                if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void DeleteItemCostoID(int CostoID)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "[dbo].[SP_EliminarCostosItems]";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdCosto", CostoID));

                if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public void DeleteItemCosto(ItemCosto Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    ItemCosto Entidad = (from n in db.ItemCosto
                                         where n.Id == Obj.Id
                                         select n).FirstOrDefault();
                    db.ItemCosto.Remove(Entidad);
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
