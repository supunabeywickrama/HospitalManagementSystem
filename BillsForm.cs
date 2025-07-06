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
            printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(printDocument1_PrintPage);


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

            int y = 40;
            Font headerFont = new Font("Arial", 20, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 10);
            Font bodyFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            // ✅ Draw Logo at Top-Right
            try
            {
                string logoPath = @"D:\visual project\test_01\HospitalManagementSystem\MEDISyslogo_2.png";
                Image logo = Image.FromFile(logoPath);
                e.Graphics.DrawImage(logo, 650, 20, 100, 100); // Adjust X, Y, Width, Height as needed
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logo could not be loaded: " + ex.Message);
            }

            // 🏥 Hospital Header
            e.Graphics.DrawString("MEDISys HOSPITAL", headerFont, Brushes.DarkBlue, 200, y);
            y += 35;
            e.Graphics.DrawString("23 Kandy road, Dalugama", subHeaderFont, Brushes.Black, 220, y);
            y += 20;
            e.Graphics.DrawString("Phone: +94 11 256 0000 | Email: contact@medisys.lk", subHeaderFont, Brushes.Black, 220, y);
            y += 30;

            // 🔻 Divider Line
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 20;

            // 📋 Invoice Header
            e.Graphics.DrawString("INVOICE", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, 50, y);
            y += 30;

            e.Graphics.DrawString("Invoice ID: " + billId, bodyFont, Brushes.Black, 50, y);
            e.Graphics.DrawString("Date: " + date, bodyFont, Brushes.Black, 600, y);
            y += 20;
            e.Graphics.DrawString("Patient: " + patient, bodyFont, Brushes.Black, 50, y);
            y += 20;

            // 🔻 Divider
            y += 10;
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 20;

            // Table Header
            e.Graphics.DrawString("Description", boldFont, Brushes.Black, 50, y);
            e.Graphics.DrawString("Amount (Rs.)", boldFont, Brushes.Black, 600, y);
            y += 20;

            // Table Content
            string query = "SELECT Description, Amount FROM BillDetails WHERE BillID = @BillID";
            SqlParameter[] parameters = { new SqlParameter("@BillID", billId) };
            DataTable dt = DatabaseHelper.ExecuteQuery(query, parameters);

            foreach (DataRow row in dt.Rows)
            {
                string desc = row["Description"].ToString();
                string amt = Convert.ToDecimal(row["Amount"]).ToString("0.00");

                e.Graphics.DrawString(desc, bodyFont, Brushes.Black, 50, y);
                e.Graphics.DrawString("Rs. " + amt, bodyFont, Brushes.Black, 600, y);
                y += 20;
            }

            // Total
            y += 10;
            e.Graphics.DrawLine(Pens.Black, 50, y, 750, y);
            y += 20;
            e.Graphics.DrawString("Total: Rs. " + total, new Font("Arial", 12, FontStyle.Bold), Brushes.Black, 600, y);

            // 📝 Footer
            y += 40;
            e.Graphics.DrawLine(Pens.Gray, 50, y, 750, y);
            y += 20;
            e.Graphics.DrawString("Thank you for trusting MediSys Hospital.", subHeaderFont, Brushes.Gray, 50, y);
            y += 20;
            e.Graphics.DrawString("This is a computer-generated invoice. No signature required.", new Font("Arial", 8, FontStyle.Italic), Brushes.Gray, 50, y);
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
