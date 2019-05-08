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
    public class FamiliaDALC 
    {
        private static FamiliaDALC oInstance;


        public List<Familia> GetFamilias()
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                return db.Familia.ToList();
            }
        }

        public void InsertFamilia(Familia Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    db.Familia.Add(Obj);
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    EntityExceptionError.CatchError(ex);
                }
            }
        }

        public void UpdateFamilia(Familia Obj)
        {
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                try
                {
                    Familia Entidad = (from n in db.Familia
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

        public static FamiliaDALC Instance()
        {

            if (oInstance == null)
                oInstance = new FamiliaDALC();

            return oInstance;

        }

        public DataTable VerificarRutPass(string NumFamilia)
        {
            //using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            //{
            //    List<SP_VerifyUserPass_Result> result = db.SP_VerifyUserPass(RutUser,Pass).ToList();

            //    return new DataTable().ListToDataTable(result);
            //}

            DataTable DtResultado = new DataTable();
            SqlConnection SlqCon = new SqlConnection();

            try
            {
                string sp = "[SP_VerifyFamilia]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@NumFamilia", NumFamilia));
                

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
    }
}
