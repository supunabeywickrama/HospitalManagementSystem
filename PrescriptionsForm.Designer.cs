namespace HospitalManagementSystem
{
    partial class PrescriptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrescriptionsForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPatient = new System.Windows.Forms.ComboBox();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.cmbMedication = new System.Windows.Forms.ComboBox();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.dataGridViewTempPrescriptions = new System.Windows.Forms.DataGridView();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeletePrescription = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTempPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medication :";
            // 
            // cmbPatient
            // 
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(107, 63);
            this.cmbPatient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(107, 21);
            this.cmbPatient.TabIndex = 3;
            this.cmbPatient.Text = "Select patient\n";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(107, 117);
            this.cmbDoctor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(107, 21);
            this.cmbDoctor.TabIndex = 4;
            this.cmbDoctor.Text = "Select doctor\n";
            // 
            // cmbMedication
            // 
            this.cmbMedication.FormattingEnabled = true;
            this.cmbMedication.Location = new System.Drawing.Point(107, 163);
            this.cmbMedication.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbMedication.Name = "cmbMedication";
            this.cmbMedication.Size = new System.Drawing.Size(107, 21);
            this.cmbMedication.TabIndex = 5;
            this.cmbMedication.Text = "Select medication\n";
            // 
            // txtDosage
            // 
            this.txtDosage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDosage.Location = new System.Drawing.Point(107, 206);
            this.txtDosage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDosage.Multiline = true;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(107, 48);
            this.txtDosage.TabIndex = 6;
            // 
            // btnAddToList
            // 
            this.btnAddToList.BackColor = System.Drawing.Color.Teal;
            this.btnAddToList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToList.ForeColor = System.Drawing.Color.White;
            this.btnAddToList.Location = new System.Drawing.Point(251, 11);
            this.btnAddToList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(56, 31);
            this.btnAddToList.TabIndex = 7;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = false;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // dataGridViewTempPrescriptions
            // 
            this.dataGridViewTempPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTempPrescriptions.Location = new System.Drawing.Point(251, 46);
            this.dataGridViewTempPrescriptions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTempPrescriptions.Name = "dataGridViewTempPrescriptions";
            this.dataGridViewTempPrescriptions.RowHeadersWidth = 51;
            this.dataGridViewTempPrescriptions.RowTemplate.Height = 24;
            this.dataGridViewTempPrescriptions.Size = new System.Drawing.Size(338, 115);
            this.dataGridViewTempPrescriptions.TabIndex = 8;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(251, 201);
            this.dataGridViewHistory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(338, 128);
            this.dataGridViewHistory.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dosage :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(251, 168);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 29);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeletePrescription
            // 
            this.btnDeletePrescription.BackColor = System.Drawing.Color.Teal;
            this.btnDeletePrescription.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletePrescription.ForeColor = System.Drawing.Color.White;
            this.btnDeletePrescription.Location = new System.Drawing.Point(533, 332);
            this.btnDeletePrescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeletePrescription.Name = "btnDeletePrescription";
            this.btnDeletePrescription.Size = new System.Drawing.Size(56, 27);
            this.btnDeletePrescription.TabIndex = 12;
            this.btnDeletePrescription.Text = "Delete";
            this.btnDeletePrescription.UseVisualStyleBackColor = false;
            this.btnDeletePrescription.Click += new System.EventHandler(this.btnDeletePrescription_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(436, -29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 99);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnDeletePrescription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewHistory);
            this.Controls.Add(this.dataGridViewTempPrescriptions);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.cmbMedication);
            this.Controls.Add(this.cmbDoctor);
            this.Controls.Add(this.cmbPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PrescriptionsForm";
            this.Text = "PrescriptionsForm";
            this.Load += new System.EventHandler(this.PrescriptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTempPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPatient;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.ComboBox cmbMedication;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.DataGridView dataGridViewTempPrescriptions;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeletePrescription;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}