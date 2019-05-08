//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
[Serializable]
public partial class Item
{
    public int Id { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public string Nombre { get; set; }
    public Nullable<int> Familia { get; set; }
    public string TipoItem { get; set; }
    public Nullable<decimal> Espesor { get; set; }
    public Nullable<decimal> Ancho { get; set; }
    public Nullable<decimal> Largo { get; set; }
    public Nullable<decimal> Diametro { get; set; }
    public Nullable<decimal> Volumen { get; set; }
    public Nullable<decimal> Peso { get; set; }
    public string TipoAcero { get; set; }
    public Nullable<decimal> CostoCM { get; set; }
    public Nullable<decimal> CostoRH { get; set; }
    public Nullable<decimal> CostoPR { get; set; }
    public Nullable<decimal> CostoAC { get; set; }
    public Nullable<decimal> CostoTotal { get; set; }
    public byte[] Imagen { get; set; }
    public Nullable<System.DateTime> FechaCreacion { get; set; }
    public string UsuarioCrea { get; set; }
    public Nullable<System.DateTime> FechaModificacion { get; set; }
    public string UsuarioMod { get; set; }
    public string TipoPieza { get; set; }
    public Nullable<int> Estatus { get; set; }
    public Nullable<int> Autorizado { get; set; }
    public Nullable<decimal> CostoUSD { get; set; }
    public Nullable<int> FactorInd { get; set; }
    public Nullable<decimal> CostoTotalFactor { get; set; }
    public string NumFamilia { get; set; }
}
