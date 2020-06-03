using Microsoft.EntityFrameworkCore;
using BIKESobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using BIKESobj.ApplicationServices.Synchronization;

namespace BIKESobj.InfrastructureServices.Gateways.Database
{
    public class BIKESobjContext : DbContext
    {
        public DbSet<bikesobj> BIKESobjs { get; set; }

        public BIKESobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var v = new UseCaseBIKESobj();

            modelBuilder.Entity<bikesobj>().HasData(v.bikesobjs);
        }
        
        
    }
}
