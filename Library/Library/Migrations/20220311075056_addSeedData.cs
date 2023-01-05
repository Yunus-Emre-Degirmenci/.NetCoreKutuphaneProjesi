using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Tbl_Students",
                columns: new[] { "ID", "CreatedDate", "FirstName", "Gender", "LastName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(2452), "Yunus", 1, "Değirmenci", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(3514), "Serhat", 1, "Ünver", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(3521), "Gözde", 2, "Sağlam", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(3522), "Özlem", 2, "Yılmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 3, 11, 10, 50, 55, 803, DateTimeKind.Local).AddTicks(6710), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$jyrI60Z.HgbUtxW7/FHGYuLWUslnZRKF4AnpZek6j27EjHbjcEi9u", 1, 1, "administrator" },
                    { 2, new DateTime(2022, 3, 11, 10, 50, 55, 804, DateTimeKind.Local).AddTicks(9216), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$QMuCP13XCnJyAy8nIlL31.qYKkmStHrUoVYMz2.VuRol2Z0dPkcpi", 2, 1, "yunus" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchollNumber", "Status", "Tbl_StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1996, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(4157), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "100", 1, 1 },
                    { 2, new DateTime(1999, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(5202), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "101", 1, 2 },
                    { 3, new DateTime(1995, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(5210), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "102", 1, 3 },
                    { 4, new DateTime(1994, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 11, 10, 50, 55, 806, DateTimeKind.Local).AddTicks(5223), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "103", 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tbl_Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tbl_Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tbl_Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tbl_Students",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
