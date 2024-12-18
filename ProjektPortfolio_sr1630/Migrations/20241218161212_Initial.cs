using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjektPortfolio_sr1630.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technologies = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Desc", "Name", "Pic", "Technologies" },
                values: new object[,]
                {
                    { 1, "A responsive personal portfolio website showcasing skills and projects.", "Personal Portfolio", "https://picsum.photos/200/300?random=11", "HTML, CSS, JavaScript, Bootstrap" },
                    { 2, "An application for task management with notifications and reporting.", "Task Tracker", "https://picsum.photos/200/300?random=12", "C#, .NET Core, SQL Server" },
                    { 3, "E-commerce platform for browsing and purchasing products.", "Online Store", "https://picsum.photos/200/300?random=13", "React, Node.js, Express, MongoDB" },
                    { 4, "A content management system for creating and managing blog posts.", "Blogging CMS", "https://picsum.photos/200/300?random=14", "PHP, Laravel, MySQL, TailwindCSS" },
                    { 5, "A weather forecasting app using OpenWeatherMap API.", "Weather App", "https://picsum.photos/200/300?random=15", "JavaScript, Vue.js, CSS" },
                    { 6, "A quiz system with scoring and detailed result reports.", "Quiz Application", "https://picsum.photos/200/300?random=16", "Python, Flask, PostgreSQL" },
                    { 7, "Real-time chat application with group chat functionality.", "Chat Platform", "https://picsum.photos/200/300?random=17", "JavaScript, Socket.IO, Node.js" },
                    { 8, "A personal finance management tool with budget planning.", "Expense Tracker", "https://picsum.photos/200/300?random=18", "Java, Spring Boot, Hibernate, MySQL" },
                    { 9, "An app for browsing and saving cooking recipes.", "Recipe App", "https://picsum.photos/200/300?random=19", "Kotlin, Android Studio, Firebase" },
                    { 10, "A 3D viewer application for showcasing digital artwork.", "3D Art Viewer", "https://picsum.photos/200/300?random=20", "C#, Unity, Blender" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
