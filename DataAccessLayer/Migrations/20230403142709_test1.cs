using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials");

            migrationBuilder.RenameTable(
                name: "Testimonials",
                newName: "Testsimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testsimonials",
                table: "Testsimonials",
                column: "TestimonialID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Testsimonials",
                table: "Testsimonials");

            migrationBuilder.RenameTable(
                name: "Testsimonials",
                newName: "Testimonials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Testimonials",
                table: "Testimonials",
                column: "TestimonialID");
        }
    }
}
