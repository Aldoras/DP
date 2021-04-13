using Microsoft.EntityFrameworkCore;
using Reader.Entity;

namespace Reader.Data
{
    
    public class DataContext : DbContext
    {
           public DataContext()
    {
    }

      protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<Tag>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)  {
            string constr = Utility.GetConnectionString("ConnectionStrings:DefaultConnection");
            string path = System.IO.Directory.GetCurrentDirectory();
            constr = constr.Replace("=", "=" + path + "\\");
            optionsBuilder.UseSqlite(constr);
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tag> Tags {get;set;}
    }

}