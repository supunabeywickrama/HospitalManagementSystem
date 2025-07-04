using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class DoctorsForm : Form
    {
        public DoctorsForm()
        {
            InitializeComponent();
        }

        private void DoctorsForm_Load(object sender, EventArgs e)
        {
            LoadDoctors();
        }

        private void LoadDoctors()
        {
            string query = "SELECT * FROM Doctors";
            SqlParameter[] parameters = new SqlParameter[0];
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);
            dataGridViewDoctors.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string specialty = txtSpecialty.Text;
                string contact = txtContact.Text;

                string query = "INSERT INTO Doctors (Name, Specialty, Contact) VALUES (@Name, @Specialty, @Contact)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@Name", name),
                    new SqlParameter("@Specialty", specialty),
                    new SqlParameter("@Contact", contact)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Doctor added successfully.");
                LoadDoctors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.CurrentRow == null) return;

            int doctorId = Convert.ToInt32(dataGridViewDoctors.CurrentRow.Cells["DoctorID"].Value);
            string name = txtName.Text;
            string specialty = txtSpecialty.Text;
            string contact = txtContact.Text;

            string query = "UPDATE Doctors SET Name=@Name, Specialty=@Specialty, Contact=@Contact WHERE DoctorID=@DoctorID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Specialty", specialty),
                new SqlParameter("@Contact", contact),
                new SqlParameter("@DoctorID", doctorId)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Doctor updated successfully.");
            LoadDoctors();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewDoctors.CurrentRow == null) return;

            int doctorId = Convert.ToInt32(dataGridViewDoctors.CurrentRow.Cells["DoctorID"].Value);

            string query = "DELETE FROM Doctors WHERE DoctorID=@DoctorID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@DoctorID", doctorId)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Doctor deleted.");
            LoadDoctors();
        }

        private void dataGridViewDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewDoctors.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtSpecialty.Text = row.Cells["Specialty"].Value.ToString();
                txtContact.Text = row.Cells["Contact"].Value.ToString();
            }
        }
    }
}
