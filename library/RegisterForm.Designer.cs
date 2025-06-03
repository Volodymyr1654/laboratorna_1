namespace Library
{
    partial class RegisterForm
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
            tbRegisterPassword = new TextBox();
            tbRegisterEmail = new TextBox();
            tbRegisterLastName = new TextBox();
            tbRegisterFirstName = new TextBox();
            btnRegister = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // tbRegisterPassword
            // 
            tbRegisterPassword.Location = new Point(103, 104);
            tbRegisterPassword.Name = "tbRegisterPassword";
            tbRegisterPassword.Size = new Size(109, 23);
            tbRegisterPassword.TabIndex = 0;
            // 
            // tbRegisterEmail
            // 
            tbRegisterEmail.Location = new Point(103, 75);
            tbRegisterEmail.Name = "tbRegisterEmail";
            tbRegisterEmail.Size = new Size(109, 23);
            tbRegisterEmail.TabIndex = 1;
            // 
            // tbRegisterLastName
            // 
            tbRegisterLastName.Location = new Point(103, 46);
            tbRegisterLastName.Name = "tbRegisterLastName";
            tbRegisterLastName.Size = new Size(109, 23);
            tbRegisterLastName.TabIndex = 2;
            // 
            // tbRegisterFirstName
            // 
            tbRegisterFirstName.Location = new Point(103, 17);
            tbRegisterFirstName.Name = "tbRegisterFirstName";
            tbRegisterFirstName.Size = new Size(109, 23);
            tbRegisterFirstName.TabIndex = 3;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(103, 133);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(109, 23);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 25);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 5;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 54);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 6;
            label2.Text = "Прізвище";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 112);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 7;
            label3.Text = "Пароль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 83);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "E-mail";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 191);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(tbRegisterFirstName);
            Controls.Add(tbRegisterLastName);
            Controls.Add(tbRegisterEmail);
            Controls.Add(tbRegisterPassword);
            MaximumSize = new Size(260, 230);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbRegisterPassword;
        private TextBox tbRegisterEmail;
        private TextBox tbRegisterLastName;
        private TextBox tbRegisterFirstName;
        private Button btnRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}