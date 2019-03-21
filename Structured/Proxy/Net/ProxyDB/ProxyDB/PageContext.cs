using System.Data.Entity;

namespace ProxyDB
{
    class PageContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
    }

}
