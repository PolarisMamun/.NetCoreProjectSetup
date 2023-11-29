//Here will learn how to setup EntityFramework in our project

//1. First we need to download NuGet package
//a. Microsoft.EntityFrameworkCore.SqlServer
//b. Microsoft.EntityFrameworkCore.Tools
//c. also need to download Microsoft.EntityFrameworkCore.Design since Design already downloaded with Tools then no need to download again

//2. Next need to set the connectionString configuration in appsettings.json file 
"ConnectionStrings": {
    "HotelListingDbConnectionString": "Server = LENEVOTHINKPAD\\SQLEXPRESS;Database=HotelListingAPIDb1;Trusted_Connection=True;MultipleActiveResultSets=True"
  },
//3. Next in program.cs file need to add the connectionstring also need to create a class for DbContext
var connectionString = builder.Configuration.GetConnectionString("HotelListingDbConnectionString");
builder.Services.AddDbContext<HotelListingDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

///class DbContext
      public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options) //inhareat from options
        {
                
        }
    }
