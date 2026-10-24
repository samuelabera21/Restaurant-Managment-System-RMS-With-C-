ዉለታ **Restaurant Order Management System** 

**Phase 1 — C# Windows Forms Desktop Applica�on** 

**UI & Func�onal Blueprint** 

**Course:** Event-Driven Programming **Department:** So�ware Engineering **Project:** Restaurant Order Management System (RMS) **Phase:** Phase 1 — Desktop Applica�on **Technology:** C# Windows Forms **Data Storage:** Local in-memory storage **Database:** Not used in Phase 1 **API:** Not used in Phase 1 **Primary User:** Waiter / Service Staff 

# **1. Purpose of This Document**

This document converts the approved SRS requirements into a concrete Phase 1 desktop applica�on design. 

It defines: 

- Which screens/forms will exist. 

- What the user sees on each screen. 

- What the user can click. 

- What happens a�er each click. 

- What informa�on the user enters. 

- What valida�on occurs. 

- What data changes. 

- What output the user should see. 

- How the forms connect to each other. 

- How the real restaurant workflow is represented in the desktop applica�on. 

This document will later be used as the blueprint for: 

1. UI/UX design in S�tch/Figma/Penpot. 

2. C# Windows Forms implementa�on. 

3. Event-driven programming. 

4. Phase 1 tes�ng. 

5. Phase 1 demonstra�on. 

# **2. Phase 1 Scope** 

Phase 1 implements the following requirements from the SRS: 

- **FR-01:** Naviga�on 

- **FR-02:** Menu Display 

- **FR-03:** Create Orders 

- **FR-04:** Automa�c Order Number 

- **FR-05:** Separate Customer Orders 

- **FR-06:** Add Order Items 

- **FR-07:** Calculate Total 

- **FR-08:** Display Orders 

- **FR-09:** Search and Filter 

- **FR-10:** Edit and Cancel Orders 

- **FR-11:** Input Valida�on 

- **FR-12:** Status Messages 

- **FR-13:** Basic Repor�ng View 

# **3. Phase 1 Actors** 

# **3.1 Waiter / Service Staff** 

The waiter is the primary Phase 1 user. 

The waiter can: 

- Open the applica�on. 

- View the menu. 

- Check menu availability and prices. 

- Create customer orders. 

- Enter customer name. 

- Enter table number. 

- Add menu items. 

- Enter quan��es. 

- Save orders. 

- Search orders. 

- Filter orders. 

- Edit unfinished orders. 

- Cancel permi�ed orders. 

- Check order status. 

- View basic order informa�on and totals. 

# **3.2 Manager / Owner** 

The manager is not the main Phase 1 user. 

For Phase 1, the manager may use the desktop applica�on to: 

- View menu informa�on. 

- View orders. 

- View basic repor�ng informa�on. 

The more advanced manager func�onality belongs to the Web Applica�on in Phase 3. 

# **3.3 Kitchen Staff** 

Kitchen staff do not need a separate Phase 1 applica�on. 

Their full workflow will be implemented later through the Web Applica�on. 

Phase 1 may s�ll display order statuses such as: 

- Pending 

- Preparing 

- Ready 

- Completed 

This allows the desktop applica�on to represent the complete order lifecycle without implemen�ng the real API/web communica�on yet. 

# **3.4 Customer** 

The customer does not directly use the so�ware. 

Example: 

Hana says: 

"I want two coffees and one burger." 

The waiter listens to Hana and enters the informa�on into the applica�on. 

# **4. Phase 1 System Boundary** 

The Phase 1 system is: 

Waiter 

| 

v 

C# Windows Forms Applica�on 

| | | 

+---- Menu 

+---- Orders 

+---- Local Business Logic | 

+---- In-Memory Data 

There is no: 

SQL Server PostgreSQL ASP.NET API 

Web Applica�on 

Online Customer Ordering 

Real Payment Gateway 

SignalR 

Those belong to later phases. 

# **5. Overall Applica�on Structure** 

The desktop applica�on should contain the following main areas: 

ዉለታ Restaurant RMS 

│ 

- `├` ── Dashboard / Home │ 

- `├` ── Menu │ 

- `├` ── New Order 

│ 

- `├` ── Orders 

- │ `├` ── Search 

- │ `├` ── Filter 

│ `├` ── View 

│ `├` ── Edit 

- │   └── Cancel 

│ 

└── Reports 

The main naviga�on should always allow the waiter to move between these areas without closing the en�re applica�on. 

# **6. Main Applica�on Layout** 

The recommended desktop structure is: 

|┌───────────────────────<br>│ዉለታRestaurant RMS|──────────────────────────────────────┐<br>User: Waiter │|
|---|---|
|`├`───────────────`┬`─────|────────────────────────────────────────`┤`|
|│               │|│|
|│  Dashboard    │|│|
|│               │|│|
|│  Menu         │             MAIN C|ONTENT                    │|
|│               │|│|
|│  New Order    │|│|
|│               │|│|
|│  Orders       │|│|
|│               │|│|
|│  Reports      │|│|
|│               │|│|
|│  Exit         │|│|
|│               │|│|



`├` ─────────────── `┴` ───────────────────────────────────────────── `┤` 

│ Status: Ready                                                │ 

└─────────────────────────────────────────────────────────────┘ 

The le� side is the main naviga�on. 

The center area displays the selected func�onality. 

The bo�om status area displays system messages. 

# **7. Screen 1 — Dashboard / Home** 

# **7.1 Purpose** 

The Dashboard is the first screen displayed when the applica�on starts. 

Its purpose is to give the waiter a quick overview and provide naviga�on to the main func�ons. 

# **7.2 Dashboard Informa�on** 

The dashboard can display: 

Welcome to ዉለታ Restaurant 

Today's Orders 

12 

Pending 

2 

Preparing 

3 

Ready 

2 

Completed 

# 5 

Completed Order Value 

1,850 ETB 

These values come from the local in-memory orders. 

# **8. Dashboard Clickable Ac�ons** 

**Ac�on 1 — Click "Menu"** 

# **User ac�on** 

The waiter clicks: 

**Menu** 

# **System event** 

MenuBu�on_Click 

# **Expected result** 

The Menu screen opens. 

# **Ac�on 2 — Click "New Order"** 

# **User ac�on** 

The waiter clicks: 

**New Order** 

# **Expected result** 

The Create Order screen opens. 

# **Ac�on 3 — Click "Orders"** 

# **User ac�on** 

The waiter clicks: 

**Orders** 

# **Expected result** 

The Orders screen opens. 

# **Ac�on 4 — Click "Reports"** 

# **User ac�on** 

The waiter clicks: 

**Reports** 

# **Expected result** 

The Basic Reports screen opens. 

# **9. Screen 2 — Menu** 

# **9.1 Purpose** 

The Menu screen allows the waiter to see available restaurant food and drink items. This sa�sfies: 

**FR-02 — Menu Display** 

# **9.2 Menu Screen** 

Recommended layout: 

┌─────────────────────────────────────────────────────────────┐ │ Menu                                                        │ `├` ───────────────────────────────────────────────────────────── `┤` 

│ Search Menu: [____________________]                         │ 



<!-- Start of picture text -->
│                                                             │<br>│ ┌────────── ┬ ─────────────── ┬ ─────────────┐                 │<br>│ │ Item     │ Price         │ Availability │                 │<br>│  ├ ────────── ┼ ─────────────── ┼ ───────────── ┤                  │<br>│ │ Coffee   │ 40 ETB        │ Available   │                 │<br>│ │ Tea      │ 30 ETB        │ Available   │                 │<br>│ │ Juice    │ 60 ETB        │ Available   │                 │<br>│ │ Burger   │ 180 ETB       │ Available   │                 │<br>│ │ Pizza    │ 250 ETB       │ Available   │                 │<br>│ └────────── ┴ ─────────────── ┴ ─────────────┘                 │<br>└─────────────────────────────────────────────────────────────┘<br><!-- End of picture text -->

The exact visual design will be decided later. 

# **10. Menu Interac�on** 

# **Ac�on — Select a menu item** 

The waiter clicks an item. 

# **Expected result** 

The selected item becomes highlighted. 

The applica�on can display: 

Selected Item 

Coffee 

Price: 40 ETB 

Availability: Available 

# **Ac�on — Search menu** 

The waiter enters: 

Coffee 

# **Expected result** 

Only matching menu items are displayed. 

# **11. Screen 3 — Create New Order** 

This is the most important screen in Phase 1. 

It implements: 

|<br>F|R-03|
|---|---|
|<br>F|R-04|
|<br>F|R-05|
|<br>F|R-06|
|<br>F|R-07|
|<br>F|R-11|
|<br>F|R-12|



# **12. Create Order Screen Layout** 

Recommended structure: 

┌─────────────────────────────────────────────────────────────┐ │ Create New Order                                            │ `├` ───────────────────────────────────────────────────────────── `┤` │                                                             │ │ Order Number:  [104]       Generated automa�cally         │ │                                                             │ │ Customer Name: [________________________]                   │ │                                                             │ 

│ Table Number:  [____]                                       │ │                                                             │ `├` ───────────────────────────────────────────────────────────── `┤` │ Add Order Item                                              │ │                                                             │ │ Menu Item: [ Select Item ▼ ]                                │ │ Quan�ty:  [____]                                          │ │                                                             │ │                    [ Add Item ]                             │ │                                                             │ `├` ───────────────────────────────────────────────────────────── `┤` │ Order Items                                                 │ │                                                             │ │ Item       Quan�ty     Unit Price       Subtotal           │ │ Coffee       2          40 ETB           80 ETB             │ │ Burger       1          180 ETB          180 ETB            │ │                                                             │ `├` ───────────────────────────────────────────────────────────── `┤` │ Total:                                      260 ETB          │ │                                                             │ │ [ Save Order ]       [ Clear ]       [ Cancel ]             │ └─────────────────────────────────────────────────────────────┘ 

# **13. Create Order — Step-by-Step Workflow** 

We will use Hana's order as the demonstra�on example. 

# **Step 1 — Open Create Order** 

The waiter clicks: 

**New Order** 

# **Expected result** 

The Create Order form opens. 

The system automa�cally generates an order number. 

Example: 

Order Number: 104 

The waiter does not type this number. 

# **14. Step 2 — Enter Customer Name** 

The waiter clicks: 

**Customer Name** 

and enters: 

Hana 

# **Expected value** 

Customer Name = Hana 

# **15. Step 3 — Enter Table Number** 

The waiter clicks: 

# **Table Number** 

and enters: 

# 4 

# **Expected value** 

Table Number = 4 

# **16. Step 4 — Select Menu Item** 

The waiter clicks: 

**Menu Item** 

A dropdown opens: 

Coffee Tea Juice Burger Pizza 

The waiter selects: 

**Coffee** 

# **17. Step 5 — Enter Quan�ty** 

The waiter enters: 

2 

The form displays: 

Coffee 

Quan�ty: 2 Unit Price: 40 ETB Subtotal: 80 ETB 

**18. Step 6 — Click "Add Item"** 

The waiter clicks: 

**Add Item** 

**Event** 

AddItemBu�on_Click 

# **System processing** 

The applica�on: 

1. Checks that a menu item was selected. 

2. Checks that quan�ty is valid. 

3. Gets the menu item's price. 

4. Calculates the subtotal. 

5. Adds the item to the temporary order. 

6. Refreshes the order item list. 

7. Recalculates the total. 

# **Expected result** 

The order list now displays: 

Coffee    2    40 ETB    80 ETB 

# **19. Step 7 — Add Burger** 

The waiter selects: 

Burger 

Quan�ty: 

1 

Then clicks: 

**Add Item** 

# **Expected result** 

Coffee    2    40 ETB     80 ETB 

Burger    1    180 ETB    180 ETB 

Total: 

260 ETB 

# **20. Step 8 — Automa�c Total Calcula�on** 

The system calculates: Coffee: 40 × 2 = 80 ETB 

Burger: 180 × 1 = 180 ETB 

Total: 

80 + 180 = 260 ETB The waiter does not enter the total manually. 

# **21. Step 9 — Save Order** 

The waiter clicks: 

**Save Order** 

The applica�on performs valida�on. If everything is valid: Order #104 created successfully. The order is added to local memory. Conceptually: Orders [ Order #104 ] 

# **22. Invalid Save Example** 

Suppose the waiter leaves Customer Name empty. 

The waiter clicks: 

**Save Order** 

The applica�on should not save the order. 

Expected message: Customer name is required. 

The form remains open. 

# **23. Another Valida�on Example** 

Suppose quan�ty is: 

-2 

Expected message: 

Quan�ty must be greater than zero. 

The item is not added. 

# **24. Another Valida�on Example** 

Suppose the waiter enters: 

Table Number = ABC 

Expected message: 

Please enter a valid table number. 

# **25. Another Valida�on Example** 

Suppose the waiter selects an unavailable item. 

Expected message: 

This menu item is currently unavailable. 

The item is not added. 

# **26. Screen 4 — Orders** 

The Orders screen is the main management screen for exis�ng orders. 

It implements: 

||FR-08|
|---|---|
||FR-09|
||FR-10|
||FR-12|



# **27. Orders Screen Layout** 

Recommended structure: 

┌─────────────────────────────────────────────────────────────┐ │ Orders                                                      │ `├` ───────────────────────────────────────────────────────────── `┤` │ Search: [____________________]                              │ │                                                             │ │ Search By: [Order Number ▼]    Status: [All ▼]             │ │                                                             │ │ [ Search ]    [ Clear ]                                    │ │                                                             │ `├` ───────────────────────────────────────────────────────────── `┤` │ Orders                                                      │ │                                                             │ │ Order │ Customer │ Table │ Total │ Status                  │ │ #104  │ Hana     │ 4     │ 260   │ Pending                 │ │ #105  │ Abel     │ 4     │ 250   │ Pending                 │ 

│ #106  │ Sara     │ 4     │ 30    │ Ready                   │ │                                                             │ `├` ───────────────────────────────────────────────────────────── `┤` 

│ [ View ] [ Edit ] [ Cancel ]                               │ 

└─────────────────────────────────────────────────────────────┘ 

# **28. Display Orders** 

When the Orders screen opens: 

# **Expected result** 

All locally stored orders appear. 

Example: 

#104 | Hana  | Table 4 | 260 ETB | Pending #105 | Abel  | Table 4 | 250 ETB | Pending #106 | Sara  | Table 4 | 30 ETB  | Ready This sa�sfies: 

**FR-08 — Display Orders** 

# **29. Search by Order Number** 

The waiter selects: 

Search By: Order Number 

Enters: 

104 Clicks: **Search** 

# **Expected result** 

Only: 

#104 | Hana | Table 4 | 260 ETB | Pending 

is displayed. 

# **30. Search by Customer Name** 

The waiter selects: 

Search By: Customer Name 

Enters: 

Hana 

Clicks: 

**Search** 

# **Expected result** 

#104 | Hana | Table 4 | 260 ETB | Pending 

# **31. Search by Table Number** 

The waiter selects: 

Search By: Table Number 

Enters: 

4 

# **Expected result** 

The system displays all orders belonging to Table 4. 

For example: 

#104 | Hana  | Table 4 | 260 ETB | Pending 

#105 | Abel  | Table 4 | 250 ETB | Pending 

#106 | Sara  | Table 4 | 30 ETB  | Ready 

#107 | Dawit | Table 4 | 60 ETB  | Preparing 

This demonstrates the important dis�nc�on between: 

**Table number** and **order number** . 

# **32. Filter by Status** 

The waiter selects: 

Status: Ready 

# **Expected result** 

Only Ready orders appear. 

Example: 

#106 | Sara | Table 4 | 30 ETB | Ready 

Other statuses are hidden. 

# **33. Clear Search** 

The waiter clicks: 

**Clear** 

# **Expected result** 

The search box becomes empty. 

The status filter returns to: 

All 

All orders are displayed again. 

# **34. View Order Details** 

The waiter selects: 

Order #104 

and clicks: 

**View** 

# **Expected result** 

An Order Details form opens. 

Example: Order #104 Customer: Hana Table: 4 Status: Pending 

Items: 

Coffee Quan�ty: 2 Price: 40 ETB Subtotal: 80 ETB 

Burger Quan�ty: 1 Price: 180 ETB Subtotal: 180 ETB 

Total: 260 ETB 

**35. Edit Order** Suppose Hana says: "Please add one tea." The waiter selects Order #104. 

Clicks: 

**Edit** 

The Edit Order form opens. 

The waiter selects: Tea Quan�ty: 1 Clicks: **Add Item** The system calculates: Tea = 30 ETB New total: 260 + 30 = 290 ETB Expected result: Order #104 updated successfully. 

# **36. Restrict Edi�ng** 

Edi�ng should not be allowed when an order is already completed. Example: Order #104 Status: Completed The waiter clicks: 

**Edit** Expected result: Completed orders cannot be edited. The applica�on does not modify the order. This is an important business rule. 

# **37. Cancel Order** 

The waiter selects an unfinished order. 

Clicks: 

**Cancel** 

The system asks: 

Are you sure you want to cancel Order #108? 

Bu�ons: 

[ Yes, Cancel Order ] [ No ] 

# **38. Confirm Cancella�on** 

If the waiter clicks: 

**Yes, Cancel Order** Expected result: Order #108 cancelled successfully. 

The order should no longer appear as an ac�ve order. 

# **39. Cancel Completed Order** 

If the waiter a�empts to cancel: Order #104 

Status: Completed Expected result: Completed orders cannot be cancelled. 

The order remains unchanged. 

# **40. Screen 5 — Reports** 

The Reports screen provides the simple repor�ng view required by: 

**FR-13** 

It is inten�onally simple in Phase 1. 

|**41. Reports Screen Layout**<br>Example:<br>┌──────────────────────────────|───────────────────────────────┐|
|---|---|
|<br>│ Basic Order Report|<br>│|
|`├`─────────────────────────────|────────────────────────────────`┤`|
|│                                                             │||
|│ Total Orders        12|│|
|│ Pending Orders       2|│|
|│ Preparing Orders     3|│|
|│ Ready Orders         2|│|
|│ Completed Orders     5|│|
|│                                                             │||
|│ Completed Order Value|│|
|│ 1,850 ETB|│|
|│                                                             │||
|`├`─────────────────────────────|────────────────────────────────`┤`|
|│ Order Summary|│|
|│                                                             │||
|│ #104 | Hana | 260 ETB | Completed|│|
|│ #105 | Abel | 250 ETB | Completed|│|
|│ #106 | Sara | 30 ETB  | Ready<br>│                                                             │|│|



└─────────────────────────────────────────────────────────────┘ 

# **42. Report Calcula�on** 

Suppose the system contains: #104 = 260 ETB Completed #105 = 250 ETB Completed #106 = 30 ETB Ready #107 = 60 ETB Preparing The report should calculate: 

Total Orders = 4 

Completed Orders = 2 

Completed Order Value = 260 + 250 = 510 ETB 

The applica�on calculates this from the in-memory orders. 

# **43. Order Statuses in Phase 1** 

The applica�on should use the same order status concepts defined in the SRS: 

Pending Preparing 

Ready Completed The conceptual lifecycle is: 

Pending 

↓ 

Preparing 

↓ 

Ready 

↓ 

Completed 

The Phase 1 applica�on can represent these statuses locally. 

The actual shared kitchen workflow will be implemented through the API and Web Applica�on in later phases. 

# **44. Complete Real-Life Example** 

Now we can demonstrate the complete Phase 1 workflow using Hana. 

# **44.1 Customer arrives** 

Hana sits at: 

Table 4 

She tells the waiter: 

"I want two coffees and one burger." 

The customer does not touch the so�ware. 

# **44.2 Waiter checks menu** 

Waiter opens: 

**Menu** 

Sees: 

Coffee = 40 ETB 

Burger = 180 ETB 

Both are available. 

# **44.3 Waiter creates order** 

Clicks: 

**New Order** System generates: Order #104 Waiter enters: Customer = Hana Table = 4 

# **44.4 Waiter adds coffee** 

Coffee 

Quan�ty = 2 System calculates: 

40 × 2 = 80 ETB 

# **44.5 Waiter adds burger** 

Burger 

Quan�ty = 1 System calculates: 

180 × 1 = 180 ETB 

# **44.6 System calculates total** 

80 + 180 = 260 ETB 

# **44.7 Waiter saves** 

Clicks: 

**Save Order** 

System displays: Order #104 created successfully. 

Order is stored in local memory. 

# **44.8 Waiter views orders** 

Orders screen displays: 

#104 | Hana | Table 4 | 260 ETB | Pending 

# **44.9 Waiter searches** 

Search: 

Hana Result: 

#104 | Hana | Table 4 | 260 ETB | Pending 

# **44.10 Waiter edits** 

Hana asks: "Add one tea." Waiter edits Order #104. Adds: 

Tea × 1 = 30 ETB New total: 290 ETB System displays: 

Order #104 updated successfully. 

# **44.11 Status demonstra�on** 

The order can move through: 

Pending ↓ Preparing ↓ Ready ↓ Completed 

Phase 1 represents these states locally. 

The later Web/API implementa�on will allow the actual kitchen staff to update them. 

# **44.12 Report** 

The manager opens: 

**Reports** 

The system calculates the current order sta�s�cs from memory. Example: 

Total Orders: 10 Pending: 2 Preparing: 2 Ready: 1 Completed: 5 

Completed Order Value: 

1,850 ETB 

# **45. Event-Driven Behavior** 

Because this is an Event-Driven Programming course, every important user ac�on should correspond to an event. 

Examples: 

|**User ac�on**|**Event**|**Result**|
|---|---|---|
|Click New Order|Bu�on Click|Open Create Order|
|Click Add Item|Bu�on Click|Add item|
|Click Save|Bu�on Click|Validate and save|
|Change search text|TextChanged|Update search|
|Select status|SelectedIndexChanged|Filter orders|
|Select order|SelectedIndexChanged|Enable ac�ons|
|Click Edit|Bu�on Click|Open edit form|
|Click Cancel|Bu�on Click|Confirm cancella�on|
|Click Menu|Bu�on Click|Open menu|
|Click Reports|Bu�on Click|Generate report|



The applica�on should therefore demonstrate that the interface responds to **user-generated events** . 

# **46. Recommended Phase 1 Form Structure** 

For implementa�on, the applica�on can use these WinForms forms: 

MainForm 

- │ 

- `├` ── Dashboard/UserControl 

│ `├` ── MenuForm │ `├` ── CreateOrderForm │ `├` ── OrdersForm │ `├` ── OrderDetailsForm │ `├` ── EditOrderForm │ └── ReportsForm 

We should decide later whether some of these should be Forms or UserControls. 

The important point at this stage is the **func�onal separa�on** , not the exact technical implementa�on. 

# **47. Phase 1 Data Objects** 

Even without a database, we should model the real en��es. 

The main objects are: 

MenuItem 

Order 

OrderItem 

# **MenuItem** 

Conceptually: 

MenuItem 

--------- 

Id Name Price Availability Example: Id: 1 Name: Coffee Price: 40 Availability: true 

# **Order** 

Conceptually: Order ----OrderNumber CustomerName TableNumber CreatedAt Status Total OrderItems Example: OrderNumber: 104 CustomerName: Hana TableNumber: 4 

Status: Pending 

Total: 260 

# **OrderItem** 

Conceptually: 

OrderItem --------MenuItem Quan�ty UnitPrice Subtotal Example: MenuItem: Coffee Quan�ty: 2 UnitPrice: 40 Subtotal: 80 

# **48. In-Memory Storage** 

Instead of a database, Phase 1 can use: 

List<MenuItem> List<Order> For example: MenuItems ↓ Coffee Tea 

Juice Burger Pizza 

Orders 

↓ #104 #105 #106 #107 

When the program closes, this data can disappear. 

That is acceptable for Phase 1. 

# **49. Phase 1 Naviga�on Flow** 

The complete naviga�on should look like: 

┌──────────────┐ │    START     │ └────── `┬` ───────┘ ↓ ┌──────────────┐ │  DASHBOARD   │ └────── `┬` ───────┘ │ ┌────────────────── `┼` ───────────────────┐ ↓                  ↓                   ↓ MENU             NEW ORDER             ORDERS 

│                  │                   │ │                  ↓                   │ │             CREATE ORDER             │ │                  │                   │ │                  ↓                   │ │              SAVE ORDER              │ │                  │                   │ │                  └──────────┐        │ │                             ↓        │ └────────────────────────── ORDERS ←───┘ │ ┌─────── `┼` ────────┐ ↓       ↓        ↓ VIEW    EDIT     CANCEL 

REPORTS ↑ │ DASHBOARD 

# **50. Phase 1 Acceptance Test** 

Before declaring Phase 1 complete, a user should be able to perform the following demonstra�on successfully: 

# **Test 1 — Start applica�on** 

Expected: 

Dashboard appears. 

# **Test 2 — Open Menu** 

Expected: 

Menu items, prices and availability appear. 

# **Test 3 — Create Hana's order** 

Input: 

Customer: Hana 

Table: 4 Coffee × 2 Burger × 1 Expected: Order #104 Total: 260 ETB Status: Pending 

# **Test 4 — Save order** 

Expected: 

Order #104 created successfully. 

# **Test 5 — View orders** 

Expected: 

#104 appears in the order list. 

# **Test 6 — Search** 

Search: Hana Expected: #104 appears. 

**Test 7 — Filter** 

Select: 

Pending Expected: 

#104 appears if s�ll pending. 

# **Test 8 — Edit** 

Add: 

Tea × 1 

Expected: 

Total = 290 ETB 

# **Test 9 — Valida�on** 

Try: 

Quan�ty = -1 

Expected: 

Error message. 

Item is not added. 

# **Test 10 — Cancel** 

Cancel an unfinished order. 

Expected: 

Confirma�on appears. 

Order is cancelled a�er confirma�on. 

# **Test 11 — Report** 

Open Reports. 

Expected: 

Order counts and completed order value are calculated. 

# **51. Final Phase 1 Defini�on** 

The Phase 1 desktop applica�on is therefore: 

**A C# Windows Forms, event-driven restaurant order management applica�on that allows restaurant service staff to view menu informa�on, create and manage customer orders, automa�cally calculate order totals, search and filter orders, validate input, display status messages, and view basic order reports using temporary in-memory data.** 

The applica�on does **not** yet communicate with a server, database, kitchen web applica�on, or external API. 

# **52. Phase 1 Success Criteria** 

Phase 1 is successful when the applica�on demonstrates all of the following: 

# **Naviga�on** 

The user can move between the main applica�on func�ons. 

# **Event-driven interac�on** 

Bu�ons, controls, selec�ons and user input trigger appropriate applica�on behavior. 

# **Menu** 

The waiter can see menu items, prices and availability. 

# **Order crea�on** 

The waiter can create a customer order. 

# **Automa�c numbering** 

The system generates a unique order number. 

# **Mul�ple customers at one table** 

Different customers can have separate orders even when they share a table. 

# **Order items** 

Mul�ple menu items and quan��es can be added. 

# **Calcula�on** 

The system automa�cally calculates subtotals and the order total. 

# **Valida�on** 

Invalid input is rejected with understandable messages. 

# **Order management** 

Orders can be viewed, searched, filtered, edited and cancelled when permi�ed. 

# **Status** 

Orders have understandable statuses. 

# **Repor�ng** 

A simple report summarizes order informa�on and totals. 

# **Clean UI** 

The applica�on is organized, readable and consistent. 

# **Clean structure** 

The UI, business logic and data handling are separated sufficiently to allow the later API/database phase to be added without rebuilding the en�re applica�on. 

