using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Coordinator.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Nodes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5fe71db8-0c38-4bb9-b059-7c4d54ae923d"), "Stock.API" },
                    { new Guid("9ab31ef7-0779-4727-bd3e-9840ba7db9e3"), "Payment.API" },
                    { new Guid("c75cfe57-e0ec-4605-8aa7-b773318d7bc9"), "Order.API" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("5fe71db8-0c38-4bb9-b059-7c4d54ae923d"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("9ab31ef7-0779-4727-bd3e-9840ba7db9e3"));

            migrationBuilder.DeleteData(
                table: "Nodes",
                keyColumn: "Id",
                keyValue: new Guid("c75cfe57-e0ec-4605-8aa7-b773318d7bc9"));
        }
    }
}
