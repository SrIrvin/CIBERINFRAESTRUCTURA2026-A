namespace CIBERINFRAESTRUCTURA
{
    public partial class Form1 : Form
    {
        private readonly IAuthenticationService _authService;

        public Form1(IAuthenticationService authService)
        {
            _authService = authService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // 1. Validación de campos vacíos
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Validación de Complejidad (Regex)
            if (!_authService.ValidatePasswordComplexity(password))
            {
                MessageBox.Show("La contraseña debe tener: \n- 1 Mayúscula \n- 1 Minúscula \n- 1 Número \n- 1 Símbolo",
                                "Seguridad Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Validación de coincidencia
            if (password != confirmPassword)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si pasa todas las validaciones de las reglas solicitadas:
            MessageBox.Show("La contraseña ha sido validada", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 4. Intento de autenticación final (Lógica del servicio)
            if (_authService.Authenticate(username, password))
            {
                MessageBox.Show($"¡Bienvenido {username}!", "Acceso Concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
