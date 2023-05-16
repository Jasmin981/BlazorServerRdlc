﻿// <auto-generated />
using BlazorServerRdlc.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorServerRdlc.Migrations
{
    [DbContext(typeof(ReportDbContext))]
    [Migration("20230516083511_AddAttachmentsTable")]
    partial class AddAttachmentsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorServerRdlc.Data.Attachment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("BlazorServerRdlc.Data.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            LastName = "Nuhanović",
                            Name = "Jasmin"
                        },
                        new
                        {
                            Id = 2,
                            LastName = "Zejnilović",
                            Name = "Nedžad"
                        },
                        new
                        {
                            Id = 3,
                            LastName = "Baggio",
                            Name = "Roberto"
                        },
                        new
                        {
                            Id = 4,
                            LastName = "Riba",
                            Name = "Trend"
                        },
                        new
                        {
                            Id = 5,
                            LastName = "Galaxy",
                            Name = "Samsung"
                        });
                });

            modelBuilder.Entity("BlazorServerRdlc.Data.Attachment", b =>
                {
                    b.HasOne("BlazorServerRdlc.Data.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
