using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class pods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    OrderTime = table.Column<DateTime>(nullable: false),
                    OrderNumber = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ShopCartItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PodcastItemId = table.Column<Guid>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    AdDuration = table.Column<string>(nullable: true),
                    AdMessage = table.Column<string>(nullable: true),
                    AdMonth = table.Column<string>(nullable: true),
                    ShopCartId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShopCartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShopCartItems_Podcasts_PodcastItemId",
                        column: x => x.PodcastItemId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrderId = table.Column<Guid>(nullable: false),
                    PodcastItemId = table.Column<Guid>(nullable: false),
                    AdDuration = table.Column<string>(nullable: true),
                    AdMessage = table.Column<string>(nullable: true),
                    AdMonth = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Podcasts_PodcastItemId",
                        column: x => x.PodcastItemId,
                        principalTable: "Podcasts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PodcastItemId",
                table: "OrderDetails",
                column: "PodcastItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_PodcastItemId",
                table: "ShopCartItems",
                column: "PodcastItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ShopCartItems");

            migrationBuilder.DropTable(
                name: "Orders");

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
    }
}
