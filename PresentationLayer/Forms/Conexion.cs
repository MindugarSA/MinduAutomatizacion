using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Forms
{
    class Conexion
    {
        public String conectar()
        {
            return "Data Source = FSSAPBO; Initial Catalog = DB_AUTOMATIZACION; User ID = SA; password = Sqladmin281;";
        }
    }
}
