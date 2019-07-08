﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sandbox_EFCore;

namespace Sandbox_EFCore.Migrations
{
    [DbContext(typeof(EFModel))]
    partial class EFModelModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dbo")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sandbox_EFCore.PressRelease", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PressReleaseDetail_Id");

                    b.HasKey("Id");

                    b.HasIndex("PressReleaseDetail_Id");

                    b.ToTable("PressReleases");
                });

            modelBuilder.Entity("Sandbox_EFCore.PressReleaseDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PressRelease_Id");

                    b.HasKey("Id");

                    b.HasIndex("PressRelease_Id");

                    b.ToTable("PressReleaseDetails");
                });

            modelBuilder.Entity("Sandbox_EFCore.PressRelease", b =>
                {
                    b.HasOne("Sandbox_EFCore.PressReleaseDetail", "PressReleaseDetail")
                        .WithMany("PressReleases")
                        .HasForeignKey("PressReleaseDetail_Id");
                });

            modelBuilder.Entity("Sandbox_EFCore.PressReleaseDetail", b =>
                {
                    b.HasOne("Sandbox_EFCore.PressRelease", "PressRelease")
                        .WithMany("PressReleaseDetailHistory")
                        .HasForeignKey("PressRelease_Id");
                });
#pragma warning restore 612, 618
        }
    }
}