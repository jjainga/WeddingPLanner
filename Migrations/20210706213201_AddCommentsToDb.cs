using Microsoft.EntityFrameworkCore.Migrations;

namespace weddingplanner.Migrations
{
    public partial class AddCommentsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dress",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingEventRefId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Style = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Dislikes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dress_WeddingEvent_WeddingEventRefId",
                        column: x => x.WeddingEventRefId,
                        principalTable: "WeddingEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeddingEventRefId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Location = table.Column<string>(nullable: true),
                    Link = table.Column<string>(nullable: true),
                    Price = table.Column<int>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Dislikes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venue_WeddingEvent_WeddingEventRefId",
                        column: x => x.WeddingEventRefId,
                        principalTable: "WeddingEvent",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DressComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DressRefId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Dislikes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DressComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DressComments_Dress_DressRefId",
                        column: x => x.DressRefId,
                        principalTable: "Dress",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VenueComments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueRefId = table.Column<int>(nullable: false),
                    Comment = table.Column<string>(nullable: false),
                    Likes = table.Column<int>(nullable: false),
                    Dislikes = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VenueComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VenueComments_Venue_VenueRefId",
                        column: x => x.VenueRefId,
                        principalTable: "Venue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dress_WeddingEventRefId",
                table: "Dress",
                column: "WeddingEventRefId");

            migrationBuilder.CreateIndex(
                name: "IX_DressComments_DressRefId",
                table: "DressComments",
                column: "DressRefId");

            migrationBuilder.CreateIndex(
                name: "IX_Venue_WeddingEventRefId",
                table: "Venue",
                column: "WeddingEventRefId");

            migrationBuilder.CreateIndex(
                name: "IX_VenueComments_VenueRefId",
                table: "VenueComments",
                column: "VenueRefId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DressComments");

            migrationBuilder.DropTable(
                name: "VenueComments");

            migrationBuilder.DropTable(
                name: "Dress");

            migrationBuilder.DropTable(
                name: "Venue");
        }
    }
}
