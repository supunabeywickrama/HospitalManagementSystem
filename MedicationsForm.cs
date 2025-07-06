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
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            int stock;

            // ✅ Validate stock input
            if (!int.TryParse(stocktxt.Text.Trim(), out stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            string query = "INSERT INTO Medications (Name, Description, Stock) VALUES (@Name, @Description, @Stock)";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
                new SqlParameter("@Stock", stock)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Medication added.");
            LoadMedications();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedications.CurrentRow == null)
            {
                MessageBox.Show("Select a medication to update.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewMedications.CurrentRow.Cells["MedicationID"].Value);
            string name = txtName.Text.Trim();
            string description = txtDescription.Text.Trim();
            int stock;

            if (!int.TryParse(stocktxt.Text.Trim(), out stock))
            {
                MessageBox.Show("Please enter a valid stock quantity.");
                return;
            }

            string query = "UPDATE Medications SET Name = @Name, Description = @Description, Stock = @Stock WHERE MedicationID = @MedicationID";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Name", name),
                new SqlParameter("@Description", description),
                new SqlParameter("@Stock", stock),
                new SqlParameter("@MedicationID", id)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Medication updated.");
            LoadMedications();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewMedications.CurrentRow == null)
            {
                MessageBox.Show("Select a medication to delete.");
                return;
            }

            int id = Convert.ToInt32(dataGridViewMedications.CurrentRow.Cells["MedicationID"].Value);

            string query = "DELETE FROM Medications WHERE MedicationID = @MedicationID";
            SqlParameter[] parameters = {
                new SqlParameter("@MedicationID", id)
            };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Medication deleted.");
            LoadMedications();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtDescription.Clear();
            stocktxt.Clear();
        }

        private void dataGridViewMedications_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void lblDescription_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewMedications_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewMedications.Rows[e.RowIndex];
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtDescription.Text = row.Cells["Description"].Value.ToString();
                stocktxt.Text = row.Cells["Stock"].Value.ToString();
            }
        }
    }
}
