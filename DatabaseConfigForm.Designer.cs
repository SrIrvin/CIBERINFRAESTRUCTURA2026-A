namespace CIBERINFRAESTRUCTURA
{
    partial class DatabaseConfigForm
    {
        private System.ComponentModel.IContainer components = null;

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
            pnlMain = new TableLayoutPanel();
            lblTitle = new Label();
            txtServer = new TextBox();
            txtDatabase = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnConnect = new Button();
            btnContinue = new Button();
            dgvPersonal = new DataGridView();
            pnlMain.SuspendLayout();
            pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.ColumnCount = 1;
            pnlMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnlMain.Controls.Add(lblTitle, 0, 0);
            pnlMain.Controls.Add(txtServer, 0, 1);
            pnlMain.Controls.Add(txtDatabase, 0, 2);
            pnlMain.Controls.Add(txtUser, 0, 3);
            pnlMain.Controls.Add(txtPassword, 0, 4);
            pnlMain.Controls.Add(pnlButtons, 0, 5);
            pnlMain.Controls.Add(dgvPersonal, 0, 6);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(29, 33);
            pnlMain.Margin = new Padding(4, 5, 4, 5);
            pnlMain.Name = "pnlMain";
            pnlMain.RowCount = 7;
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 58F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            pnlMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlMain.Size = new Size(1085, 934);
            pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 122, 204);
            lblTitle.Location = new Point(4, 0);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(299, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Configuración y Datos";
            // 
            // txtServer
            // 
            txtServer.BackColor = Color.FromArgb(45, 45, 48);
            txtServer.BorderStyle = BorderStyle.FixedSingle;
            txtServer.Dock = DockStyle.Fill;
            txtServer.ForeColor = Color.White;
            txtServer.Location = new Point(4, 72);
            txtServer.Margin = new Padding(4, 5, 4, 5);
            txtServer.Name = "txtServer";
            txtServer.PlaceholderText = "Servidor";
            txtServer.Size = new Size(1077, 31);
            txtServer.TabIndex = 1;
            txtServer.Text = "localhost";
            // 
            // txtDatabase
            // 
            txtDatabase.BackColor = Color.FromArgb(45, 45, 48);
            txtDatabase.BorderStyle = BorderStyle.FixedSingle;
            txtDatabase.Dock = DockStyle.Fill;
            txtDatabase.ForeColor = Color.White;
            txtDatabase.Location = new Point(4, 130);
            txtDatabase.Margin = new Padding(4, 5, 4, 5);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.PlaceholderText = "Base de Datos";
            txtDatabase.Size = new Size(1077, 31);
            txtDatabase.TabIndex = 2;
            txtDatabase.Text = "mydb";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(45, 45, 48);
            txtUser.BorderStyle = BorderStyle.FixedSingle;
            txtUser.Dock = DockStyle.Fill;
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(4, 188);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.PlaceholderText = "Usuario";
            txtUser.Size = new Size(1077, 31);
            txtUser.TabIndex = 3;
            txtUser.Text = "adm1N";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(45, 45, 48);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(4, 246);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(1077, 31);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "w5GR3B635ft7DfHroRPMmU6K5hblS9Z6H1dZiVm6jhbKdDegJS48oP08TszEH9w3";
            // 
            // pnlButtons
            // 
            pnlButtons.Controls.Add(btnConnect);
            pnlButtons.Controls.Add(btnContinue);
            pnlButtons.Dock = DockStyle.Fill;
            pnlButtons.Location = new Point(4, 304);
            pnlButtons.Margin = new Padding(4, 5, 4, 5);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(1077, 73);
            pnlButtons.TabIndex = 5;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.FromArgb(0, 122, 204);
            btnConnect.FlatAppearance.BorderSize = 0;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(4, 5);
            btnConnect.Margin = new Padding(4, 5, 4, 5);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(214, 58);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Conectar y Cargar";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnContinue
            // 
            btnContinue.BackColor = Color.FromArgb(40, 40, 40);
            btnContinue.Enabled = false;
            btnContinue.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            btnContinue.FlatStyle = FlatStyle.Flat;
            btnContinue.ForeColor = Color.FromArgb(0, 122, 204);
            btnContinue.Location = new Point(226, 5);
            btnContinue.Margin = new Padding(4, 5, 4, 5);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(186, 58);
            btnContinue.TabIndex = 1;
            btnContinue.Text = "Ir al Login";
            btnContinue.UseVisualStyleBackColor = false;
            btnContinue.Click += btnContinue_Click;
            // 
            // dgvPersonal
            // 
            dgvPersonal.AllowUserToAddRows = false;
            dgvPersonal.BackgroundColor = Color.FromArgb(30, 30, 30);
            dgvPersonal.BorderStyle = BorderStyle.None;
            dgvPersonal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonal.Dock = DockStyle.Fill;
            dgvPersonal.EnableHeadersVisualStyles = false;
            dgvPersonal.GridColor = Color.FromArgb(63, 63, 70);
            dgvPersonal.Location = new Point(4, 387);
            dgvPersonal.Margin = new Padding(4, 5, 4, 5);
            dgvPersonal.Name = "dgvPersonal";
            dgvPersonal.ReadOnly = true;
            dgvPersonal.RowHeadersVisible = false;
            dgvPersonal.RowHeadersWidth = 62;
            dgvPersonal.Size = new Size(1077, 542);
            dgvPersonal.TabIndex = 6;
            // 
            // DatabaseConfigForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1143, 1000);
            Controls.Add(pnlMain);
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(848, 796);
            Name = "DatabaseConfigForm";
            Padding = new Padding(29, 33, 29, 33);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Personal - Ciberinfraestructura";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonal).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.DataGridView dgvPersonal;
    }
}
