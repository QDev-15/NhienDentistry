using Microsoft.AspNetCore.Identity;
using NhienDentistry.DataBase.Entities;

namespace NhienDentistry.DataBase.Helper
{
    public static class Common
    {
        public static string HashPassword(string password)
        {
            var hasher = new PasswordHasher<object>(); // Use object because it needs a class type, but it won't be used.
            var hashedPassword = hasher.HashPassword(null, password); // null is for the user object, since we are not using it here
            return hashedPassword;
        }
        public static async Task<bool> VerifyPassword(UserManager<AppUser> userManager, AppUser user, string enteredPassword)
        {
            var result = await userManager.CheckPasswordAsync(user, enteredPassword);
            return result; // Returns true if the password is correct, false otherwise
        }
    }
}
