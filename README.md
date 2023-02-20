# Inventory!

<p align="center" width="100%">
    <img src="https://user-images.githubusercontent.com/25421570/220009056-346cb9cd-f5d0-40b2-bb1c-2cfcbe124d87.png"> 
</p>

<p align="center" width="100%">
    <img src="https://user-images.githubusercontent.com/25421570/220010642-2bcee091-8393-407b-a5fd-7d5840d0df7f.jpg"> 
</p>

<p align="center" width="100%">
    <img src="https://user-images.githubusercontent.com/25421570/220010695-d8c9d8f1-d208-4ef5-9bd3-3d27dbf8462e.jpg"> 
</p>
<p align="center" width="100%">
    <img src="https://user-images.githubusercontent.com/25421570/220010760-7377a1d9-cb38-4a22-a1c3-588462210c3e.jpg"> 
</p>

## Summery
The C# application is designed to help manage sales for a business. The application uses a SQLite database that is created each time the application is built, to store data about products and customers.

The database has two tables: one for products and one for customers. The products table contains information about each product, including its name, description, price, and quantity. The customers table contains information about each customer, including their name, address, phone number, and email.

The application has a user interface that includes a tab to display the list of products available for sale. This tab allows the user to view the details of each product and its current quantity in stock. The user can also add new products or update existing ones through this tab.

The application also has a tab to manage customers. This tab allows the user to view a list of all customers and their contact information. The user can add new customers or update existing ones through this tab.

The most important tab of the application is the "Sell" tab, which allows the user to sell a product to a customer. To use this tab, the user must first log in with an admin account, which is stored in the database. Once logged in, the user can select a customer from the list and a product from the list of available products. The application will then prompt the user to enter the quantity of the product to be sold. The application will automatically update the product quantity in the database and generate a receipt for the transaction.

To ensure security, the application requires an admin login to access the "Sell" tab. The admin login credentials are stored in the database and encrypted to prevent unauthorized access. Only authorized users with the correct login credentials can access the "Sell" tab and perform sales transactions.
