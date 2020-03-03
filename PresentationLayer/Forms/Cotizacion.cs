using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Forms
{
    public class Cotizacion
    {
        public int Id { get; set; }
        public string CodigoPro { get; set; }
        public Nullable<int> IdItem { get; set; }
        public Nullable<int> Item { get; set; }
        public Nullable<int> NumeroCot { get; set; }
        public string NombreVendedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Cliente { get; set; }
        public string DetallePro { get; set; }
        public string FamiliaPro { get; set; }
        public Nullable<decimal> CostoUni { get; set; }
        public Nullable<int> FactorComer { get; set; }
        public Nullable<decimal> Cantidad { get; set; }
        public Nullable<decimal> ValorNeto { get; set; }
        public Nullable<decimal> ValorIva { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
    }
    //public partial class Cotizacion
    //{
    //    public int Id { get; set; }
    //    public Nullable<int> IdItem { get; set; }
    //    public Nullable<int> Item { get; set; }
    //    public Nullable<int> NumeroCot { get; set; }
    //    public string NombreVendedor { get; set; }
    //    public Nullable<System.DateTime> Fecha { get; set; }
    //    public string Cliente { get; set; }
    //    public string DetallePro { get; set; }
    //    public Nullable<decimal> CostoUni { get; set; }
    //    public Nullable<int> FactorComer { get; set; }
    //    public Nullable<decimal> Cantidad { get; set; }
    //    public Nullable<decimal> ValorNeto { get; set; }
    //    public Nullable<decimal> ValorIva { get; set; }
    //    public Nullable<decimal> ValorTotal { get; set; }

    //    public virtual Item Item1 { get; set; }
    //}
}
