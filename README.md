# Conference Hall Management System

![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen) ![Errors](https://img.shields.io/badge/Errors-0-brightgreen) ![Warnings](https://img.shields.io/badge/Warnings-0-brightgreen) ![Platform](https://img.shields.io/badge/Platform-.NET_Core_|_Blazor-blue)

## ? Project Overview

This repository contains the core **Master Data Management** modules for an enterprise-grade Conference Hall Management System. The project is designed to handle the fundamental configuration data required for booking operations, specifically focusing on **Room Types** and **Booking Statuses**.

The application is built using **.NET (Blazor Server)** and strictly follows **Clean Architecture** principles to ensure scalability, maintainability, and testability.

---

## ? Key Modules

### 1. Master Booking Status
* Manages the lifecycle states of a booking (e.g., Confirmed, Pending, Cancelled).
* **Features:** List view, Create, Edit, Soft Delete, Search.

### 2. Master Room Type
* Categorizes conference halls (e.g., Auditorium, Board Room, Banquet Hall).
* **Features:** Full CRUD operations with validation and historical data preservation.

---

## ? Technical Highlights

* **Architecture:** Implements **Repository Pattern** and **Dependency Injection (DI)** for loose coupling.
* **UI Pattern:** Uses **MVVM (Model-View-ViewModel)** with dedicated ViewModels (e.g., `MasterRoomTypeVM`).
* **Performance:** Features **Debounced Search** to minimize database load during real-time filtering.
* **Data Integrity:** Implements **Soft Delete** logic to maintain referential integrity and audit trails.
* **Validation:** robust **Dual-Layer Validation** (Client-side Data Annotations + Server-side Logic).
* **UX:** Fully **Responsive Design** with **Bilingual Support (English & Hindi)**.

---

## ? Tech Stack

* **Framework:** .NET Core / Blazor Server
* **Language:** C#
* **Database:** SQL Server
* **ORM:** Entity Framework Core
* **Frontend:** HTML5, CSS3, Bootstrap
* **Tools:** Visual Studio, Git

---

## ? Getting Started

### Prerequisites
* .NET SDK
* SQL Server

### Installation & Run

1.  **Clone the repository**
    ```bash
    git clone [repository-url]
    ```

2.  **Build the solution**
    ```bash
    dotnet build
    ```

3.  **Run the application**
    ```bash
    dotnet run --project ConferenceHallManagement.web
    ```

4.  **Access the modules**
    * **Booking Status:** `https://localhost:[port]/booking-status`
    * **Room Types:** `https://localhost:[port]/room-type`

---

## ? Project Status

| Metric | Status |
| :--- | :--- |
| **Compilation** | Successful |
| **Errors** | 0 |
| **Warnings** | 0 |
| **Readiness** | Production Ready |

---

## ? Contact

**Developer:** [Vaidehi Jha]
**Role:** intern at PGCIL
