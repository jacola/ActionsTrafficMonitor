﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.WorkflowJob", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime?>("CompletedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("completed_at");

                    b.Property<string>("Labels")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("labels");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("OrganizationName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("org_name");

                    b.Property<DateTime?>("QueuedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("queued_at");

                    b.Property<string>("RepositoryName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("repo_name");

                    b.Property<long>("RunId")
                        .HasColumnType("bigint")
                        .HasColumnName("run_id");

                    b.Property<string>("RunnerGroupName")
                        .HasColumnType("text")
                        .HasColumnName("runner_group_name");

                    b.Property<string>("RunnerName")
                        .HasColumnType("text")
                        .HasColumnName("runner_name");

                    b.Property<DateTime?>("StartedAt")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("started_at");

                    b.HasKey("Id");

                    b.ToTable("workflow_jobs");
                });
#pragma warning restore 612, 618
        }
    }
}
