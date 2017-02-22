using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using FinalOrm;

namespace FinalOrm.Migrations
{
    [DbContext(typeof(Model))]
    [Migration("20170222085509_NiharikaTesting")]
    partial class NiharikaTesting
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FinalOrm.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<string>("URL");

                    b.HasKey("ProdId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FinalOrm.Updates", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("ProdId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("ProdId");

                    b.ToTable("Updates");
                });

            modelBuilder.Entity("FinalOrm.Updates", b =>
                {
                    b.HasOne("FinalOrm.Product", "Product")
                        .WithMany("Updates")
                        .HasForeignKey("ProdId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
