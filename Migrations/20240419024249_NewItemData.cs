using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projectef.Migrations
{
    /// <inheritdoc />
    public partial class NewItemData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "CategoriaId", "Descripcion", "Nombre", "Peso" },
                values: new object[] { new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"), null, "Actividades laborales", 30 });

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"),
                column: "FechaCreacion",
                value: new DateTime(2024, 4, 18, 20, 42, 49, 6, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("155a6ffb-bb0c-4956-abb1-4e817000e532"),
                column: "FechaCreacion",
                value: new DateTime(2024, 4, 18, 20, 42, 49, 6, DateTimeKind.Local).AddTicks(5757));

            migrationBuilder.InsertData(
                table: "Tarea",
                columns: new[] { "TareaId", "CategoriaId", "Descripcion", "FechaCreacion", "PrioridadTarea", "Titulo" },
                values: new object[] { new Guid("155a6ffb-bb0c-4956-abb1-4e817000e533"), new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"), null, new DateTime(2024, 4, 18, 20, 42, 49, 6, DateTimeKind.Local).AddTicks(5759), 2, "Terminar el reporte mensual de ventas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("155a6ffb-bb0c-4956-abb1-4e817000e533"));

            migrationBuilder.DeleteData(
                table: "Categoria",
                keyColumn: "CategoriaId",
                keyValue: new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("155a6ffb-bb0c-4956-abb1-4e817000e531"),
                column: "FechaCreacion",
                value: new DateTime(2024, 4, 18, 20, 36, 11, 63, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Tarea",
                keyColumn: "TareaId",
                keyValue: new Guid("155a6ffb-bb0c-4956-abb1-4e817000e532"),
                column: "FechaCreacion",
                value: new DateTime(2024, 4, 18, 20, 36, 11, 63, DateTimeKind.Local).AddTicks(6291));
        }
    }
}
