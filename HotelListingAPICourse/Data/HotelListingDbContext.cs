using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Argentina",
                    ShortName = "ARG"
                },
                new Country
                {
                    Id = 2,
                    Name = "United States",
                    ShortName = "USA"
                },
                new Country
                {
                    Id = 3,
                    Name = "Spain",
                    ShortName = "SPA"
                }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Pullman Hotel",
                    Adress = "Casino Rosario",
                    CountryId = 1,
                    Rating = 4.0
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Maga Hotel",
                    Adress = "George Town",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Islas Hotel",
                    Adress = "Islas Canarias",
                    CountryId = 3,
                    Rating = 5.0
                }
                );
        }
    }
}
