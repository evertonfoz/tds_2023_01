﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Aula05.RazorPages.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventID);
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    PlayerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.PlayerID);
                });

            migrationBuilder.CreateTable(
                name: "EventosEJogadores",
                columns: table => new
                {
                    EventID = table.Column<int>(type: "INTEGER", nullable: false),
                    PlayerID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventosEJogadores", x => new { x.EventID, x.PlayerID });
                    table.ForeignKey(
                        name: "FK_EventosEJogadores_Eventos_EventID",
                        column: x => x.EventID,
                        principalTable: "Eventos",
                        principalColumn: "EventID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventosEJogadores_Jogadores_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Jogadores",
                        principalColumn: "PlayerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EventosEJogadores_PlayerID",
                table: "EventosEJogadores",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventosEJogadores");

            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.DropTable(
                name: "Jogadores");
        }
    }
}
