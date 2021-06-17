using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class ssssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "AllOrderDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "AllOrderDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Period",
                table: "AllOrderDetails",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "fd3502a1-cc04-4598-882c-1579e08a7ec8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ccb5497b-39eb-4e7f-a6f2-f3c0abfb4603", "AQAAAAEAACcQAAAAEPxRTQpMvJkcw4VcUAD/x3HdwiI7eOzacZQueP5cWVxottAfsN2EuU2ogNFQYoOMdQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "AllOrderDetails");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "AllOrderDetails");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "AllOrderDetails");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "96bb1779-7543-4719-ba63-eda9a58a4a9b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8948cf0f-b1fc-47d6-b8c3-dbc0e98363ed", "AQAAAAEAACcQAAAAEGl8cuYNldO4jl7d48xJ7Ek8QKS54MPEdwmi6vQsJiWDz21kayiXU7OuQDR+5SMJog==" });
        }
    }
}
