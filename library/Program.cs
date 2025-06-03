using Library.Models;

namespace Library
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var guestUser = new User
            {
                FirstName = "ó���",
                LastName = "",
                Role = "Guest"
            };
            Application.Run(new MainForm(guestUser));
            

        }
    }
}