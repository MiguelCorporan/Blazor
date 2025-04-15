using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace taskUser.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_AdminInfo_AdminInfoId",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK__AdminInf__3214EC079117457D",
                table: "AdminInfo");

            migrationBuilder.RenameTable(
                name: "AdminInfo",
                newName: "AdminInfos");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tareas",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tareas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AdminInfos",
                table: "AdminInfos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_AdminInfos_AdminInfoId",
                table: "Tareas",
                column: "AdminInfoId",
                principalTable: "AdminInfos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tareas_AdminInfos_AdminInfoId",
                table: "Tareas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AdminInfos",
                table: "AdminInfos");

            migrationBuilder.RenameTable(
                name: "AdminInfos",
                newName: "AdminInfo");

            migrationBuilder.AlterColumn<string>(
                name: "Titulo",
                table: "Tareas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaCreacion",
                table: "Tareas",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Descripcion",
                table: "Tareas",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK__AdminInf__3214EC079117457D",
                table: "AdminInfo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tareas_AdminInfo_AdminInfoId",
                table: "Tareas",
                column: "AdminInfoId",
                principalTable: "AdminInfo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
