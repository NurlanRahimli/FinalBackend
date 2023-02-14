using Microsoft.EntityFrameworkCore.Migrations;

namespace Boake_BackEnd.Migrations
{
    public partial class addbooktype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTypes_ProductTypes_ProductTypeId",
                table: "BookTypes");

            migrationBuilder.DropColumn(
                name: "BookTypeId",
                table: "BookTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "BookTypes",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTypes_ProductTypes_ProductTypeId",
                table: "BookTypes",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookTypes_ProductTypes_ProductTypeId",
                table: "BookTypes");

            migrationBuilder.AlterColumn<int>(
                name: "ProductTypeId",
                table: "BookTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "BookTypeId",
                table: "BookTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_BookTypes_ProductTypes_ProductTypeId",
                table: "BookTypes",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
