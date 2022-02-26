using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityProject.Migrations
{
    public partial class lastmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "Name", "OpenedDate" },
                values: new object[,]
                {
                    { 1, ".NetBootcamp", "22.02.2002" },
                    { 2, "JavaBootcamp", "22.02.2002" },
                    { 3, "GoBootcamp", "22.02.2002" }
                });

            migrationBuilder.InsertData(
                table: "SubjectTeachers",
                columns: new[] { "Id", "SubjectId", "TeacherId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 2, 3 },
                    { 4, 2, 4 },
                    { 5, 3, 5 },
                    { 6, 3, 6 },
                    { 7, 4, 5 },
                    { 8, 4, 1 },
                    { 9, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "dotnet" },
                    { 2, "java" },
                    { 3, "go" },
                    { 4, "foundation" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Age", "Email", "FirstName", "GroupId", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 21, "asad@gmail.com", "Asadbek", 1, "Latipov", "99 999 99 99" },
                    { 12, 21, "mhriddin@gmail.com", "Muhriddin", 3, "Muhriddinov", "99 999 99 99" },
                    { 9, 20, "bobur@gmail.com", "Bobur", 3, "Boburov", "99 999 99 99" },
                    { 6, 22, "umar@gmail.com", "Umar", 3, "Mahmudjanov", "99 999 99 99" },
                    { 3, 21, "homid@gmail.com", "Homid", 3, "Rozipv", "99 999 99 99" },
                    { 11, 21, "ahror@gmail.com", "Ahror", 2, "Ahrarov", "99 999 99 99" },
                    { 5, 22, "avaz@gmail.com", "Avaz", 2, "Davlatov", "99 999 99 99" },
                    { 8, 21, "abdurahmon@gmail.com", "Abdurahmon", 2, "Zafarov", "99 999 99 99" },
                    { 13, 22, "tohirov@gmail.com", "Tohir", 1, "Tohirov", "99 999 99 99" },
                    { 10, 21, "obid@gmail.com", "Obid", 1, "Obidov", "99 999 99 99" },
                    { 7, 19, "usmon@gmail.com", "Usmon", 1, "Qodirov", "99 999 99 99" },
                    { 4, 20, "asad@gmail.com", "Orip", 1, "Yuldashev", "99 999 99 99" },
                    { 2, 22, "muboshir@gmail.com", "Muboshshir", 2, "Fozilov", "99 999 99 99" }
                });

            migrationBuilder.InsertData(
                table: "Teachers",
                columns: new[] { "Id", "Department", "Experience", "FirstName", "GroupId", "LastName" },
                values: new object[,]
                {
                    { 2, "Education", 9, "Javohir", 1, "Buzrukov" },
                    { 5, "Education", 9, "Davron", 3, "Yusupov" },
                    { 1, "Education", 9, "Muhammadkarim", 1, "To'xtaboyev" },
                    { 3, "Education", 9, "O'tkirbek", 2, "Sobirov" },
                    { 4, "Education", 9, "Abduvohid", 2, "Karimov" },
                    { 6, "Education", 9, "Tohir", 3, "Fozilov" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SubjectTeachers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Teachers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Groups",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
