namespace Library
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbLoginFirstName = new TextBox();
            tbLoginLastName = new TextBox();
            tbLoginPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // tbLoginFirstName
            // 
            tbLoginFirstName.Location = new Point(100, 28);
            tbLoginFirstName.Name = "tbLoginFirstName";
            tbLoginFirstName.Size = new Size(100, 23);
            tbLoginFirstName.TabIndex = 0;
            // 
            // tbLoginLastName
            // 
            tbLoginLastName.Location = new Point(100, 57);
            tbLoginLastName.Name = "tbLoginLastName";
            tbLoginLastName.Size = new Size(100, 23);
            tbLoginLastName.TabIndex = 1;
            // 
            // tbLoginPassword
            // 
            tbLoginPassword.Location = new Point(100, 86);
            tbLoginPassword.Name = "tbLoginPassword";
            tbLoginPassword.Size = new Size(100, 23);
            tbLoginPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(100, 115);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Увійти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 4;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 65);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Прізвище";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 94);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 191);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(tbLoginPassword);
            Controls.Add(tbLoginLastName);
            Controls.Add(tbLoginFirstName);
            MaximumSize = new Size(260, 230);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLoginFirstName;
        private TextBox tbLoginLastName;
        private TextBox tbLoginPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}