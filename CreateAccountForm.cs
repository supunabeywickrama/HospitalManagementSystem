using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BCrypt.Net;

namespace HospitalManagementSystem
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(confirmPassword) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password); // secure password

            string query = "INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)";
            SqlParameter[] parameters = {
               new SqlParameter("@Username", username),
               new SqlParameter("@Password", hashedPassword),
               new SqlParameter("@Role", role)
             };

            try
            {
                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Account created successfully!");
                Form1 goToLogin = new Form1();
                goToLogin.Show();
                this.Hide();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627) // duplicate username
                    MessageBox.Show("Username already exists.");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
        }
    }
}
