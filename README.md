<h1 align="center">PET-ADOPTION-API</h1>
<p align="center"><i>Pet Adoption Management Web API System</i></p>

<p align="center">
  <img src="https://img.shields.io/badge/last%20commit-July-blue">
  <img src="https://img.shields.io/badge/language-C%23-purple">
  <img src="https://img.shields.io/badge/framework-.NET-red">
</p>

---

## 📌 Table of Contents
- [Overview](#overview)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Project Structure](#project-structure)
- [Getting Started](#getting-started)
- [API Endpoints](#api-endpoints)
---

## 📘 Overview
**Pet Adoption API** is a **Web API backend system** designed to manage pet adoption workflows.  
It helps organizations or pet shelters manage:

✅ Pets available for adoption  
✅ Adoption requests  
✅ User accounts & authentication  
✅ Pet categories & statuses  
✅ Application approvals  
✅ Secure user access using JWT  

The system is built using **clean architecture**, **SOLID principles**, and **EF Core (Code-First)** for scalability and maintainability.

---

## ✅ Features
- 🐶 **Pet Management (CRUD)**
- 📝 **Adoption Application System**
- 🔐 **JWT Authentication & Authorization**
- 🧩 **Entity Framework Core (Code-First)**
- ✅ **DTO Mapping for clean structured data**
- 🧠 **Fluent Validation for robust input validation**
- ⚙️ **Follows SOLID Principles**
- 🗃 **SQL Server Integration**
- 📦 **Layered Architecture (Controller → Service → Repository)**

---

## 🛠 Tech Stack
| Category | Technology |
|---------|------------|
| Backend | ASP.NET Web API |
| Database | SQL Server / EF Core |
| ORM | Entity Framework Core (Code-First) |
| Validation | FluentValidation |
| Authentication | JWT Authentication |
| Tools | Visual Studio, Postman |
| Version Control | Git, GitHub |

---

## Project Structure
```
PetAdoptionApi.sln
├── PetAdoptionApi/ (Application Layer)
│   ├── Controllers/
│   ├── Config/ 
│   ├── Program.cs (Application entry point)
│   └── appsettings.json
├── BLL/ (Business Logic Layer)
│   ├── Services/ (Implements Core business logic, utilizes Repositories)
│   │   ├── Interfaces/ (e.g., IPetService, IAuthService)
│   │   └── Implementations/ (e.g., PetService, AuthService)
│   ├── Validators/ (FluentValidation rules for DTOs)
│   └── Mappers/ (AutoMapper profiles for DTO to Entity mapping)
├── DAL/ (Data Access Layer)
│   ├── Data/
│   │   ├── ApplicationDbContext.cs
│   │   └── Migrations/
│   ├── Models/ (EF Core Entities/Domain Models)
│   ├── Repositories/ (Implements data persistence operations)
│   │   ├── Interfaces/ (e.g., IPetRepository)
│   │   └── Implementations/ (e.g., PetRepository)
│   └── DTOs/ (Data Transfer Objects for request/response bodies)
│       ├── Pet/
│       ├── Auth/
│       └── Adoption/
└── README.md
```
## API Endpoints
🐾 Pet Endpoints
| Method | Endpoint         | Description   |
| ------ | ---------------- | ------------- |
| GET    | `/api/pets`      | Get all pets  |
| GET    | `/api/pets/{id}` | Get pet by ID |
| POST   | `/api/pets`      | Add new pet   |
| PUT    | `/api/pets/{id}` | Update pet    |
| DELETE | `/api/pets/{id}` | Delete pet    |

👤 Authentication Endpoints
| Method | Endpoint             | Description                  |
| ------ | -------------------- | ---------------------------- |
| POST   | `/api/auth/register` | Register new user            |
| POST   | `/api/auth/login`    | Login user                   |
| GET    | `/api/auth/profile`  | Get logged-in user's profile |

