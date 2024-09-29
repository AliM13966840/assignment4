using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RecruitCatAdekunle.Migrations
{
    /// <inheritdoc />
    public partial class SeedJobTitles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JobTitle",
                columns: new[] { "Id", "JobDescription", "MaxSalary", "MinSalary", "Title" },
                values: new object[,]
                {
                    { 1, "Develop and maintain software applications.", 120000m, 60000m, "Software Engineer" },
                    { 2, "Analyze and interpret data to drive decision-making.", 100000m, 50000m, "Data Analyst" },
                    { 3, "Manage product development and lead teams.", 130000m, 70000m, "Product Manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "JobTitle",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
