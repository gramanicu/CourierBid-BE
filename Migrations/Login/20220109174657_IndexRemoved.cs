using Microsoft.EntityFrameworkCore.Migrations;

namespace CourierBid.Migrations.Login
{
    public partial class IndexRemoved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(name: "IX_Expeditions_UserId", table: "Expeditions");
            migrationBuilder.CreateIndex(name: "IX_Expeditions_UserId", table: "Expeditions", column: "UserId", unique: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
