using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StudentHousing
{
    public class UserManager
    {
        private static readonly string filePath = Path.Combine("..", "..", "..", "Database", "users.json");

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public static User GetUserById(string id)
        {
            try
            {
                Debug.WriteLine("tukaaa");
                Debug.WriteLine(filePath);
                string json = File.ReadAllText(filePath);
                var users = JsonSerializer.Deserialize<List<User>>(json);
                if (users != null)
                {
                    return users.FirstOrDefault(user => user.Id == id);
                }

                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading users: {ex.Message}");
                return null;
            }
        }

        public static User LogIn(string username, string password)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                var users = JsonSerializer.Deserialize<List<User>>(json);
                if (users != null)
                {
                    foreach (var user in users)
                    {
                        if (user.UserName == username && user.PasswordHash.Equals(HashPassword(password)))
                        {
                            
                            return user;
                        }
                    }
                    
                }
                Debug.WriteLine("Izliza 2");
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading users: {ex.Message}");
                Debug.WriteLine("Izliza 3");
                return null;
            }

        }

    }

}
