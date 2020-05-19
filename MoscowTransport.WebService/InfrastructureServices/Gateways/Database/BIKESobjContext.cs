using Microsoft.EntityFrameworkCore;
using BIKESobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.InfrastructureServices.Gateways.Database
{
    public class BIKESobjContext : DbContext
    {
        public DbSet<DomainObjects.BIKESobj> BIKESobjs { get; set; }


        public BIKESobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DomainObjects.BIKESobj>().HasData(
              new DomainObjects.BIKESobj()
              {
                  Id = 1L,
                  Name = "А/д Боровское шоссе – Киевское шоссе – д. Ботаково",
                  PathType = "Велопешеходная дорожка с совмещенным движением, велосипедная полоса попутного движения, Двустороняя велополоса",
                  PathWeidth = "1.8",
                  Location = "ТиНАО, посел. Первомайское, М-3 Украина- г.Троицк (М-1 Беларусь-Крекшино-Троицк)",
                  Telephone = "(495) 940-06-94"
              }
           );
        }      
    }
}
