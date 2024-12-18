using Microsoft.EntityFrameworkCore;
using ProjektPortfolio_sr1630.Models;

namespace ProjektPortfolio_sr1630.DAL
{
	public class ProjectsContext : DbContext
	{
        public DbSet<Project> Projects { get; set; }
        public ProjectsContext(DbContextOptions options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			List<Project> projects = new List<Project>
		{
			new Project
			{
				Id = 1,
				Name = "Personal Portfolio",
				Pic = "https://picsum.photos/200/300?random=11",
				Desc = "A responsive personal portfolio website showcasing skills and projects.",
				Technologies = "HTML, CSS, JavaScript, Bootstrap"
			},
			new Project
			{
				Id = 2,
				Name = "Task Tracker",
				Pic = "https://picsum.photos/200/300?random=12",
				Desc = "An application for task management with notifications and reporting.",
				Technologies = "C#, .NET Core, SQL Server"
			},
			new Project
			{
				Id = 3,
				Name = "Online Store",
				Pic = "https://picsum.photos/200/300?random=13",
				Desc = "E-commerce platform for browsing and purchasing products.",
				Technologies = "React, Node.js, Express, MongoDB"
			},
			new Project
			{
				Id = 4,
				Name = "Blogging CMS",
				Pic = "https://picsum.photos/200/300?random=14",
				Desc = "A content management system for creating and managing blog posts.",
				Technologies = "PHP, Laravel, MySQL, TailwindCSS"
			},
			new Project
			{
				Id = 5,
				Name = "Weather App",
				Pic = "https://picsum.photos/200/300?random=15",
				Desc = "A weather forecasting app using OpenWeatherMap API.",
				Technologies = "JavaScript, Vue.js, CSS"
			},
			new Project
			{
				Id = 6,
				Name = "Quiz Application",
				Pic = "https://picsum.photos/200/300?random=16",
				Desc = "A quiz system with scoring and detailed result reports.",
				Technologies = "Python, Flask, PostgreSQL"
			},
			new Project
			{
				Id = 7,
				Name = "Chat Platform",
				Pic = "https://picsum.photos/200/300?random=17",
				Desc = "Real-time chat application with group chat functionality.",
				Technologies = "JavaScript, Socket.IO, Node.js"
			},
			new Project
			{
				Id = 8,
				Name = "Expense Tracker",
				Pic = "https://picsum.photos/200/300?random=18",
				Desc = "A personal finance management tool with budget planning.",
				Technologies = "Java, Spring Boot, Hibernate, MySQL"
			},
			new Project
			{
				Id = 9,
				Name = "Recipe App",
				Pic = "https://picsum.photos/200/300?random=19",
				Desc = "An app for browsing and saving cooking recipes.",
				Technologies = "Kotlin, Android Studio, Firebase"
			},
			new Project
			{
				Id = 10,
				Name = "3D Art Viewer",
				Pic = "https://picsum.photos/200/300?random=20",
				Desc = "A 3D viewer application for showcasing digital artwork.",
				Technologies = "C#, Unity, Blender"
			}
		};

			modelBuilder.Entity<Project>().HasData(projects);
		}
	}
}
