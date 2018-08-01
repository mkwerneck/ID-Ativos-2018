using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CoreUI.Web.Migrations
{
    public partial class ParametrosEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria_Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Assunto_Email = table.Column<string>(maxLength: 255, nullable: false),
                    Email_Destinatario = table.Column<string>(maxLength: 255, nullable: false),
                    Email_Remetente = table.Column<string>(maxLength: 255, nullable: false),
                    Categoria = table.Column<string>(maxLength: 255, nullable: false),
                    Nome_Remetente = table.Column<string>(maxLength: 255, nullable: false),
                    SMTP = table.Column<string>(maxLength: 255, nullable: false),
                    Senha_Remetente = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria_Emails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Send_Emails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoriaEmailId = table.Column<int>(nullable: false),
                    Email = table.Column<string>(maxLength: 255, nullable: false),
                    Identificacao = table.Column<string>(maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Send_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Send_Emails_Categoria_Emails_CategoriaEmailId",
                        column: x => x.CategoriaEmailId,
                        principalTable: "Categoria_Emails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Send_Emails_CategoriaEmailId",
                table: "Send_Emails",
                column: "CategoriaEmailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Send_Emails");

            migrationBuilder.DropTable(
                name: "Categoria_Emails");
        }
    }
}
