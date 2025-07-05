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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTempPrescriptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Medication";
            // 
            // cmbPatient
            // 
            this.cmbPatient.FormattingEnabled = true;
            this.cmbPatient.Location = new System.Drawing.Point(143, 78);
            this.cmbPatient.Name = "cmbPatient";
            this.cmbPatient.Size = new System.Drawing.Size(141, 24);
            this.cmbPatient.TabIndex = 3;
            this.cmbPatient.Text = "Select patient\n";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(143, 144);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(141, 24);
            this.cmbDoctor.TabIndex = 4;
            this.cmbDoctor.Text = "Select doctor\n";
            // 
            // cmbMedication
            // 
            this.cmbMedication.FormattingEnabled = true;
            this.cmbMedication.Location = new System.Drawing.Point(143, 201);
            this.cmbMedication.Name = "cmbMedication";
            this.cmbMedication.Size = new System.Drawing.Size(141, 24);
            this.cmbMedication.TabIndex = 5;
            this.cmbMedication.Text = "Select medication\n";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(143, 292);
            this.txtDosage.Multiline = true;
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(141, 58);
            this.txtDosage.TabIndex = 6;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(461, 30);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(75, 23);
            this.btnAddToList.TabIndex = 7;
            this.btnAddToList.Text = "Add";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // dataGridViewTempPrescriptions
            // 
            this.dataGridViewTempPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTempPrescriptions.Location = new System.Drawing.Point(325, 59);
            this.dataGridViewTempPrescriptions.Name = "dataGridViewTempPrescriptions";
            this.dataGridViewTempPrescriptions.RowHeadersWidth = 51;
            this.dataGridViewTempPrescriptions.RowTemplate.Height = 24;
            this.dataGridViewTempPrescriptions.Size = new System.Drawing.Size(451, 141);
            this.dataGridViewTempPrescriptions.TabIndex = 8;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistory.Location = new System.Drawing.Point(325, 235);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersWidth = 51;
            this.dataGridViewHistory.RowTemplate.Height = 24;
            this.dataGridViewHistory.Size = new System.Drawing.Size(451, 158);
            this.dataGridViewHistory.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Dosage ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDeletePrescription
            // 
            this.btnDeletePrescription.Location = new System.Drawing.Point(586, 399);
            this.btnDeletePrescription.Name = "btnDeletePrescription";
            this.btnDeletePrescription.Size = new System.Drawing.Size(75, 23);
            this.btnDeletePrescription.TabIndex = 12;
            this.btnDeletePrescription.Text = "Delete";
            this.btnDeletePrescription.UseVisualStyleBackColor = true;
            this.btnDeletePrescription.Click += new System.EventHandler(this.btnDeletePrescription_Click);
            // 
            // PrescriptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Name = "PrescriptionsForm";
            this.Text = "PrescriptionsForm";
            this.Load += new System.EventHandler(this.PrescriptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTempPrescriptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
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
    }
}