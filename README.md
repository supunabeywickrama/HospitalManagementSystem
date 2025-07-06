🏥 Hospital Management System — MediSys
A complete desktop-based Hospital Management System built with C# (.NET Windows Forms) and SQL Server for managing patients, doctors, medications, prescriptions, billing, and appointments.


🚀 Features
✅ Secure User Login with BCrypt Hashed Passwords
✅ Role-based access: Admin, Doctor, etc.
✅ Patient Management (CRUD)
✅ Appointment Scheduling
✅ Medication & Stock Management
✅ Bill Generation with Professional PDF Invoices
✅ Prescription Management
✅ Dashboard Summary
✅ Print Preview Support
✅ Image-based branding/logo in invoices
✅ Clean, responsive UI with custom backgrounds

📁 Project Structure
bash
Copy code
HospitalManagementSystem/
│
├── AppointmentsForm.cs       # Manage patient appointments
├── BillsForm.cs              # Generate and print hospital bills
├── CreateAccountForm.cs      # Register new users with password hashing
├── DashboardForm.cs          # Home panel after login
├── DoctorsForm.cs            # Manage doctor records
├── MedicationsForm.cs        # Add/edit medications and stock levels
├── PatientsForm.cs           # Handle patient records
├── PrescriptionsForm.cs      # Assign and print prescriptions
├── Form1.cs (Login)          # User login logic (hashed verification)
├── StartForm.cs              # Initial splash or navigation form
├── DatabaseHelper.cs         # SQL utility functions
├── Resources/                # App icons, logos (e.g., MEDISyslogo.png)
├── Program.cs                # Main entry point
└── packages.config           # Dependencies and libraries
🔐 Security
BCrypt password hashing used for storing and verifying user credentials.

Prevents direct password comparison with SQL.

💾 Technologies Used
C# .NET Framework

Windows Forms (WinForms)

SQL Server

ADO.NET

BCrypt.Net for password hashing

System.Drawing.Printing for invoices

🖨 Sample Invoice Preview
A custom print document with hospital branding, contact details, patient info, and itemized charges.

⚙ How to Run
Open solution in Visual Studio

Configure your SQL Server database:

Update connection string in DatabaseHelper.cs

Run StartForm.cs or Form1.cs as startup

Create an account and log in

Explore modules via the Dashboard

📌 Future Enhancements (Optional)
Export Reports to Excel/PDF

Email notifications for appointments

Add search & filter to DataGridViews

Convert to Web Version using ASP.NET Core

REST API + Flutter/React Native app

👨‍💻 Author
Supun Tharaka
🎓 Undergraduate | University of Kelaniya
🔗 GitHub: YourGitHubUsername

📸 Screenshots
You can add screenshot images like:

md
Copy code
![Dashboard](screenshots/dashboard.png)
![Login](screenshots/login.png)
