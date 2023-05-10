﻿// <auto-generated />
using GoodHabits.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoodHabits.Database.Migrations
{
    [DbContext(typeof(GoodHabitsDbContext))]
    [Migration("20230425221802_MultiTenant")]
    partial class MultiTenant
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoodHabits.Database.Entities.Habit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Habits");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Description = "Become a francophone",
                            Name = "Learn French",
                            TenantName = "CloudSphere"
                        },
                        new
                        {
                            Id = 101,
                            Description = "Get really fit",
                            Name = "Run a marathon",
                            TenantName = "CloudSphere"
                        },
                        new
                        {
                            Id = 102,
                            Description = "Finish your book project",
                            Name = "Write every day",
                            TenantName = "CloudSphere"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
