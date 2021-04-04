using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Uganda", ShortName = "UG" },
                new Country { Id = 2, Name = "Kenya", ShortName = "KE" },
                new Country { Id = 3, Name = "Rwanda", ShortName = "RW" },
                new Country { Id = 4, Name = "Ethiopia", ShortName = "ETH" }
                );

            builder.Entity<Hotel>().HasData(
              new Hotel { Id = 1, Name = "Sheraton", Address = "Kampala", CountryID = 1, Rating = 5 },
              new Hotel { Id = 2, Name = "United Kenya Club", Address = "Nairobi", CountryID = 2, Rating = 3 },
              new Hotel { Id = 3, Name = "Imperial Royal", Address = "Kampala", CountryID = 1, Rating = 5 },
              new Hotel { Id = 4, Name = "Six Eighty", Address = "Nairobi", CountryID = 2, Rating = 5 },
              new Hotel { Id = 5, Name = "Washington", Address = "Addis", CountryID = 4, Rating = 3 },
              new Hotel { Id = 6, Name = "Best Western", Address = "Addis", CountryID = 4, Rating = 3 },
              new Hotel { Id = 7, Name = "Okapi", Address = "Kigali", CountryID = 3, Rating = 3 }
              );

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
    }
}
