using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class ParametrosCorporativosVersion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissoesUsuario_Grupos_GrupoId",
                table: "PermissoesUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PermissoesUsuario_GrupoId",
                table: "PermissoesUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoId",
                table: "PermissoesUsuario",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "PermissaoUsuarioId",
                table: "Grupos",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "DepreciacaoMensal",
                table: "Grupos",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "DepreciacaoDiaria",
                table: "Grupos",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "CustoOperacionalMensal",
                table: "Grupos",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<decimal>(
                name: "CustoOperacionalDiario",
                table: "Grupos",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesUsuario_GrupoId",
                table: "PermissoesUsuario",
                column: "GrupoId",
                unique: true,
                filter: "[GrupoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PermissoesUsuario_Grupos_GrupoId",
                table: "PermissoesUsuario",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PermissoesUsuario_Grupos_GrupoId",
                table: "PermissoesUsuario");

            migrationBuilder.DropIndex(
                name: "IX_PermissoesUsuario_GrupoId",
                table: "PermissoesUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "GrupoId",
                table: "PermissoesUsuario",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PermissaoUsuarioId",
                table: "Grupos",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DepreciacaoMensal",
                table: "Grupos",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DepreciacaoDiaria",
                table: "Grupos",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CustoOperacionalMensal",
                table: "Grupos",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "CustoOperacionalDiario",
                table: "Grupos",
                nullable: false,
                oldClrType: typeof(decimal),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesUsuario_GrupoId",
                table: "PermissoesUsuario",
                column: "GrupoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PermissoesUsuario_Grupos_GrupoId",
                table: "PermissoesUsuario",
                column: "GrupoId",
                principalTable: "Grupos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
