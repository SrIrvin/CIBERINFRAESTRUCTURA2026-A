namespace CIBERINFRAESTRUCTURA
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private Button btnLogin;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            btnLogin = new Button();
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            lblTitle = new Label();
            SuspendLayout();
            
            // txtUsername
            txtUsername.Location = new Point(140, 80);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(160, 23);
            txtUsername.TabIndex = 0;
            
            // txtPassword
            txtPassword.Location = new Point(140, 120);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(160, 23);
            txtPassword.TabIndex = 1;

            // txtConfirmPassword
            txtConfirmPassword.Location = new Point(140, 160);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(160, 23);
            txtConfirmPassword.TabIndex = 2;
            
            // btnLogin
            btnLogin.Location = new Point(140, 200);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 30);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Validar y Entrar";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            
            // lblUsername
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(30, 83);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(50, 15);
            lblUsername.Text = "Usuario:";
            
            // lblPassword
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(30, 123);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.Text = "Contraseña:";

            // lblConfirmPassword
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(30, 163);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(100, 15);
            lblConfirmPassword.Text = "Confirmar Pass:";
            
            // lblTitle
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(110, 30);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 21);
            lblTitle.Text = "Registro de Sesión";

            // Form1
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 270);
            Controls.Add(lblTitle);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(btnLogin);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Seguro";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
