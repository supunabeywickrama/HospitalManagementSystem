using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SqlClient;

namespace HospitalManagementSystem
{
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void LoadPatients()
        {
            string query = "SELECT * FROM Patients";
            SqlParameter[] parameters = new SqlParameter[0]; // Provide an empty array for the required parameter
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dataGridViewPatients.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = int.Parse(txtAge.Text);
                string gender = cmbGender.SelectedItem?.ToString() ?? "";
                string contact = txtContact.Text;
                string address = txtAddress.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender))
                {
                    MessageBox.Show("Name and Gender are required.");
                    return;
                }

                string query = "INSERT INTO Patients (Name, Age, Gender, Contact, Address) VALUES (@Name, @Age, @Gender, @Contact, @Address)";
                SqlParameter[] parameters = new SqlParameter[]
                {
            new SqlParameter("@Name", name),
            new SqlParameter("@Age", age),
            new SqlParameter("@Gender", gender),
            new SqlParameter("@Contact", contact),
            new SqlParameter("@Address", address)
                };

                int rowsAffected = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Patient added successfully.");
                    LoadPatients();
                }
                else
                {
                    MessageBox.Show("Failed to add patient.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridViewPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewPatients.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtAge.Text = row.Cells["Age"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewPatients.CurrentRow.Cells["PatientID"].Value);
            string name = txtName.Text;
            if (!int.TryParse(txtAge.Text, out int age))
            {
                MessageBox.Show("Please enter a valid numeric age.");
                return;
            }
            string gender = cmbGender.SelectedItem?.ToString() ?? "";
            string contact = txtContact.Text;
            string address = txtAddress.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(gender))
            {
                MessageBox.Show("Name and Gender are required.");
                return;
            }

            string query = "UPDATE Patients SET Name=@Name, Age=@Age, Gender=@Gender, Contact=@Contact, Address=@Address WHERE PatientID=@PatientID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Age", age),
                 new SqlParameter("@Gender", gender),
                new SqlParameter("@Contact", contact),
                new SqlParameter("@Address", address),
                 new SqlParameter("@PatientID", id)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Patient updated");
            LoadPatients();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewPatients.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewPatients.CurrentRow.Cells["PatientID"].Value);
            string query = "DELETE FROM Patients WHERE PatientID=@PatientID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@PatientID", id)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Patient deleted");
            LoadPatients();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
