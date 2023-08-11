using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassJournal.Repository.Migrations.Class
{
    /// <inheritdoc />
    public partial class ClassJournalRepositoryDatabaseContextClassContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Classes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrainerId = table.Column<int>(type: "int", nullable: false),
                    AttendancePassigThreshold = table.Column<int>(type: "int", nullable: false),
                    HomeworkPassigThreshold = table.Column<int>(type: "int", nullable: false),
                    TestPassingThreshold = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Classes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Function = table.Column<int>(type: "int", nullable: false),
                    ClassModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Classes_ClassModelId",
                        column: x => x.ClassModelId,
                        principalTable: "Classes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Classes_TrainerId",
                table: "Classes",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ClassModelId",
                table: "Users",
                column: "ClassModelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Classes_Users_TrainerId",
                table: "Classes",
                column: "TrainerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Classes_Users_TrainerId",
                table: "Classes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Classes");
        }
    }
}
