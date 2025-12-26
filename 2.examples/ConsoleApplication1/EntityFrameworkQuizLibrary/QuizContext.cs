using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkQuizLibrary
{
    public class QuizContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=server.softech.cloud;database=Quiz;user=developer;password=123456789;Encrypt=True;TrustServerCertificate=True;");
        }
    }
}
