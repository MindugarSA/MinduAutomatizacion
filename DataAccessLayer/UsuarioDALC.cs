using Entities;
using System;
using System.Collections.Generic;
using System.Data;
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
            using (DB_AUTOMATIZACIONEntities db = new DB_AUTOMATIZACIONEntities())
            {
                List<SP_VerifyUserPass_Result> result = db.SP_VerifyUserPass(RutUser,Pass).ToList();

                return new DataTable().ListToDataTable(result);
            }
        }
    }
}
