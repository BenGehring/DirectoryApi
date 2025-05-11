using Directory.Dto;
using Microsoft.EntityFrameworkCore;

namespace Directory.Data;
public class ListingsContext : DbContext
{
    public DbSet<Listing> Listings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ListingsDatabase");
    }
}
