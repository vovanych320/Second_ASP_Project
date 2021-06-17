using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class date : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PodcastPremierDate",
                table: "Podcasts",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "f37999e3-dcb4-4488-a9c1-97bb0f33c9da");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fffda6c1-2ec6-4f36-9b9d-b6ae6b26f68a", "AQAAAAEAACcQAAAAEMH+R0cEceOP+aQ9jbljHB5TV6T5s5qIMbaXPeMRKy7MgtcsJsTeGM1z3A8K/NSvPg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "PodcastPremierDate",
                table: "Podcasts",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "007706eb-0806-4328-9361-daa1e6c855a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cddb16e-e438-4b10-a99d-6f2ee859854d", "AQAAAAEAACcQAAAAECqw6uVomyhT+UzunfvHgXdn47Xe/kjegLHyCwmVYmO3/TAMLQfXR4jFxzcG2LBKIw==" });
        }
    }
}
