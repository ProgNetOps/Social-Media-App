using SocialMedia.Data.Models;
using SocialMediaApp.Data.Models;


namespace SocialMediaApp.Data.Helpers;

public static class DbInitializer
{
    public static async Task SeedAsync(AppDbContext appDbContext)
    {
        if (appDbContext.Users.Any() is false &&
            appDbContext.Posts.Any() is false)
        {
            User newUser = new()
            {
                FullName = "John kaka",
                ProfilePictureUrl = "https://img-b.udemycdn.com/user/200_H/16004620_10db_5.jpg"
            };
            await appDbContext.Users.AddAsync(newUser);
            await appDbContext.SaveChangesAsync();

            Post newPostWithoutImage = new()
            {
                Content = "This is the first post, loaded from the database and created with a test user",
                ImageUrl = "",
                NrOfReports = 0,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                UserId = newUser.Id,
            };

            Post newPostWithImage = new()
            {
                Content = "This is the first post, loaded from the database and created with a test user, with an image",
                ImageUrl = "https://unsplash.com/photos/foggy-mountain-summit-1Z2niiBPg5A",
                NrOfReports = 0,
                DateCreated = DateTime.UtcNow,
                DateUpdated = DateTime.UtcNow,
                UserId = newUser.Id,
            };

            await appDbContext.Posts.AddRangeAsync(newPostWithoutImage, newPostWithImage);
            await appDbContext.SaveChangesAsync();
        }
    }
}
