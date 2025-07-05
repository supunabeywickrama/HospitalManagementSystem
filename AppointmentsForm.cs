using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace HospitalManagementSystem
{
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
            this.Load += AppointmentsForm_Load;
        }

        private void AppointmentsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            LoadAppointments();
        }

        private void LoadPatients()
        {
            string query = "SELECT PatientID, Name FROM Patients";
            SqlParameter[] parameters = new SqlParameter[0];

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

        private void LoadAppointments()
        {
            string query = @"
                SELECT 
                    a.AppointmentID,
                    p.Name AS PatientName,
                    d.Name AS DoctorName,
                    a.AppointmentDate,
                    a.Notes
                FROM Appointments a
                JOIN Patients p ON a.PatientID = p.PatientID
                JOIN Doctors d ON a.DoctorID = d.DoctorID";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, null);
            dataGridViewAppointments.DataSource = dt;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = Convert.ToInt32(cmbPatient.SelectedValue);
                int doctorId = Convert.ToInt32(cmbDoctor.SelectedValue);
                DateTime date = dtpAppointment.Value;
                string notes = txtNotes.Text;

                string query = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Notes) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Notes)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PatientID", patientId),
                    new SqlParameter("@DoctorID", doctorId),
                    new SqlParameter("@AppointmentDate", date),
                    new SqlParameter("@Notes", notes)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Appointment booked successfully.");
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BtnBook_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = Convert.ToInt32(cmbPatient.SelectedValue);
                int doctorId = Convert.ToInt32(cmbDoctor.SelectedValue);
                DateTime date = dtpAppointment.Value;
                string notes = txtNotes.Text;

                string query = "INSERT INTO Appointments (PatientID, DoctorID, AppointmentDate, Notes) VALUES (@PatientID, @DoctorID, @AppointmentDate, @Notes)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PatientID", patientId),
                    new SqlParameter("@DoctorID", doctorId),
                    new SqlParameter("@AppointmentDate", date),
                    new SqlParameter("@Notes", notes)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Appointment booked successfully.");
                LoadAppointments();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
