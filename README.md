# ዉለታ Restaurant Order Management System (RMS)

[![.NET 10 Windows](https://img.shields.io/badge/.NET-10.0_Windows-512BD4?logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![Language](https://img.shields.io/badge/Language-C%23_13-239120?logo=csharp&logoColor=white)](https://learn.microsoft.com/dotnet/csharp/)
[![UI Platform](https://img.shields.io/badge/Platform-Windows_Forms-0078D7?logo=windows&logoColor=white)](https://learn.microsoft.com/dotnet/desktop/winforms/)
[![Architecture](https://img.shields.io/badge/Architecture-Event--Driven-orange)](#system-architecture)
[![Phase](https://img.shields.io/badge/Milestone-Phase_1_Complete-brightgreen)](#project-roadmap--phases)

A modern, robust, and event-driven **Restaurant Order Management System (RMS)** designed for **ዉለታ Restaurant**. Built as a pair-programmed desktop application using C# Windows Forms, this project addresses the real-world operational challenges of table service, order entry, status progression, historical price freezing, and operational reporting.

---

## Table of Contents
1. [Project Overview](#project-overview)
2. [Project Roadmap & Phases](#project-roadmap--phases)
3. [Phase 1: Desktop Application Details](#phase-1-desktop-application-details)
   - [Core Features](#core-features)
   - [Business Invariants & Rules](#business-invariants--rules)
   - [Default System Credentials & Data](#default-system-credentials--data)
4. [System Architecture & Design](#system-architecture--design)
   - [Directory Structure](#directory-structure)
   - [Event-Driven Pattern](#event-driven-pattern)
   - [Design System & Theme](#design-system--theme)
5. [Prerequisites & Getting Started](#prerequisites--getting-started)
   - [Environment Requirements](#environment-requirements)
   - [Build and Run](#build-and-run)
   - [Running Automated Verification Tests](#running-automated-verification-tests)
6. [Interactive Demonstration Script](#interactive-demonstration-script)
7. [Upcoming Phases Preview](#upcoming-phases-preview)

---

## Project Overview

In a fast-paced dining environment, miscommunicated orders, lost physical tickets, and incorrect billing lead to inventory discrepancies and delayed service. **RMS** bridges this gap with a responsive, reliable software platform structured around:

- **Service Staff / Waiters:** Rapid digital order creation, real-time price calculation, line-item modifications, and instant order tracking.
- **Kitchen Staff:** Clear visibility into pending and in-progress items with preparation status lifecycle transitions.
- **Management:** Real-time visibility into active table orders, daily revenue metrics, order history, and menu pricing administration.

The software is engineered with a strict **event-driven paradigm**, ensuring that changes in orders, menu availability, and status updates trigger automatic UI re-renders without full-page reloads or manual refreshes.

---

## Project Roadmap & Phases

The complete RMS project is designed as a three-phase software engineering lifecycle:

```
┌────────────────────────────────────────────────────────────────────────┐
│                   PHASE 1: DESKTOP APPLICATION                         │
│  • Technology: C# Windows Forms (.NET 10 Desktop)                      │
│  • Primary Actor: Waiter / Service Staff & Manager                     │
│  • Storage: In-Memory Domain Store with JSON Local Fallback            │
│  • Status: COMPLETED & VERIFIED                                        │
└───────────────────────────────────┬────────────────────────────────────┘
                                    │
                                    ▼
┌────────────────────────────────────────────────────────────────────────┐
│                   PHASE 2: API & DATA LAYER                            │
│  • Technology: ASP.NET Core Web API & Relational DB (PostgreSQL/SQL)  │
│  • Focus: REST Endpoints, DTOs, Repository Pattern, Multi-Client Sync │
│  • Status: Planned Next Milestone                                     │
└───────────────────────────────────┬────────────────────────────────────┘
                                    │
                                    ▼
┌────────────────────────────────────────────────────────────────────────┐
│                   PHASE 3: WEB APPLICATION                             │
│  • Technology: ASP.NET Core MVC / Razor Pages                         │
│  • Focus: Kitchen Order List (KDS), Role-Based Auth, Web Dashboard    │
│  • Status: Future Milestone                                           │
└────────────────────────────────────────────────────────────────────────┘
```

---

## Phase 1: Desktop Application Details

Phase 1 provides a fully functional standalone desktop workstation that requires **no external database or server setup** to run.

### Core Features

1. **Executive Dashboard (`DashboardView`)**
   - Live KPI stat cards: *Total Orders (12)*, *Pending (2)*, *Preparing (3)*, *Ready (2)*, *Completed (5)*, and *Completed Revenue (1,850 ETB)*.
   - Interactive Recent Orders summary table displaying order status badges.
   - Quick navigation shortcuts to create orders and view details.

2. **Menu Catalog (`MenuView`)**
   - Displays all registered food and beverage items with categorized cards.
   - Live search filter by item name or category.
   - Visual status indicators (*Available* in green pill, *Unavailable* in amber/red pill).

3. **Order Creation (`NewOrderView`)**
   - Automatic unique order number assignment (e.g. `#116`).
   - Customer name validation (required, inline red feedback).
   - Table number selection (supports multiple customers seated at the same table).
   - Dynamic line-item builder with menu selection, quantity controls, and live subtotal calculation.
   - Single-click line item removal (`🗑 Remove`).
   - Visual alert banners for validation errors and success confirmations.

4. **Order Management & Table Tracker (`OrdersView`)**
   - Unified orders grid with balanced column spacing: Order #, Customer, Table, Created Time, Total (ETB), Status, and Actions.
   - Real-time search across Customer Name, Order Number, and Table Number.
   - Filter dropdown by status (`All`, `Pending`, `Preparing`, `Ready`, `Completed`, `Cancelled`).
   - Action controls: `View`, `Edit`, `Change Status`, and `Cancel`.

5. **Order Details & Modification (`OrderDetailsView` & `EditOrderView`)**
   - Detailed inspection of order metadata, customer name, table number, timestamps, and line items.
   - Ability to add new menu items or update quantities on active orders.
   - Live re-calculation of order totals upon editing.
   - Strict lock preventing edits or cancellations once an order is marked *Completed*.

6. **Order Lifecycle Transitions (`ChangeStatusDialog`)**
   - Step-by-step state progression: `Pending` $\rightarrow$ `Preparing` $\rightarrow$ `Ready` $\rightarrow$ `Completed`.
   - Option to cancel unfinished orders with confirmation.

7. **Operational Reporting (`ReportsView`)**
   - Summary statistics covering active orders, status distribution, and total completed revenue.
   - Radio button filters for quick segment inspection (`All`, `Pending`, `Preparing`, `Ready`, `Completed`).
   - Detailed summary table with sorting and double-click inspection.

8. **Admin Menu Management (`MenuManagementView` & `PinEntryDialog`)**
   - Protected behind an Admin Security PIN (`1234`).
   - Add new food and beverage items with category, price, and initial availability.
   - Edit existing menu item details and prices.
   - One-click status toggle (`Available` $\leftrightarrow$ `Unavailable`).

---

### Business Invariants & Rules

The system enforces critical restaurant business logic:

1. **Price Snapshot Freezing:** When an item is added to an order, its `UnitPrice` is frozen on that order. If management changes menu prices later (e.g. Coffee goes from 40 ETB to 50 ETB), past orders retain their historical 40 ETB unit price snapshot.
2. **Order vs. Table Separation:** Multiple independent customers can share the same table (e.g. Table 4). Each customer receives their own distinct `OrderNumber` and bill.
3. **Completed Order Immutability:** Once food has been delivered and an order is marked `Completed`, it is permanently locked. It cannot be edited or cancelled.
4. **Input Validation:** Customer Name is required; Table Number must be $\ge 1$; Item quantities must be positive integers; unavailable items cannot be added to new orders.

---

### Default System Credentials & Data

| Setting | Default Value | Description |
| :--- | :--- | :--- |
| **Active Staff Account** | Walter: Abebe (Staff / Waiter) | Displayed in top navigation bar |
| **Admin Security PIN** | `1234` | Required to access **Manage Menu** administration |
| **Seeded Baseline Orders** | 12 total orders | Seeded historical table orders (`#104` to `#115`) |
| **Completed Revenue Baseline**| 1,850 ETB | Sum of initial completed orders (`#107`, `#112`, `#113`, `#114`, `#115`) |
| **Default Menu Items** | 5 core items | Coffee (40 ETB), Tea (30 ETB), Juice (60 ETB, Unavailable), Burger (180 ETB), Pizza (250 ETB) |

---

## System Architecture & Design

### Directory Structure

```
c:\Users\hp\source\repos\RMS\
│
├── RMS/                            # Main C# WinForms Project
│   ├── Common/
│   │   └── AppTheme.cs             # Design system tokens (colors, fonts, radii)
│   ├── Models/
│   │   ├── MenuItem.cs             # Menu item entity
│   │   ├── Order.cs                # Order entity with line items and totals
│   │   ├── OrderItem.cs            # Frozen price line-item model
│   │   └── OrderStatus.cs          # Status enum (Pending, Preparing, Ready, Completed, Cancelled)
│   ├── Services/
│   │   ├── IRestaurantStore.cs     # Contract for data operations
│   │   ├── OrderService.cs         # Order workflow logic & state validation
│   │   └── RestaurantStore.cs      # In-memory store with seeded data & JSON persistence
│   ├── UI/
│   │   ├── Dialogs/
│   │   │   ├── ChangeStatusDialog.cs # Order status progression modal
│   │   │   ├── ConfirmationDialog.cs # Cancellation & discard confirmation modal
│   │   │   ├── MenuItemDialog.cs     # Add/edit menu item modal
│   │   │   └── PinEntryDialog.cs     # Admin PIN verification modal
│   │   ├── Navigation/
│   │   │   ├── INavigationAware.cs   # Lifecycle interface for views
│   │   │   └── ViewType.cs           # Enum of all screen views
│   │   ├── Views/
│   │   │   ├── BaseView.cs           # Abstract base UserControl with standardized header
│   │   │   ├── DashboardView.cs      # KPI metric overview screen
│   │   │   ├── EditOrderView.cs      # Order modification screen
│   │   │   ├── MenuManagementView.cs # Admin menu management screen
│   │   │   ├── MenuView.cs           # Customer menu catalog screen
│   │   │   ├── NewOrderView.cs       # Order creation screen
│   │   │   ├── OrderDetailsView.cs   # Read-only order review screen
│   │   │   ├── OrdersView.cs         # Master order management grid
│   │   │   └── ReportsView.cs        # Revenue & sales report screen
│   │   ├── MainForm.cs               # Application shell (Sidebar, Header, Host Panel)
│   │   └── MainForm.Designer.cs
│   ├── Program.cs                    # Application entry point
│   └── RMS.csproj                    # Project configuration (.NET 10.0 Windows Forms)
│
├── docs/                           # Software Engineering Documentation
│   ├── Group-5-SRS.md               # Software Requirements Specification (SRS)
│   ├── Phase-1-Reqirments.md        # Detailed Phase 1 functional blueprint
│   ├── Main-Design.md               # Visual design tokens and UI architecture
│   └── Workflow.md                  # Development methodology and review logs
│
└── UI/                             # Reference Mockups & Screen Wireframes
    ├── dashboard/                   # Reference images for Dashboard
    ├── menu/                        # Reference images for Menu
    ├── new-order/                   # Reference images for Order Creation
    ├── orders/                      # Reference images for Order Management
    └── reports/                     # Reference images for Reports
```

### Event-Driven Pattern

All business operations execute through decoupled events:
- When an order is added, edited, advanced, or cancelled, `RestaurantStore` raises `OnOrdersChanged`.
- Views subscribe to these events and update their grids and badges reactively.
- No direct coupling exists between view controllers, enabling clean extensibility for Phase 2 API synchronization.

### Design System & Theme

The UI follows the approved reference design system defined in [`AppTheme.cs`](file:///c:/Users/hp/source/repos/RMS/RMS/Common/AppTheme.cs):
- **Primary Brand:** Deep Burgundy (`#2E181D` Sidebar, `#7A2030` Buttons & Accents)
- **Canvas Background:** Warm Off-White (`#F8F6F4`)
- **Card Surfaces:** Pure White (`#FFFFFF`) with subtle border (`#EBE6E1`)
- **Typography:** Microsoft Segoe UI hierarchy (16pt Bold headers, 9.5pt Body, 8.5pt Badges)
- **Status Pills:** Standardized color pairs (Amber for Pending, Orange for Preparing, Emerald for Ready, Slate for Completed, Soft Red for Cancelled)

---

## Prerequisites & Getting Started

### Environment Requirements
- **Operating System:** Windows 10 (Build 19041+) or Windows 11
- **.NET SDK:** [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) (or .NET 8.0+ with Windows Desktop Workload)
- **IDE (Optional):** Visual Studio 2022 (v17.10+), JetBrains Rider, or VS Code with C# Dev Kit

### Build and Run

1. **Clone the repository:**
   ```bash
   git clone https://github.com/samuelabera21/Restaurant-Managment-System-RMS-With-C-.git
   cd Restaurant-Managment-System-RMS-With-C-
   ```

2. **Restore dependencies and build:**
   ```bash
   dotnet build RMS/RMS.csproj
   ```

3. **Launch the Desktop Application:**
   ```bash
   dotnet run --project RMS/RMS.csproj
   ```

---

### Running Automated Verification Tests

A dedicated verification test suite validates all 82 Phase 1 functional scenarios, model invariants, status state machines, and view lifecycles:

```bash
dotnet test
# OR run the standalone verification runner:
dotnet run --project scratch/VerificationTest/VerificationTest.csproj
```

**Test Coverage Highlights:**
- `[PASS]` Default menu items loaded (5 items, Juice Unavailable at 60 ETB, Coffee Available at 40 ETB).
- `[PASS]` Seeded orders validation (12 seeded orders, 5 completed, 1,850 ETB completed total).
- `[PASS]` Automatic sequential order numbering (`#116`, `#117`).
- `[PASS]` Validation rejection on empty customer name, table number $\le 0$, and empty cart.
- `[PASS]` Price freezing snapshot retains original pricing after catalog updates.
- `[PASS]` Order lifecycle progression: `Pending` $\rightarrow$ `Preparing` $\rightarrow$ `Ready` $\rightarrow$ `Completed`.
- `[PASS]` Completed order immutability guards (throws on edit or cancellation attempts).

---

## Interactive Demonstration Script

To verify Phase 1 acceptance in 3 minutes, follow this script:

1. **Start Application:** The dashboard opens showing **12 Total Orders**, **5 Completed**, and **1,850 ETB** completed revenue.
2. **Review Menu:** Click **Menu** in the sidebar. Confirm 5 items appear, with Coffee at 40 ETB and Juice marked *Unavailable*.
3. **Create Order (Hana's Order):**
   - Click **New Order** in the sidebar. Note that `#116` is automatically generated.
   - Enter Customer Name: `Hana`.
   - Table Number: `4`.
   - Select `Coffee`, Quantity `2` $\rightarrow$ Click **+ Add Item** (Subtotal: 80 ETB).
   - Select `Burger`, Quantity `1` $\rightarrow$ Click **+ Add Item** (Subtotal: 180 ETB).
   - Note the Total automatically updates to **260 ETB**.
   - Click **💾 Save Order**. A green confirmation banner displays: *"Order #116 created successfully!"*
4. **Locate Order in Orders View:**
   - Click **Orders** in the sidebar.
   - Search `Hana` in the search box; Order `#116` appears with status `Pending`.
5. **Progress Order Status:**
   - Click **Change Status** on Order `#116`.
   - Advance status from `Pending` $\rightarrow$ `Preparing` $\rightarrow$ `Ready` $\rightarrow$ `Completed`.
6. **Verify Reports & Revenue Update:**
   - Click **Reports** in the sidebar.
   - Notice Completed Orders incremented from 5 to 6, and Completed Order Value automatically increased from 1,850 ETB to **2,110 ETB** ($1,850 + 260$).
7. **Test Admin Menu Management:**
   - Click **Manage Menu** under Administration in the sidebar.
   - Enter PIN: `1234` and click **Unlock**.
   - Click **+ Add Menu** to add a new specialty item, or click **Toggle Status** to make Juice available.

---

## Upcoming Phases Preview

### Phase 2: RESTful Web API & Database Storage
- Migration from local in-memory/JSON storage to a centralized **PostgreSQL** or **SQL Server** database.
- Development of an **ASP.NET Core Web API** with controllers for `/api/menu`, `/api/orders`, and `/api/reports`.
- Introduction of Entity Framework Core, Repository & Unit-of-Work patterns, and Data Transfer Objects (DTOs).
- Transition of the desktop client from local memory to asynchronous HTTP communication (`HttpClient`) with server-side error handling.

### Phase 3: Kitchen Display System (KDS) & Web Portal
- Responsive Web Application developed in **ASP.NET Core MVC** or **Razor Pages**.
- Dedicated **Kitchen Display System (KDS)** interface for kitchen staff to view incoming tickets in real-time.
- Role-based authorization separating Waiter, Kitchen Staff, and Restaurant Manager permissions.
- Live order status synchronization across web and desktop clients using **SignalR**.

---

## Authors & Acknowledgments
- **Project:** ዉለታ Restaurant Order Management System (RMS)
- **Course:** Event-Driven Programming — Software Engineering Department
- **Author:** Samuel Abera ([@samuelabera21](https://github.com/samuelabera21))
- **Pair Programming AI:** Antigravity (Google DeepMind)
