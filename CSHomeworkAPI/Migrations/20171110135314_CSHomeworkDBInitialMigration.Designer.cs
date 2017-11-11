﻿// <auto-generated />
using CSHomeworkAPI.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace CSHomeworkAPI.Migrations
{
    [DbContext(typeof(CSHomeworkContext))]
    [Migration("20171110135314_CSHomeworkDBInitialMigration")]
    partial class CSHomeworkDBInitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CSHomeworkAPI.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cols");

                    b.Property<bool>("CorrectAnswer")
                        .HasMaxLength(255);

                    b.Property<bool>("Explanation")
                        .HasMaxLength(255);

                    b.Property<int>("Max");

                    b.Property<int>("MaxLength");

                    b.Property<int>("Min");

                    b.Property<int>("MinLength");

                    b.Property<string>("Pattern")
                        .HasMaxLength(255);

                    b.Property<string>("PlaceHolder")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Rows");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("Id");

                    b.ToTable("Question");
                });
#pragma warning restore 612, 618
        }
    }
}
