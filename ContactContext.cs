using Microsoft.EntityFrameworkCore;

namespace Contact_Manager.Models
{
	public class ContactContext : DbContext
	{
		public ContactContext(DbContextOptions<ContactContext> options) : base(options) { }
		public DbSet<Contact> Contacts { get; set; } = null!;
		public DbSet<Category> Categories { get; set; } = null!;

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Category>().HasData(
				new Category { CategoryId = 1, Name = "Family" },
				new Category { CategoryId = 2, Name = "Friend" },
				new Category { CategoryId = 3, Name = "Work" },
				new Category { CategoryId = 4, Name = "Other" }
				);

			modelBuilder.Entity<Category>().HasData(
				new Contact
				{
					ContactId = 1,
					Firstname = "Mary Ellen",
					Lastname = "Walton",
					Phone = "555-333-2211",
					Email = "MaryEllenWalton@yahoo.com",
					CategoryId = 1,
					DateAdded = DateTime.Now
				},

				new Contact
				{
					ContactId = 2,
					Firstname = "Joe",
					Lastname = "Schmuckatelly",
					Phone = "555-123-4567",
					Email = "JSchmuck@yahoo.com",
					CategoryId = 2,
					DateAdded = DateTime.Now
				},

				new Contact
				{
					ContactId = 3,
					Firstname = "Dana",
					Lastname = "McGee",
					Phone = "555-867-5309",
					Email = "McGee83@gmail.com",
					CategoryId = 3,
					DateAdded = DateTime.Now
				},

				new Contact
				{
					ContactId = 4,
					Firstname = "Jennifer",
					Lastname = "Perry",
					Phone = "216-645-6291",
					Email = "S00859488@acad.tri-c.edu",
					CategoryId = 4,
					DateAdded = DateTime.Now
				},

				new Contact
				{
					ContactId = 5,
					Firstname = "Johnny",
					Lastname = "FiveAlive",
					Phone = "555-555-5555",
					Email = "NoDisssassembleStephanie@yahoo.com",
					CategoryId = 5,
					DateAdded = DateTime.Now
				}


				);
		}

	}
}
