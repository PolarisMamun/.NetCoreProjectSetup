//Create the class 
//then in DbContext class create property for DbSet
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
                
        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

    }


// in package manager console terminal trigger "add-migration InitialMigration" to add migration after successfully add migration "update-database" to update the db
//add-migration InitialMigration
//update-database
