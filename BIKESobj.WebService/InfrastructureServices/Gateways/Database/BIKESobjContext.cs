using Microsoft.EntityFrameworkCore;
using BIKESobj.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BIKESobj.InfrastructureServices.Gateways.Database
{
    public class BIKESobjContext : DbContext
    {
        public DbSet<bikeobj> BIKESobjs { get; set; }

        public BIKESobjContext(DbContextOptions options)
            : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillTestData(modelBuilder);
        }
        private void FillTestData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<bikeobj>().HasData(
                new
                {
                    Id = 1L,
                    Name = "А/д Боровское шоссе – Киевское шоссе – д. Ботаково",
                    PathType = "Велопешеходная дорожка с совмещенным движением,велосипедная полоса попутного движения,Двустороняя велополоса",
                    PathWeidth = "1.8 M",
                    PathLocation = "ТиНАО, посел. Первомайское, М-3 Украина- г.Троицк (М-1 Беларусь-Крекшино-Троицк)",
                    Telephone = "(495) 940-06-94",
                },
                new
                {
                    Id = 2L,
                    Name = "Андреевская набережная, Природный заказник «Воробьёвы горы»",
                    PathType = "велосипедная дорожка двухстороннего движения",
                    PathWeidth = "1.5 M",
                    PathLocation = "улица Крымский Вал, дом 9",
                    Telephone = "(495) 995-00-20",

                },
                new
                {
                    Id = 3L,
                    Name = "Арбатская площадь",
                    PathType = "Велопешеходная дорожка с совмещенным движением,велосипедная полоса попутного движения,велосипедная дорожка одностороннего движения",
                    PathWeidth = "1.2 M",
                    PathLocation = "Арбатская площадь",
                    Telephone = "(495) 940-06-94",

                },
                new
                {
                    Id = 4L,
                    Name = "Березовая аллея",
                    PathType = "велосипедная дорожка одностороннего движения",
                    PathWeidth = "1 M",
                    PathLocation = "от Олонецкой улицы дом 15Б до Березовой аллеи дом 7",
                    Telephone = "(495) 708-44-69",

                }
               
            );
        }
    }
}
