using Microsoft.EntityFrameworkCore.Migrations;

namespace BIKESobj.WebService.Migrations
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
                    PathLocation = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIKESobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "Name", "PathLocation", "PathType", "PathWeidth", "Telephone" },
                values: new object[] { 1L, "А/д Боровское шоссе – Киевское шоссе – д. Ботаково", "ТиНАО, посел. Первомайское, М-3 Украина- г.Троицк (М-1 Беларусь-Крекшино-Троицк)", "Велопешеходная дорожка с совмещенным движением,велосипедная полоса попутного движения,Двустороняя велополоса", "1.8 M", "(495) 940-06-94" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "Name", "PathLocation", "PathType", "PathWeidth", "Telephone" },
                values: new object[] { 2L, "Андреевская набережная, Природный заказник «Воробьёвы горы»", "улица Крымский Вал, дом 9", "велосипедная дорожка двухстороннего движения", "1.5 M", "(495) 995-00-20" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "Name", "PathLocation", "PathType", "PathWeidth", "Telephone" },
                values: new object[] { 3L, "Арбатская площадь", "Арбатская площадь", "Велопешеходная дорожка с совмещенным движением,велосипедная полоса попутного движения,велосипедная дорожка одностороннего движения", "1.2 M", "(495) 940-06-94" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "Name", "PathLocation", "PathType", "PathWeidth", "Telephone" },
                values: new object[] { 4L, "Березовая аллея", "от Олонецкой улицы дом 15Б до Березовой аллеи дом 7", "велосипедная дорожка одностороннего движения", "1 M", "(495) 708-44-69" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIKESobjs");
        }
    }
}
