﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SimpleTrader.EntityFramework;

namespace SimpleTrader.EntityFramework.Migrations
{
    [DbContext(typeof(SimpleTraderDbContext))]
    partial class SimpleTraderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SimpleTrader.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AcoountHolderId")
                        .HasColumnType("int");

                    b.Property<double>("Balance")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("AcoountHolderId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.AssetTransactions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateProcessed")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsPurchase")
                        .HasColumnType("bit");

                    b.Property<int>("Shares")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.ToTable("AssetTransactions");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DataJoined")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.Account", b =>
                {
                    b.HasOne("SimpleTrader.Domain.Models.User", "AcoountHolder")
                        .WithMany()
                        .HasForeignKey("AcoountHolderId");

                    b.Navigation("AcoountHolder");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.AssetTransactions", b =>
                {
                    b.HasOne("SimpleTrader.Domain.Models.Account", "Account")
                        .WithMany("AssetTransactions")
                        .HasForeignKey("AccountId");

                    b.OwnsOne("SimpleTrader.Domain.Models.Stock", "Stock", b1 =>
                        {
                            b1.Property<int>("AssetTransactionsId")
                                .HasColumnType("int");

                            b1.Property<double>("PricePerShare")
                                .HasColumnType("float");

                            b1.Property<string>("Symbol")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AssetTransactionsId");

                            b1.ToTable("Stocks");

                            b1.WithOwner()
                                .HasForeignKey("AssetTransactionsId");
                        });

                    b.Navigation("Account");

                    b.Navigation("Stock");
                });

            modelBuilder.Entity("SimpleTrader.Domain.Models.Account", b =>
                {
                    b.Navigation("AssetTransactions");
                });
#pragma warning restore 612, 618
        }
    }
}