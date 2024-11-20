using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;

namespace StudentHousing
{
    public class User
    {
        public string Id { get; private set; }
        public bool IsAdmin { get; private set; } 
        public string Name { get; private set; } 
        public string UserName { get; private set; } 
        public string PasswordHash { get; private set; }

        
        public User(bool isAdmin, string name, string userName, string password)
        {
            Id = Guid.NewGuid().ToString();
            IsAdmin = isAdmin;
            Name = name;
            UserName = userName;
            PasswordHash = UserManager.HashPassword(password);
        }
        public User() { }

        [JsonConstructor]
        public User(string id, bool isAdmin, string? name, string userName, string passwordHash)
        {
            Id = id;
            IsAdmin = isAdmin;
            Name = name;
            UserName = userName;
            PasswordHash = passwordHash;
        }
    }
}
