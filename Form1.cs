using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Change this to System.Data.SqlClient to match the SqlParameter type
using BCrypt.Net;

namespace HospitalManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text; // Plain password entered by user

            // Fetch hashed password from DB by username
            string query = "SELECT Password, Role FROM Users WHERE Username = @username";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };

            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
                string storedHashedPassword = result.Rows[0]["Password"].ToString();
                string role = result.Rows[0]["Role"].ToString();

                // Compare entered password with stored hash
                bool passwordMatch = BCrypt.Net.BCrypt.Verify(password, storedHashedPassword);

                if (passwordMatch)
                {
                    MessageBox.Show("Login successful!", "Success");

                    // Navigate to dashboard or based on role
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
