//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sinav.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sinavdbEntities : DbContext
    {
        public sinavdbEntities()
            : base("name=sinavdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hakkimizda> Hakkimizda { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<ozellik> ozellik { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tarihce> tarihce { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<iletisim> iletisim { get; set; }
    }
}
