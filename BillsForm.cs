using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HospitalManagementSystem
{
    public partial class BillsForm : Form
    {
        public BillsForm()
        {
            InitializeComponent();
            this.Load += BillsForm_Load;

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                int patientId = Convert.ToInt32(cmbPatient.SelectedValue);
                decimal amount = decimal.Parse(txtAmount.Text);
                DateTime billingDate = dtpDate.Value;

                string query = "INSERT INTO Bills (PatientID, Amount, BillingDate) VALUES (@PatientID, @Amount, @BillingDate)";
                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@PatientID", patientId),
                    new SqlParameter("@Amount", amount),
                    new SqlParameter("@BillingDate", billingDate)
                };

                DatabaseHelper.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Bill generated successfully.");
                LoadBills();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BillsForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadBills();
        }

        private void LoadPatients()
        {
            DataTable dt = DatabaseHelper.ExecuteQuery("SELECT PatientID, Name FROM Patients", null);
            cmbPatient.DataSource = dt;
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "PatientID";
        }

        private void LoadBills()
        {
            string query = @"
                SELECT 
                    b.BillID,
                    p.Name AS PatientName,
                    b.Amount,
                    b.BillingDate
                FROM Bills b
                JOIN Patients p ON b.PatientID = p.PatientID";

            DataTable dt = DatabaseHelper.ExecuteQuery(query, null);
            dataGridViewBills.DataSource = dt;
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (dataGridViewBills.CurrentRow == null)
            {
                MessageBox.Show("Please select a bill to print.");
                return;
            }

            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           if (dataGridViewBills.CurrentRow == null) return;

            int billId = Convert.ToInt32(dataGridViewBills.CurrentRow.Cells["BillID"].Value);
            string patient = dataGridViewBills.CurrentRow.Cells["PatientName"].Value.ToString();
            string date = Convert.ToDateTime(dataGridViewBills.CurrentRow.Cells["BillingDate"].Value).ToShortDateString();
            string total = Convert.ToDecimal(dataGridViewBills.CurrentRow.Cells["Amount"].Value).ToString("0.00");


            // Header
            e.Graphics.DrawString("HOSPITAL INVOICE", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, 200, 50);
            e.Graphics.DrawString("Date: " + date, new Font("Arial", 10), Brushes.Black, 50, 100);
            e.Graphics.DrawString("Patient: " + patient, new Font("Arial", 10), Brushes.Black, 50, 120);
           // e.Graphics.DrawString("Doctor: " + doctor, new Font("Arial", 10), Brushes.Black, 50, 140);
            e.Graphics.DrawString("Invoice ID: " + billId.ToString(), new Font("Arial", 10), Brushes.Black, 50, 160);

            // Line
            e.Graphics.DrawLine(Pens.Black, 50, 180, 750, 180);

            // Table Header
            e.Graphics.DrawString("Description", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 200);
            e.Graphics.DrawString("Amount", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, 600, 200);

            // Fetch and print bill details
            string query = "SELECT Description, Amount FROM BillDetails WHERE BillID = @BillID";
            SqlParameter[] parameters = { new SqlParameter("@BillID", billId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            int y = 220;
            foreach (DataRow row in dt.Rows)
            {
                string desc = row["Description"].ToString();
                string amt = Convert.ToDecimal(row["Amount"]).ToString("0.00");

                y += 20;
                e.Graphics.DrawString(desc, new Font("Arial", 10), Brushes.Black, 50, y);
                e.Graphics.DrawString(amt, new Font("Arial", 10), Brushes.Black, 600, y);              
            }

            // Line
            y += 20;
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            

            // Total
            y += 20;
            e.Graphics.DrawString("Total: Rs. " + total, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 600, y);
        }

        private void lblPatient_Click(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
