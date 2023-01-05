using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class addonetoOneRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDay",
                table: "Tbl_Students");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Tbl_Students");

            migrationBuilder.DropColumn(
                name: "SchollNumber",
                table: "Tbl_Students");

            migrationBuilder.CreateTable(
                name: "StudentDetail",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tbl_StudentID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StudentDetail_Tbl_Students_Tbl_StudentID",
                        column: x => x.Tbl_StudentID,
                        principalTable: "Tbl_Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentDetail_Tbl_StudentID",
                table: "StudentDetail",
                column: "Tbl_StudentID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentDetail");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDay",
                table: "Tbl_Students",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Tbl_Students",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SchollNumber",
                table: "Tbl_Students",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
