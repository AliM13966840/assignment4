using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecruitCatAdekunle.Migrations
{
    /// <inheritdoc />
    public partial class AddCompanyToCandidateObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidate_JobTitle_CompanyId",
                table: "Candidate",
                column: "CompanyId",
                principalTable: "JobTitle",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidate_JobTitle_CompanyId",
                table: "Candidate");

            migrationBuilder.DropIndex(
                name: "IX_Candidate_CompanyId",
                table: "Candidate");
        }
    }
}
