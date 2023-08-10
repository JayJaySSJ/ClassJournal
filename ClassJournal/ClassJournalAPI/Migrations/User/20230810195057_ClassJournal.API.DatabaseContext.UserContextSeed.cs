using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassJournal.API.Migrations.User
{
    /// <inheritdoc />
    public partial class ClassJournalAPIDatabaseContextUserContextSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "Email", "Function", "Name", "Password", "Surname" },
                values: new object[] { 1, new DateTime(1973, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", 0, "admin", "admin", "admin" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}