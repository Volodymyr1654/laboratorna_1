using Library.Models;
using System.Text.Json;

namespace Library
{
    public static class DataStorage
    {
        private static string booksFile = "books.json";
        private static string usersFile = "users.json";
        private static string rentalsFile = "rentals.json";

           public static void SaveBooks(List<Book> books)
           {
            string json = JsonSerializer.Serialize(books, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(booksFile, json);
           }

        public static List<Book> LoadBooks()
        {
            if (!File.Exists(booksFile))
                return new List<Book>();

            string json = File.ReadAllText(booksFile);
            if (string.IsNullOrWhiteSpace(json))
                return new List<Book>();

            try
            {
                return JsonSerializer.Deserialize<List<Book>>(json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при читанні books.json: {ex.Message}");
                return new List<Book>();
            }
        }

        public static void SaveUsers(List<User> users)
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(usersFile, json);
        }

        public static List<User> LoadUsers()
        {
            if (!File.Exists(usersFile))
                return new List<User>();

            string json = File.ReadAllText(usersFile);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        public static void SaveRentals(List<Rental> rentals)
        {
            string json = JsonSerializer.Serialize(rentals, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rentalsFile, json);
        }

        public static List<Rental> LoadRentals()
        {
            if (!File.Exists(rentalsFile))
                return new List<Rental>();

            string json = File.ReadAllText(rentalsFile);
            return JsonSerializer.Deserialize<List<Rental>>(json);
        }
    }
}
