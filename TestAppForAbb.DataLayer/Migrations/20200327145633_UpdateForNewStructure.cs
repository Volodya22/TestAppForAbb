using Microsoft.EntityFrameworkCore.Migrations;

namespace TestAppForAbb.DataLayer.Migrations
{
    public partial class UpdateForNewStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Measures_Motors_MotorId",
                table: "Measures");

            migrationBuilder.DropIndex(
                name: "IX_Measures_MotorId",
                table: "Measures");

            migrationBuilder.DropColumn(
                name: "Current",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Displacement",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "FuelConsumption",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "MaxPressure",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "MaxTorque",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Voltage",
                table: "Motors");

            migrationBuilder.DropColumn(
                name: "Current",
                table: "Measures");

            migrationBuilder.DropColumn(
                name: "MotorId",
                table: "Measures");

            migrationBuilder.DropColumn(
                name: "Pressure",
                table: "Measures");

            migrationBuilder.DropColumn(
                name: "Torque",
                table: "Measures");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Motors",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "CombustionMotors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorId = table.Column<int>(nullable: false),
                    FuelConsumption = table.Column<double>(nullable: false),
                    MaxTorque = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CombustionMotors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CombustionMotors_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ElectricMotors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorId = table.Column<int>(nullable: false),
                    Voltage = table.Column<double>(nullable: false),
                    Current = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricMotors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricMotors_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HydraulicMotors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotorId = table.Column<int>(nullable: false),
                    MaxPressure = table.Column<double>(nullable: false),
                    Displacement = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HydraulicMotors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HydraulicMotors_Motors_MotorId",
                        column: x => x.MotorId,
                        principalTable: "Motors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TorqueMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasureId = table.Column<int>(nullable: false),
                    CombustionMotorId = table.Column<int>(nullable: false),
                    Torque = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TorqueMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TorqueMeasures_CombustionMotors_CombustionMotorId",
                        column: x => x.CombustionMotorId,
                        principalTable: "CombustionMotors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TorqueMeasures_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CurrentMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasureId = table.Column<int>(nullable: false),
                    ElectricMotorId = table.Column<int>(nullable: false),
                    Current = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CurrentMeasures_ElectricMotors_ElectricMotorId",
                        column: x => x.ElectricMotorId,
                        principalTable: "ElectricMotors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentMeasures_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PressureMeasures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MeasureId = table.Column<int>(nullable: false),
                    HydraulicMotorId = table.Column<int>(nullable: false),
                    Pressure = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PressureMeasures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PressureMeasures_HydraulicMotors_HydraulicMotorId",
                        column: x => x.HydraulicMotorId,
                        principalTable: "HydraulicMotors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PressureMeasures_Measures_MeasureId",
                        column: x => x.MeasureId,
                        principalTable: "Measures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CombustionMotors_MotorId",
                table: "CombustionMotors",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentMeasures_ElectricMotorId",
                table: "CurrentMeasures",
                column: "ElectricMotorId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentMeasures_MeasureId",
                table: "CurrentMeasures",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricMotors_MotorId",
                table: "ElectricMotors",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_HydraulicMotors_MotorId",
                table: "HydraulicMotors",
                column: "MotorId");

            migrationBuilder.CreateIndex(
                name: "IX_PressureMeasures_HydraulicMotorId",
                table: "PressureMeasures",
                column: "HydraulicMotorId");

            migrationBuilder.CreateIndex(
                name: "IX_PressureMeasures_MeasureId",
                table: "PressureMeasures",
                column: "MeasureId");

            migrationBuilder.CreateIndex(
                name: "IX_TorqueMeasures_CombustionMotorId",
                table: "TorqueMeasures",
                column: "CombustionMotorId");

            migrationBuilder.CreateIndex(
                name: "IX_TorqueMeasures_MeasureId",
                table: "TorqueMeasures",
                column: "MeasureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentMeasures");

            migrationBuilder.DropTable(
                name: "PressureMeasures");

            migrationBuilder.DropTable(
                name: "TorqueMeasures");

            migrationBuilder.DropTable(
                name: "ElectricMotors");

            migrationBuilder.DropTable(
                name: "HydraulicMotors");

            migrationBuilder.DropTable(
                name: "CombustionMotors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Motors");

            migrationBuilder.AddColumn<double>(
                name: "Current",
                table: "Motors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Displacement",
                table: "Motors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "FuelConsumption",
                table: "Motors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxPressure",
                table: "Motors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxTorque",
                table: "Motors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Motors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Voltage",
                table: "Motors",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Current",
                table: "Measures",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotorId",
                table: "Measures",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                table: "Measures",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Torque",
                table: "Measures",
                type: "float",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Measures_MotorId",
                table: "Measures",
                column: "MotorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Measures_Motors_MotorId",
                table: "Measures",
                column: "MotorId",
                principalTable: "Motors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
