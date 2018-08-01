using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class ParametrosEquipamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EquipmentTypeTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaEquipamentosId = table.Column<int>(nullable: false),
                    Descricao_Tecnica = table.Column<string>(maxLength: 255, nullable: false),
                    FabricanteId = table.Column<int>(nullable: false),
                    ImagemAtivo = table.Column<string>(nullable: true),
                    Modelo = table.Column<string>(maxLength: 600, nullable: false),
                    Part_Number = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EquipmentTypeTables", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EquipmentTypeTables_Categoria_EquipamentosSet_CategoriaEquipamentosId",
                        column: x => x.CategoriaEquipamentosId,
                        principalTable: "Categoria_EquipamentosSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EquipmentTypeTables_ManufacturerTables_FabricanteId",
                        column: x => x.FabricanteId,
                        principalTable: "ManufacturerTables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GPSIDEquipamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ESN = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPSIDEquipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TAGID_EquipmentTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TAGID_Equipment = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAGID_EquipmentTables", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentTypeTables_CategoriaEquipamentosId",
                table: "EquipmentTypeTables",
                column: "CategoriaEquipamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_EquipmentTypeTables_FabricanteId",
                table: "EquipmentTypeTables",
                column: "FabricanteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EquipmentTypeTables");

            migrationBuilder.DropTable(
                name: "GPSIDEquipamentos");

            migrationBuilder.DropTable(
                name: "TAGID_EquipmentTables");
        }
    }
}
