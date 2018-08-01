using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class ParametrosCorporativosVersion3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NomePermissao",
                table: "PermissoesUsuario");

            migrationBuilder.AlterColumn<float>(
                name: "DuracaoExpediente",
                table: "PermissoesUsuario",
                nullable: true,
                oldClrType: typeof(float));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "DuracaoExpediente",
                table: "PermissoesUsuario",
                nullable: false,
                oldClrType: typeof(float),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomePermissao",
                table: "PermissoesUsuario",
                nullable: true);
        }
    }
}
