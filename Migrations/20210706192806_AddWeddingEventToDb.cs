using Microsoft.EntityFrameworkCore.Migrations;

namespace weddingplanner.Migrations
{
    public partial class AddWeddingEventToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeddingEvent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingEvent", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingEventRefId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    RSP = table.Column<bool>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    FoodLimitations = table.Column<string>(nullable: true),
                    Virtual = table.Column<bool>(nullable: false),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    HotelName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guest_WeddingEvent_WeddingEventRefId",
                        column: x => x.WeddingEventRefId,
                        principalTable: "WeddingEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingEventRefId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    Role = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_WeddingEvent_WeddingEventRefId",
                        column: x => x.WeddingEventRefId,
                        principalTable: "WeddingEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guest_WeddingEventRefId",
                table: "Guest",
                column: "WeddingEventRefId");

            migrationBuilder.CreateIndex(
                name: "IX_User_WeddingEventRefId",
                table: "User",
                column: "WeddingEventRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guest");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "WeddingEvent");
        }
    }
}
