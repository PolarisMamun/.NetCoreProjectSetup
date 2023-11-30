protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Bangladesh",
                    ShortName = "BD"
                },
                new Country
                {
                    Id = 2,
                    Name = "Malaysia",
                    ShortName = "MY"
                },
                new Country
                {
                    Id = 3,
                    Name = "Singapore",
                    ShortName = "SG"
                }
            );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id =1,
                    Name = "Sandals Resort and Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Cpmfort Suites",
                    Address = "George Town",
                    CountryId = 3,
                    Rating = 5.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Grand Palldium",
                    Address = "Nassua",
                    CountryId = 2,
                    Rating = 6.5
                }
           );
        }


//after add the data need to add-migration again and update-database
//add-migration SeededCountriesAndHotels
//update-database
