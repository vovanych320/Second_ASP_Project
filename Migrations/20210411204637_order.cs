using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Surname = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    OrderTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AllOrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    PodcastId = table.Column<Guid>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllOrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllOrderDetails_Podcasts_PodcastId",
                        column: x => x.PodcastId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AllOrderDetails_OrderId",
                table: "AllOrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AllOrderDetails_PodcastId",
                table: "AllOrderDetails",
                column: "PodcastId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllOrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "ef73ab5d-f439-4a51-9254-ef7b184e8d71");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7911843b-94bf-4fb5-b5fa-32086e888dad", "AQAAAAEAACcQAAAAEOyWud3bJRuHnDiwRo9r7Cg5Y4Rat6VN60oCLbCIpORViiWj8pIvprv2sbLtFAIr2g==" });
        }
    }
}
