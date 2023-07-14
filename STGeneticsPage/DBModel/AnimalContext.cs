using Microsoft.EntityFrameworkCore;

namespace STGeneticsPage.DBModel
{
    public class AnimalContext : DbContext //call to entity, inheritance
    {
        public DbSet<Animals> AnimalsT { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //method from DbContext
        {
            if (!optionsBuilder.IsConfigured) //if optionsBuilder is not congired yet...
            {
               optionsBuilder.UseSqlServer("Server=SRPIZZA-PC; DataBase=STGDb; User Id=SRPIZZA-PC\nicol ;Trusted_Connection=True; TrustServerCertificate=True ");
            }
        }
        protected override void OnModelCreating(ModelBuilder ModelBuild) //pre charged data
        {
            base.OnModelCreating(ModelBuild);

            ModelBuild.Entity<Animals>().HasData //if there isn´t any data, gonna charge this new data
                (
                    new Animals //new object
                    { 
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "ButterCup",
                        Breed = "Red Angus", 
                        DateOfBirth = new DateTime(2020,2,5), 
                        Sex = "Female", 
                        Price = 4500, 
                        Status = "Active" },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Lola",
                        Breed = "Holstein",
                        DateOfBirth = new DateTime(2022, 4, 6),
                        Sex = "Female",
                        Price = 2000,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Thor",
                        Breed = "Limousin",
                        DateOfBirth = new DateTime(2021, 12, 25),
                        Sex = "Male",
                        Price = 5100,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Delilah",
                        Breed = "Piedmontese",
                        DateOfBirth = new DateTime(2012, 8, 20),
                        Sex = "Female",
                        Price = 2000,
                        Status = "Inactive"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Duke",
                        Breed = "Brahman",
                        DateOfBirth = new DateTime(2020, 5, 12),
                        Sex = "Male",
                        Price = 4600,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Atlas",
                        Breed = "Watusi",
                        DateOfBirth = new DateTime(2014, 7, 25),
                        Sex = "Male",
                        Price = 2300,
                        Status = "Inactive"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Ginger",
                        Breed = "Red Angus",
                        DateOfBirth = new DateTime(2022, 1, 25),
                        Sex = "Female",
                        Price = 2600,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Aurora",
                        Breed = "Charolais",
                        DateOfBirth = new DateTime(2019, 4, 23),
                        Sex = "Female",
                        Price = 6600,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Brutus",
                        Breed = "Simmental",
                        DateOfBirth = new DateTime(2018, 11, 3),
                        Sex = "Male",
                        Price = 6100,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Maverick",
                        Breed = "Hereford",
                        DateOfBirth = new DateTime(2011, 10, 28),
                        Sex = "Male",
                        Price = 1400,
                        Status = "Inactive"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Hazel",
                        Breed = "Gelbvieh",
                        DateOfBirth = new DateTime(2010, 6, 14),
                        Sex = "Female",
                        Price = 900,
                        Status = "Inactive"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Molly",
                        Breed = "Red Angus",
                        DateOfBirth = new DateTime(2020,11, 7),
                        Sex = "Female",
                        Price = 4700,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Titan",
                        Breed = "Watusi",
                        DateOfBirth = new DateTime(2017, 5, 8),
                        Sex = "Male",
                        Price = 6400,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Bella",
                        Breed = "Piedmontese",
                        DateOfBirth = new DateTime(2011, 3, 6),
                        Sex = "Female",
                        Price = 1400,
                        Status = "Inactive"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Maisie",
                        Breed = "Shorthorn",
                        DateOfBirth = new DateTime(2023, 1, 12),
                        Sex = "Female",
                        Price = 2000,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Maximus",
                        Breed = "Gelbvieh",
                        DateOfBirth = new DateTime(2022, 12, 21),
                        Sex = "Male",
                        Price = 3200,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Rocky",
                        Breed = "Simmental",
                        DateOfBirth = new DateTime(2022, 8, 19),
                        Sex = "Male",
                        Price = 3000,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Clover",
                        Breed = "Limousin",
                        DateOfBirth = new DateTime(2021, 7, 3),
                        Sex = "Female",
                        Price = 3800,
                        Status = "Active"
                    },
                    new Animals
                    {
                        AnimalId = Guid.NewGuid().ToString(),
                        Name = "Daisy",
                        Breed = "Red Angus",
                        DateOfBirth = new DateTime(2013, 5, 1),
                        Sex = "Female",
                        Price = 1500,
                        Status = "Inactive"
                    }
                );
        }
    }
}
