using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ContactsApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "bob@bob.com", "Bob Johnson" },
                    { 52, "bob@bob.com", "Lucy Liu" },
                    { 51, "bob@bob.com", "Robert Redford" },
                    { 50, "bob@bob.com", "Bob Johnson" },
                    { 49, "bob@bob.com", "Robert Redford" },
                    { 48, "bob@bob.com", "Lucy Liu" },
                    { 47, "bob@bob.com", "Robert Redford" },
                    { 53, "bob@bob.com", "Robert Redford" },
                    { 46, "bob@bob.com", "Lucy Liu" },
                    { 44, "bob@bob.com", "Lucy Liu" },
                    { 43, "bob@bob.com", "Robert Redford" },
                    { 42, "bob@bob.com", "Lucy Liu" },
                    { 41, "bob@bob.com", "Robert Redford" },
                    { 40, "bob@bob.com", "Bob Johnson" },
                    { 39, "bob@bob.com", "Robert Redford" },
                    { 45, "bob@bob.com", "Robert Redford" },
                    { 38, "bob@bob.com", "Lucy Liu" },
                    { 54, "bob@bob.com", "Lucy Liu" },
                    { 56, "bob@bob.com", "Lucy Liu" },
                    { 70, "bob@bob.com", "Bob Johnson" },
                    { 69, "bob@bob.com", "Robert Redford" },
                    { 68, "bob@bob.com", "Lucy Liu" },
                    { 67, "bob@bob.com", "Robert Redford" },
                    { 66, "bob@bob.com", "Lucy Liu" },
                    { 65, "bob@bob.com", "Robert Redford" },
                    { 55, "bob@bob.com", "Robert Redford" },
                    { 64, "bob@bob.com", "Lucy Liu" },
                    { 62, "bob@bob.com", "Lucy Liu" },
                    { 61, "bob@bob.com", "Lucy Liu" },
                    { 60, "bob@bob.com", "Bob Johnson" },
                    { 59, "bob@bob.com", "Robert Redford" },
                    { 58, "bob@bob.com", "Lucy Liu" },
                    { 57, "bob@bob.com", "Robert Redford" },
                    { 63, "bob@bob.com", "Robert Redford" },
                    { 71, "bob@bob.com", "Lucy Liu" },
                    { 37, "bob@bob.com", "Robert Redford" },
                    { 35, "bob@bob.com", "Robert Redford" },
                    { 15, "bob@bob.com", "Robert Redford" },
                    { 14, "bob@bob.com", "Lucy Liu" },
                    { 13, "bob@bob.com", "Robert Redford" },
                    { 12, "bob@bob.com", "Lucy Liu" },
                    { 11, "bob@bob.com", "Bob Johnson" },
                    { 10, "bob@bob.com", "Bob Johnson" },
                    { 16, "bob@bob.com", "Lucy Liu" },
                    { 9, "bob@bob.com", "Robert Redford" },
                    { 7, "bob@bob.com", "Robert Redford" },
                    { 6, "bob@bob.com", "Lucy Liu" },
                    { 5, "bob@bob.com", "Robert Redford" },
                    { 4, "bob@bob.com", "Lucy Liu" },
                    { 3, "bob@bob.com", "Robert Redford" },
                    { 2, "bob@bob.com", "Lucy Liu" },
                    { 8, "bob@bob.com", "Lucy Liu" },
                    { 36, "bob@bob.com", "Lucy Liu" },
                    { 17, "bob@bob.com", "Robert Redford" },
                    { 19, "bob@bob.com", "Robert Redford" },
                    { 34, "bob@bob.com", "Lucy Liu" },
                    { 33, "bob@bob.com", "Robert Redford" },
                    { 32, "bob@bob.com", "Lucy Liu" },
                    { 31, "bob@bob.com", "Robert Redford" },
                    { 30, "bob@bob.com", "Bob Johnson" },
                    { 29, "bob@bob.com", "Robert Redford" },
                    { 18, "bob@bob.com", "Lucy Liu" },
                    { 28, "bob@bob.com", "Lucy Liu" },
                    { 26, "bob@bob.com", "Lucy Liu" },
                    { 24, "bob@bob.com", "Robert Redford" },
                    { 23, "bob@bob.com", "Lucy Liu" },
                    { 22, "bob@bob.com", "Robert Redford" },
                    { 21, "bob@bob.com", "Lucy Liu" },
                    { 20, "bob@bob.com", "Bob Johnson" },
                    { 27, "bob@bob.com", "Robert Redford" },
                    { 72, "bob@bob.com", "Robert Redford" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");
        }
    }
}
