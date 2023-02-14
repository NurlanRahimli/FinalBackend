using Microsoft.EntityFrameworkCore.Migrations;

namespace Boake_BackEnd.Migrations
{
    public partial class ordermessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Order",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Order");
        }
    }
}
