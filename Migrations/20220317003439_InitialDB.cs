using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace projetoConsultorio.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "EspecialidadeId",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Registro",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Salario",
                table: "Pessoas");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pacientes");

            migrationBuilder.AlterColumn<string>(
                name: "Fone",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Pacientes",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Dentistas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Fone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Senha = table.Column<string>(nullable: false),
                    Registro = table.Column<string>(nullable: false),
                    Salario = table.Column<double>(nullable: false),
                    EspecialidadeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dentistas_Especialidades_EspecialidadeId",
                        column: x => x.EspecialidadeId,
                        principalTable: "Especialidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_AgendamentoId",
                table: "Atendimentos",
                column: "AgendamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Atendimentos_ProcedimentoId",
                table: "Atendimentos",
                column: "ProcedimentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Dentistas_EspecialidadeId",
                table: "Dentistas",
                column: "EspecialidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Agendamentos_AgendamentoId",
                table: "Atendimentos",
                column: "AgendamentoId",
                principalTable: "Agendamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atendimentos_Procedimentos_ProcedimentoId",
                table: "Atendimentos",
                column: "ProcedimentoId",
                principalTable: "Procedimentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Agendamentos_AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropForeignKey(
                name: "FK_Atendimentos_Procedimentos_ProcedimentoId",
                table: "Atendimentos");

            migrationBuilder.DropTable(
                name: "Dentistas");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_AgendamentoId",
                table: "Atendimentos");

            migrationBuilder.DropIndex(
                name: "IX_Atendimentos_ProcedimentoId",
                table: "Atendimentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacientes",
                table: "Pacientes");

            migrationBuilder.RenameTable(
                name: "Pacientes",
                newName: "Pessoas");

            migrationBuilder.AlterColumn<string>(
                name: "Fone",
                table: "Pessoas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataNascimento",
                table: "Pessoas",
                type: "datetime(6)",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<int>(
                name: "EspecialidadeId",
                table: "Pessoas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Registro",
                table: "Pessoas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Salario",
                table: "Pessoas",
                type: "double",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Pessoas",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "Id");
        }
    }
}
