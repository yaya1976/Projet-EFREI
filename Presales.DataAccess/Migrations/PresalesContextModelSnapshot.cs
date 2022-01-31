﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Presales.DataAccess.Context;

#nullable disable

namespace Presales.DataAccess.Migrations
{
    [DbContext(typeof(PresalesContext))]
    partial class PresalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Presales.Entity.AssetClass", b =>
                {
                    b.Property<long>("IdAssetClass")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("IdAssetClass"));

                    b.Property<string>("NameClass")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdAssetClass");

                    b.ToTable("ASSETCLASSES", "dbo");
                });

            modelBuilder.Entity("Presales.Entity.Client", b =>
                {
                    b.Property<long>("IdBdr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("IdBdr"));

                    b.Property<string>("ClientType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DateLastRFP")
                        .HasColumnType("date");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("NumberOfFunds")
                        .HasColumnType("bigint");

                    b.Property<string>("OverviewCustomerActivity")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("SgssProspectionUniverse")
                        .HasColumnType("boolean");

                    b.Property<float>("TotalGlobalFirmAumKeur")
                        .HasColumnType("real");

                    b.HasKey("IdBdr");

                    b.ToTable("CLIENTS", "dbo");
                });

            modelBuilder.Entity("Presales.Entity.ClientAssetClass", b =>
                {
                    b.Property<long>("IdAssetClass")
                        .HasColumnType("bigint");

                    b.Property<long>("IdBdr")
                        .HasColumnType("bigint");

                    b.HasKey("IdAssetClass", "IdBdr");

                    b.HasIndex("IdBdr");

                    b.ToTable("CLIENTS-ASSETCLASSES", "dbo");
                });

            modelBuilder.Entity("Presales.Entity.ClientLocalAum", b =>
                {
                    b.Property<long>("IdLocalAum")
                        .HasColumnType("bigint");

                    b.Property<bool>("AmountLocalAssetCustodiedByCometitores")
                        .HasColumnType("boolean");

                    b.Property<bool>("AmountTotalAssetCustodiedByCountry")
                        .HasColumnType("boolean");

                    b.Property<string>("CompetitoresCurrentCustodiensDepositariesFundAdministrators")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("IdBdr")
                        .HasColumnType("bigint");

                    b.Property<string>("IdCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TotalLocalFirmAumEur")
                        .HasColumnType("boolean");

                    b.HasKey("IdLocalAum");

                    b.ToTable("LOCAL_AUM", "dbo");
                });

            modelBuilder.Entity("Presales.Entity.ClientPriority", b =>
                {
                    b.Property<long>("IdPriority")
                        .HasColumnType("bigint");

                    b.Property<long>("IdBdr")
                        .HasColumnType("bigint");

                    b.HasKey("IdPriority", "IdBdr");

                    b.HasIndex("IdBdr");

                    b.ToTable("CLIENT_PRIORITIES", "dbo");
                });

            modelBuilder.Entity("Presales.Entity.ClientSgssService", b =>
                {
                    b.Property<long>("IdService")
                        .HasColumnType("bigint");

                    b.Property<string>("IdBdr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("SgssServiceIdBdr")
                        .HasColumnType("bigint");

                    b.HasKey("IdService");

                    b.HasIndex("SgssServiceIdBdr");

                    b.ToTable("CLIENT-SGSSSERVICIES", (string)null);
                });

            modelBuilder.Entity("Presales.Entity.Priority", b =>
                {
                    b.Property<long>("IdPriority")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("IdPriority"));

                    b.Property<string>("CustomerNeedDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameOfPriority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdPriority");

                    b.ToTable("PRIORITIES", (string)null);
                });

            modelBuilder.Entity("Presales.Entity.SgssService", b =>
                {
                    b.Property<long>("IdBdr")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("IdBdr"));

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("DepartementBanking")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("IdCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("IdService")
                        .HasColumnType("bigint");

                    b.Property<string>("ItSystem")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NameServie")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("Outsourced")
                        .HasColumnType("boolean");

                    b.Property<long?>("SgssServiceIdBdr")
                        .HasColumnType("bigint");

                    b.Property<string>("TypeOfService")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("IdBdr");

                    b.HasIndex("SgssServiceIdBdr");

                    b.ToTable("SGSS_SERVICES", (string)null);
                });

            modelBuilder.Entity("Presales.Entity.ClientAssetClass", b =>
                {
                    b.HasOne("Presales.Entity.AssetClass", "AssetClass")
                        .WithMany("ClientAssetClass")
                        .HasForeignKey("IdAssetClass")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Presales.Entity.Client", "Client")
                        .WithMany("ClientAssetClasses")
                        .HasForeignKey("IdBdr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetClass");

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Presales.Entity.ClientLocalAum", b =>
                {
                    b.HasOne("Presales.Entity.Client", "Client")
                        .WithMany("ClientLocalAums")
                        .HasForeignKey("IdLocalAum")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Presales.Entity.ClientPriority", b =>
                {
                    b.HasOne("Presales.Entity.Client", "Client")
                        .WithMany("ClientPriorities")
                        .HasForeignKey("IdBdr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Presales.Entity.Priority", "Priority")
                        .WithMany("ClientPriorities")
                        .HasForeignKey("IdPriority")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Priority");
                });

            modelBuilder.Entity("Presales.Entity.ClientSgssService", b =>
                {
                    b.HasOne("Presales.Entity.Client", "Client")
                        .WithMany("ClientSgssServices")
                        .HasForeignKey("IdService")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Presales.Entity.SgssService", "SgssService")
                        .WithMany()
                        .HasForeignKey("SgssServiceIdBdr")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("SgssService");
                });

            modelBuilder.Entity("Presales.Entity.SgssService", b =>
                {
                    b.HasOne("Presales.Entity.SgssService", null)
                        .WithMany("sgssServices")
                        .HasForeignKey("SgssServiceIdBdr");
                });

            modelBuilder.Entity("Presales.Entity.AssetClass", b =>
                {
                    b.Navigation("ClientAssetClass");
                });

            modelBuilder.Entity("Presales.Entity.Client", b =>
                {
                    b.Navigation("ClientAssetClasses");

                    b.Navigation("ClientLocalAums");

                    b.Navigation("ClientPriorities");

                    b.Navigation("ClientSgssServices");
                });

            modelBuilder.Entity("Presales.Entity.Priority", b =>
                {
                    b.Navigation("ClientPriorities");
                });

            modelBuilder.Entity("Presales.Entity.SgssService", b =>
                {
                    b.Navigation("sgssServices");
                });
#pragma warning restore 612, 618
        }
    }
}
