using Microsoft.EntityFrameworkCore.Migrations;

namespace Ragnarok_Mobile_Website.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AdventureBook",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaximumHp = table.Column<int>(nullable: false),
                    PhysicalAttack = table.Column<int>(nullable: false),
                    MagicAttack = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdventureBook", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "CharacterStats",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<int>(nullable: false),
                    GuildId = table.Column<int>(nullable: false),
                    Class = table.Column<string>(nullable: true),
                    Level = table.Column<int>(nullable: false),
                    HealthPoints = table.Column<int>(nullable: false),
                    GoldMedals = table.Column<int>(nullable: false),
                    GuildContribution = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterStats", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "ClassStat",
                columns: table => new
                {
                    ClassId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PhysicalAttack = table.Column<int>(nullable: false),
                    MagicAttack = table.Column<int>(nullable: false),
                    PhysicalDefenseIgnore = table.Column<int>(nullable: false),
                    MagicDefenseIgnore = table.Column<int>(nullable: false),
                    PhysicalPenetration = table.Column<int>(nullable: false),
                    MagicPenetration = table.Column<int>(nullable: false),
                    HealAmount = table.Column<int>(nullable: false),
                    PhysicalDamageReduction = table.Column<int>(nullable: false),
                    MagicDamageIgnore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassStat", x => x.ClassId);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WeaponName = table.Column<string>(nullable: true),
                    WeaponRefine = table.Column<int>(nullable: false),
                    WeaponCard = table.Column<string>(nullable: true),
                    ShieldName = table.Column<string>(nullable: true),
                    ShieldRefine = table.Column<int>(nullable: false),
                    ShieldCard = table.Column<string>(nullable: true),
                    ArmorName = table.Column<string>(nullable: true),
                    ArmorRefine = table.Column<int>(nullable: false),
                    ArmorCard = table.Column<string>(nullable: true),
                    ManteauName = table.Column<string>(nullable: true),
                    ManteauRefine = table.Column<int>(nullable: false),
                    ManteauCard = table.Column<string>(nullable: true),
                    LeftAccessoryName = table.Column<string>(nullable: true),
                    LeftAccessoryRefine = table.Column<int>(nullable: false),
                    LeftAccessoryCard = table.Column<string>(nullable: true),
                    RightAccessoryName = table.Column<string>(nullable: true),
                    RightAccessoryRefine = table.Column<int>(nullable: false),
                    RightAccessoryCard = table.Column<string>(nullable: true),
                    HeadgearName = table.Column<string>(nullable: true),
                    HeadgearRefine = table.Column<int>(nullable: false),
                    HeadgearCard = table.Column<string>(nullable: true),
                    FaceName = table.Column<string>(nullable: true),
                    FaceRefine = table.Column<int>(nullable: false),
                    MouthName = table.Column<string>(nullable: true),
                    MouthRefine = table.Column<int>(nullable: false),
                    BackName = table.Column<string>(nullable: true),
                    BackRefine = table.Column<int>(nullable: false),
                    TailName = table.Column<string>(nullable: true),
                    TailRefine = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Guild",
                columns: table => new
                {
                    GuildId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GuildName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guild", x => x.GuildId);
                });

            migrationBuilder.CreateTable(
                name: "PrayerTracker",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaximumHp = table.Column<int>(nullable: false),
                    PhysicalAttack = table.Column<int>(nullable: false),
                    MagicAttack = table.Column<int>(nullable: false),
                    PhysicalDefense = table.Column<int>(nullable: false),
                    MagicalDefense = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrayerTracker", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "StatusResistance",
                columns: table => new
                {
                    CharacterId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FearResistance = table.Column<int>(nullable: false),
                    FreezeResistance = table.Column<int>(nullable: false),
                    PetrifyResistance = table.Column<int>(nullable: false),
                    SleepResistance = table.Column<int>(nullable: false),
                    StunResistance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusResistance", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdventureBook");

            migrationBuilder.DropTable(
                name: "CharacterStats");

            migrationBuilder.DropTable(
                name: "ClassStat");

            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "Guild");

            migrationBuilder.DropTable(
                name: "PrayerTracker");

            migrationBuilder.DropTable(
                name: "StatusResistance");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
