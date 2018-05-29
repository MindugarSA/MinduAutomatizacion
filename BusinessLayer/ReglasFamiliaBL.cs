using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ReglasFamiliaBL
    {
        public static List<ReglasFamilia> GetReglasFamilia()
        {
            ReglasFamiliaDALC obj = new ReglasFamiliaDALC();
            return obj.GetReglasFamilia();
        }
    }
}
