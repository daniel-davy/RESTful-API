using Microsoft.EntityFrameworkCore;

namespace HotelAPI.Data
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
               new Country()
               {
                   Id = 1,
                   Name = "Ukraine",
                   ShortName = "UA",
               },
               new Country()
               {
                   Id = 2,
                   Name = "USA",
                   ShortName = "US",
               },
               new Country()
               {
                   Id = 3,
                   Name = "Japan",
                   ShortName = "JP",
               }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    Id = 1,
                    Name = "Bukovina",
                    Address = "Lviv",
                    Rating = 4,
                    CountryId = 1,
                },
                new Hotel()
                {
                    Id = 2,
                    Name = "Saint Resort",
                    Address = "LA",
                    Rating = 5,
                    CountryId = 2,
                },
                new Hotel()
                {
                    Id = 3,
                    Name = "Kaguya SPA",
                    Address = "Kioto",
                    Rating = 4.5,
                    CountryId = 3,
                }
             );
        }
    }
}
