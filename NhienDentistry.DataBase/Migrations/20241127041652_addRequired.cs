using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NhienDentistry.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class addRequired : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a64a710b-2085-43fc-a9bb-a9f041fdcd84", "AQAAAAIAAYagAAAAEF75ZJZJWN61k4I3PfV9TBL/jeiNRRZp5+g7cv9Q/LKrDsDS0GiQCSZ0P2r4X4goJw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 11, 16, 52, 584, DateTimeKind.Local).AddTicks(6709));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 11, 16, 52, 584, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Newss",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 11, 16, 52, 584, DateTimeKind.Local).AddTicks(6802));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                column: "CreatedDate",
                value: new DateTime(2024, 11, 27, 10, 51, 28, 661, DateTimeKind.Local).AddTicks(2478));
        }
    }
}
