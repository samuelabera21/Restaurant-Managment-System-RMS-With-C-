

<!-- Start of picture text -->
PAL ACTS PCO:<br>a<br>pea an ie)<br>DEBRE BERHAN UNIVERSITY<br><!-- End of picture text -->

# **DEBRE BIRHANUNIVERSITY** 

## **COLLEGE OF COMPUTING** 

**DEPARTMENT OF SOFTWAREENGINEERING** 

**Restaurant Order Management System (RMS)** Software **So�ware Requirements Specifica�on** Requirements Specification 

**Course: Event-Driven Programming** 

**Group 5** 

**GROUP MEMBERS                                                                                         ID Kalkidan Behailu-------- ---- ---- ------ ----- ------ ---------- ----- ----- -DBU1601272 Lidiya Abebaw--------- ---- ---- ------ ----- ------ ---------- ----- ----- ---DBU1601308 Samuel Abera---------- ---- ---- ------ ----- ------ ---------- ----- ----- ---DBU1601589** 

**Submi�ed To: Biniyam.T** Submitted To: Biniyam.T **Date: 09/02/2019 E.C** 

### **So�ware Requirements Specifica�on (SRS)** 

ዉለታ **Restaurant Order Management System** 

**Department:** So�ware Engineering **Course:** Event-Driven Programming **Project Type:** Group Project — C# Desktop, API/Data Layer, and Web Applica�on **Group Size:** 5–6 students **Dura�on:** 2 months **Date:** 02/02/2019 

### **1. Introduc�on** 

### **1.1 Project Overview** 

ዉለታ Restaurant Order Management System is a so�ware applica�on designed to help restaurant employees manage food orders, menu items, and order prepara�on. 

The system will allow waiters to record customers’ orders through a C# Windows Forms desktop applica�on. Kitchen staff will view incoming orders and update their prepara�on status through a web applica�on. The restaurant manager will manage menu items and view basic reports through the web applica�on. 

The desktop applica�on, ASP.NET Web API, database, and web applica�on will be developed in three phases according to the lecturer’s requirements. 

### **1.2 Problem Statement** 

Managing restaurant orders manually can cause mistakes when recording food items, calcula�ng totals, communica�ng orders to the kitchen, and checking prepara�on status. Handwri�en records can also make it difficult for the manager to review daily restaurant ac�vity. 

The proposed system will provide a centralized way to record orders, share order informa�on between restaurant staff, and review basic reports. 

### **2. Objec�ves** 

### **2.1 General Objec�ve** 

To develop a restaurant order management system that improves the recording, prepara�on, and monitoring of customer orders. 

### **2.2 Specific Objec�ves** 

- To record customer orders and calculate their totals. 

- To maintain menu items, prices, and availability. 

- To allow kitchen staff to view orders and update prepara�on status. 

- To allow waiters to monitor orders and iden�fy ready orders. 

- To store and manage order informa�on using a database and REST API. 

- To provide the manager with basic reports about restaurant orders. 

### **3. Project Scope** 

### **3.1 Included in the Project** 

The ini�al system will include: 

- A C# Windows Forms desktop applica�on for waiters. 

- Customer names, table numbers, and individual customer orders. 

- Adding menu items and quan��es to orders. 

- Automa�c order numbering and total calcula�on. 

- Viewing, searching, edi�ng, and managing orders. 

- An ASP.NET Web API for communica�on between applica�ons and the database. 

- A database for storing menu items, users, orders, and order items. 

- A web applica�on for kitchen staff and the manager. 

- Basic authen�ca�on for authorized users. 

- Order status updates and basic no�fica�ons to help waiters iden�fy ready orders. 

- A dashboard and simple reports. 

### **3.2 Outside the Project Scope** 

The ini�al system will not include: 

- Online customer ordering or customer accounts. 

- Real payment processing or payment gateway integra�on. 

- Employee salary management. 

- Inventory purchasing and supplier management. 

- Full accoun�ng or financial management. 

- Food delivery tracking. 

- Advanced real-�me communica�on using technologies such as SignalR. 

The system may display order totals and summarize the value of completed orders, but these figures will not represent verified payments received. 

### **4. System Users** 

|**User**|**Main responsibili�es**|
|---|---|
|Waiter / Service Staff|View the menu, create orders, add items,<br>search orders,and checkprepara�on status.|
|Kitchen Staff|View incoming orders and update their<br>prepara�on status.|
|Manager / Owner|Add, view, edit, and remove menu items;<br>view orders and reports.|
|Customer|Communicate food choices to the waiter;<br>does not use the so�ware directly.|



One employee may perform more than one role in the restaurant. The so�ware will provide access according to the user's assigned permissions. 

### **5. Func�onal Requirements** 

### **5.1 Desktop Applica�on — Phase 1** 

The first phase will use C# Windows Forms and local in-memory storage. A database and API are not required in this phase. 

### **FR-01: Naviga�on** 

The system shall provide forms and menus for naviga�ng between the main applica�on func�ons. 

### **FR-02: Menu Display** 

The system shall display available menu items, their prices, and their availability. 

### **FR-03: Create Orders** 

The system shall allow the waiter to create an order by entering a customer name, table number, menu items, and quan��es. 

### **FR-04: Order Number** 

The system shall generate a unique order number for each new order. 

### **FR-05: Separate Customer Orders** 

The system shall allow mul�ple customers at the same table to have separate orders. 

### **FR-06: Add Order Items** 

The system shall allow the waiter to add menu items and quan��es to an exis�ng order before it is completed. 

### **FR-07: Calculate Total** 

The system shall calculate each order's total based on item prices and quan��es. 

### **FR-08: Display Orders** 

The system shall display orders in a list, using a ListView or another suitable Windows Forms list control. 

### **FR-09: Search and Filter** 

The system shall allow the waiter to search for orders by order number, customer name, or table number and filter them by status. 

### **FR-10: Edit and Cancel Orders** 

The system shall allow permi�ed changes to orders and cancella�on of orders that have not been completed. 

### **FR-11: Input Valida�on** 

The system shall validate required fields and reject invalid quan��es, missing informa�on, and invalid prices. 

### **FR-12: Status Messages** 

The system shall display messages indica�ng whether an opera�on succeeded or failed. 

### **FR-13: Basic Repor�ng View** 

The desktop applica�on shall provide a simple view of order informa�on and totals. 

### **5.2 API and Data Layer — Phase 2** 

This phase will introduce ASP.NET Web API, a database, and communica�on between the desktop applica�on and the API. 

### **FR-14: REST API** 

The system shall provide REST API endpoints for crea�ng, viewing, upda�ng, and dele�ng permi�ed records. 

### **FR-15: Database Storage** 

The system shall store menu items, user accounts, orders, and order items in a rela�onal database. 

### **FR-16: Data Rela�onships** 

The database shall associate each order with its order items and each order item with its corresponding menu item. 

### **FR-17: Desktop API Integra�on** 

The desktop applica�on shall retrieve and manage persistent data through the API instead of relying only on temporary in-memory storage. 

### **FR-18: Order Status Management** 

The system shall support the order statuses Pending, Preparing, Ready, and Completed. 

### **FR-19: Error Handling** 

The API shall handle invalid requests and database errors and return appropriate responses. 

### **FR-20: Basic Logging** 

The system shall record basic technical errors to support troubleshoo�ng. 

### **FR-21: DTO and Service Structure** 

The system shall use Data Transfer Objects (DTOs) for API communica�on and a repository/service layer to organize data access and business logic. 

### **5.3 Web Applica�on — Phase 3** 

The web applica�on will use ASP.NET MVC, Razor Pages, or another lecturer-approved approach and will connect to the same API. 

### **FR-22: Login** 

The system shall provide a login page for authorized users. 

### **FR-23: Role-Based Access** 

The system shall restrict menu management and repor�ng to the manager and order prepara�on func�ons to kitchen staff, according to assigned permissions. 

### **FR-24: Kitchen Order List** 

The system shall display incoming orders, their items, quan��es, order numbers, and table numbers. 

### **FR-25: Update Prepara�on Status** 

The system shall allow kitchen staff to change an order from Pending to Preparing and then to Ready. 

### **FR-26: Order Comple�on** 

The system shall allow the waiter to mark an order Completed a�er delivering the food. 

### **FR-27: Order Updates** 

The system shall make new orders and status changes available to connected applica�ons through the API. The kitchen order list shall check for updates periodically. 

### **FR-28: Menu Management** 

The system shall allow the manager to add, view, edit, and remove menu items and update their prices and availability. 

### **FR-29: Dashboard** 

The system shall display a basic dashboard showing order counts and other relevant summary informa�on. 

### **FR-30: Reports** 

The system shall provide reports showing the number of orders created and completed, the value of completed orders, and frequently ordered menu items. 

### **FR-31: Search and Filter** 

The web applica�on shall allow users to search and filter orders using relevant informa�on, such as order number and status. 

### **FR-32: Responsive Interface** 

The web applica�on shall provide a usable layout on common desktop and mobile screen sizes. 

### **6. Main Order Workflow** 

1. The waiter checks the menu and records the customer's order. 

2. The system generates an order number, records the table number and customer name, and calculates the total. 

3. The order is saved and becomes visible to kitchen staff. 

4. Kitchen staff mark the order as Preparing when prepara�on begins. 

5. Kitchen staff mark the order as Ready when the food is ready. 

6. The waiter sees the updated status, collects the food, and delivers it. 

7. The waiter marks the order Completed. 

8. The manager can review the order and its value in reports. 

Each customer at a shared table will have a separate order. Addi�onal items may be added to that customer's exis�ng order before comple�on. Newly added items must also become visible to kitchen staff. 

### **7. Main Data En��es** 

The database will contain the following main en��es: 

- **User:** Stores the account informa�on and role of each authorized user. 

- **MenuItem:** Stores the name, descrip�on if needed, price, and availability of each menu item. 

- **Order:** Stores the unique order number, customer name, table number, crea�on �me, status, and total. 

- **OrderItem:** Stores the menu item, quan�ty, and price recorded for each item in an order. 

An order can contain mul�ple order items, and a menu item can appear in many different orders. Order-item prices should be recorded when the order is placed so that later menu price changes do not alter historical order totals. 

### **8. Non-Func�onal Requirements** 

- **Usability:** Forms and pages shall be clear and easy for restaurant employees to use. 

- **Valida�on:** The system shall validate user input before saving data. 

- **Reliability:** The API and database shall maintain consistent order informa�on. 

- **Security:** Authorized pages and opera�ons shall require appropriate access permissions. 

- **Maintainability:** The project shall use a clear separa�on between the user interface, business logic, API, and data access. 

- **Performance:** Common opera�ons, such as displaying orders and upda�ng status, shall complete within a reasonable �me under normal project tes�ng condi�ons. 

**9. Development Phases and Deliverables** 

|**Phase**|**Weeks**|**Main deliverables**|
|---|---|---|
|Phase 1: Desktop|1–3|Event-driven WinForms interface, forms, valida�on, naviga�on, order<br>calcula�ons,and temporaryin-memorydata.|
|||ASP.NET Web API, rela�onal database, CRUD opera�ons,|
|Phase 2: API and Data|4–6|service/repository structure, error handling, logging, and desktop API<br>integra�on.|
|Phase 3: Web|7–8|Login, role-based access, kitchen order list, menu management,<br>dashboard,reports,and API integra�on.|



The final submission will include the desktop, API, and web source code; database schema; documenta�on of approximately 5–10 pages; and a group contribu�on report. 

### **10. Conclusion** 

The ዉለታ Restaurant Order Management System will provide a prac�cal way to manage restaurant menus and customer orders. It will connect a Windows Forms desktop applica�on, an ASP.NET Web API, a rela�onal database, and a web applica�on. The project will follow the lecturer's three development phases and focus on the core func�ons needed for a working restaurant order management system within the available two months. 

