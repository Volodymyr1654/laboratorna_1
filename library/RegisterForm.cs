using Library.Models;

namespace Library
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        public User RegisteredUser { get; private set; }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            var newUser = new User
            {
                Id = Guid.NewGuid().ToString(),
                FirstName = tbRegisterFirstName.Text,
                LastName = tbRegisterLastName.Text,
                Email = tbRegisterEmail.Text,
                Password = tbRegisterPassword.Text,
                Role = "User"
            };
            var users = DataStorage.LoadUsers();

            if (users.Any(u => u.Email == tbRegisterEmail.Text))
            {
                MessageBox.Show("Ця пошта вже використовується.");
                return;
            }

            users.Add(newUser);
            DataStorage.SaveUsers(users);

            //RegisteredUser = newUser;
            DialogResult = DialogResult.OK;
            Close();
        }

        
    }

}
