using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhienDentistry.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class addShowHome : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "showHome",
                table: "Newss",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9dfacf34-c838-4949-80d2-662deb91268d", "AQAAAAIAAYagAAAAEKEW+o/gZCX94KJvUF6sEWJhCWClOt3VQFhn4sLNyvO/GkzHRSubdV7QFvzAhr1Ueg==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 10, 51, 28, 640, DateTimeKind.Local).AddTicks(2097));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 10, 51, 28, 661, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "showHome" },
                values: new object[] { new DateTime(2024, 11, 27, 10, 51, 28, 661, DateTimeKind.Local).AddTicks(2478), false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "showHome",
                table: "Newss");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b810eb5b-61d7-4c02-8b9b-64719542007c", "AQAAAAIAAYagAAAAENNTMxz2gfeaDSAlbRl+u9nn09U7UJ95ZsAouEGhZQoft/fx1IF4XMsVfZHBFUkgNw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 26, 15, 21, 8, 608, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 26, 15, 21, 8, 609, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 26, 15, 21, 8, 609, DateTimeKind.Local).AddTicks(3284));
        }
    }
}
