using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class PostgresInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "workflow_jobs",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    runid = table.Column<long>(name: "run_id", type: "bigint", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    orgname = table.Column<string>(name: "org_name", type: "text", nullable: false),
                    labels = table.Column<string>(type: "text", nullable: false),
                    reponame = table.Column<string>(name: "repo_name", type: "text", nullable: false),
                    runnername = table.Column<string>(name: "runner_name", type: "text", nullable: true),
                    runnergroupname = table.Column<string>(name: "runner_group_name", type: "text", nullable: true),
                    queuedat = table.Column<DateTime>(name: "queued_at", type: "timestamp with time zone", nullable: true),
                    startedat = table.Column<DateTime>(name: "started_at", type: "timestamp with time zone", nullable: true),
                    completedat = table.Column<DateTime>(name: "completed_at", type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workflow_jobs", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "workflow_jobs");
        }
    }
}
