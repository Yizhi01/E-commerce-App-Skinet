using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    // Seed identity data
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Amy",
                    Email = "amy@test.com",
                    UserName = "amy@test.com",
                    Address = new Address
                    {
                        FirstName = "Amy",
                        LastName = "Baker",
                        Street = "10 The Street",
                        City = "Los Angeles",
                        State = "CA",
                        Zipcode = "90001"
                    }
                };

                // Set a complex password
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}