using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExcitelProject.Data.Migrations
{
    public partial class Migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Subareas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PINCode",
                table: "Subareas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Leads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Subareas",
                columns: new[] { "SubareaId", "Name", "PINCode" },
                values: new object[,]
                {
                    { 1, "Subarea name 1", 100000 },
                    { 2, "Subarea name 2", 200000 },
                    { 3, "Subarea name 3", 300000 },
                    { 4, "Subarea name 4", 400000 },
                    { 5, "Subarea name 5", 500000 },
                    { 6, "Subarea name 6", 600000 },
                    { 7, "Subarea name 7", 700000 },
                    { 8, "Subarea name 8", 800000 },
                    { 9, "Subarea name 9", 900000 },
                    { 10, "Subarea name 10", 100000 },
                    { 11, "Subarea name 11", 110000 },
                    { 12, "Subarea name 12", 120000 },
                    { 13, "Subarea name 13", 130000 },
                    { 14, "Subarea name 14", 140000 },
                    { 15, "Subarea name 15", 150000 },
                    { 16, "Subarea name 16", 160000 },
                    { 17, "Subarea name 17", 170000 },
                    { 18, "Subarea name 18", 180000 },
                    { 19, "Subarea name 19", 190000 },
                    { 20, "Subarea name 20", 200000 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Leads_SubareaId",
                table: "Leads",
                column: "SubareaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Leads_Subareas_SubareaId",
                table: "Leads",
                column: "SubareaId",
                principalTable: "Subareas",
                principalColumn: "SubareaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Leads_Subareas_SubareaId",
                table: "Leads");

            migrationBuilder.DropIndex(
                name: "IX_Leads_SubareaId",
                table: "Leads");

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Subareas",
                keyColumn: "SubareaId",
                keyValue: 20);

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Subareas");

            migrationBuilder.DropColumn(
                name: "PINCode",
                table: "Subareas");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Leads");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Leads");
        }
    }
}
