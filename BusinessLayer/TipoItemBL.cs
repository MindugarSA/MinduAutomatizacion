using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccessLayer;

namespace BusinessLayer
{
    public class TipoItemBL
    {
    public static List<TipoItem> GetTipoItems()
    {
        TipoItemDALC obj = new TipoItemDALC();
        return obj.GetTipoItems();
    }
    }
}
