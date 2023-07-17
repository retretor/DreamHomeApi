using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DreamHomeApi.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Staff_Branches_BranchId",
                table: "Staff");

            migrationBuilder.DropIndex(
                name: "IX_Staff_BranchId",
                table: "Staff");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Staff_BranchId",
                table: "Staff",
                column: "BranchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Staff_Branches_BranchId",
                table: "Staff",
                column: "BranchId",
                principalTable: "Branches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
