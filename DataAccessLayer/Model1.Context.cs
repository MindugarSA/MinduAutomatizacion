﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_AUTOMATIZACIONEntities : DbContext
    {
        public DB_AUTOMATIZACIONEntities()
            : base("name=DB_AUTOMATIZACIONEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Familia> Familia { get; set; }
        public virtual DbSet<Propiedades> Propiedades { get; set; }
        public virtual DbSet<TipoItem> TipoItem { get; set; }
        public virtual DbSet<ReglasFamilia> ReglasFamilia { get; set; }
        public virtual DbSet<Unidades> Unidades { get; set; }
        public virtual DbSet<ItemCosto> ItemCosto { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Costos> Costos { get; set; }
        public virtual DbSet<ItemDetalle> ItemDetalle { get; set; }
        public virtual DbSet<Item> Item { get; set; }
    
        public virtual ObjectResult<SP_GetItemCostoID_Result> SP_GetItemCostoID(Nullable<int> id_Item)
        {
            var id_ItemParameter = id_Item.HasValue ?
                new ObjectParameter("id_Item", id_Item) :
                new ObjectParameter("id_Item", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetItemCostoID_Result>("SP_GetItemCostoID", id_ItemParameter);
        }
    
        public virtual ObjectResult<SP_VerifyUserPass_Result> SP_VerifyUserPass(string rut, string pass)
        {
            var rutParameter = rut != null ?
                new ObjectParameter("Rut", rut) :
                new ObjectParameter("Rut", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("Pass", pass) :
                new ObjectParameter("Pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_VerifyUserPass_Result>("SP_VerifyUserPass", rutParameter, passParameter);
        }
    
        public virtual int SP_ActualizarCostosItems(Nullable<int> idCosto)
        {
            var idCostoParameter = idCosto.HasValue ?
                new ObjectParameter("IdCosto", idCosto) :
                new ObjectParameter("IdCosto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ActualizarCostosItems", idCostoParameter);
        }
    
        public virtual ObjectResult<SP_GetItemDependeceID_Result> SP_GetItemDependeceID(Nullable<int> id_Item)
        {
            var id_ItemParameter = id_Item.HasValue ?
                new ObjectParameter("id_Item", id_Item) :
                new ObjectParameter("id_Item", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetItemDependeceID_Result>("SP_GetItemDependeceID", id_ItemParameter);
        }
    
        public virtual int SP_ListadoItemsCostosDetallado()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ListadoItemsCostosDetallado");
        }
    
        public virtual ObjectResult<SP_ListadoItemsCostosResumen_Result> SP_ListadoItemsCostosResumen()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoItemsCostosResumen_Result>("SP_ListadoItemsCostosResumen");
        }
    
        public virtual ObjectResult<SP_ListadoItemsResumen_Result> SP_ListadoItemsResumen()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoItemsResumen_Result>("SP_ListadoItemsResumen");
        }
    
        public virtual ObjectResult<SP_ListadoItemTipoCostoFactor_Result> SP_ListadoItemTipoCostoFactor(string tipoItem)
        {
            var tipoItemParameter = tipoItem != null ?
                new ObjectParameter("TipoItem", tipoItem) :
                new ObjectParameter("TipoItem", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoItemTipoCostoFactor_Result>("SP_ListadoItemTipoCostoFactor", tipoItemParameter);
        }
    
        public virtual ObjectResult<SP_ListadoItemTipoCostoFactorRES_Result> SP_ListadoItemTipoCostoFactorRES(string tipoItem)
        {
            var tipoItemParameter = tipoItem != null ?
                new ObjectParameter("TipoItem", tipoItem) :
                new ObjectParameter("TipoItem", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoItemTipoCostoFactorRES_Result>("SP_ListadoItemTipoCostoFactorRES", tipoItemParameter);
        }
    
        public virtual ObjectResult<SP_GetItemBusqueda_Result> SP_GetItemBusqueda(Nullable<int> id_Item)
        {
            var id_ItemParameter = id_Item.HasValue ?
                new ObjectParameter("id_Item", id_Item) :
                new ObjectParameter("id_Item", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetItemBusqueda_Result>("SP_GetItemBusqueda", id_ItemParameter);
        }
    
        public virtual int SP_ActualizarCostosItemsKitProduto(Nullable<int> idItemDet)
        {
            var idItemDetParameter = idItemDet.HasValue ?
                new ObjectParameter("IdItemDet", idItemDet) :
                new ObjectParameter("IdItemDet", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SP_ActualizarCostosItemsKitProduto", idItemDetParameter);
        }
    
        public virtual ObjectResult<SP_ListadoItemAutorizaciones_Result> SP_ListadoItemAutorizaciones()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_ListadoItemAutorizaciones_Result>("SP_ListadoItemAutorizaciones");
        }
    
        public virtual ObjectResult<SP_GetItemDetalleID_Result> SP_GetItemDetalleID(Nullable<int> id_Item)
        {
            var id_ItemParameter = id_Item.HasValue ?
                new ObjectParameter("id_Item", id_Item) :
                new ObjectParameter("id_Item", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_GetItemDetalleID_Result>("SP_GetItemDetalleID", id_ItemParameter);
        }
    }
}
