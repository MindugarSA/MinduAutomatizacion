using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class UsuarioDALC
    {
        private static UsuarioDALC oInstance;

        protected UsuarioDALC()
        {
        }

        public static UsuarioDALC Instance()
        {

            if (oInstance == null)
                oInstance = new UsuarioDALC();

            return oInstance;

        }

        public DataTable VerificarRutPass(string RutUser, string Pass)
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
                string sp = "[SP_VerifyUserPass]";

                SlqCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand(sp, SlqCon);

                SlqCon.Open();
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlCmd.Parameters.Add(new SqlParameter("@Rut", RutUser));
                SqlCmd.Parameters.Add(new SqlParameter("@Pass", Pass));

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
