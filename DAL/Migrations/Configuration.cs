namespace DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Models.AdoptionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.Models.AdoptionContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*Random random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                context.Users.AddOrUpdate(new DAL.Models.User
                {
                    Uname = "User-" + i,
                    Name = Guid.NewGuid().ToString().Substring(0, 15),
                    Password = Guid.NewGuid().ToString("N").Substring(0, 10),
                    type = "General"
                });
            }

            context.SaveChanges();

            string[] species = { "Dog", "Cat", "Rabbit", "Bird", "Hamster" };
            string[] breeds = { "Labrador", "Persian Cat", "Golden Retriever", "Siamese Cat", "Holland Lop", "Canary", "Syrian Hamster", "Bulldog" };
            string[] genders = { "Male", "Female" };
            string[] statuses = { "Available", "Adopted", "Pending", "Medical Care" };

            for (int i = 1; i <= 25; i++)
            {
                context.Pets.AddOrUpdate(new DAL.Models.Pet
                {
                    Id = i,
                    Name = "Pet-" + i,
                    Species = species[random.Next(species.Length)],
                    Breed = breeds[random.Next(breeds.Length)],
                    Gender = genders[random.Next(genders.Length)],
                    Description = "Desc for Pet-" + i + " - " + Guid.NewGuid().ToString("N").Substring(0, 15),
                    Status = statuses[random.Next(statuses.Length)],
                    CreatedAt = DateTime.Now.AddDays(-random.Next(0, 365)).ToString("yyyy-MM-dd"),
                });
            }

            context.SaveChanges();

            string[] appStatuses = { "Submitted", "Under Review", "Approved", "Rejected", "Completed" };

            for (int i = 1; i <= 30; i++)
            {
                DateTime appDate = DateTime.Now.AddDays(-random.Next(0, 60));
                context.AdoptionApplication.AddOrUpdate(new DAL.Models.AdoptionApplication
                {
                    Id = i,
                    Applicationdate = appDate,
                    PetId = random.Next(1, 26),
                    ApplicationStatus = appStatuses[random.Next(appStatuses.Length)],
                    ReviewDate = appDate.AddDays(random.Next(1, 14)),
                    Notes = "Note for Pet-" + i + " - " + Guid.NewGuid().ToString("N").Substring(0, 20)
                });
            }

            context.SaveChanges();

            for (int i = 1; i <= 20; i++)
            {
                context.ApplicationHistories.AddOrUpdate(new DAL.Models.ApplicationHistory
                {
                    HistoryId = i,
                    ApplicationId = random.Next(1, 31),
                    ApplicationStatus = appStatuses[random.Next(appStatuses.Length)],
                    ChangedBy = random.Next(1, 11),
                    ChangedAt = DateTime.Now.AddDays(-random.Next(0, 30))
                });
            }

            context.SaveChanges();
            */
        }
    }
}
