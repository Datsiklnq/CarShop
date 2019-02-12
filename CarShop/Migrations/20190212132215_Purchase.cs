using Microsoft.EntityFrameworkCore.Migrations;

namespace CarShop.Migrations
{
    public partial class Purchase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Purchase",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CutomerId",
                table: "Purchase",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Purchase_CustomerId",
                table: "Purchase",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Purchase_Customer_CustomerId",
                table: "Purchase",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Purchase_Customer_CustomerId",
                table: "Purchase");

            migrationBuilder.DropIndex(
                name: "IX_Purchase_CustomerId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Purchase");

            migrationBuilder.DropColumn(
                name: "CutomerId",
                table: "Purchase");
        }
    }
}
