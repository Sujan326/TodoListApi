# ✅ Todo List API - .NET 8 Backend

This is the backend of a **Todo List Application** built using **ASP.NET Core 8**, **Entity Framework Core**, and **SQL Server**. It provides a RESTful API to manage todo tasks.
---

## 🚀 Features

- Create, Read, Update, and Delete (CRUD) operations for todo items
- API tested using **Swagger**
- Connected to **SQL Server** using Entity Framework Core
- Built using Clean Architecture for easy maintenance

---

## 🛠️ Technologies Used

- [.NET 8](https://dotnet.microsoft.com/en-us/download)
- Entity Framework Core
- SQL Server (SSMS)
- Swagger (OpenAPI)
- Visual Studio Code

---

## 📂 Project Structure

```bash
TodoApi/
├── Controllers/
│   └── TodoController.cs
├── Data/
│   └── AppDbContext.cs
├── Models/
│   └── Todo.cs
├── Migrations/
├── appsettings.json
├── Program.cs
├── Startup.cs (if used)
└── README.md
```

---

## 🔗 API Endpoints

| Method | Endpoint           | Description          |
|--------|--------------------|----------------------|
| GET    | `/api/todo`        | Get all todos        |
| GET    | `/api/todo/{id}`   | Get a todo by ID     |
| POST   | `/api/todo`        | Create a new todo    |
| PUT    | `/api/todo/{id}`   | Update a todo        |
| DELETE | `/api/todo/{id}`   | Delete a todo        |

---

## ⚙️ Getting Started

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/todo-api-dotnet8.git
cd todo-api-dotnet8
```

### 2. Restore Packages

```bash
dotnet restore
```

### 3. Apply Migrations

```bash
dotnet ef database update
```

### 4. Run the Application

```bash
dotnet run
```

Navigate to `https://localhost:PORT/swagger` to test your API.

---

## 🙌 Author

- **Sujan TR**
- [LinkedIn](https://www.linkedin.com/) | [GitHub](https://github.com/)

---

## 📄 License

This project is open-source and available under the [MIT License](LICENSE).
```
