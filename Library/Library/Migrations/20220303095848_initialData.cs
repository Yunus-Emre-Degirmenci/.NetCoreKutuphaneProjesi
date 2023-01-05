using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class initialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Authors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Authors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_BookTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_BookTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Students",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SchollNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Students", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Books",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PageCount = table.Column<int>(type: "int", nullable: false),
                    Tbl_AuthorID = table.Column<int>(type: "int", nullable: false),
                    Tbl_BookTypeID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Books", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tbl_Books_Tbl_Authors_Tbl_AuthorID",
                        column: x => x.Tbl_AuthorID,
                        principalTable: "Tbl_Authors",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Books_Tbl_BookTypes_Tbl_BookTypeID",
                        column: x => x.Tbl_BookTypeID,
                        principalTable: "Tbl_BookTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Operations",
                columns: table => new
                {
                    Tbl_StudentID = table.Column<int>(type: "int", nullable: false),
                    Tbl_BookID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Operations", x => new { x.Tbl_StudentID, x.Tbl_BookID });
                    table.ForeignKey(
                        name: "FK_Tbl_Operations_Tbl_Books_Tbl_BookID",
                        column: x => x.Tbl_BookID,
                        principalTable: "Tbl_Books",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tbl_Operations_Tbl_Students_Tbl_StudentID",
                        column: x => x.Tbl_StudentID,
                        principalTable: "Tbl_Students",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Books_Tbl_AuthorID",
                table: "Tbl_Books",
                column: "Tbl_AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Books_Tbl_BookTypeID",
                table: "Tbl_Books",
                column: "Tbl_BookTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Operations_Tbl_BookID",
                table: "Tbl_Operations",
                column: "Tbl_BookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Operations");

            migrationBuilder.DropTable(
                name: "Tbl_Books");

            migrationBuilder.DropTable(
                name: "Tbl_Students");

            migrationBuilder.DropTable(
                name: "Tbl_Authors");

            migrationBuilder.DropTable(
                name: "Tbl_BookTypes");
        }
    }
}
