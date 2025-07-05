using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class PrescriptionsForm : Form
    {
        public PrescriptionsForm()
        {
            InitializeComponent();
        }

        private DataTable tempPrescriptionTable;


        private void button2_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(cmbPatient.SelectedValue);
            int doctorId = Convert.ToInt32(cmbDoctor.SelectedValue);

            foreach (DataRow row in tempPrescriptionTable.Rows)
            {
                int medId = Convert.ToInt32(row["MedicationID"]);
                string dosage = row["Dosage"].ToString();

                string query = "INSERT INTO Prescriptions (PatientID, DoctorID, MedicationID, Dosage, DatePrescribed) VALUES (@PatientID, @DoctorID, @MedicationID, @Dosage, @DatePrescribed)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PatientID", patientId),
                    new SqlParameter("@DoctorID", doctorId),
                    new SqlParameter("@MedicationID", medId),
                    new SqlParameter("@Dosage", dosage),
                    new SqlParameter("@DatePrescribed", DateTime.Now)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
            }

            MessageBox.Show("Prescriptions saved.");
            tempPrescriptionTable.Clear();
            LoadHistory();
        }
        

        private void PrescriptionsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            LoadMedications();
            InitTempTable();
            LoadHistory();
        }

        private void LoadHistory()
        {
            string query = @"
        SELECT 
            p.PrescriptionID,
            pa.Name AS Patient,
            d.Name AS Doctor,
            m.Name AS Medication,
            p.Dosage,
            p.DatePrescribed
        FROM Prescriptions p
        JOIN Patients pa ON p.PatientID = pa.PatientID
        JOIN Doctors d ON p.DoctorID = d.DoctorID
        JOIN Medications m ON p.MedicationID = m.MedicationID
        ORDER BY p.DatePrescribed DESC";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, null);
            dataGridViewHistory.DataSource = dt;
        }



        private void LoadPatients()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT PatientID, Name FROM Patients", null);
            cmbPatient.DataSource = dt;
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "PatientID";
        }

        private void LoadDoctors()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT DoctorID, Name FROM Doctors", null);
            cmbDoctor.DataSource = dt;
            cmbDoctor.DisplayMember = "Name";
            cmbDoctor.ValueMember = "DoctorID";
        }

        private void LoadMedications()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT MedicationID, Name FROM Medications", null);
            cmbMedication.DataSource = dt;
            cmbMedication.DisplayMember = "Name";
            cmbMedication.ValueMember = "MedicationID";
        }

        private void InitTempTable()
        {
            tempPrescriptionTable = new DataTable();
            tempPrescriptionTable.Columns.Add("MedicationID", typeof(int));
            tempPrescriptionTable.Columns.Add("Medication", typeof(string));
            tempPrescriptionTable.Columns.Add("Dosage", typeof(string));

            dataGridViewTempPrescriptions.DataSource = tempPrescriptionTable;
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            int medicationId = Convert.ToInt32(cmbMedication.SelectedValue);
            string medName = cmbMedication.Text;
            string dosage = txtDosage.Text;

            tempPrescriptionTable.Rows.Add(medicationId, medName, dosage);
        }

        private void btnDeletePrescription_Click(object sender, EventArgs e)
        {
            if (dataGridViewHistory.CurrentRow == null) return;

            int prescriptionId = Convert.ToInt32(dataGridViewHistory.CurrentRow.Cells["PrescriptionID"].Value);
            string query = "DELETE FROM Prescriptions WHERE PrescriptionID = @PrescriptionID";
            SqlParameter[] parameters = { new SqlParameter("@PrescriptionID", prescriptionId) };

            DatabaseHelper.ExecuteNonQuery(query, parameters);
            MessageBox.Show("Prescription deleted.");
            LoadHistory();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
