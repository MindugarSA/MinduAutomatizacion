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
    public class GlosarioBL
    {
        
        public static List<Glosario> GetGlosario()
        {
            GlosarioDALC obj = new GlosarioDALC();
            return obj.GetGlosario();
        }
    }
}
