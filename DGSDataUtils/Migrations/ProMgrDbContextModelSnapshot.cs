﻿// <auto-generated />
using System;
using DGSDataUtils.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DGSDataUtils.Migrations
{
    [DbContext(typeof(ProMgrDbContext))]
    partial class ProMgrDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoAgentDefault", b =>
                {
                    b.Property<int>("IdAgent")
                        .HasColumnType("int");

                    b.Property<int?>("IdRaceProfile")
                        .HasColumnType("int");

                    b.HasKey("IdAgent");

                    b.HasIndex(new[] { "IdRaceProfile" }, "IX_IBET_AgentDefaults_IdRaceProfile");

                    b.ToTable("IBET_AgentDefaults", (string)null);
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoBetType", b =>
                {
                    b.Property<int>("IdBetType")
                        .HasColumnType("int");

                    b.Property<string>("BetName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBetType");

                    b.ToTable("IBET_BetTypes", (string)null);
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoProfileMap", b =>
                {
                    b.Property<int>("IdProfileMap")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProfileMap"));

                    b.Property<int?>("IdPlayer")
                        .HasColumnType("int");

                    b.Property<int?>("IdRaceProfile")
                        .HasColumnType("int");

                    b.Property<int>("IdSportProfile")
                        .HasColumnType("int");

                    b.HasKey("IdProfileMap");

                    b.ToTable("IBET_ProfileMaps", (string)null);
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoRaceProfile", b =>
                {
                    b.Property<int>("IdRaceProfile")
                        .HasColumnType("int");

                    b.Property<decimal>("DefaultPerRaceMaxWin")
                        .HasColumnType("money");

                    b.Property<decimal>("GlobalMaxAmount")
                        .HasColumnType("money");

                    b.Property<int>("GlobalMaxTime")
                        .HasColumnType("int");

                    b.Property<int>("HorseGlobalMax")
                        .HasColumnType("int");

                    b.Property<int?>("IbetAgentDefaultIdAgent")
                        .HasColumnType("int");

                    b.Property<string>("ProfileName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdRaceProfile");

                    b.HasIndex("IbetAgentDefaultIdAgent");

                    b.ToTable("IBET_RaceProfiles", (string)null);
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoTrack", b =>
                {
                    b.Property<int>("IdTrack")
                        .HasColumnType("int");

                    b.Property<string>("TrackCode")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("TrackName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTrack");

                    b.ToTable("IBET_Track", (string)null);
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoTrackLimit", b =>
                {
                    b.Property<int>("IdTrack")
                        .HasColumnType("int");

                    b.Property<int>("IdRaceProfile")
                        .HasColumnType("int");

                    b.Property<int>("IdBetType")
                        .HasColumnType("int");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<decimal>("MaxBet")
                        .HasColumnType("money");

                    b.Property<decimal>("MaxPayoutOdds")
                        .HasColumnType("money");

                    b.Property<decimal>("MinBet")
                        .HasColumnType("money");

                    b.Property<decimal>("PerBetMaxWin")
                        .HasColumnType("money");

                    b.Property<decimal>("PerRaceMaxWin")
                        .HasColumnType("money");

                    b.HasKey("IdTrack", "IdRaceProfile", "IdBetType");

                    b.HasIndex("IdBetType");

                    b.HasIndex("IdRaceProfile");

                    b.HasIndex("IdTrack");

                    b.ToTable("IBET_TrackLimits", (string)null);
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.TrackLimitPercentages", b =>
                {
                    b.Property<int>("IdBetType")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValuePercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("ValueType")
                        .HasColumnType("int");

                    b.ToTable("TrackLimitPercentages", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoRaceProfile", b =>
                {
                    b.HasOne("DGSDataUtils.Entities.ProMgrEntities.DtoAgentDefault", "IbetAgentDefault")
                        .WithMany()
                        .HasForeignKey("IbetAgentDefaultIdAgent");

                    b.Navigation("IbetAgentDefault");
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoTrackLimit", b =>
                {
                    b.HasOne("DGSDataUtils.Entities.ProMgrEntities.DtoBetType", "IdBetTypeNavigation")
                        .WithMany()
                        .HasForeignKey("IdBetType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DGSDataUtils.Entities.ProMgrEntities.DtoRaceProfile", "IdRaceProfileNavigation")
                        .WithMany()
                        .HasForeignKey("IdRaceProfile")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DGSDataUtils.Entities.ProMgrEntities.DtoTrack", "IdTrackNavigation")
                        .WithOne("IbetTrackLimit")
                        .HasForeignKey("DGSDataUtils.Entities.ProMgrEntities.DtoTrackLimit", "IdTrack")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IdBetTypeNavigation");

                    b.Navigation("IdRaceProfileNavigation");

                    b.Navigation("IdTrackNavigation");
                });

            modelBuilder.Entity("DGSDataUtils.Entities.ProMgrEntities.DtoTrack", b =>
                {
                    b.Navigation("IbetTrackLimit");
                });
#pragma warning restore 612, 618
        }
    }
}
