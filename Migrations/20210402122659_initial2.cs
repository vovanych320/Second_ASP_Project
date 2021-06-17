using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Podcast.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Podcasts",
                keyColumn: "Id",
                keyValue: new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"));

            migrationBuilder.DeleteData(
                table: "Podcasts",
                keyColumn: "Id",
                keyValue: new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                column: "ConcurrencyStamp",
                value: "2038e0ec-3b3d-45e5-8f7c-b29a8451a2b8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e46c4f08-8bc8-4f01-bb56-213fb114db1d", "AQAAAAEAACcQAAAAENMMfA2m+TnYcwdMA5CUIbDpUK4G/nbi+4S+Ym4yAWyYA6DtJx53/jQRJSlyoQ5oZQ==" });

            migrationBuilder.InsertData(
                table: "Podcasts",
                columns: new[] { "Id", "PathToPhoto", "PodcasrListenedAmount", "PodcastAudience", "PodcastAuthor", "PodcastClients", "PodcastDescription", "PodcastDuration", "PodcastName", "PodcastPremierDate", "PodcastPrice", "PodcastTopic" },
                values: new object[,]
                {
                    { new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"), "~/img/IT_POdcast.png", "120000", "Люди,зацікавлені у вступі в IT галузь", "UCodeAccademy", "Samsung, Apple, Citrus", "Курси по програмуванню для новачків від новачка і до професіонала", "300 секунд", "Курси IT", new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2999.9899999999998, "IT" },
                    { new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"), "~/img/IT_POdcast.png", "120000", "Люди,зацікавлені у вступі в IT галузь", "UCodeAccademy", "Samsung, Apple, Citrus", "Курси по програмуванню для новачків від новачка і до професіонала", "300 секунд", "Курси IT", new DateTime(2021, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2999.9899999999998, "IT" }
                });
        }
    }
}
