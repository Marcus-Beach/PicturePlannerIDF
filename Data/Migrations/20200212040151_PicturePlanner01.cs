using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PicturePlannerIDF.Data.Migrations
{
    public partial class PicturePlanner01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    UserFriendId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FriendID = table.Column<string>(nullable: true),
                    UserID = table.Column<string>(nullable: true),
                    Confirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.UserFriendId);
                });

            migrationBuilder.CreateTable(
                name: "Plans",
                columns: table => new
                {
                    PlanId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharedPlanId = table.Column<int>(nullable: true),
                    FloorId = table.Column<int>(nullable: true),
                    SharedFloorId = table.Column<int>(nullable: true),
                    OwnerId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plans", x => x.PlanId);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    SettingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharedSettingId = table.Column<int>(nullable: true),
                    CanMove = table.Column<bool>(nullable: false),
                    CanPlace = table.Column<bool>(nullable: false),
                    CanRemove = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SettingId);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharedTagId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Things",
                columns: table => new
                {
                    ThingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SharedThingId = table.Column<int>(nullable: true),
                    PublicThingId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 255, nullable: false),
                    LocalImagePath = table.Column<string>(maxLength: 255, nullable: true),
                    SharedImagePath = table.Column<string>(maxLength: 255, nullable: true),
                    PublicImagePath = table.Column<string>(maxLength: 255, nullable: true),
                    UnitOfMeasure = table.Column<int>(nullable: false),
                    Length = table.Column<double>(nullable: false),
                    Width = table.Column<double>(nullable: false),
                    XPosition = table.Column<double>(nullable: true),
                    YPosition = table.Column<double>(nullable: true),
                    Orientation = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Things", x => x.ThingId);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    TransactionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    FriendId = table.Column<string>(nullable: true),
                    PlanId = table.Column<int>(nullable: true),
                    SharedPlanId = table.Column<int>(nullable: true),
                    ThingId = table.Column<int>(nullable: true),
                    SharedThingId = table.Column<int>(nullable: true),
                    TagId = table.Column<int>(nullable: true),
                    SharedTagId = table.Column<int>(nullable: true),
                    SettingId = table.Column<int>(nullable: true),
                    SharedSettingId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.TransactionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Plans");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Things");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
