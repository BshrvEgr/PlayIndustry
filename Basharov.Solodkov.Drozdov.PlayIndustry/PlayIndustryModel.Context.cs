﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Basharov.Solodkov.Drozdov.PlayIndustry
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlayIndustryEntities : DbContext
    {
        private static PlayIndustryEntities _connect;


        public PlayIndustryEntities()
            : base("name=PlayIndustryEntities")
        {
        }

        public static PlayIndustryEntities GetConnect()
        {
            if (_connect == null)
                _connect = new PlayIndustryEntities();

            return _connect;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Computer> Computer { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<PlayBuilds> PlayBuilds { get; set; }
        public virtual DbSet<PlayRoom> PlayRoom { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
