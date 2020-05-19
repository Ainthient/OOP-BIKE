using Microsoft.EntityFrameworkCore.Migrations;

namespace ManagementOrganizations.WebService.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BIKESobjs",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    PathType = table.Column<string>(nullable: true),
                    PathWeidth = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIKESobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "Location", "Name", "PathType", "PathWeidth", "Telephone" },
                values: new object[] { 1L, "ТиНАО, посел. Первомайское, М-3 Украина- г.Троицк (М-1 Беларусь-Крекшино-Троицк)", "А/д Боровское шоссе – Киевское шоссе – д. Ботаково", "Велопешеходная дорожка с совмещенным движением, велосипедная полоса попутного движения, Двустороняя велополоса", "1.8", "(495) 940-06-94" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIKESobjs");
        }
    }
}
