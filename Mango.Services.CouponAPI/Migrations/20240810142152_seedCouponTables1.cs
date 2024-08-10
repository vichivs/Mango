using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.CouponAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedCouponTables1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(2024, 8, 10, 14, 21, 51, 523, DateTimeKind.Utc).AddTicks(2988));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(2024, 8, 10, 14, 21, 51, 523, DateTimeKind.Utc).AddTicks(3079));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 1,
                column: "LastUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Coupons",
                keyColumn: "CouponId",
                keyValue: 2,
                column: "LastUpdated",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
