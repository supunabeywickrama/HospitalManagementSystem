namespace HospitalManagementSystem
{
    partial class DoctorsForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecialty = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecialty = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(219, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblSpecialty
            // 
            this.lblSpecialty.AutoSize = true;
            this.lblSpecialty.Location = new System.Drawing.Point(219, 133);
            this.lblSpecialty.Name = "lblSpecialty";
            this.lblSpecialty.Size = new System.Drawing.Size(63, 16);
            this.lblSpecialty.TabIndex = 1;
            this.lblSpecialty.Text = "Specialty";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(219, 193);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(52, 16);
            this.lblContact.TabIndex = 2;
            this.lblContact.Text = "Contact";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(346, 74);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 3;
            // 
            // txtSpecialty
            // 
            this.txtSpecialty.Location = new System.Drawing.Point(346, 130);
            this.txtSpecialty.Name = "txtSpecialty";
            this.txtSpecialty.Size = new System.Drawing.Size(100, 22);
            this.txtSpecialty.TabIndex = 4;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(346, 190);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(100, 22);
            this.txtContact.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(557, 85);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 28);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(557, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(104, 28);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(557, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 28);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(183, 251);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.RowHeadersWidth = 51;
            this.dataGridViewDoctors.RowTemplate.Height = 24;
            this.dataGridViewDoctors.Size = new System.Drawing.Size(531, 150);
            this.dataGridViewDoctors.TabIndex = 9;
            // 
            // DoctorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewDoctors);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtSpecialty);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblSpecialty);
            this.Controls.Add(this.lblName);
            this.Name = "DoctorsForm";
            this.Text = "DoctorsForm";
            this.Load += new System.EventHandler(this.DoctorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecialty;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
    }
}