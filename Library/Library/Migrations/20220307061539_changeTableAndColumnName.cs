using Microsoft.EntityFrameworkCore.Migrations;

namespace Library.Migrations
{
    public partial class changeTableAndColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Books_Tbl_Authors_Tbl_AuthorID",
                table: "Tbl_Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Operations_Tbl_Books_Tbl_BookID",
                table: "Tbl_Operations");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Operations_Tbl_Students_Tbl_StudentID",
                table: "Tbl_Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Operations",
                table: "Tbl_Operations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Authors",
                table: "Tbl_Authors");

            migrationBuilder.RenameTable(
                name: "Tbl_Operations",
                newName: "Operasyon");

            migrationBuilder.RenameTable(
                name: "Tbl_Authors",
                newName: "Yazarlar");

            migrationBuilder.RenameIndex(
                name: "IX_Tbl_Operations_Tbl_BookID",
                table: "Operasyon",
                newName: "IX_Operasyon_Tbl_BookID");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Yazarlar",
                newName: "Soyisim");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Yazarlar",
                newName: "Isim");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operasyon",
                table: "Operasyon",
                columns: new[] { "Tbl_StudentID", "Tbl_BookID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Operasyon_Tbl_Books_Tbl_BookID",
                table: "Operasyon",
                column: "Tbl_BookID",
                principalTable: "Tbl_Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Operasyon_Tbl_Students_Tbl_StudentID",
                table: "Operasyon",
                column: "Tbl_StudentID",
                principalTable: "Tbl_Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Books_Yazarlar_Tbl_AuthorID",
                table: "Tbl_Books",
                column: "Tbl_AuthorID",
                principalTable: "Yazarlar",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Operasyon_Tbl_Books_Tbl_BookID",
                table: "Operasyon");

            migrationBuilder.DropForeignKey(
                name: "FK_Operasyon_Tbl_Students_Tbl_StudentID",
                table: "Operasyon");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Books_Yazarlar_Tbl_AuthorID",
                table: "Tbl_Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Yazarlar",
                table: "Yazarlar");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operasyon",
                table: "Operasyon");

            migrationBuilder.RenameTable(
                name: "Yazarlar",
                newName: "Tbl_Authors");

            migrationBuilder.RenameTable(
                name: "Operasyon",
                newName: "Tbl_Operations");

            migrationBuilder.RenameColumn(
                name: "Soyisim",
                table: "Tbl_Authors",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Isim",
                table: "Tbl_Authors",
                newName: "FirstName");

            migrationBuilder.RenameIndex(
                name: "IX_Operasyon_Tbl_BookID",
                table: "Tbl_Operations",
                newName: "IX_Tbl_Operations_Tbl_BookID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Authors",
                table: "Tbl_Authors",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Operations",
                table: "Tbl_Operations",
                columns: new[] { "Tbl_StudentID", "Tbl_BookID" });

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Books_Tbl_Authors_Tbl_AuthorID",
                table: "Tbl_Books",
                column: "Tbl_AuthorID",
                principalTable: "Tbl_Authors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Operations_Tbl_Books_Tbl_BookID",
                table: "Tbl_Operations",
                column: "Tbl_BookID",
                principalTable: "Tbl_Books",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Operations_Tbl_Students_Tbl_StudentID",
                table: "Tbl_Operations",
                column: "Tbl_StudentID",
                principalTable: "Tbl_Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
