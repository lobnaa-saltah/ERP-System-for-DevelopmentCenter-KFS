using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyERP.Web.Migrations
{
    /// <inheritdoc />
    public partial class seedGovs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Governorates",
                columns: new[] { "Id", "Code", "CreatedAt", "DeletedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 100, "047", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "كفر الشيخ", null },
                    { 101, "02", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الجيزة", null },
                    { 102, "03", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الإسكندرية", null },
                    { 103, "050", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الدقهلية", null },
                    { 104, "065", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "البحر الأحمر", null },
                    { 105, "045", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "البحيرة", null },
                    { 106, "084", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الفيوم", null },
                    { 107, "040", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الغربية", null },
                    { 108, "064", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الإسماعيلية", null },
                    { 109, "048", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "المنوفية", null },
                    { 110, "086", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "المنيا", null },
                    { 111, "013", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "القليوبية", null },
                    { 112, "092", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الوادي الجديد", null },
                    { 113, "062", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "السويس", null },
                    { 114, "097", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "اسوان", null },
                    { 115, "088", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "اسيوط", null },
                    { 116, "082", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "بني سويف", null },
                    { 117, "066", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "بورسعيد", null },
                    { 118, "057", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "دمياط", null },
                    { 119, "055", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الشرقية", null },
                    { 120, "069", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "جنوب سيناء", null },
                    { 121, "02", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "القاهرة", null },
                    { 122, "046", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "مطروح", null },
                    { 123, "095", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "الأقصر", null },
                    { 124, "096", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "قنا", null },
                    { 125, "068", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "شمال سيناء", null },
                    { 126, "093", new DateTime(2025, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), null, "سوهاج", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Governorates",
                keyColumn: "Id",
                keyValue: 126);
        }
    }
}
