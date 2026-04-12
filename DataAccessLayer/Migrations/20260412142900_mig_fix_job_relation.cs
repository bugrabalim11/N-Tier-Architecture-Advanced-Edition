using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_fix_job_relation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "Jobs",
                newName: "JobId");

            migrationBuilder.RenameColumn(
                name: "JobID",
                table: "Customers",
                newName: "JobId");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_JobID",
                table: "Customers",
                newName: "IX_Customers_JobId");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Jobs_JobId",
                table: "Customers",
                column: "JobId",
                principalTable: "Jobs",
                principalColumn: "JobId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Jobs_JobId",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Jobs",
                newName: "JobID");

            migrationBuilder.RenameColumn(
                name: "JobId",
                table: "Customers",
                newName: "JobID");

            migrationBuilder.RenameIndex(
                name: "IX_Customers_JobId",
                table: "Customers",
                newName: "IX_Customers_JobID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Jobs_JobID",
                table: "Customers",
                column: "JobID",
                principalTable: "Jobs",
                principalColumn: "JobID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
