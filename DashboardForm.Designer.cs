namespace HospitalManagementSystem
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPatients = new System.Windows.Forms.Button();
            this.mngDoctors = new System.Windows.Forms.Button();
            this.appointments = new System.Windows.Forms.Button();
            this.billing = new System.Windows.Forms.Button();
            this.medicatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.Location = new System.Drawing.Point(120, 156);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(147, 47);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Manage Patients";
            this.btnPatients.UseVisualStyleBackColor = true;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // mngDoctors
            // 
            this.mngDoctors.Location = new System.Drawing.Point(301, 156);
            this.mngDoctors.Name = "mngDoctors";
            this.mngDoctors.Size = new System.Drawing.Size(151, 47);
            this.mngDoctors.TabIndex = 1;
            this.mngDoctors.Text = "Manage Doctors";
            this.mngDoctors.UseVisualStyleBackColor = true;
            this.mngDoctors.Click += new System.EventHandler(this.mngDoctors_Click);
            // 
            // appointments
            // 
            this.appointments.Location = new System.Drawing.Point(488, 156);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(154, 47);
            this.appointments.TabIndex = 2;
            this.appointments.Text = "Appointments";
            this.appointments.UseVisualStyleBackColor = true;
            this.appointments.Click += new System.EventHandler(this.appointments_Click);
            // 
            // billing
            // 
            this.billing.Location = new System.Drawing.Point(190, 259);
            this.billing.Name = "billing";
            this.billing.Size = new System.Drawing.Size(167, 47);
            this.billing.TabIndex = 3;
            this.billing.Text = "Billing";
            this.billing.UseVisualStyleBackColor = true;
            this.billing.Click += new System.EventHandler(this.billing_Click);
            // 
            // medicatebtn
            // 
            this.medicatebtn.Location = new System.Drawing.Point(389, 260);
            this.medicatebtn.Name = "medicatebtn";
            this.medicatebtn.Size = new System.Drawing.Size(166, 46);
            this.medicatebtn.TabIndex = 4;
            this.medicatebtn.Text = "Medication ";
            this.medicatebtn.UseVisualStyleBackColor = true;
            this.medicatebtn.Click += new System.EventHandler(this.medicatebtn_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.medicatebtn);
            this.Controls.Add(this.billing);
            this.Controls.Add(this.appointments);
            this.Controls.Add(this.mngDoctors);
            this.Controls.Add(this.btnPatients);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button mngDoctors;
        private System.Windows.Forms.Button appointments;
        private System.Windows.Forms.Button billing;
        private System.Windows.Forms.Button medicatebtn;
    }
}