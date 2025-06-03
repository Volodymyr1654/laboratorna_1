using Library.Models;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace Library
{
    public partial class MainForm : Form
    {
        private List<Book> books = new List<Book>();
        private List<User> users = new List<User>();
        private List<Rental> rentals = new List<Rental>();

        private User? currentUser = null;

        public MainForm(User user)
        {

            InitializeComponent();
            books = DataStorage.LoadBooks();
            users = DataStorage.LoadUsers();
            rentals = DataStorage.LoadRentals();

            currentUser = new User { Role = "Guest" }; ;

            LoadBooksGrid();
            LoadUsersGrid();
            LoadRentalsGrid();
            ApplyGuestMode();
        }
        
        private void ApplyGuestMode()
        {
            btnLoginMain.Visible = true;
            btnRegisterMain.Visible = true;
            tabLib.TabPages.Clear();
            tabLib.TabPages.Add(tabPageBooks);
            btnAddBook.Visible = false;
            btnEditBook.Visible = false;
            btnDeleteBook.Visible = false;

        }
        private void ApplyUserPermissions()
        {
            btnLoginMain.Visible = false;
            btnRegisterMain.Visible = false;

            if (currentUser.Role == "User")
            {
                tabLib.TabPages.Add(tabPageRentals);
                tabLib.TabPages.Add(tabPageUsers);
                btnAddUser.Visible = false;
                btnEditUser.Visible = false;
                btnDeleteUser.Visible = false;
                btnDeleteRental.Visible = false;
            }
            else if (currentUser.Role == "Admin")
            {
                tabLib.TabPages.Add(tabPageUsers);
                tabLib.TabPages.Add(tabPageRentals);
                btnAddBook.Visible = true;
                btnEditBook.Visible = true;
                btnDeleteBook.Visible = true;
                btnDeleteRental.Visible = true;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            currentUser = new User { Role = "Guest" };
            LoadFilterOptions();
        }
        private void btnLoginMain_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                currentUser = loginForm.LoggedInUser;
                ApplyUserPermissions();
            }
        }
        private void btnRegisterMain_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            if (registerForm.ShowDialog() == DialogResult.OK)
            {
                currentUser = registerForm.RegisteredUser;
                MessageBox.Show("Реєстрація успішна! Увійдіть.");
                LoadUsersList();
            }  
        }
        public void LoadUsersList()
        {
            users = DataStorage.LoadUsers(); 
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = users;
        }
        private void LoadBooksGrid()
        {
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = books;
        }
        private void LoadUsersGrid()
        {
            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = users;  
        }
        private void LoadRentalsGrid()
        {
            var displayRentalsList = rentals.Select(r => new
            {
                RentId =r.Id,
                BookTitle = books.FirstOrDefault(b => b.Id == r.Book.Id)?.Title ?? "невідомо",
                UserName = users.FirstOrDefault(u => u.Id == r.User.Id)?.FullName ?? "невідомо",
                Start = r.StartDate.ToShortDateString(),
                Returned = r.ReturnDate.HasValue ? r.ReturnDate.Value.ToShortDateString() : "ще не повернено"
            }).ToList();

            dataGridViewRentals.DataSource = displayRentalsList;
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title = Interaction.InputBox("Введіть назву книги:", "Нова книга");
            if (string.IsNullOrWhiteSpace(title)) return;

            string author = Interaction.InputBox("Введіть автора:", "Нова книга");
            if (string.IsNullOrWhiteSpace(author)) return;

            string year = Interaction.InputBox("Введіть рік видання:", "Нова книга");
            if (string.IsNullOrWhiteSpace(year)) return;

            string genre = Interaction.InputBox("Введіть жанр:", "Нова книга");
            if (string.IsNullOrWhiteSpace(genre)) return;

            Book newBook = new Book
            {
                Id = Guid.NewGuid().ToString(),
                Title = title,
                Author = author,
                Year = year,
                Genre = genre
            };

            books.Add(newBook);
            LoadBooksGrid();
            DataStorage.SaveBooks(books);
        }
        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow == null)
            {
                MessageBox.Show("Будь ласка, виберіть книгу для редагування.");
                return;
            }
            Book selectedBook = (Book)dataGridViewBooks.CurrentRow.DataBoundItem;

            string newTitle = Interaction.InputBox("Змініть назву:", "Редагування", selectedBook.Title);
            if (string.IsNullOrWhiteSpace(newTitle)) return;

            string newAuthor = Interaction.InputBox("Змініть автора:", "Редагування", selectedBook.Author);
            if (string.IsNullOrWhiteSpace(newAuthor)) return;

            string newYear = Interaction.InputBox("Змініть рік видання:", "Редагування", selectedBook.Title);
            if (string.IsNullOrWhiteSpace(newYear)) return;

            string newGenre = Interaction.InputBox("Змініть жанр:", "Редагування", selectedBook.Title);
            if (string.IsNullOrWhiteSpace(newGenre)) return;

            selectedBook.Title = newTitle;
            selectedBook.Author = newAuthor;
            selectedBook.Year = newYear;
            selectedBook.Genre = newGenre;

            LoadBooksGrid();
            DataStorage.SaveBooks(books);
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewBooks.CurrentRow == null)
            {
                MessageBox.Show("Будь ласка, виберіть книгу для видалення.");
                return;
            }
            if (dataGridViewBooks.CurrentRow != null)
            {
                Book selectedBook = (Book)dataGridViewBooks.CurrentRow.DataBoundItem;
                books.Remove(selectedBook);
                LoadBooksGrid();
                DataStorage.SaveBooks(books);
            }
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string firstName = Interaction.InputBox("Введіть ім’я користувача:", "Новий користувач");
            if (string.IsNullOrWhiteSpace(firstName)) return;

            string lastName = Interaction.InputBox("Введіть прізвище користувача:", "Новий користувач");
            if (string.IsNullOrWhiteSpace(lastName)) return;

            string email = Interaction.InputBox("Введіть e-mail:", "Новий e-mail");
            if (string.IsNullOrWhiteSpace(email)) return;

            User newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = firstName,
                LastName = lastName,
                Email = email
            };

            users.Add(newUser);
            LoadUsersGrid();
            DataStorage.SaveUsers(users);
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Будь ласка, виберіть користувача для редагування.");
                return;
            }

            User selectedUser = (User)dataGridViewUsers.CurrentRow.DataBoundItem;

            string newfirstName = Interaction.InputBox("Змініть ім'я:", "Редагування", selectedUser.FirstName);
            if (string.IsNullOrWhiteSpace(newfirstName)) return;

            string newlastName = Interaction.InputBox("Змініть прізвище:", "Редагування", selectedUser.LastName);
            if (string.IsNullOrWhiteSpace(newlastName)) return;

            string newEmail = Interaction.InputBox("Змініть e-mail:", "Редагування", selectedUser.Email);
            if (string.IsNullOrWhiteSpace(newEmail)) return;

            selectedUser.FirstName = newfirstName;
            selectedUser.LastName = newlastName;
            selectedUser.Email = newEmail;

            LoadUsersGrid();
            DataStorage.SaveUsers(users);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.CurrentRow == null)
            {
                MessageBox.Show("Будь ласка, виберіть користувача для видалення.");
                return;
            }

            if (dataGridViewUsers.CurrentRow != null)
            {
                User selectedUser = (User)dataGridViewUsers.CurrentRow.DataBoundItem;
                users.Remove(selectedUser);
                LoadUsersGrid();
                DataStorage.SaveUsers(users);
            }
        }
        private void btnGiveBook_Click(object sender, EventArgs e)
        {
            if (users.Count == 0 || books.Count == 0)
            {
                MessageBox.Show("Немає книг або користувачів!");
                return;
            }

            string userName = Interaction.InputBox("Введіть ім’я та прізвище користувача:", "Оренда");
            User user = users.FirstOrDefault(u => u.FullName == userName);
            if (user == null) { MessageBox.Show("Користувача не знайдено."); return; }

            string bookTitle = Interaction.InputBox("Введіть назву книги:", "Оренда");
            Book book = books.FirstOrDefault(b => b.Title == bookTitle);
            if (book == null) { MessageBox.Show("Книгу не знайдено."); return; }

            Rental newRental = new Rental
            {
                Id = Guid.NewGuid().ToString(),
                User = user,
                Book = book,
                StartDate = DateTime.Now
            };

            rentals.Add(newRental);
            LoadRentalsGrid();
            DataStorage.SaveRentals(rentals);
        }
        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (dataGridViewRentals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть запис для повернення.");
                return;
            }

            var selectedRow = dataGridViewRentals.SelectedRows[0];
            string rentalId = selectedRow.Cells["RentId"].Value.ToString();

            var rent = rentals.FirstOrDefault(r => r.Id == rentalId);
            if (rent == null)
            {
                MessageBox.Show("Не вдалося знайти запис оренди.");
                return;
            }

            if (rent.ReturnDate != null)
            {
                MessageBox.Show("Книга вже повернена.");
                return;
            }

            rent.ReturnDate = DateTime.Now;
            DataStorage.SaveRentals(rentals);
            LoadRentalsGrid();

            MessageBox.Show("Книгу повернено успішно.");

        }

        private void btnDeleteRental_Click(object sender, EventArgs e)
        {
            if (dataGridViewRentals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Будь ласка, виберіть запис для видалення.");
                return;
            }

            var displayItem = dataGridViewRentals.SelectedRows[0].DataBoundItem;

            string rentId = displayItem.GetType().GetProperty("RentId")?.GetValue(displayItem)?.ToString();

            if (string.IsNullOrEmpty(rentId))
            {
                MessageBox.Show("Не вдалося визначити ID оренди.");
                return;
            }

            var rent = rentals.FirstOrDefault(r => r.Id == rentId);

            if (rent == null)
            {
                MessageBox.Show("Оренду не знайдено.");
                return;
            }

            var confirm = MessageBox.Show("Ви точно хочете видалити цю оренду?", "Підтвердження", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes)
                return;

            rentals.Remove(rent);

            DataStorage.SaveRentals(rentals);    
            LoadRentalsGrid(); 

            MessageBox.Show("Оренду видалено успішно.");
        }
        private void LoadFilterOptions()
        {
            var genres = books.Select(b => b.Genre).Distinct().ToList();
            genres.Insert(0, "Всі");  
            cbGenre.DataSource = genres;

            var authors = books.Select(b => b.Author).Distinct().ToList();
            authors.Insert(0, "Всі");
            cbAuthor.DataSource = authors;
        }
        private void ApplyBookFilter()
        {
            var filteredBooks = books.AsEnumerable();

            // Фильтр по жанру
            if (cbGenre.SelectedItem != null && cbGenre.SelectedItem.ToString() != "Всі")
            {
                string selectedGenre = cbGenre.SelectedItem.ToString();
                filteredBooks = filteredBooks.Where(b => b.Genre == selectedGenre);
            }

            // Фильтр по автору
            if (cbAuthor.SelectedItem != null && cbAuthor.SelectedItem.ToString() != "Всі")
            {
                string selectedAuthor = cbAuthor.SelectedItem.ToString();
                filteredBooks = filteredBooks.Where(b => b.Author == selectedAuthor);
            }
            dataGridViewBooks.DataSource = null;
            dataGridViewBooks.DataSource = filteredBooks.ToList();
        }
        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyBookFilter();
        }
    }
}
