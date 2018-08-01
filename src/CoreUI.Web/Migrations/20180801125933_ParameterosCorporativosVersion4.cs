using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class ParameterosCorporativosVersion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IDs_Sistemas_CadastroLocalTable_LocalizacaoId",
                table: "IDs_Sistemas");

            migrationBuilder.AlterColumn<int>(
                name: "LocalizacaoId",
                table: "IDs_Sistemas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_IDs_Sistemas_CadastroLocalTable_LocalizacaoId",
                table: "IDs_Sistemas",
                column: "LocalizacaoId",
                principalTable: "CadastroLocalTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IDs_Sistemas_CadastroLocalTable_LocalizacaoId",
                table: "IDs_Sistemas");

            migrationBuilder.AlterColumn<int>(
                name: "LocalizacaoId",
                table: "IDs_Sistemas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_IDs_Sistemas_CadastroLocalTable_LocalizacaoId",
                table: "IDs_Sistemas",
                column: "LocalizacaoId",
                principalTable: "CadastroLocalTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
