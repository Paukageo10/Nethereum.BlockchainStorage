﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nethereum.BlockchainStore.EFCore.SqlServer;

namespace Nethereum.BlockchainStore.EFCore.SqlServer.Migrations
{
    [DbContext(typeof(SqlServerBlockchainDbContext_dbo))]
    partial class SqlServerBlockchainDbContext_dboModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.AddressTransaction", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(43);

                    b.Property<string>("BlockNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(67);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.HasKey("RowIndex");

                    b.HasIndex("Address");

                    b.HasIndex("Hash");

                    b.HasIndex("BlockNumber", "Hash", "Address")
                        .IsUnique();

                    b.ToTable("AddressTransactions");
                });

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.Block", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BlockNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Difficulty")
                        .HasMaxLength(100);

                    b.Property<string>("ExtraData");

                    b.Property<string>("GasLimit")
                        .HasMaxLength(100);

                    b.Property<string>("GasUsed")
                        .HasMaxLength(100);

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(67);

                    b.Property<string>("Miner")
                        .HasMaxLength(43);

                    b.Property<string>("Nonce")
                        .HasMaxLength(100);

                    b.Property<string>("ParentHash")
                        .IsRequired()
                        .HasMaxLength(67);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.Property<string>("Size")
                        .HasMaxLength(100);

                    b.Property<string>("Timestamp")
                        .HasMaxLength(100);

                    b.Property<string>("TotalDifficulty")
                        .HasMaxLength(100);

                    b.Property<long>("TransactionCount");

                    b.HasKey("RowIndex");

                    b.HasIndex("BlockNumber", "Hash")
                        .IsUnique();

                    b.ToTable("Blocks");
                });

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.BlockProgress", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LastBlockProcessed")
                        .IsRequired()
                        .HasMaxLength(43);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.HasKey("RowIndex");

                    b.HasIndex("LastBlockProcessed");

                    b.ToTable("BlockProgress");
                });

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.Contract", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ABI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Address")
                        .HasMaxLength(43);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Creator")
                        .HasMaxLength(43);

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.Property<string>("TransactionHash")
                        .HasMaxLength(67);

                    b.HasKey("RowIndex");

                    b.HasIndex("Address");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Contracts");
                });

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.Transaction", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressFrom")
                        .HasMaxLength(43);

                    b.Property<string>("AddressTo")
                        .HasMaxLength(43);

                    b.Property<string>("BlockHash")
                        .HasMaxLength(67);

                    b.Property<string>("BlockNumber")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("CumulativeGasUsed")
                        .HasMaxLength(100);

                    b.Property<string>("Error")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Failed");

                    b.Property<bool>("FailedCreateContract");

                    b.Property<string>("Gas")
                        .HasMaxLength(100);

                    b.Property<string>("GasPrice")
                        .HasMaxLength(100);

                    b.Property<string>("GasUsed")
                        .HasMaxLength(100);

                    b.Property<bool>("HasLog");

                    b.Property<bool>("HasVmStack");

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(67);

                    b.Property<string>("Input")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NewContractAddress")
                        .HasMaxLength(43);

                    b.Property<string>("Nonce")
                        .HasMaxLength(100);

                    b.Property<string>("ReceiptHash")
                        .HasMaxLength(67);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.Property<string>("TimeStamp")
                        .HasMaxLength(100);

                    b.Property<string>("TransactionIndex")
                        .HasMaxLength(100);

                    b.Property<string>("Value")
                        .HasMaxLength(100);

                    b.HasKey("RowIndex");

                    b.HasIndex("AddressFrom");

                    b.HasIndex("AddressTo");

                    b.HasIndex("Hash");

                    b.HasIndex("NewContractAddress");

                    b.HasIndex("BlockNumber", "Hash")
                        .IsUnique();

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.TransactionLog", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(43);

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EventHash")
                        .HasMaxLength(67);

                    b.Property<string>("IndexVal1")
                        .HasMaxLength(67);

                    b.Property<string>("IndexVal2")
                        .HasMaxLength(67);

                    b.Property<string>("IndexVal3")
                        .HasMaxLength(67);

                    b.Property<string>("LogIndex")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.Property<string>("TransactionHash")
                        .IsRequired()
                        .HasMaxLength(67);

                    b.HasKey("RowIndex");

                    b.HasIndex("Address");

                    b.HasIndex("EventHash");

                    b.HasIndex("IndexVal1");

                    b.HasIndex("IndexVal2");

                    b.HasIndex("IndexVal3");

                    b.HasIndex("TransactionHash", "LogIndex")
                        .IsUnique()
                        .HasFilter("[LogIndex] IS NOT NULL");

                    b.ToTable("TransactionLogs");
                });

            modelBuilder.Entity("Nethereum.BlockchainProcessing.Storage.Entities.TransactionVmStack", b =>
                {
                    b.Property<int>("RowIndex")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(43);

                    b.Property<DateTime?>("RowCreated");

                    b.Property<DateTime?>("RowUpdated");

                    b.Property<string>("StructLogs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TransactionHash")
                        .HasMaxLength(67);

                    b.HasKey("RowIndex");

                    b.HasIndex("Address");

                    b.HasIndex("TransactionHash");

                    b.ToTable("TransactionLogVmStacks");
                });
#pragma warning restore 612, 618
        }
    }
}
