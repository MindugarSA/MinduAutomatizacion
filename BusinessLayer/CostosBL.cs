using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class CostosBL
    {
        public static List<Costos> GetCostos()
        {
            CostosDALC obj = new CostosDALC();
            return obj.GetCostos();
        }
    }
}
