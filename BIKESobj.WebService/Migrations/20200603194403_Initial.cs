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
                    DepartamentalAffiliation = table.Column<string>(nullable: true),
                    Width = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    ObjectOperOrgPhone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIKESobjs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 1L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "ТиНАО, посел. Первомайское, М-3 Украина- г.Троицк (М-1 Беларусь-Крекшино-Троицк)", "А/д Боровское шоссе – Киевское шоссе – д. Ботаково", "(495) 940-06-94", "1.8" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 103L, "Префектура Центрального административного округа города Москвы", "Пречистенских ворот пл-дь", "Пречистенских ворот пл-дь", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 102L, "Префектура Центрального административного округа города Москвы", "Покровский б-р", "Покровский б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 101L, "Префектура Северо-Восточного административного округа города Москвы", "Вдоль улицы Северодвинской через Пойму реки Яуза вдоль ул. Северодвинская к 91-му километру МКАД", "Пойма реки Яуза вдоль Северодвинской улицы", "(495) 656-98-51", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 100L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Площадь Арбатские ворота", "Площадь Арбатские ворота", "(495) 940-06-94", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 99L, "Префектура Центрального административного округа города Москвы", "Петровский б-р", "Петровский б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 98L, "Префектура Северного административного округа города Москвы", "Парк-усадьба Михалково", "Парк-усадьба Михалково", "(499) 153-00-12", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 97L, "Департамент культуры города Москвы", "аллея Жемчуговой, владение 2", "Парк у прудов «Радуга»", "(495) 309-53-42", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 96L, "Департамент культуры города Москвы", "Стартовая улица, дом 10", "Парк у Джамгаровского пруда", "(499) 184-34-22", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 95L, "Префектура Северо-Восточного административного округа города Москвы", "от Юрловского проезда дом 14 до Сельскохозяйственной дом 64", "Парк поймы реки Чермянка", "(495) 708-44-69", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 94L, "Департамент культуры города Москвы", "от улицы Маршала Захарова, дом 18 до Борисовского проезда, дом 15, корпус 2", "Парк по Борисовским прудам", "(499) 175-33-69", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 93L, "Департамент культуры города Москвы", "улица Сокольнический Вал, дом 1, строение 1", "Парк культуры и отдыха «Сокольники»", "(499) 268-54-30", "2.4" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 92L, "Департамент культуры города Москвы", "Коренная улица, дом 8-10", "Парк культуры и отдыха «Перовский»", "(495) 309-53-42", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 91L, "Префектура Центрального административного округа города Москвы", "ул. Сущевский вал, 56 (Парк Фестивальный)", "Парк Фестивальный", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 90L, "Департамент культуры города Москвы", "проспект Андропова, дом 58А", "Парк Садовники", "(499) 175-33-69", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 89L, "Префектура Северного административного округа города Москвы", "Парк Грачевка", "Парк Грачевка", "(499) 767-17-93", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 88L, "Департамент культуры города Москвы", "Москва, Ходынский бульвар, з/у 1", "Парк «Ходынское поле»", "(495) 657-45-12", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 87L, "Департамент культуры города Москвы", "Большая Филёвская улица, дом 22, строение 16", "Парк «Фили»", "(499) 145-00-00", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 73L, "Префектура Центрального административного округа города Москвы", "Неглинная ул.", "Неглинная ул.", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 74L, "Префектура Центрального административного округа города Москвы", "Никитская Б. ул.", "Никитская Б. ул.", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 75L, "Префектура Центрального административного округа города Москвы", "Никитская М. ул.", "Никитская М. ул.", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 76L, "Префектура Центрального административного округа города Москвы", "Никитский б-р", "Никитский б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 77L, "Префектура Центрального административного округа города Москвы", "Никитских ворот пл-дь", "Никитских ворот пл-дь", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 78L, "Префектура Центрального административного округа города Москвы", "От Новодевичьей наб. до Погодинской ул.", "Новодевичий пр-д", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 104L, "Префектура Центрального административного округа города Москвы", "Путинковский Б. пер.", "Путинковский Б. пер.", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 79L, "Префектура Центрального административного округа города Москвы", "Новодевичья наб.", "Новодевичья наб.", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 81L, "Префектура Северо-Восточного административного округа города Москвы", "от ул. Череповецкая д.4 до ул. Череповецкая д.24", "Озелененная территория по улице Череповецкая", "(499) 908-80-79", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 82L, "Префектура Юго-Западного административного округа города Москвы", "улица Перекопская дом 34 корпус 4", "Парк 70-летия Победы", "(499) 128-17-63", "1.3" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 83L, "Департамент культуры города Москвы", "улица Удальцова, дом 22", "Парк «50-летия Октября»", "(499) 145-45-05", "2.4" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 84L, "Департамент культуры города Москвы", "пересечение улицы Ангарской с улицей Софьи Ковалевской", "Парк «Ангарские пруды»", "(499) 908-35-00", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 85L, "Департамент культуры города Москвы", "улица Руставели, владение 7", "Парк «Гончаровский»", "(499) 908-35-00", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 86L, "Департамент культуры города Москвы", "улица Свободы, владение 50-70", "Парк «Северное Тушино»", "(495) 640-73-55", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 80L, "Префектура Центрального административного округа города Москвы", "Новолужнецкий проезд", "Новолужнецкий проезд", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 105L, "Департамент культуры города Москвы", "улица Крымский Вал, дом 9", "Пушкинская набережная, Парк Горького", "(495) 995-00-20", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 106L, "Префектура Центрального административного округа города Москвы", "От Климентовского пер. до дома №82", "Пятницкая ул.", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 107L, "Префектура Центрального административного округа города Москвы", "Рождественский б-р", "Рождественский б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 126L, "Префектура Центрального административного округа города Москвы", "Фрунзенская наб.", "Фрунзенская наб.", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 127L, "Префектура Центрального административного округа города Москвы", "Чистопрудный б-р", "Чистопрудный б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 128L, "Префектура Центрального административного округа города Москвы", "Яузский бульвар", "Яузский бульвар", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 129L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "г. Москва, г. Троицк, ул. Октябрьский проспект", "велодорожка вдоль Октябрьского проспекта г. Троицк", "(926) 095-83-50", "2.3" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 130L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "г. Москва, г. Троицк, ул. Солнечная", "велодорожка вдоль ул. Солнечная г. Троицк", "(926) 095-83-50", "2.3" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 131L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "г. Москва, г. Троицк, ул. Октябрьский проспект", "г.о. Троицк, Октябрьский проспект", "(926) 095-83-50", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 125L, "Департамент культуры города Москвы", "Алтуфьевское шоссе, дом 147 - 149", "Усадьба «Алтуфьево»", "(499) 908-35-00", "1.6" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 132L, "Департамент природопользования и охраны окружающей среды города Москвы", "от улицы Островитянова до зоны отдыха Тропарево", "ландшафтный заказник Теплый Стан", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 134L, "Департамент природопользования и охраны окружающей среды города Москвы", "МКАД, 36 км, внешняя сторона", "парк Битцевский лес", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 135L, "Департамент природопользования и охраны окружающей среды города Москвы", "в границах природно-исторического парка Измайлово", "парк Измайлово", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 136L, "Департамент природопользования и охраны окружающей среды города Москвы", "в границах природно-исторического парка Кузьминки-Люблино", "парк Кузьминки-Люблино", "(495) 940-06-94", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 137L, "Департамент природопользования и охраны окружающей среды города Москвы", "на территории лесопарка Кусково", "парк Кусково", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 138L, "Департамент природопользования и охраны окружающей среды города Москвы", "от Иваньковского шоссе до Никольского тупика", "парк Покровское-Стрешнево", "(499) 739-27-05", "3.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 139L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "г. Москва, от ст. Филатов луг до мкр. Первый Московский, ул. Радужная д.1", "парк Филатов Луг", "(495) 620-20-00", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 133L, "Департамент природопользования и охраны окружающей среды города Москвы", "от улицы Миклухо Маклая до микрорайона Северное Чертаново", "парк Битцевский лес", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 72L, "Департамент культуры города Москвы", "Усадьба «Коломенское», 2-я улица Дьяково-Городище", "Московский государственный объединенный художественный историко-архитектурный и природно-ландшафтный музей-заповедник (МГОМЗ)", "(499) 612-52-17", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 124L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Территория МГУ на Воробьевых горах", "Университетская площадь", "(495) 940-06-94", "1.8" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 122L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Ордынка большая улица", "Улица Большая Ордынка", "(495) 940-06-94", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 108L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Рублевское шоссе", "Рублевское шоссе", "(495) 940-06-94", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 109L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Рязанский проспект", "Рязанский проспект", "(495) 940-06-94", "1.8" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 110L, "Префектура Северо-Восточного административного округа города Москвы", "Парк Сад Будущего", "Сад будущего", "(499) 187-99-86", "3" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 111L, "Префектура Северо-Восточного административного округа города Москвы", "вдоль сквера по Северному бульвару с адресной привязкой от Северного бульвара дом 2 до Северного бульвара дом 21", "Северный бульвар", "(495) 708-44-69", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 112L, "Департамент культуры города Москвы", "Сухонская улица, дом 7", "Сквер по Олонецкому проезду", "(499) 184-34-22", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 113L, "Префектура Северо-Восточного административного округа города Москвы", "Парк света по улице Костромская", "Сквер по ул. Костромская", "(495) 533-00-22", "3" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 123L, "Департамент культуры города Москвы", "улица Лобачевского/Мичуринский проспект", "Улица Лобачевского/Мичуринский проспект", "(499) 145-45-05", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 114L, "Префектура Центрального административного округа города Москвы", "Соймоновский пр-д", "Соймоновский пр-д", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 116L, "Префектура Центрального административного округа города Москвы", "Сретенский б-р", "Сретенский б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 117L, "Префектура Центрального административного округа города Москвы", "Сретенских ворот пл-дь", "Сретенских ворот пл-дь", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 118L, "Префектура Центрального административного округа города Москвы", "Страстной б-р", "Страстной б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 119L, "Префектура Центрального административного округа города Москвы", "Тверской б-р", "Тверской б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 120L, "Префектура Центрального административного округа города Москвы", "Трубная площадь", "Трубная площадь", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 121L, "Префектура Центрального административного округа города Москвы", "Тургеневская площадь", "Тургеневская площадь", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 115L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "г. Москва, п. Десеновское, ул. 1-я Ватутинская, д. 6, к. 2", "Спортивный парк", "(495) 902-57-52", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 140L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "микрорайон Ленинские Горы, дом 1 строение 43 - микрорайон Ленинские Горы, дом 1 строение 2", "улица Академика Хохлова", "(495) 940-06-94", "1.8" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 71L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Люсиновская улица", "Люсиновская улица", "(495) 940-06-94", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 69L, "Департамент природопользования и охраны окружающей среды города Москвы", @"от Ярославского шоссе дом 118 до улицы Курганская дом 6
", "Лосиный остров", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 32L, "Префектура Южного административного округа города Москвы", "Коломенская набережная", "Велодорожка по Коломенской набережной", "(499) 617-21-11", "2.4" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 31L, "Префектура Южного административного округа города Москвы", "Битцевский проезд", "Велодорожка по Битцевскому проезду", "(495) 315-50-36", "1.6" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 30L, "Префектура Южного административного округа города Москвы", "парк Фруктовый по Востряковскому проезду", "Велодорожка на территории парка Фруктовый", "(495) 384-05-00", "2.4" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 29L, "Префектура Северо-Западного административного округа города Москвы", "г. Москва, район Куркино, территория между мкр.15 и мкр.4.", "Велодорожка на территории между мкр.15 и мкр.4 Парк Дубрава", "(499) 744-88-11", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 28L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "ул. Радужная, г. Московский", "Велодорожка на озелененной территории ул.Радужная, г. Московский", "(495) 841-81-47", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 27L, "Префектура Западного административного округа города Москвы", "от улицы Улофе Пальме 3 до улицы Мосфильмовская", "Велодорожка вдоль улицы Улофа Пальме", "(495) 539-53-53", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 26L, "Префектура Западного административного округа города Москвы", "улица Минская от дома 1 до железнодорожного моста", "Велодорожка вдоль улицы Минская", "(499) 792-65-06", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 25L, "Префектура Западного административного округа города Москвы", "Ул. Лобачевского (от проспекта Вернадского до Мичуринского проспекта)", "Велодорожка вдоль улицы Лобачевского", "(499) 792-65-06", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 24L, "Префектура Северного административного округа города Москвы", "Авиаконструктора Микояна", "Велодорожка вдоль ул. Авиаконструктора Микояна", "(495) 940-08-83", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 23L, "Префектура Западного административного округа города Москвы", "Рублевское шоссе от дома 16 корпус 1 до дома 52 а", "Велодорожка вдоль дублера Рублевского шоссе", "(499) 792-65-06", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 22L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, д. 77-79", "Велодорожка вблизи дома 77-79", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 21L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 71", "Велодорожка вблизи дома 71", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 20L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 51", "Велодорожка вблизи дома 51", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 19L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 28", "Велодорожка вблизи дома 28", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 18L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 45-49", "Велодорожка вблизи д. 45-49", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 17L, "Префектура Юго-Восточного административного округа города Москвы", "Парк на набережной (по ул.Гурьянова)", "Велодорожка в парке на набережной (по ул.Гурьянова)", "(495) 657-35-00", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 16L, "Префектура Западного административного округа города Москвы", "улица Кравченко дом 7", "Велодорожка в парке Кравченские пруды", "(499) 792-65-06", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 2L, "Департамент культуры города Москвы", "улица Крымский Вал, дом 9", "Андреевская набережная, Природный заказник «Воробьёвы горы»", "(495) 995-00-20", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 3L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Арбатская площадь", "Арбатская площадь", "(495) 940-06-94", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 4L, "Префектура Северо-Восточного административного округа города Москвы", "от Олонецкой улицы дом 15Б до Березовой аллеи дом 7", "Березовая аллея", "(495) 708-44-69", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 5L, "Префектура Северного административного округа города Москвы", "Бескудниковский район", "Бескудниковский бульвар (озелененная часть)", "(499) 487-04-90", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 6L, "Департамент природопользования и охраны окружающей среды города Москвы", "в границах Бирюлевского дендропарка", "Бирюлевский дендропарк", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 7L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Боровское шоссе", "Боровское шоссе", "(495) 940-06-94", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 33L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 22-24", "Велопешеходная зона", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 8L, "Префектура Центрального административного округа города Москвы", "Бронная М. ул.", "Бронная М. ул.", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 10L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 14", "Велодорожка (в зоне озеленения)", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 11L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 18", "Велодорожка (зона озеленения)", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 12L, "Префектура Западного административного округа города Москвы", "от улицы Славянский бульвар дом 15 до улицы Кременчугская дом 22", "Велодорожка в Кременчугском сквере", "(499) 792-65-06", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 13L, "Префектура Западного административного округа города Москвы", "Парк школьников", "Велодорожка в Парке Школьников", "(499) 792-65-06", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 14L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 2", "Велодорожка в зоне озеленения", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 15L, "Префектура Троицкого и Новомосковского административных округов города Москвы", "г. Московский место массового отдыха населения между микрорайоном 3 и поселком института полиомиелита", "Велодорожка в месте массового отдыха населения г. Московский", "(495) 841-81-47", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 9L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 8-10", "Велодорожка", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 34L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 35", "Велопешеходная зона (в зоне озеленения)", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 35L, "Префектура Восточного административного округа города Москвы", "Район Богородское", "Велосипедная дорожка", "(495) 195-82-47", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 36L, "Префектура Восточного административного округа города Москвы", "Район Гольяново ВАО г. Москвы", "Велосипедная дорожка", "(495) 469-82-81", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 55L, "Префектура Северо-Западного административного округа города Москвы", "от дома №41 до дома №47 по Пятницкому шоссе", "Велосипедная дорожка на бульварной зоне №4 по Пятницкому шоссе", "(495) 753-12-22", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 56L, "Префектура Северо-Западного административного округа города Москвы", "территория Березовой рощи (между ул. 3-я Хорошевская д. 5-9 и Новохорошевским проездом д. 8-10)", "Велосипедная дорожка на территории Березовой рощи (между ул. 3-я Хорошевская д. 5-9 и Новохорошевским проездом д. 8-10)", "(499) 191-40-86", "1.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 57L, "Префектура Северо-Западного административного округа города Москвы", "Левый берег реки Сходня", "Велосипедная дорожка на территории набережной-сквера вдоль левого берега реки Сходня", "(499) 492-29-36", "1.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 58L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "площадь Джавахарлала Неру, дом 1 - Вернадского проспект дом 12", "Вернадского проспект", "(495) 940-06-94", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 59L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Воробьёвская набережная, дом 1", "Воробьевская набережная", "(495) 940-06-94", "3" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 60L, "Департамент культуры города Москвы", "улица Косыгина, дом 28", "Воробьёвская набережная, Природный заказник «Воробьёвы горы»", "(495) 995-00-20", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 54L, "Префектура Северо-Западного административного округа города Москвы", "от дома №29 до дома №39 по Пятницкому шоссе", "Велосипедная дорожка на бульварной зоне №3 по Пятницкому шоссе", "(495) 753-12-22", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 61L, "Префектура Центрального административного округа города Москвы", "Гоголевский б-р", "Гоголевский б-р", "(495) 670-02-60", "1.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 63L, "Департамент природопользования и охраны окружающей среды города Москвы", "от улицы Улофа Пальме до Воробьевского шоссе", "Долина реки Сетунь", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 64L, "Департамент природопользования и охраны окружающей среды города Москвы", "парк Царицыно", "Долина реки Язвенки (Царицыно)", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 65L, "Департамент культуры города Москвы", "от улицы Борисовские Пруды и Каширского шоссе до Наташинской улицы", "Зона отдыха Борисовские пруды", "(499) 175-33-69", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 66L, "Департамент культуры города Москвы", "аллея Большого Круга, аллея Пролетарского входа", "Измайловский парк", "(499) 166-61-19", "1.8" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 67L, "Департамент культуры города Москвы", "Крымская набережная, владение 2", "Крымская набережная, Музеон", "(495) 995-00-20", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 68L, "Департамент жилищно-коммунального хозяйства и благоустройства города Москвы", "Ленинградское шоссе, дом 67 - Ленинградское шоссе, дом 25", "Ленинградское шоссе", "(495) 940-06-94", "5.4" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 62L, "Департамент природопользования и охраны окружающей среды города Москвы", "от улицы Улофа Пальме до улицы Минская", "Долина реки Сетунь", "(499) 739-27-05", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 70L, "Префектура Центрального административного округа города Москвы", "Лужнецкая наб.", "Лужнецкая наб.", "(495) 670-02-60", "2.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 53L, "Префектура Северо-Западного административного округа города Москвы", "Пятницкое шоссе от д.7 до д.23", "Велосипедная дорожка на бульварной зоне по Пятницкому шоссе", "(495) 753-12-22", "3.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 51L, "Префектура Северо-Западного административного округа города Москвы", "ул. Героев Панфиловцев, д. 22, корп. 1", "Велосипедная дорожка в сквере по адресу ул. Героев Панфиловцев, д. 22, корп. 1", "(495) 496-46-92", "0.8" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 37L, "Префектура Северного административного округа города Москвы", "улица Большая Академическая, дом 12, корп. 1", "Велосипедная дорожка", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 38L, "Префектура Восточного административного округа города Москвы", "Район Ивановское", "Велосипедная дорожка", "(495) 307-84-91", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 39L, "Префектура Восточного административного округа города Москвы", "Район Новокосино", "Велосипедная дорожка", "(495) 701-07-35", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 40L, "Префектура Восточного административного округа города Москвы", "Район Ивановское", "Велосипедная дорожка", "(495) 307-84-91", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 41L, "Префектура Восточного административного округа города Москвы", "Район Измайлово", "Велосипедная дорожка", "(499) 165-39-91", "2.2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 42L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 6", "Велосипедная дорожка (в зоне озеленения)", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 52L, "Префектура Западного административного округа города Москвы", "улица Мосфильмовская от дома 2 до дома 17/25", "Велосипедная дорожка вдоль улицы Мосфильмовская", "(499) 792-65-06", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 43L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 18А-20", "Велосипедная дорожка (зона озеленения)", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 45L, "Префектура Западного административного округа города Москвы", "Парк 60 лет Октября", "Велосипедная дорожка в Парке 60 лет Октября", "(499) 792-45-37", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 46L, "Департамент культуры города Москвы", "Парк Победы на Поклонной горе, з/у 1", "Велосипедная дорожка в Парке Победы на Поклонной горе", "(499) 148-83-00", "1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 47L, "Префектура Северного административного округа города Москвы", "Большая Академическая улица, дом 4", "Велосипедная дорожка в зоне озеленения", "(985) 640-80-67", "2.1" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 48L, "Префектура Юго-Восточного административного округа города Москвы", "Парк 850-летия", "Велосипедная дорожка в парке 850 летия", "(495) 351-19-91", "3.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 49L, "Префектура Юго-Восточного административного округа города Москвы", "Парк им.Артёма Боровика", "Велосипедная дорожка в парке им. Артема Боровика", "(495) 351-19-91", "3.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 50L, "Префектура Юго-Восточного административного округа города Москвы", "в парке на набережной Москвы-Реки в Капотни", "Велосипедная дорожка в парке на набережной Москвы-Реки в Капотни", "(495) 355-75-92", "1.5" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 44L, "Префектура Западного административного округа города Москвы", "от ул. Осенняя до Пр-д от ул. Крылатские холмы до ул. Крылатская", "Велосипедная дорожка в Народном парке Крылатское", "(495) 413-26-14", "2" });

            migrationBuilder.InsertData(
                table: "BIKESobjs",
                columns: new[] { "Id", "DepartamentalAffiliation", "Location", "Name", "ObjectOperOrgPhone", "Width" },
                values: new object[] { 141L, "Префектура Юго-Западного административного округа города Москвы", "улица Миклухо-Маклая", "улица Миклухо-Маклая", "(499) 128-17-63", "2.3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BIKESobjs");
        }
    }
}
