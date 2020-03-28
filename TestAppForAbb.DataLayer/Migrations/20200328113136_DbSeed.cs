using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace TestAppForAbb.DataLayer.Migrations
{
    public partial class DbSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Motors", new string[] { "Name", "MaxPower", "IsDeleted" }, new object[] { "Motor 1", 2, false });
            migrationBuilder.InsertData("Motors", new string[] { "Name", "MaxPower", "IsDeleted" }, new object[] { "Motor 2", 50, false });
            migrationBuilder.InsertData("Motors", new string[] { "Name", "MaxPower", "IsDeleted" }, new object[] { "Motor 3", 1, false });

            migrationBuilder.InsertData("ElectricMotors", new string[] { "MotorId", "Voltage", "Current" }, new object[] { 1, 230, 8.7 });
            migrationBuilder.InsertData("CombustionMotors", new string[] { "MotorId", "FuelConsumption", "MaxTorque" }, new object[] { 2, 4, 3000 });
            migrationBuilder.InsertData("HydraulicMotors", new string[] { "MotorId", "MaxPressure", "Displacement" }, new object[] { 3, 160, 16 });

            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 10, 0, 0) });
            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 10, 10, 0) });
            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 10, 20, 0) });
            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 10, 30, 0) });
            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 10, 40, 0) });
            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 10, 50, 0) });
            migrationBuilder.InsertData("Measures", new string[] { "Time" }, new object[] { new DateTime(2020, 3, 27, 11, 0, 0) });

            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 1, 1, 7 });
            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 2, 1, 7.9 });
            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 3, 1, 6.5 });
            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 4, 1, 7.3 });
            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 5, 1, 7.8 });
            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 6, 1, 6.9 });
            migrationBuilder.InsertData("CurrentMeasures", new string[] { "MeasureId", "ElectricMotorId", "Current" }, new object[] { 7, 1, 7 });

            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 1, 1, 2890 });
            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 2, 1, 3100 });
            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 3, 1, 2800 });
            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 4, 1, 2860 });
            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 5, 1, 2875 });
            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 6, 1, 2790 });
            migrationBuilder.InsertData("TorqueMeasures", new string[] { "MeasureId", "CombustionMotorId", "Torque" }, new object[] { 7, 1, 2900 });

            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 1, 1, 155 });
            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 2, 1, 158 });
            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 3, 1, 140 });
            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 4, 1, 145 });
            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 5, 1, 159 });
            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 6, 1, 160 });
            migrationBuilder.InsertData("PressureMeasures", new string[] { "MeasureId", "HydraulicMotorId", "Pressure" }, new object[] { 7, 1, 139 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
