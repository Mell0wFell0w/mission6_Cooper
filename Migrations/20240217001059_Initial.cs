﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace mission6_Cooper.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MovieTitle = table.Column<string>(type: "TEXT", nullable: false),
                    MovieYear = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieDirector = table.Column<string>(type: "TEXT", nullable: false),
                    MovieCategory = table.Column<string>(type: "TEXT", nullable: false),
                    MovieRating = table.Column<string>(type: "TEXT", nullable: false),
                    MovieEdited = table.Column<bool>(type: "INTEGER", nullable: true),
                    MovieLentTo = table.Column<string>(type: "TEXT", nullable: true),
                    MovieNotes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
