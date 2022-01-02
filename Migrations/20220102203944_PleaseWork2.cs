using Microsoft.EntityFrameworkCore.Migrations;

namespace CourierBid.Migrations
{
    public partial class PleaseWork2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Transports_TransportId",
                table: "Trucks");

            migrationBuilder.RenameColumn(
                name: "TransportId",
                table: "Trucks",
                newName: "CourierId");

            migrationBuilder.RenameIndex(
                name: "IX_Trucks_TransportId",
                table: "Trucks",
                newName: "IX_Trucks_CourierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Users_CourierId",
                table: "Trucks",
                column: "CourierId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trucks_Users_CourierId",
                table: "Trucks");

            migrationBuilder.RenameColumn(
                name: "CourierId",
                table: "Trucks",
                newName: "TransportId");

            migrationBuilder.RenameIndex(
                name: "IX_Trucks_CourierId",
                table: "Trucks",
                newName: "IX_Trucks_TransportId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trucks_Transports_TransportId",
                table: "Trucks",
                column: "TransportId",
                principalTable: "Transports",
                principalColumn: "TransportId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
