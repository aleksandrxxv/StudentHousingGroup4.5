using System.Diagnostics;
using System.Text.Json;

namespace StudentHousing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //var users = new List<User>
            //{
            //    new User(false, "John Doe", "john123", "password123"),
            //    new User(true, "Admin User", "admin", "adminpass"),
            //    new User(false, "Jane Smith", "jane123", "securepass")
            //};

            //string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            //Debug.WriteLine("tuka");
            //Debug.WriteLine(json);
            //File.WriteAllText("C:\\Users\\krisy\\Desktop\\StudentHousingGroup4.5\\Database\\users.json", json);
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
        }
    }
}