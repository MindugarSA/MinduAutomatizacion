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
    public class ItemsDALC
    {
        public List<Item> GetItems()
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    return (List<Item>)db.Item.ToList()
            //                              .OrderBy(c => c.Codigo)
            //                              .ToList();
            //}

            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            List<Item> lItem = new List<Item>(); //Lista vacia

            try
            {
                string sp = "[SP_GetItems]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count > 0)
                {
                    lItem = (List<Item>)DtResultado.ToList<Item>();
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

        public List<Item> GetItemsTipo(string sItemTipo)
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    return (List<Item>)db.Item.ToList()
            //                              .Where(c => c.TipoItem == sItemTipo)
            //                              .OrderBy(c => c.Codigo)
            //                              .ToList();
            //}

            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            List<Item> lItem = new List<Item>(); //Lista vacia

            try
            {
                string sp = "[SP_GetItemsTipo]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@sItemTipo", sItemTipo));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if(DtResultado.Rows.Count >0)
                {
                    lItem = (List<Item>)DtResultado.ToList<Item>();
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

        public List<Item> GetItemId(int idItem)
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    if (db.Database.Connection.State == ConnectionState.Closed)
            //        db.Database.Connection.Open();

            //    return (List<Item>)db.Item.ToList()
            //                              .Where(c => c.Id == idItem)
            //                              .ToList();
            //}
            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            List<Item> lItem = new List<Item>(); //Lista vacia

            try
            {
                string sp = "[GetItemId]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@ID", idItem));

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

                if (DtResultado.Rows.Count > 0)
                {
                    lItem = (List<Item>)DtResultado.ToList<Item>();
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

        public DataTable GetItemsBusqueda(int? idItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_GetItemBusqueda_Result> result = db.SP_GetItemBusqueda(idItem).ToList();

                return new DataTable().ListToDataTable(result);
            }

            //DataTable DtResultado = new DataTable();
            //SqlConnection SlqCon = new SqlConnection();

            //List<Item> lItem = new List<Item>(); //Lista vacia

            //try
            //{
            //    string sp = "[SP_GetItemBusqueda]";

            //    SlqCon.ConnectionString = Conexion.Cn;
            //    SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

            //    SlqCon.Open();
            //    SqlCmd.CommandType = CommandType.StoredProcedure;
            //    SqlCmd.Parameters.Add(new SqlParameter("@id_Item", idItem));

            //    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
            //    SqlDat.Fill(DtResultado);

            //    if (DtResultado.Rows.Count > 0)
            //    {
            //        lItem = (List<Item>)DtResultado.ToList<Item>();
            //    }

            //}
            //catch
            //{
            //    DtResultado = null;
            //}
            //finally
            //{
            //    if (SlqCon.State == ConnectionState.Open) SlqCon.Close();
            //}
            //return DtResultado;


        }

        public DataTable GetItemsDespendencias(int? idItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_GetItemDependeceID_Result> result = db.SP_GetItemDependeceID(idItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsResumen()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_ListadoItemsResumen_Result> result = db.SP_ListadoItemsResumen().ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsCostoResumen()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_ListadoItemsCostosResumen_Result> result = db.SP_ListadoItemsCostosResumen().ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsCostoDetallado()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                DataTable dt = new DataTable();

                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "[dbo].[SP_ListadoItemsCostosDetallado]";
                cmd.CommandType = CommandType.StoredProcedure;

                if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
                dt.Load(cmd.ExecuteReader());

                return dt;
            }
        }

        public DataTable ListadoItemsTipoCostoFactor(string TipoItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_ListadoItemTipoCostoFactor_Result> result = db.SP_ListadoItemTipoCostoFactor(TipoItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsTipoCostoFactorRES(string TipoItem)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_ListadoItemTipoCostoFactorRES_Result> result = db.SP_ListadoItemTipoCostoFactorRES(TipoItem).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public DataTable ListadoItemsAutorizacion()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                List<SP_ListadoItemAutorizaciones_Result> result = db.SP_ListadoItemAutorizaciones().ToList();

                return new DataTable().ListToDataTable(result);
            }
        }

        public Item InsertItem(Item Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    db.Item.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
                return Obj;
            }
        }

        public Item UpdateItem(Item Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    Item Entidad = (from n in db.Item
                                    where n.Id == Obj.Id
                                    select n).FirstOrDefault();
                    db.Entry(Entidad).CurrentValues.SetValues(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
                return Obj;
            }
        }

        public void UpdateItemCostoTotalRelacionados(int ItemID)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {

                if (db.Database.Connection.State == ConnectionState.Closed)
                    db.Database.Connection.Open();

                var cmd = db.Database.Connection.CreateCommand();
                cmd.CommandText = "[dbo].[SP_ActualizarCostosItemsKitProduto]";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@IdItemDet", ItemID));

                if (cmd.Connection.State == ConnectionState.Closed) cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
        }

        public Item DeleteItem(Item Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    if (db.Database.Connection.State == ConnectionState.Closed)
                        db.Database.Connection.Open();

                    Item Entidad = (from n in db.Item
                                    where n.Id == Obj.Id
                                    select n).FirstOrDefault();
                    db.Item.Remove(Entidad);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
                return Obj;
            }
        }
    }
}

