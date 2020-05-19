﻿// <auto-generated />
using BIKESobj.InfrastructureServices.Gateways.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ManagementOrganizations.WebService.Migrations
{
    [DbContext(typeof(BIKESobjContext))]
    partial class BIKESobjContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("BIKESobj.DomainObjects.BIKESobj", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Location")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("PathType")
                        .HasColumnType("TEXT");

                    b.Property<string>("PathWeidth")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telephone")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("BIKESobjs");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Location = "ТиНАО, посел. Первомайское, М-3 Украина- г.Троицк (М-1 Беларусь-Крекшино-Троицк)",
                            Name = "А/д Боровское шоссе – Киевское шоссе – д. Ботаково",
                            PathType = "Велопешеходная дорожка с совмещенным движением, велосипедная полоса попутного движения, Двустороняя велополоса",
                            PathWeidth = "1.8",
                            Telephone = "(495) 940-06-94"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
