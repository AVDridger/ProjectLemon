﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectLemon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class lemonDbEntities : DbContext
    {
        public lemonDbEntities()
            : base("name=lemonDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<auth> auth { get; set; }
        public virtual DbSet<c_request> c_request { get; set; }
        public virtual DbSet<fio> fio { get; set; }
        public virtual DbSet<person> person { get; set; }
    }
}
