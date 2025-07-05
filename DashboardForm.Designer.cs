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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.btnPatients = new System.Windows.Forms.Button();
            this.mngDoctors = new System.Windows.Forms.Button();
            this.appointments = new System.Windows.Forms.Button();
            this.billing = new System.Windows.Forms.Button();
            this.medicatebtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.Cyan;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPatients.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPatients.Location = new System.Drawing.Point(168, 124);
            this.btnPatients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(110, 51);
            this.btnPatients.TabIndex = 0;
            this.btnPatients.Text = "Manage\r\n Patients\r\n";
            this.btnPatients.UseVisualStyleBackColor = false;
            this.btnPatients.Click += new System.EventHandler(this.btnPatients_Click);
            // 
            // mngDoctors
            // 
            this.mngDoctors.BackColor = System.Drawing.Color.Cyan;
            this.mngDoctors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mngDoctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mngDoctors.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mngDoctors.Location = new System.Drawing.Point(327, 124);
            this.mngDoctors.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mngDoctors.Name = "mngDoctors";
            this.mngDoctors.Size = new System.Drawing.Size(110, 49);
            this.mngDoctors.TabIndex = 1;
            this.mngDoctors.Text = "Manage Doctors";
            this.mngDoctors.UseVisualStyleBackColor = false;
            this.mngDoctors.Click += new System.EventHandler(this.mngDoctors_Click);
            // 
            // appointments
            // 
            this.appointments.BackColor = System.Drawing.Color.Cyan;
            this.appointments.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.appointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.appointments.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.appointments.Location = new System.Drawing.Point(406, 221);
            this.appointments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.appointments.Name = "appointments";
            this.appointments.Size = new System.Drawing.Size(122, 37);
            this.appointments.TabIndex = 2;
            this.appointments.Text = "Appointments";
            this.appointments.UseVisualStyleBackColor = false;
            this.appointments.Click += new System.EventHandler(this.appointments_Click);
            // 
            // billing
            // 
            this.billing.BackColor = System.Drawing.Color.Cyan;
            this.billing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.billing.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.billing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.billing.Location = new System.Drawing.Point(101, 221);
            this.billing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.billing.Name = "billing";
            this.billing.Size = new System.Drawing.Size(110, 38);
            this.billing.TabIndex = 3;
            this.billing.Text = "Billing";
            this.billing.UseVisualStyleBackColor = false;
            this.billing.Click += new System.EventHandler(this.billing_Click);
            // 
            // medicatebtn
            // 
            this.medicatebtn.BackColor = System.Drawing.Color.Cyan;
            this.medicatebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.medicatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicatebtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.medicatebtn.Location = new System.Drawing.Point(250, 221);
            this.medicatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.medicatebtn.Name = "medicatebtn";
            this.medicatebtn.Size = new System.Drawing.Size(110, 37);
            this.medicatebtn.TabIndex = 4;
            this.medicatebtn.Text = "Medication ";
            this.medicatebtn.UseVisualStyleBackColor = false;
            this.medicatebtn.Click += new System.EventHandler(this.medicatebtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(437, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 121);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.medicatebtn);
            this.Controls.Add(this.billing);
            this.Controls.Add(this.appointments);
            this.Controls.Add(this.mngDoctors);
            this.Controls.Add(this.btnPatients);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Button mngDoctors;
        private System.Windows.Forms.Button appointments;
        private System.Windows.Forms.Button billing;
        private System.Windows.Forms.Button medicatebtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}