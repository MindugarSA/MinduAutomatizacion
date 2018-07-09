using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entities;
using DataAccessLayer;
using System.Data;

namespace BusinessLayer
{
    public static class UsuarioBL
    {
        public static DataTable VerificarRutPass(string RutUser, string Pass)
        {
            return UsuarioDALC.Instance().VerificarRutPass(RutUser, Pass);
        }
    }
}
