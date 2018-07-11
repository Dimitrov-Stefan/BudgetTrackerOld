﻿// <auto-generated />
using BudgetTracker.Common;
using BudgetTracker.Common.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BudgetTracker.Common.Migrations
{
    [DbContext(typeof(BudgetTrackerDbContext))]
    [Migration("20171127162147_FixedFinancialOperationsTableName")]
    partial class FixedFinancialOperationsTableName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BudgetTracker.Common.Entities.FinancialItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.ToTable("FinancialItems");
                });

            modelBuilder.Entity("BudgetTracker.Common.Entities.FinancialOperation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Amount");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("Timestamp");

                    b.HasKey("Id");

                    b.ToTable("FinancialOperations");
                });
#pragma warning restore 612, 618
        }
    }
}
