using Blogy.EntityLayer;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Context
{
	public class BlogyContext : IdentityDbContext<AppUser, AppRole, int>
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=DESKTOP-FCK5R8M\\SQLEXPRESS;initial catalog=DbBlogy;integrated Security=true;");
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Article> Articles { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Tag> Tags { get; set; }
		public DbSet<WriterTable> Writers { get; set; }
		public DbSet<ToDoList> toDoLists { get; set; }
		public DbSet<Notification> notifications { get; set; }
		public DbSet<Browser> browsers { get; set; }
		public DbSet<AdminMessage> adminMessages { get; set; }
		public DbSet<WriterMessage> writerMessages { get; set; }
		public DbSet<LayoutAbout> layoutAbouts { get; set; }
		public DbSet<BlogAboutPictureOrDescription> blogAboutPictureOrDescriptions { get; set; }
		public DbSet<BlogAboutService> blogAboutServices { get; set; }
		public DbSet<BlogAboutBloggerPublishing> blogAboutBloggerPublishings { get; set; }
		public DbSet<BlogSendContact> blogSendContacts { get; set; }

	}
}
