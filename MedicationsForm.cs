using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class MedicationsForm : Form
    {
        public MedicationsForm()
        {
            InitializeComponent();

        }

        private void MedicationsForm_Load(object sender, EventArgs e)
        {
            LoadMedications();
        }

        private void LoadMedications()
        {
            string query = "SELECT * FROM Medications";
            DataTable dt = DatabaseHelper.ExecuteQuery(query, null);
            dataGridViewMedications.DataSource = dt;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;

            string query = "INSERT INTO Medications (Name, Description) VALUES (@Name, @Description)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Medication added.");
            LoadMedications();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedications.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewMedications.CurrentRow.Cells["MedicationID"].Value);
            string name = txtName.Text;
            string description = txtDescription.Text;

            string query = "UPDATE Medications SET Name = @Name, Description = @Description WHERE MedicationID = @MedicationID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
                new SqlParameter("@MedicationID", id)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Medication updated.");
            LoadMedications();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedications.CurrentRow == null) return;

            int id = Convert.ToInt32(dataGridViewMedications.CurrentRow.Cells["MedicationID"].Value);

            string query = "DELETE FROM Medications WHERE MedicationID = @MedicationID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MedicationID", id)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Medication deleted.");
            LoadMedications();
        }

        private void dataGridViewMedications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMedications.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
            }
        }
    }
}
