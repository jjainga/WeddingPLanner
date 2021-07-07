using Microsoft.EntityFrameworkCore.Migrations;

namespace weddingplanner.Migrations
{
    public partial class AddBrideGrommTOWeddingEvent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BrideEmail",
                table: "WeddingEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BrideName",
                table: "WeddingEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BridePassword",
                table: "WeddingEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BridePhoneNumber",
                table: "WeddingEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "GroomEmail",
                table: "WeddingEvent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GroomName",
                table: "WeddingEvent",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GroomPassword",
                table: "WeddingEvent",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "GroomPhoneNumber",
                table: "WeddingEvent",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "User",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Family",
                table: "Guest",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrideEmail",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "BrideName",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "BridePassword",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "BridePhoneNumber",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "GroomEmail",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "GroomName",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "GroomPassword",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "GroomPhoneNumber",
                table: "WeddingEvent");

            migrationBuilder.DropColumn(
                name: "password",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Family",
                table: "Guest");
        }
    }
}
