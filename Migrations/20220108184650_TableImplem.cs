using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace CourierBid.Migrations
{
    public partial class TableImplem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(name: "IX_Transports_TruckId", table: "Transports");
            migrationBuilder.CreateIndex(name: "IX_Transports_TruckId", table: "Transports", column: "TruckId", unique: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            

            

        }
    }
}
