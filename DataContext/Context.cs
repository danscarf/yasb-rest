using System.Data.Entity;

namespace Rest
{
    public class DataContext : DbContext
    {
        //public DataContext () : base()
        //{ }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
