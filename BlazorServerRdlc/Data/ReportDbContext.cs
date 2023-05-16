using Microsoft.EntityFrameworkCore;

namespace BlazorServerRdlc.Data
{
    public class ReportDbContext : DbContext
    {
        public ReportDbContext(DbContextOptions<ReportDbContext> options) : base(options) { }

        //public DbSet<Person> Persons => Set<Person>();
		public DbSet<Person> Persons { get; set; }
		public DbSet<Attachment> Attachments { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>().HasData(
                new Person { Id = 1, Name = "John", LastName = "Smith" },
                new Person { Id = 2, Name = "Michael", LastName = "Jordan" },
                new Person { Id = 3, Name = "Roberto", LastName = "Baggio" },
                new Person { Id = 4, Name = "Trend", LastName = "Riba" },
                new Person { Id = 5, Name = "Samsung", LastName = "Galaxy" }
                );
        }
    }
}
