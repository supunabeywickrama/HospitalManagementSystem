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
            string password = txtPassword.Text.Trim();

            // Use parameterized query to prevent SQL injection
            string query = "SELECT * FROM Users_1 WHERE Username = @username AND Password = @password";
            SqlParameter[] parameters = new SqlParameter[]
            {
                    new SqlParameter("@username", username),
                    new SqlParameter("@password", password)
            };
            DataTable result = DatabaseHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count > 0)
            {
               // MessageBox.Show("Login successful!", "Success");
                // Navigate to dashboard or home form
                DashboardForm dashboard = new DashboardForm();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed");
            }
        }
    }
}
