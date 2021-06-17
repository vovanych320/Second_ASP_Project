using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class shopcart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItems_Podcasts_PodcastItemId",
                table: "ShopCartItems");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_ShopCartItems_PodcastItemId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "AdDuration",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "AdMessage",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "AdMonth",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "PodcastItemId",
                table: "ShopCartItems");

            migrationBuilder.AlterColumn<string>(
                name: "ShopCartId",
                table: "ShopCartItems",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PodcastId",
                table: "ShopCartItems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PremierTime",
                table: "ShopCartItems",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_PodcastId",
                table: "ShopCartItems",
                column: "PodcastId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItems_Podcasts_PodcastId",
                table: "ShopCartItems",
                column: "PodcastId",
                principalTable: "Podcasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopCartItems_Podcasts_PodcastId",
                table: "ShopCartItems");

            migrationBuilder.DropIndex(
                name: "IX_ShopCartItems_PodcastId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "PodcastId",
                table: "ShopCartItems");

            migrationBuilder.DropColumn(
                name: "PremierTime",
                table: "ShopCartItems");

            migrationBuilder.AlterColumn<string>(
                name: "ShopCartId",
                table: "ShopCartItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "AdDuration",
                table: "ShopCartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdMessage",
                table: "ShopCartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdMonth",
                table: "ShopCartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PodcastItemId",
                table: "ShopCartItems",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderNumber = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AdDuration = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdMonth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PodcastItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
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
                value: "87f4a27b-c17d-424e-8213-47af44db9ca4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3abfd13-94ef-4611-9000-92dc19f345ef", "AQAAAAEAACcQAAAAELAJ5yAjxu+hHSc5fECmb4t8OZr1gpMo9OzLM/xVqdQvTKwgGCNCUPDrUJnmfTXHSg==" });

            migrationBuilder.CreateIndex(
                name: "IX_ShopCartItems_PodcastItemId",
                table: "ShopCartItems",
                column: "PodcastItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PodcastItemId",
                table: "OrderDetails",
                column: "PodcastItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopCartItems_Podcasts_PodcastItemId",
                table: "ShopCartItems",
                column: "PodcastItemId",
                principalTable: "Podcasts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
