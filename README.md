# 📌 Task Management Application

## 📖 Overview

This project is a **Task Management Application** built using **ASP.NET Core MVC** and **Entity Framework Core (Code First Approach)**.

The application allows users to:

* Create tasks
* View tasks
* Update tasks
* Delete tasks
* Search tasks

It demonstrates full **CRUD operations**, proper **database design**, and **clean MVC architecture**.

---

## 🗄️ Database Design

### 📌 Table: TaskItems

| Column Name | Data Type       | Description                     |
| ----------- | --------------- | ------------------------------- |
| Id          | int (PK)        | Unique identifier               |
| Title       | nvarchar(200)   | Task title                      |
| Description | nvarchar(max)   | Task details                    |
| DueDate     | datetime        | Task deadline                   |
| Status      | nvarchar(50)    | Task status (Pending/Completed) |
| Remarks     | nvarchar(200)   | Additional notes                |
| CreatedOn   | datetime        | Created timestamp               |
| UpdatedOn   | datetime (null) | Last updated timestamp          |
| CreatedBy   | nvarchar(100)   | Creator name                    |
| UpdatedBy   | nvarchar(100)   | Last updater name               |

---

## 📊 ER Diagram

```
+------------------+
|   TaskItems      |
+------------------+
| Id (PK)          |
| Title            |
| Description      |
| DueDate          |
| Status           |
| Remarks          |
| CreatedOn        |
| UpdatedOn        |
| CreatedBy        |
| UpdatedBy        |
+------------------+
```

---

## 📘 Data Dictionary

* **Id** → Primary key for each task
* **Title** → Name of the task
* **Description** → Detailed information about task
* **DueDate** → Deadline for completion
* **Status** → Indicates whether task is Pending or Completed
* **Remarks** → Optional notes
* **CreatedOn / UpdatedOn** → Used for tracking
* **CreatedBy / UpdatedBy** → User tracking

---

## ⚡ Indexes Used

* Index on **Title column**

### ✔ Reason:

* Improves **search performance**
* Frequently used in filtering tasks

---

## 🧠 Code First vs DB First

### ✔ Approach Used: Code First

### ✔ Reason:

* Faster development
* Easy schema changes using migrations
* Better integration with EF Core
* Suitable for small to medium applications

---

## 🏗️ Application Structure

```
TaskManagement/
│
├── Controllers/
│   └── TaskController.cs
│
├── Models/
│   └── TaskItem.cs
│
├── Data/
│   └── AppDbContext.cs
│
├── Views/
│   └── Task/
│       ├── Index.cshtml
│
├── wwwroot/
├── appsettings.json
└── Program.cs
```

---

## 🎨 Frontend Structure

* Built using **Razor Views (MVC)**
* Uses **Bootstrap 5** for UI design
* jQuery used for:

  * Modal handling
  * Form interaction

### ✔ Features:

* Modal-based Create & Edit
* Table listing
* Responsive design
* Clean UI

---

## ⚙️ Build & Install Instructions

### 📌 Prerequisites

* .NET 6/7 SDK
* SQL Server
* Visual Studio / VS Code

---

### 📦 Dependencies

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.SqlServer
* Microsoft.EntityFrameworkCore.Tools
* Bootstrap 5 (CDN)
* jQuery (CDN)

---

### ▶️ Steps to Run

1. Clone the repository:

```
git clone https://github.com/your-username/task-management.git
```

2. Navigate to project:

```
cd task-management
```

3. Update connection string in `appsettings.json`

4. Run migrations:

```
dotnet ef migrations add InitialCreate
dotnet ef database update
```

5. Run application:

```
dotnet run
```

6. Open browser:

```
https://localhost:xxxx
```

---

## 🔍 Features Implemented

* ✅ Create Task
* ✅ Read Task
* ✅ Update Task
* ✅ Delete Task
* ✅ Search Task
* ✅ Modal UI
* ✅ Clean Architecture

---

## 📌 Additional Notes

* Uses **MVC Pattern**
* Clean and maintainable code
* Easily extendable for future features

---

## 🚀 Future Enhancements

* Authentication & Authorization
* Pagination
* API integration
* Mobile app support
* Notifications

---

## 👨‍💻 Author

**Mrityunjay Kumar Singh**
