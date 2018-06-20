using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class Imagem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fabricantes_Empresas_EmpresaId",
                table: "Fabricantes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Fabricantes",
                table: "Fabricantes");

            migrationBuilder.RenameTable(
                name: "Fabricantes",
                newName: "ManufacturerTables");

            migrationBuilder.RenameColumn(
                name: "NomeFabricante",
                table: "ManufacturerTables",
                newName: "Manufacturer");

            migrationBuilder.RenameIndex(
                name: "IX_Fabricantes_EmpresaId",
                table: "ManufacturerTables",
                newName: "IX_ManufacturerTables_EmpresaId");

            migrationBuilder.AddColumn<byte[]>(
                name: "Imagem",
                table: "Paises",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ManufacturerTables",
                table: "ManufacturerTables",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerTables_Empresas_EmpresaId",
                table: "ManufacturerTables",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerTables_Empresas_EmpresaId",
                table: "ManufacturerTables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ManufacturerTables",
                table: "ManufacturerTables");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Paises");

            migrationBuilder.RenameTable(
                name: "ManufacturerTables",
                newName: "Fabricantes");

            migrationBuilder.RenameColumn(
                name: "Manufacturer",
                table: "Fabricantes",
                newName: "NomeFabricante");

            migrationBuilder.RenameIndex(
                name: "IX_ManufacturerTables_EmpresaId",
                table: "Fabricantes",
                newName: "IX_Fabricantes_EmpresaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Fabricantes",
                table: "Fabricantes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Fabricantes_Empresas_EmpresaId",
                table: "Fabricantes",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
