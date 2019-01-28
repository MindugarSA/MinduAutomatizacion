using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Entities;

namespace PresentationLayer.Forms
{
    class Datos
    {
        public static DataTable listar()
        {
            Conexion c = new Conexion();
            String Cnn = c.conectar();
            String listar = "SELECT * from Item where TipoItem= 'T'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(listar, Cnn);
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarItemId(Item obj)
        {
            Conexion c = new Conexion();
            String Cnn = c.conectar();
            String buscarPro = "SELECT * FROM Item WHERE TipoItem='T' and codigo ='" + obj.Codigo + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(buscarPro, Cnn);
            da.Fill(dt);

            return dt;
        }
    }
}

//return (List<Item>) db.Item.ToList()
//                                          .Where(c => c.TipoItem == sItemTipo)
//                                          .OrderBy(c => c.Codigo)
//    
;

//var result = ItemsBL.GetItemsTipo("T")
//                            .Select(c =>
//                            {
//                                c.TipoItem = c.TipoPieza == "K" ? c.TipoItem : c.TipoItem + c.TipoPieza ?? "";
//                                return c;
//                            })
//                            .Where(s => (s.Codigo.ToUpper().Contains(txtBuscarProd.Text.Trim().ToUpper())
//                                        || s.Descripcion.ToUpper().Contains(txtBuscarProd.Text.Trim().ToUpper()))).ToList();

//                if (result != null)
//                    dgvListaItems.DataSource = result;