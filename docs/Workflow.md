Imagine We own a restaurant called ዉለታ Restaurant. We have a dining area, a kitchen, a menu, several employees, and customers. 



# **1. The Owner / Manager** 

We own the restaurant. The owner decides what food to sell, what prices to charge, which employees work there, and how the restaurant performs. 

The owner might ask: 

- Which foods are available today? 

- How many orders did we receive? 

- How much money did we sell today? 

- Which menu items need their prices updated? 

In our project, the manager can manage menu items and view reports. Managing employee salaries, purchasing stock, and accoun�ng will be outside our ini�al scope. 

# **2. The Waiter / Service staff** 

The waiter speaks directly with customers, answers ques�ons about the menu, records what customers want, and delivers their food. 

The waiter is the main person who uses our order-management system during normal service. 

In our ini�al design, the waiter uses the desktop applica�on to create orders and check their status. 

# **3. The Kitchen staff / Cook** 

The cook prepares food. The kitchen staff need to know what has been ordered, the quan��es, and which orders must be prepared. 

In a real restaurant, they might receive a printed �cket, a screen no�fica�on, or a verbal message from a waiter. 

In our ini�al project, the kitchen staff can receive orders through a kitchen order list on the applica�on. A separate kitchen screen is op�onal, not something we must build immediately. 

# **4. The Cashier** 

The cashier handles bills and payments in restaurants that assign this as a separate job. 

In a small restaurant, the waiter or owner might also handle payment. These responsibili�es depend on the restaurant's organiza�on. 

For our first version, we can calculate and display the order total without implemen�ng real payment processing. 

# **5. The Customer** 

The customer chooses food, asks ques�ons, places an order, eats, and pays. 

The customer does not have to use our so�ware. In the ini�al design, the customer communicates with the waiter as usual. The waiter enters that informa�on into the applica�on. 

These are typical restaurant roles, not a claim that every restaurant must have five separate types of employees. One person can perform mul�ple roles. 

<mark>Let's follow one real customer through the restaurant</mark> 

Our customer, Hana, enters ዉለታ Restaurant and sits at table 4. 

The restaurant sells coffee, tea, juice, pizza, burgers, and other foods. 

# **Step 1 — Hana asks about the menu** 

Hana asks the waiter: 

"Do you have coffee today? How much does it cost?" 

The waiter checks the menu. Suppose coffee is available for 40 ETB. 

There are two ways the waiter might know this: 

- In a tradi�onal restaurant, the waiter checks a printed menu or asks another employee. 

- With our so�ware, the waiter checks the menu list on the desktop applica�on. 

The waiter answers Hana verbally. She does not need to speak to the computer. 

What the so�ware does: It helps staff see the current menu price and whether an item is available. 

The manager may have entered the coffee item and its price earlier that day, or when the restaurant first added it to the menu. 

# **Step 2 — Hana places her order** 

Hana says: 

"I want two coffees and one burger, please." 

The waiter confirms the order and opens the applica�on's Create Order form. 

The waiter enters: 

# **Order #104** 

Table 4 

Illustra�ve example — not actual restaurant transac�on data 

Coffee = 40 ETB × 2 = **80 ETB** 

Burger = 180 ETB × 1 Total **180 ETB** 

# **Total=260 ETB** 

The system generates order number 104 so staff can iden�fy the order later. 

The waiter uses table number 4 and order number 104. Hana doesn't need to remember anything. 

the waiter checks the items and saves the order. 

Now the order exists in the so�ware. The waiter can find it later without relying on memory or a handwri�en note. 

No�ce something important: the waiter is s�ll responsible for listening to Hana and entering her choices correctly. The so�ware doesn't independently know what Hana wants. 

# **Step 3 — How does the kitchen receive the order?** 

In a tradi�onal restaurant, the waiter might walk to the kitchen and say: 

"Table 4 needs two coffees and one burger." 

The cook might write it down, remember it, or place the order �cket on a counter. If the kitchen is busy, the waiter and cook might misunderstand each other or forget to communicate an update. 

Our so�ware can improve this process, but we must deliberately design how kitchen staff will use it. 

A computer or screen in the kitchen. The waiter saves the order, and kitchen staff can see it on their own screen. The kitchen screen checks the API every few seconds for new or updated orders. This is called polling. 

The cook marks it as preparing and then ready. The waiter checks the same order list. 

# **Step 4 — The cook prepares the food** 

The cook sees order #104 and starts making the burger and coffee. The order status changes: 

Pending = The order has been saved and is wai�ng to be prepared. 

Preparing = The kitchen has started preparing the order. 

Ready = The food is ready for the waiter to collect. 

Kitchen worker Clicks “ **Mark Ready** ” for order #104. 

API and database Save the new status: Ready. 

Waiter's computer Displays a message: “Order #104 — Table 4 is ready for collec�on. 

Completed The order has been delivered to the customer. 

# **Step 5 — The waiter delivers the order** 

The waiter checks the order list, sees that order #104 is ready, collects the burger and coffee, and takes them to table 4. 

A�er serving Hana, the waiter updates the order to Completed. 

Hana eats and eventually pays. 

The waiter registers payments for review. 

For our ini�al system, we can display the total of 260 ETB and record completed orders for repor�ng. 

# **Let's put the complete workflow together** 

Here is the workflow I recommend for Our project: 

# **1.** Customer orders 

Hana tells the waiter what she wants. 

# **2.** Waiter records order 

System generates #104 and saves the order. 

# **3.** Kitchen receives order 

Order appears automa�cally on the kitchen screen. 

# **4.** Kitchen prepares food 

Worker changes status to Preparing. 

# **5.** Kitchen marks Ready 

The new status is saved through the API. 

# **6.** Waiter is no�fied 

Waiter sees order #104 is ready for collec�on. 

# **7.** Food is delivered 

Waiter serves Hana and marks the order Completed. 

# **How ordering works at the same table** 

Imagine four customers are si�ng at Table 4. 

Hana — Order #104 

- 2 coffees: 80 ETB 

- 1 burger: 180 ETB 

Total: 260 ETB 

Abel — Order #105 

 1 pizza: 250 ETB , Total: 250 ETB 

Sara — Order #106 



Dawit — Order #107 



All four orders belong to Table 4, but each has a different order number and total. 

The important difference is: 

- Table number: tells staff where to deliver the food. 

- Order number: iden�fies a specific order. 

- Customer name: helps staff know who placed the order. 

- Order items: contain the food, quan�ty, and price for that order. 

# **How the desktop app, API, and web app communicate** 

Customers 

Tell the waiter what they want 

Waiter — C# WinForms desktop app 

Records each person's order and table number 

ASP.NET Web API + Database 

Stores orders and shares their current status 

Kitchen staff 

Web app: prepare orders and mark them Ready 

Manager 

Web app: manage menu and view reports 

# **Step 6 — The manager reviews the restaurant's performance** 

At the end of the day, owner open the management dashboard. 

The owner might want to know: 

- How many orders were created today? 

- How many were completed? 

- What is the total value of completed orders? 

- Which menu items were ordered most frequently? 

- Are any orders s�ll pending? 

# **3. Now, who actually uses the so�ware?** 

# **The Waiter / service staff** 

Uses the desktop app to create orders, view orders, search, and check their status. In the final system, the waiter can also access the relevant order pages through the web interface if we allow that role. 

# **The Kitchen staff** 

Needs to see incoming orders and update prepara�on status. We can support this with a shared order list in the web app. We don't need to build a separate standalone kitchen applica�on. 

# **The Manager / owner** 

Uses the web applica�on to manage the menu, review orders, and view reports. The manager may also use the desktop app, but the web dashboard is par�cularly useful for oversight. 

# **The Customer** 

In our proposed first version, does not log in or use the so�ware directly. The customer communicates with the waiter in the normal way. Customer-facing online ordering is a different feature that we can leave out. 

# **Example: four customers at Table 4** 

<mark>A,Order #104 — Hana</mark> 

Burger + 2 coffees = 260 ETB 

# **Preparing** 

<mark>B,Order #105 — Abel</mark> 

Pizza = 250 ETB 

# **Pending** 

<mark>C,Order #106 — Sara</mark> 

Tea = 30 ETB **Ready** 

