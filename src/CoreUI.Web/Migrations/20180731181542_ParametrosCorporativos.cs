using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class ParametrosCorporativos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerTables_Empresas_EmpresaId",
                table: "ManufacturerTables");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "ManufacturerTables",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CRT",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CNAE",
                table: "Empresas",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateTable(
                name: "Categoria_EquipamentosSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Categoria = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria_EquipamentosSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContractNameTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assigned = table.Column<string>(maxLength: 255, nullable: false),
                    Cod_Cliente = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContractNameTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Grupos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustoOperacionalDiario = table.Column<decimal>(nullable: false),
                    CustoOperacionalMensal = table.Column<decimal>(nullable: false),
                    DepreciacaoDiaria = table.Column<decimal>(nullable: false),
                    DepreciacaoMensal = table.Column<decimal>(nullable: false),
                    PermissaoUsuarioId = table.Column<int>(nullable: false),
                    Titulo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grupos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomePermissao = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrderTables",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PO = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseOrderTables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RequisiçãoTableSet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RQ = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequisiçãoTableSet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PermissoesHabilitacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaEquipamentosId = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    FlagTodasCategorias = table.Column<bool>(nullable: false),
                    FlagTodasEmpresasEquipamentos = table.Column<bool>(nullable: false),
                    FlagTodosGrupos = table.Column<bool>(nullable: false),
                    FlagTodosProprietarios = table.Column<bool>(nullable: false),
                    GrupoId = table.Column<int>(nullable: false),
                    PermissaoId = table.Column<int>(nullable: false),
                    SetorProprietarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissoesHabilitacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissoesHabilitacao_Categoria_EquipamentosSet_CategoriaEquipamentosId",
                        column: x => x.CategoriaEquipamentosId,
                        principalTable: "Categoria_EquipamentosSet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesHabilitacao_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesHabilitacao_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesHabilitacao_Permissoes_PermissaoId",
                        column: x => x.PermissaoId,
                        principalTable: "Permissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesHabilitacao_SetorProprietarios_SetorProprietarioId",
                        column: x => x.SetorProprietarioId,
                        principalTable: "SetorProprietarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PermissoesUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DuracaoExpediente = table.Column<float>(nullable: false),
                    EmailUsuario = table.Column<string>(nullable: true),
                    GrupoId = table.Column<int>(nullable: false),
                    NomeCompleto = table.Column<string>(nullable: true),
                    NomePermissao = table.Column<string>(nullable: true),
                    PermissaoId = table.Column<int>(nullable: false),
                    TAGID = table.Column<string>(nullable: true),
                    Usuario = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissoesUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PermissoesUsuario_Grupos_GrupoId",
                        column: x => x.GrupoId,
                        principalTable: "Grupos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PermissoesUsuario_Permissoes_PermissaoId",
                        column: x => x.PermissaoId,
                        principalTable: "Permissoes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesHabilitacao_CategoriaEquipamentosId",
                table: "PermissoesHabilitacao",
                column: "CategoriaEquipamentosId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesHabilitacao_EmpresaId",
                table: "PermissoesHabilitacao",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesHabilitacao_GrupoId",
                table: "PermissoesHabilitacao",
                column: "GrupoId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesHabilitacao_PermissaoId",
                table: "PermissoesHabilitacao",
                column: "PermissaoId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesHabilitacao_SetorProprietarioId",
                table: "PermissoesHabilitacao",
                column: "SetorProprietarioId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesUsuario_GrupoId",
                table: "PermissoesUsuario",
                column: "GrupoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PermissoesUsuario_PermissaoId",
                table: "PermissoesUsuario",
                column: "PermissaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerTables_Empresas_EmpresaId",
                table: "ManufacturerTables",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ManufacturerTables_Empresas_EmpresaId",
                table: "ManufacturerTables");

            migrationBuilder.DropTable(
                name: "ContractNameTables");

            migrationBuilder.DropTable(
                name: "PermissoesHabilitacao");

            migrationBuilder.DropTable(
                name: "PermissoesUsuario");

            migrationBuilder.DropTable(
                name: "PurchaseOrderTables");

            migrationBuilder.DropTable(
                name: "RequisiçãoTableSet");

            migrationBuilder.DropTable(
                name: "Categoria_EquipamentosSet");

            migrationBuilder.DropTable(
                name: "Grupos");

            migrationBuilder.DropTable(
                name: "Permissoes");

            migrationBuilder.AlterColumn<int>(
                name: "EmpresaId",
                table: "ManufacturerTables",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CRT",
                table: "Empresas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CNAE",
                table: "Empresas",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ManufacturerTables_Empresas_EmpresaId",
                table: "ManufacturerTables",
                column: "EmpresaId",
                principalTable: "Empresas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
