using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BaseLogin.Migrations
{
    public partial class secondcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Logindetails",
                table: "Logindetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Logindetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logindetails",
                table: "Logindetails",
                column: "UserName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Logindetails",
                table: "Logindetails");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Logindetails",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logindetails",
                table: "Logindetails",
                column: "Id");
        }
    }
}
