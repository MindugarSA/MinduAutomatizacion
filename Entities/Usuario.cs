using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Usuario
    {
        private static Usuario oInstance;

        protected Usuario()
        {
        }

        public static Usuario Instance()
        {
            if (oInstance == null)
                oInstance = new Usuario();

            return oInstance;
        }

        public string UserName { get; set; }
        public int UserId { get; set; }
        public string UserRut { get; set; }
    }
}
