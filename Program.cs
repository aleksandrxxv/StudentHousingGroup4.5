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
            //Debug.WriteLine("Tuka");
            //Debug.WriteLine(UserManager.LogIn("john123", "password123").Name);
            //Debug.WriteLine(UserManager.GetUserById("4bfee1bf-c05d-4e9a-948c-7e51c7f36ae6"));
            UserManager.GetUserById("4bfee1bf-c05d-4e9a-948c-7e51c7f36ae6");
            ApplicationConfiguration.Initialize();
            Application.Run(new LogInForm());
        }
    }
}