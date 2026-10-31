# ዉለታ Restaurant Order Management System (RMS)

**Course:** Event-Driven Programming  
**Department:** Software Engineering — Debre Berhan University  
**Group:** Group 5  
**Phase:** Phase 1 — C# Windows Forms Desktop Application  

---

## 1. Project Overview
ዉለታ Restaurant Order Management System (RMS) is a desktop application developed using **C# Windows Forms** on **.NET 10.0**. The application provides an event-driven user interface for restaurant service staff (Waiters) and Managers to handle customer orders, browse the menu catalog, manage staff shifts, track order preparation lifecycles, and view live operational reports.

In accordance with Phase 1 course requirements:
- **No external database or API** is required for this phase.
- Data is managed in-memory via `RestaurantStore` and persisted locally to JSON files (`orders.json`, `menu.json`, `staff.json`).
- Built with a clean desktop design system and native Windows Forms controls (`DataGridView`, `GroupBox`, `Panel`, `ComboBox`, `TextBox`, `Button`).

---

## 2. Key Features Implemented (Phase 1)
- **Role-Based Authentication:** Clean sign-in window distinguishing between **Manager** and **Waiter** workspaces.
- **Menu Catalog (`MenuView`):** Browse food and beverages with live text search and availability filtering.
- **Order Creation (`NewOrderView`):** Sequential order numbering, customer name validation, table selection, dynamic line items, and live total calculation in ETB.
- **Order Lifecycle Management (`OrdersView`):** Track orders across 4 state-machine stages: `Pending` → `Preparing` → `Ready` → `Completed`, with cancellation support.
- **Order Details & Modification (`OrderDetailsView` & `EditOrderView`):** View itemized receipt breakdowns or update customer and item details for active orders.
- **Manager Dashboard & Reports (`DashboardView` & `ReportsView`):** Real-time KPI summary cards (Total Orders, Pending, Preparing, Ready, Completed, and Sales Revenue).
- **Staff & Menu Administration (`StaffManagementView` & `MenuManagementView`):** Register new waiters, assign shifts, add menu items, and toggle item availability.

---

## 3. How to Run the Project

### Prerequisites
- Windows 10 / 11
- .NET 10.0 SDK or Visual Studio 2022+ with **.NET Desktop Development** workload.

### Run via Visual Studio
1. Open `RMS.slnx` or `RMS/RMS.csproj` in Visual Studio.
2. Ensure build configuration is set to `Debug` | `Any CPU`.
3. Press **F5** (or click the green **Start** button).

### Run via Command Line / Terminal
```bash
dotnet build RMS
dotnet run --project RMS
```

---

## 4. Default Test Credentials
| Role | Staff ID | Default User | Accessible Views |
| :--- | :---: | :--- | :--- |
| **Manager** | `100` | Manager (Admin) | Dashboard, Reports, Manage Menu, Manage Waiters |
| **Waiter** | `101` | Abebe Bikila | Menu, New Order, Orders |

---

## 5. Group 5 Members & Contributions
| Full Name | Student ID | Primary Responsibilities |
| :--- | :--- | :--- |
| **Samuel Abera** | DBU1601589 | Desktop UI Architecture, Navigation Shell, and In-Memory Services |
| **Kalkidan Behailu** | DBU1601272 | System Requirements (SRS), Acceptance Test Plan, and Documentation |
| **Lidiya Abebaw** | DBU1601308 | Input Validation Design, Seed Data, and Quality Testing |

---

## 6. Project Roadmap
- **Phase 1 (Completed):** C# Windows Forms Desktop Application with local JSON persistence.
- **Phase 2 (Upcoming):** ASP.NET Core REST Web API and Relational Database (SQL Server / PostgreSQL).
- **Phase 3 (Upcoming):** Web Application with Kitchen Display System (KDS) and Manager Web Portal.
