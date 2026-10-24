ዉለታ **Restaurant RMS** 

# **Phase 1 C# WinForms Desktop Applica�on — UI Design Brief** 

# **1. Product** 

Design a modern, professional desktop applica�on UI for a fic�onal Ethiopian restaurant called ዉለታ **Restaurant** . 

The applica�on is a **restaurant order management system used primarily by waiters/service staff** . 

The UI will eventually be implemented using **C# Windows Forms** , so the design must be realis�c and prac�cal for a desktop applica�on. Do not design a mobile app or a highly experimental interface. 

The applica�on should feel like a real restaurant employee tool: fast, clear, simple, readable, and easy to operate during a busy restaurant shi�. 

# **2. Phase 1 Scope** 

The Phase 1 desktop applica�on must support: 

- Dashboard/Home 

- Menu display 

- Create new order 

- Automa�c order numbering 

- Customer name 

- Table number 

- Add menu items and quan��es 

- Automa�c subtotal calcula�on 

- Automa�c order total calcula�on 

- Display exis�ng orders 

- Search orders 

- Filter orders by status 

- View order details 

- Edit unfinished orders 

- Cancel unfinished orders 

- Input valida�on 

- Success/error status messages 

- Basic repor�ng 

Use local in-memory data only. 

Do not design API func�onality, database screens, authen�ca�on screens, web pages, payment processing, online customer ordering, or advanced analy�cs. 

# **3. Primary User** 

The primary user is a: 

# **Waiter / Service Staff** 

The waiter needs to perform tasks quickly: 

1. Check menu. 

2. Create customer order. 

3. Add food items. 

4. Save order. 

5. Search orders. 

6. Check order status. 

7. Edit an unfinished order. 

8. Cancel an unfinished order. 

9. View basic order informa�on. 

The customer does not use the applica�on. 

Kitchen staff will use a later web applica�on, not this Phase 1 desktop interface. 

# **4. Design Personality** 

The visual style should be: 

- Modern 

- Professional 

- Clean 

- Warm 

- Restaurant-oriented 

- Easy to scan 

- Desktop-first 

- Prac�cal 

- Not overly decora�ve 

- Not childish 

- Not futuris�c 

- Not overly complicated 

The interface should priori�ze usability over decora�on. 

The waiter should be able to understand the screen within a few seconds. 

# **5. Restaurant Iden�ty** 

Restaurant name: 

ዉለታ **Restaurant** 

System name: 

**Restaurant Order Management System** 

Short name: 

# **RMS** 

Use the Ethiopian restaurant iden�ty subtly. 

Do not fill the interface with unnecessary cultural decora�ons. 

The restaurant name and iden�ty should feel authen�c but remain professional. 

# **6. Overall Applica�on Layout** 

Use a consistent desktop applica�on shell. 

Recommended structure: 

┌──────────────────────────────────────────────────────────────┐ │ ዉለታ Restaurant RMS Waiter [User] │ `├` ──────────────── `┬` ───────────────────────────────────────────── `┤` │ │ │ │ Dashboard │ │ │ │ │ │ Menu │ MAIN CONTENT │ │ │ │ │ New Order │ │ │ │ │ │ Orders │ │ │ │ │ │ Reports │ │ │ │ │ │ │ │ │ Exit │ │ `├` ──────────────── `┴` ───────────────────────────────────────────── `┤` │ Status: Ready │ └──────────────────────────────────────────────────────────────┘ 

Use a le� naviga�on sidebar. 

The main content area should change according to the selected naviga�on item. 

Keep the sidebar consistent across all main screens. 

# **7. Naviga�on** 

The primary naviga�on should contain: 

- Dashboard 

- Menu 

- New Order 

- Orders 

- Reports 

- Exit 

Each naviga�on item should have: 

- Icon 

- Text label 

- Hover state 

- Selected/ac�ve state 

The currently selected page must be visually obvious. 

# **8. Design System** 

# **Colors** 

Use a warm professional restaurant pale�e. 

Primary color: 

Deep warm burgundy / wine tone. 

Secondary accent: 

Warm gold/orange. 

Background: 

Very light warm gray/off-white. 

Main content: 

White. 

Text: 

Dark charcoal. 

Success: 

Green. 

Warning: 

Amber/orange. 

Error: 

Red. 

Status colors should be used sparingly and consistently. 

Do not make the en�re interface highly saturated. 

# **9. Typography** 

Use a clean modern sans-serif font. 

Recommended hierarchy: 

Applica�on �tle: Large and strong. Page �tle: Large and bold. Sec�on �tle: Medium and semibold. 

Normal text: Readable regular weight. 

Labels: Small/medium semibold. 

Numbers such as order totals: Large and prominent. 

Make important informa�on visually easy to scan. 

# **10. Bu�ons** 

Primary bu�on: 

Use for important ac�ons such as: 

- Save Order 

- Add Item 

- Create Order 

Secondary bu�on: 

Use for: 

- Clear 

- Back 

- View 

Danger bu�on: 

Use for: 

- Cancel Order 

- Delete where applicable 

Bu�ons should have: 

- Clear text 

- Comfortable click area 

- Consistent height 

- Consistent corner radius 

- Hover state 

- Disabled state 

Do not use too many different bu�on styles. 

# **11. Order Status Badges** 

Use compact status badges. 

Statuses: 

**Pending Preparing Ready** 

# **Completed** 

Each status should be visually dis�nct. 

Example: 

Pending → neutral/warning appearance Preparing → ac�ve/warm appearance 

Ready → posi�ve/success appearance 

Completed → muted/success appearance 

Do not rely on color alone; always display the status text. 

# **12. Dashboard Screen** 

Create a professional restaurant dashboard. 

Header: 

# **Dashboard** 

Sub�tle: 

**Overview of today's restaurant orders** 

Display summary cards: 

1. Total Orders 

2. Pending 

3. Preparing 

4. Ready 

5. Completed 

6. Completed Order Value 

Example values: 

Total Orders: 

12 

Pending: 2 

Preparing: 

3 

Ready: 

2 

Completed: 

5 

Completed Value: 

1,850 ETB 

Below the cards, show a compact recent-orders table. 

Columns: 

- Order # 

- Customer 

- Table 

- Total 

- Status 

Example: 

#104 | Hana | Table 4 | 260 ETB | Pending 

#105 | Abel | Table 4 | 250 ETB | Preparing 

#106 | Sara | Table 4 | 30 ETB | Ready 

Include a clear **New Order** primary ac�on near the top. 

# **13. Menu Screen** 

Page �tle: 

**Menu** 

Sub�tle: 

**View available restaurant items and prices** 

At the top: 

Search menu field. 

Below: 

Menu table/list. 

Columns: 

- Item 

- Price 

- Availability 

Example: 

Coffee | 40 ETB | Available 

Tea | 30 ETB | Available 

Juice | 60 ETB | Available 

Burger | 180 ETB | Available 

Pizza | 250 ETB | Unavailable 

Availability should be represented by a small badge. 

Include search/filter capability. 

Keep the screen focused on viewing the menu. 

Do not turn Phase 1 into a complicated menu administra�on system. 

# **14. Create Order Screen** 

This is the most important screen. 

Page �tle: 

**Create New Order** 

Top sec�on: Order Number: 104 Customer Name: [ input ] 

Table Number: 

[ input ] 

The order number is generated automa�cally and should look read-only. 

Next sec�on: 

# **Add Order Item** 

Menu Item: [ dropdown ] 

Quan�ty: [ numeric input ] 

Bu�on: 

# **Add Item** 

Below: 

# **Order Items** 

Use a table with: 

- Item 

- Quan�ty 

- Unit Price 

- Subtotal 

- Remove 

Example: 

Coffee | 2 | 40 ETB | 80 ETB Burger | 1 | 180 ETB | 180 ETB At the bo�om-right: 

**Total: 260 ETB** 

Primary bu�on: 

**Save Order** 

Secondary bu�on: 

**Clear** 

Secondary/danger ac�on: 

**Cancel** 

The total must be visually prominent. 

# **15. Create Order Valida�on States** 

Design visible valida�on states for: 

Empty customer name: 

"Customer name is required." Invalid table number: 

"Please enter a valid table number." 

Invalid quan�ty: 

"Quan�ty must be greater than zero." No menu item selected: 

"Please select a menu item." 

Unavailable item: 

"This menu item is currently unavailable." 

The design should show valida�on close to the relevant input where prac�cal. 

Also provide a general status message area. 

# **16. Successful Order State** 

A�er saving an order, display a clear success no�fica�on: 

# **Order #104 created successfully.** 

Then return the user to the Orders screen or provide a clear op�on to con�nue. 

The order should appear immediately in the order list. 

# **17. Orders Screen** 

Page �tle: 

**Orders** 

Sub�tle: 

**Search and manage restaurant orders** 

Top toolbar: 

Search input. 

Search-by dropdown: 

- Order Number 

- Customer Name 

- Table Number 

Status filter: 

- All 

- Pending 

- Preparing 

- Ready 

- Completed 

Bu�ons: 

Search 

Clear 

Below: 

Orders table. 

Columns: 

- Order # 

- Customer 

- Table 

- Created 

- Total 

- Status 

- Ac�ons 

Ac�ons: 

View 

Edit 

Cancel 

Use a clean, readable table suitable for desktop. 

# **18. Orders Search Example** 

User selects: 

Search By: 

Customer Name 

Enters: 

Hana 

Clicks: 

Search 

Expected result: 

#104 | Hana | Table 4 | 260 ETB | Pending 

Provide an obvious empty-state message if no order is found: 

**No orders found.** 

# **19. Orders Filter Example** 

User selects: 

Status: 

Ready 

The table updates to show only Ready orders. Example: 

#106 | Sara | Table 4 | 30 ETB | Ready 

The ac�ve filter should be visually clear. 

# **20. Order Details Screen** 

When the user clicks View: 

Open an order details view. 

Header: 

**Order #104** 

Informa�on: Customer: Hana Table: 4 Status: Pending Created: 12:30 PM Order items: Coffee 2 × 40 ETB 80 ETB Burger 1 × 180 ETB 180 ETB Total: 

# 260 ETB 

Show the current status prominently. Provide: Back Edit Cancel 

depending on whether those ac�ons are permi�ed. 

# **21. Edit Order Screen** 

The edit screen should be visually similar to Create Order. Header: 

**Edit Order #104** Customer name: Hana Table: 4 Exis�ng items: Coffee | 2 | 40 ETB | 80 ETB Burger | 1 | 180 ETB | 180 ETB Allow the waiter to add another item. Example: Tea | 1 | 30 ETB | 30 ETB New total: 290 ETB Bu�on: **Save Changes** 

Expected success message: 

# **Order #104 updated successfully.** 

Completed orders should appear visually locked. 

If the user tries to edit a completed order: 

**Completed orders cannot be edited.** 

# **22. Cancel Order Confirma�on** 

When the user clicks Cancel Order: 

Show a confirma�on dialog. 

Title: 

**Cancel Order?** 

Message: 

**Are you sure you want to cancel Order #108?** 

Bu�ons: 

**Yes, Cancel Order** 

**No** 

Use a danger style for the confirma�on ac�on. 

A�er confirma�on: 

**Order #108 cancelled successfully.** 

# **23. Reports Screen** 

Page �tle: 

**Basic Order Report** 

Sub�tle: 

**Summary of restaurant order ac�vity** 

Display summary cards: 

Total Orders 

Pending 

Preparing 

Ready 

Completed 

Completed Order Value 

Below: 

Order Summary table. 

Columns: 

- Order # 

- Customer 

- Table 

- Total 

- Status 

Keep the report simple. 

This is Phase 1 repor�ng, not the final Phase 3 management dashboard. 

# **24. Status Message System** 

The applica�on should have a consistent no�fica�on system. 

Success example: 

# ✓ **Order #104 created successfully.** 

Error: 

- ✕ **Customer name is required.** 

Warning: 

# ⚠ **This order cannot be cancelled.** 

Informa�on: 

# **Order #104 is currently being prepared.** 

No�fica�ons should not permanently cover important informa�on. 

# **25. Empty States** 

Every major list should have an empty state. 

For Orders: 

**No orders found.** 

For search: 

**No orders match your search.** 

For menu: 

**No menu items available.** 

The empty state should explain what the user can do next. 

# **26. Loading/Processing States** 

Although Phase 1 uses local memory and opera�ons should be fast, design bu�ons with a disabled/processing state where appropriate. 

For example: 

Save Order 

Normal: 

**Save Order** 

Processing: 

**Saving...** 

Then: 

# **Order #104 created successfully.** 

This prepares the design for the later API phase. 

# **27. Complete User Flow** 

The UI must support this exact primary flow: 

Dashboard 

↓ Click New Order ↓ Create New Order ↓ System generates Order #104 ↓ Enter customer name: 

Hana ↓ Enter table: 4 ↓ Select: Coffee ↓ Quan�ty: 2 ↓ 

Click Add Item 

↓ Select: Burger 

↓ 

Quan�ty: 

1 

↓ Click Add Item 

↓ 

Total becomes: 

260 ETB 

↓ 

Click Save Order 

↓ 

Success message: 

Order #104 created successfully. 

↓ 

Orders screen 

↓ 

Search Hana 

↓ 

View Order #104 

↓ 

Edit if necessary 

↓ 

Filter by status 

↓ 

View Basic Report 

# **28. Mul�ple Customers at Same Table** 

The UI must make it clear that table number does not uniquely iden�fy an order. 

Example: 

Table 4: Order #104 — Hana — 260 ETB Order #105 — Abel — 250 ETB Order #106 — Sara — 30 ETB Order #107 — Dawit — 60 ETB 

The UI should always show: 

**Order Number** 

**Customer** 

**Table** 

together. 

# **29. Desktop Design Requirements** 

The design must be: 

- Desktop-first. 

- Suitable for C# WinForms. 

- Easy to implement with standard Windows Forms controls. 

- Compa�ble with common laptop resolu�ons. 

- Readable without excessive scrolling. 

- Consistent between screens. 

Avoid: 

- Mobile naviga�on. 

- Huge anima�ons. 

- Complex 3D effects. 

- Excessive gradients. 

- Excessive decora�ve images. 

- Overly complicated dashboards. 

- Features outside Phase 1. 

# **30. Important Implementa�on Principle** 

The final visual design should not force the C# implementa�on into poor architecture. 

The design must support the following conceptual structure: 

UI 

↓ 

Business Logic 

↓ 

In-Memory Data 

The UI is responsible for displaying informa�on and capturing user events. 

Business logic is responsible for: 

- Calcula�ng totals. 

- Valida�ng rules. 

- Genera�ng order numbers. 

- Determining whether an order can be edited/cancelled. 

- Searching/filtering. 

The data layer is responsible for temporarily storing: 

- Menu items. 

- Orders. 

- Order items. 

# **31. Required Design Screens** 

The ini�al S�tch/Figma design should contain exactly these primary screens: 

1. Dashboard 

2. Menu 

3. Create New Order 

4. Orders 

5. Order Details 

6. Edit Order 

7. Basic Reports 

Also show important states: 

8. Create Order Valida�on Error 

9. Successful Order Crea�on 

10. Search Result 

11. Empty Search Result 

12. Cancel Confirma�on 

13. Completed Order / Locked State 

# **32. Design Goal** 

The final result should look like a real internal restaurant management applica�on that a waiter could use during a busy shi�. 

The most important informa�on should be immediately visible: 

**What order?** 

**Which customer?** 

**Which table?** 

**What items?** 

**How many?** 

**How much?** 

# **What is the status?** 

The interface should make these ques�ons easy to answer without unnecessary naviga�on. 

