# 🏥 MediSys — Hospital Management System  
[![Contributors](https://img.shields.io/badge/contributors-1-blue.svg)](CONTRIBUTORS.md)  
[![Last Commit](https://img.shields.io/github/last-commit/yourusername/MediSys)](https://github.com/yourusername/MediSys)

---

## 🌟 About the Project

**MediSys** is a complete desktop-based Hospital Management System developed using **C# (.NET Windows Forms)** and **SQL Server**. It is designed to streamline hospital operations such as managing patients, doctors, medications, prescriptions, billing, and appointments.

This project was created as part of my learning journey in mastering **C#**, **WinForms**, and **SQL-based backend systems**.

---

## 🚀 Features

- 🔐 **Secure Login** using BCrypt hashed passwords  
- 👥 **Role-Based Access Control** (Admin, Doctor)  
- 🏥 **Patient Management** with full CRUD functionality  
- 📅 **Appointment Scheduling**  
- 💊 **Medication & Stock Tracking**  
- 🧾 **Professional Billing System** (with PDF invoice printing)  
- 📝 **Prescription Management**  
- 📊 **Dashboard Summary View**  
- 🖨️ **Print Preview Support**  
- 🖼️ **Branded Invoices** with hospital logos  

---
```cmd
## 🗂️ Project Structure

MediSys/
│
├── AppointmentsForm.cs # Manage appointments
├── BillsForm.cs # Generate and print bills
├── CreateAccountForm.cs # User registration (with password hashing)
├── DashboardForm.cs # Dashboard panel
├── DoctorsForm.cs # Manage doctor information
├── MedicationsForm.cs # Manage medicines and stock
├── PatientsForm.cs # Manage patient data
├── PrescriptionsForm.cs # Create and print prescriptions
├── Form1.cs # Login form and logic
├── StartForm.cs # Application splash screen or landing page
├── DatabaseHelper.cs # SQL Server connection and queries
├── Resources/ # Images (e.g., MEDISyslogo.png)
├── Program.cs # Main entry point
└── packages.config # .NET packages and dependencies
```



---

## 🛡️ Security

- Passwords are **hashed with BCrypt.Net** before storing in the database.  
- Secure verification prevents raw password leaks or SQL injection attacks.

---

## 💻 Technologies Used

- **C# (.NET Framework)**  
- **Windows Forms (WinForms)**  
- **SQL Server**  
- **ADO.NET**  
- **BCrypt.Net** for secure password hashing  
- **System.Drawing.Printing** for professional invoice generation  

---

## 🧾 Sample Invoice

Invoices include:

- Hospital branding (logo & address)  
- Patient information  
- Itemized charges with cost breakdown  
- Printable or exportable as PDF  

---

## ⚙️ How to Run the Project

1. **Open in Visual Studio**  
   - Open the `.sln` file in Visual Studio.

2. **Configure the Database**  
   - Update the SQL Server connection string in `DatabaseHelper.cs`.

3. **Run the Application**  
   - Set `StartForm.cs` or `Form1.cs` as the startup form.  
   - Compile and run the project.

4. **Create a User Account**  
   - Use the Create Account form to register.  
   - Log in and explore the system via the dashboard.

---

## 🧩 Optional Future Enhancements

- 📤 Export reports to Excel or PDF  
- 📧 Email appointment notifications  
- 🔍 Search and filter in data tables  
- 🌐 Convert to a web version using ASP.NET Core  
- 📱 Build mobile apps using Flutter or React Native + REST API  

---

## 📸 Screenshots

> Add the following screenshots to a `/screenshots` folder in your repo:


![Dashboard](https://github.com/supunabeywickrama/HospitalManagementSystem/blob/master/New%20folder%20(2)/WhatsApp%20Image%202025-07-06%20at%2020.59.09_4965ec82.jpg)
![Login](screenshots/login.png)
