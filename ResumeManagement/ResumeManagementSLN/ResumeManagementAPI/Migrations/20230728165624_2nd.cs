using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ResumeManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class _2nd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Usename",
                table: "TokenInfo",
                newName: "Username");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "TokenInfo",
                newName: "Usename");
        }
    }
}
