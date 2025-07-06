using System;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            PatientsForm pf = new PatientsForm();
            pf.Show();
        }

        private void mngDoctors_Click(object sender, EventArgs e)
        {
            DoctorsForm doctorsForm = new DoctorsForm();
            doctorsForm.Show();
        }

        private void appointments_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.Show();
        }

        private void billing_Click(object sender, EventArgs e)
        {
            BillsForm billsForm = new BillsForm();
            billsForm.Show();
        }

        private void medicatebtn_Click(object sender, EventArgs e)
        {
            MedicationsForm medicationsForm = new MedicationsForm();
            medicationsForm.Show();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 gomain = new Form1();
            gomain.Show();
        }

        private void prescription_Click(object sender, EventArgs e)
        {
            PrescriptionsForm prescription = new PrescriptionsForm();
            prescription.Show();
        }
    }
}
