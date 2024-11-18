using System;
using System.Security.Cryptography;
using System.Text;

namespace StudentHousing
{
    internal class User
    {
        public string Id { get; private set; }
        public bool IsAdmin { get; private set; } 
        public string? Name { get; private set; } 
        public string UserName { get; private set; } 
        public string PasswordHash { get; private set; } 

        public User(bool isAdmin, string name, string userName, string password)
        {
            Id = Guid.NewGuid().ToString();
            IsAdmin = isAdmin;
            Name = name;
            UserName = userName;
            PasswordHash = HashPassword(password);
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

    }
}
