using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VegaApp.Migrations
{
    public partial class CorrrectModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_Makeid",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Models",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Makeid",
                table: "Models",
                newName: "MakeId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Models",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Models_Makeid",
                table: "Models",
                newName: "IX_Models_MakeId");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Makes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Makes",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Features",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Features",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "MakeId",
                table: "Models",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makes_MakeId",
                table: "Models");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Models",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "MakeId",
                table: "Models",
                newName: "Makeid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Models",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakeId",
                table: "Models",
                newName: "IX_Models_Makeid");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Makes",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Makes",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Features",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Features",
                newName: "id");

            migrationBuilder.AlterColumn<int>(
                name: "Makeid",
                table: "Models",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makes_Makeid",
                table: "Models",
                column: "Makeid",
                principalTable: "Makes",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
