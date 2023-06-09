﻿// <auto-generated />
using CapenexisLeaners2023.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CapenexisLeaners2023.Migrations
{
    [DbContext(typeof(CapenexisLeaners2023Context))]
    partial class CapenexisLeaners2023ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CapenexisLeaners2023.Models.Courses", b =>
                {
                    b.Property<int>("CoursesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoursesId"));

                    b.Property<string>("CourseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FacillitatorId")
                        .HasColumnType("int");

                    b.HasKey("CoursesId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("CapenexisLeaners2023.Models.Facilitators", b =>
                {
                    b.Property<int>("FacilitatorsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilitatorsId"));

                    b.Property<string>("FacilitatorsName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FacilitatorsSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilitatorsId");

                    b.ToTable("Facilitators");
                });

            modelBuilder.Entity("CapenexisLeaners2023.Models.Learners", b =>
                {
                    b.Property<long>("LearnersId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("LearnersId"));

                    b.Property<long>("LearnersIdentityNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("LearnersName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnersSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LearnersId");

                    b.ToTable("Learners");
                });
#pragma warning restore 612, 618
        }
    }
}
