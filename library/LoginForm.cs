using Library.Models;

namespace Library
{
    public partial class LoginForm : Form
    {
        public User LoggedInUser { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string firstName = tbLoginFirstName.Text;
            string lastName = tbLoginLastName.Text;
            string password = tbLoginPassword.Text;

            if (firstName == "Admin" && lastName == "Admin" && password == "admin123")
            {
                LoggedInUser = new User
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    Password = "admin123",
                    Role = "Admin"
                };

                DialogResult = DialogResult.OK;
                Close();
                return;
            }

            var users = DataStorage.LoadUsers();
            var user = users.FirstOrDefault(u =>
                u.FirstName == firstName &&
                u.LastName == lastName &&
                u.Password == password);

            if (user != null)
            {
                LoggedInUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Невірні дані");
            }
        }

        
    }
}
