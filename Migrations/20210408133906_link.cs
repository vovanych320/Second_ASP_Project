using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PodcastLink",
                table: "Podcasts",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "87f4a27b-c17d-424e-8213-47af44db9ca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3abfd13-94ef-4611-9000-92dc19f345ef", "AQAAAAEAACcQAAAAELAJ5yAjxu+hHSc5fECmb4t8OZr1gpMo9OzLM/xVqdQvTKwgGCNCUPDrUJnmfTXHSg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PodcastLink",
                table: "Podcasts");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "0de0a882-6aa0-416b-939c-5622fe4d64b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72011337-77d2-4585-ab4e-25e29a9fae7e", "AQAAAAEAACcQAAAAEOOAt6faLy9i3eCaDA/sr62l6k3QHhxq45P132dK3wKT6lqcWqYKpldnShCqfkDzDQ==" });
        }
    }
}
