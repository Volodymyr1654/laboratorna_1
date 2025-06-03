namespace Library
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabLib = new TabControl();
            tabPageBooks = new TabPage();
            label2 = new Label();
            label1 = new Label();
            btnApplyFilter = new Button();
            cbAuthor = new ComboBox();
            cbGenre = new ComboBox();
            btnDeleteBook = new Button();
            btnEditBook = new Button();
            btnAddBook = new Button();
            dataGridViewBooks = new DataGridView();
            tabPageRentals = new TabPage();
            btnDeleteRental = new Button();
            dataGridViewRentals = new DataGridView();
            btnReturnBook = new Button();
            btnGiveBook = new Button();
            tabPageUsers = new TabPage();
            btnDeleteUser = new Button();
            btnEditUser = new Button();
            btnAddUser = new Button();
            dataGridViewUsers = new DataGridView();
            btnLoginMain = new Button();
            btnRegisterMain = new Button();
            lblUserInfo = new Label();
            tabLib.SuspendLayout();
            tabPageBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).BeginInit();
            tabPageRentals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).BeginInit();
            tabPageUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // tabLib
            // 
            tabLib.Controls.Add(tabPageBooks);
            tabLib.Controls.Add(tabPageRentals);
            tabLib.Controls.Add(tabPageUsers);
            tabLib.Location = new Point(12, 33);
            tabLib.Name = "tabLib";
            tabLib.SelectedIndex = 0;
            tabLib.Size = new Size(776, 416);
            tabLib.TabIndex = 0;
            // 
            // tabPageBooks
            // 
            tabPageBooks.Controls.Add(label2);
            tabPageBooks.Controls.Add(label1);
            tabPageBooks.Controls.Add(btnApplyFilter);
            tabPageBooks.Controls.Add(cbAuthor);
            tabPageBooks.Controls.Add(cbGenre);
            tabPageBooks.Controls.Add(btnDeleteBook);
            tabPageBooks.Controls.Add(btnEditBook);
            tabPageBooks.Controls.Add(btnAddBook);
            tabPageBooks.Controls.Add(dataGridViewBooks);
            tabPageBooks.Location = new Point(4, 24);
            tabPageBooks.Name = "tabPageBooks";
            tabPageBooks.Padding = new Padding(3);
            tabPageBooks.Size = new Size(768, 388);
            tabPageBooks.TabIndex = 0;
            tabPageBooks.Text = "Книги";
            tabPageBooks.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(543, 221);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 10;
            label2.Text = "За автором->";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(543, 192);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 9;
            label1.Text = "За жанром->";
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.Location = new Point(641, 242);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(121, 23);
            btnApplyFilter.TabIndex = 8;
            btnApplyFilter.Text = "Фільтрувати";
            btnApplyFilter.UseVisualStyleBackColor = true;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // cbAuthor
            // 
            cbAuthor.FormattingEnabled = true;
            cbAuthor.Items.AddRange(new object[] { "Джордж Оруел", "Даніель Канеман", "Роберт Грін", "Бодо Шефер", "Макс Кідрук", "Робін Шарма", "Колін Тіппінг", "Віктор Франкл" });
            cbAuthor.Location = new Point(641, 213);
            cbAuthor.Name = "cbAuthor";
            cbAuthor.Size = new Size(121, 23);
            cbAuthor.TabIndex = 7;
            // 
            // cbGenre
            // 
            cbGenre.FormattingEnabled = true;
            cbGenre.Items.AddRange(new object[] { "Психологія", "Саморозвиток", "Трилер", "Проза", "Антиутопія", "Популярно-публіцистичний", "Науково-популярний", "Політична сатира" });
            cbGenre.Location = new Point(641, 184);
            cbGenre.Name = "cbGenre";
            cbGenre.Size = new Size(121, 23);
            cbGenre.TabIndex = 6;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(495, 64);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(154, 23);
            btnDeleteBook.TabIndex = 3;
            btnDeleteBook.Text = "Видалити";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnEditBook
            // 
            btnEditBook.Location = new Point(495, 35);
            btnEditBook.Name = "btnEditBook";
            btnEditBook.Size = new Size(154, 23);
            btnEditBook.TabIndex = 2;
            btnEditBook.Text = "Редагувати";
            btnEditBook.UseVisualStyleBackColor = true;
            btnEditBook.Click += btnEditBook_Click;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(495, 6);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(154, 23);
            btnAddBook.TabIndex = 1;
            btnAddBook.Text = "Додати книгу";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // dataGridViewBooks
            // 
            dataGridViewBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBooks.Location = new Point(0, 0);
            dataGridViewBooks.Name = "dataGridViewBooks";
            dataGridViewBooks.Size = new Size(476, 381);
            dataGridViewBooks.TabIndex = 0;
            // 
            // tabPageRentals
            // 
            tabPageRentals.Controls.Add(btnDeleteRental);
            tabPageRentals.Controls.Add(dataGridViewRentals);
            tabPageRentals.Controls.Add(btnReturnBook);
            tabPageRentals.Controls.Add(btnGiveBook);
            tabPageRentals.Location = new Point(4, 24);
            tabPageRentals.Name = "tabPageRentals";
            tabPageRentals.Padding = new Padding(3);
            tabPageRentals.Size = new Size(768, 388);
            tabPageRentals.TabIndex = 1;
            tabPageRentals.Text = "Оренда";
            tabPageRentals.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRental
            // 
            btnDeleteRental.Location = new Point(575, 109);
            btnDeleteRental.Name = "btnDeleteRental";
            btnDeleteRental.Size = new Size(115, 23);
            btnDeleteRental.TabIndex = 3;
            btnDeleteRental.Text = "Видалити оренду";
            btnDeleteRental.UseVisualStyleBackColor = true;
            btnDeleteRental.Click += btnDeleteRental_Click;
            // 
            // dataGridViewRentals
            // 
            dataGridViewRentals.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRentals.Location = new Point(6, 6);
            dataGridViewRentals.Name = "dataGridViewRentals";
            dataGridViewRentals.Size = new Size(476, 386);
            dataGridViewRentals.TabIndex = 2;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(575, 58);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(115, 23);
            btnReturnBook.TabIndex = 1;
            btnReturnBook.Text = "Повернути книгу";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnGiveBook
            // 
            btnGiveBook.Location = new Point(575, 20);
            btnGiveBook.Name = "btnGiveBook";
            btnGiveBook.Size = new Size(115, 23);
            btnGiveBook.TabIndex = 0;
            btnGiveBook.Text = "Взяти книгу";
            btnGiveBook.UseVisualStyleBackColor = true;
            btnGiveBook.Click += btnGiveBook_Click;
            // 
            // tabPageUsers
            // 
            tabPageUsers.Controls.Add(btnDeleteUser);
            tabPageUsers.Controls.Add(btnEditUser);
            tabPageUsers.Controls.Add(btnAddUser);
            tabPageUsers.Controls.Add(dataGridViewUsers);
            tabPageUsers.Location = new Point(4, 24);
            tabPageUsers.Name = "tabPageUsers";
            tabPageUsers.Size = new Size(768, 388);
            tabPageUsers.TabIndex = 2;
            tabPageUsers.Text = "Користувачі";
            tabPageUsers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(506, 61);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(133, 23);
            btnDeleteUser.TabIndex = 3;
            btnDeleteUser.Text = "Видалити";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnEditUser
            // 
            btnEditUser.Location = new Point(506, 32);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(133, 23);
            btnEditUser.TabIndex = 2;
            btnEditUser.Text = "Редагувати";
            btnEditUser.UseVisualStyleBackColor = true;
            btnEditUser.Click += btnEditUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(506, 3);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(133, 23);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Додати користувача";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(3, 3);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(497, 392);
            dataGridViewUsers.TabIndex = 0;
            // 
            // btnLoginMain
            // 
            btnLoginMain.Location = new Point(492, 4);
            btnLoginMain.Name = "btnLoginMain";
            btnLoginMain.Size = new Size(75, 23);
            btnLoginMain.TabIndex = 1;
            btnLoginMain.Text = "Увійти";
            btnLoginMain.UseVisualStyleBackColor = true;
            btnLoginMain.Click += btnLoginMain_Click;
            // 
            // btnRegisterMain
            // 
            btnRegisterMain.Location = new Point(573, 4);
            btnRegisterMain.Name = "btnRegisterMain";
            btnRegisterMain.Size = new Size(119, 23);
            btnRegisterMain.TabIndex = 2;
            btnRegisterMain.Text = "Зареєструватися";
            btnRegisterMain.UseVisualStyleBackColor = true;
            btnRegisterMain.Click += btnRegisterMain_Click;
            // 
            // lblUserInfo
            // 
            lblUserInfo.AutoSize = true;
            lblUserInfo.Location = new Point(12, 4);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(0, 15);
            lblUserInfo.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(lblUserInfo);
            Controls.Add(btnRegisterMain);
            Controls.Add(btnLoginMain);
            Controls.Add(tabLib);
            MaximumSize = new Size(800, 500);
            Name = "MainForm";
            Text = "MainForm";
            tabLib.ResumeLayout(false);
            tabPageBooks.ResumeLayout(false);
            tabPageBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBooks).EndInit();
            tabPageRentals.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRentals).EndInit();
            tabPageUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabLib;
        private TabPage tabPageBooks;
        private TabPage tabPageRentals;
        private DataGridView dataGridViewBooks;
        private TabPage tabPageUsers;
        private Button btnDeleteBook;
        private Button btnEditBook;
        private Button btnAddBook;
        private Button btnDeleteUser;
        private Button btnEditUser;
        private Button btnAddUser;
        private DataGridView dataGridViewUsers;
        private DataGridView dataGridViewRentals;
        private Button btnReturnBook;
        private Button btnGiveBook;
        private Button btnDeleteRental;
        private Button btnLoginMain;
        private Button btnRegisterMain;
        private Label lblUserInfo;
        private ComboBox cbAuthor;
        private ComboBox cbGenre;
        private Button btnApplyFilter;
        private Label label2;
        private Label label1;
    }
}
