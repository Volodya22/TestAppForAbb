using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAppForAbb.DataLayer.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Motors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false),
                    MaxPower = table.Column<double>(nullable: false),
                    Voltage = table.Column<double>(nullable: true),
                    FuelConsumption = table.Column<double>(nullable: true),
                    Current = table.Column<double>(nullable: true),
                    MaxTorque = table.Column<double>(nullable: true),
                    MaxPressure = table.Column<double>(nullable: true),
                    Displacement = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Motors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Measures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Time = table.Column<DateTime>(nullable: false),
                    MotorId = table.Column<int>(nullable: false),
                    Current = table.Column<double>(nullable: true),
                    Torque = table.Column<double>(nullable: true),
                    Pressure = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Measures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Measures_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Measures_MotorId",
                table: "Measures",
                column: "MotorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Measures");

            migrationBuilder.DropTable(
                name: "Motors");
        }
    }
}
