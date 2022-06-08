using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcitelProject.Data.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubareaId",
                table: "Subareas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LeadId",
                table: "Leads",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Subareas",
                newName: "SubareaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Leads",
                newName: "LeadId");
        }
    }
}
