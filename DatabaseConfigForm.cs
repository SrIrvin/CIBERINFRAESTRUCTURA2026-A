using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace CIBERINFRAESTRUCTURA
{
    public partial class DatabaseConfigForm : Form
    {
        private string _connectionString = "";

        public DatabaseConfigForm()
        {
            InitializeComponent();
            LogMessage("Aplicación iniciada. Esperando configuración de base de datos.");
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _connectionString = $"Server={txtServer.Text};Database={txtDatabase.Text};Uid={txtUser.Text};Pwd={txtPassword.Text};";
            
            LogMessage("Intentando conectar a MySQL...");
            
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    LogMessage("¡Conexión exitosa!");
                    btnContinue.Enabled = true;
                    MessageBox.Show("Conexión establecida correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error de conexión: {ex.Message}");
                btnContinue.Enabled = false;
                MessageBox.Show($"No se pudo conectar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Aquí inyectamos el servicio con la conexión configurada
            // Nota: En una app real, pasaríamos esta string al servicio
            IAuthenticationService authService = new MySqlAuthenticationService();
            
            Form1 loginForm = new Form1(authService);
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void LogMessage(string message)
        {
            dgvLogs.Rows.Add(DateTime.Now.ToLongTimeString(), message);
            // Hacer scroll al final
            dgvLogs.FirstDisplayedScrollingRowIndex = dgvLogs.RowCount - 1;
        }
    }
}
