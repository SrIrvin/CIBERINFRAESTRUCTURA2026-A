using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

using CIBERINFRAESTRUCTURA.Services;
using CIBERINFRAESTRUCTURA.Models;

namespace CIBERINFRAESTRUCTURA.UI
{
    public partial class DatabaseConfigForm : Form
    {
        private readonly IPersonalService _personalService;
        private string _connectionString = "";

        public DatabaseConfigForm()
        {
            // Inyección de dependencia (SOLID - DIP)
            _personalService = new MySqlPersonalService();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            _connectionString = $"Server={txtServer.Text};Database={txtDatabase.Text};Uid={txtUser.Text};Pwd={txtPassword.Text};";
            
            try
            {
                // 1. Intentar cargar los datos
                List<Personal> listaPersonal = _personalService.GetAll(_connectionString);
                
                // 2. Mostrar en el Grid
                dgvPersonal.DataSource = listaPersonal;
                
                // 3. Habilitar navegación
                btnContinue.Enabled = true;
                btnContinue.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
                btnContinue.ForeColor = System.Drawing.Color.White;
                
                MessageBox.Show("Conexión exitosa y datos cargados.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnContinue.Enabled = false;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            IAuthenticationService authService = new MySqlAuthenticationService();
            Form1 loginForm = new Form1(authService);
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
