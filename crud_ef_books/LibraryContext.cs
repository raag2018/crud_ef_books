using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace crud_ef_books{
    public class LibraryContext : DbContext{
        public DbSet<Book> Books { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            optionsBuilder.UseSqlServer("Data Source=ROBERT;Initial Catalog=library;User ID=unab;Password=unab;TrustServerCertificate=True");
        }
    }
}
