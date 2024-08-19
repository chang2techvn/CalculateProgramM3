Calculate Water Bill

Project Overview

This project is a C# WinForms application designed to calculate and display water bills for customers. It includes functionalities for customer data entry, bill calculation, searching for specific customers, and displaying detailed billing information.

Installation

Prerequisites:

Steps
Clone the repository:
bash
Copy code
git clone https://github.com/chang2techvn/CalculateProgramM3.git
Open the solution file in Visual Studio.
Restore the NuGet packages (if any).
Build the solution.

Usage

Running the Application

Start the application from Visual Studio by clicking the "Start" button.

 Enter customer details, including: ID Customer: e.g., PA12345678901
 
 Name Customer: e.g., Charles Darwin
 
 Last Month's Water: e.g., 10 m3
 
 This Month's Water: e.g., 24 m3
 
 Type of Customer: Select from the dropdown menu.
 
 Number of People: Input if applicable.
 
 Click "Show Bill" to calculate the bill.
 
 The calculated bills will be displayed in the ListView.
 
 Use the search bar to find specific customers.
 
 Click on a customer in the ListView to view detailed billing information.
 

Features

Customer Information Input: Allows the user to enter customer details such as ID, Name, water usage, and customer type.

Bill Calculation: Calculates the total water bill based on usage and displays it in the ListView.

Search Functionality: Provides a search bar to filter and find specific customers in the ListView.

Detailed Bill View: Displays detailed information about the selected customer's bill, including consumption, price, and total bill.

Payment Option: Includes a "Payment" button to simulate the payment process.


UI Layout
Information Customer Panel: Inputs for ID Customer, Name Customer, Last Month's Water, This Month's Water, Type of Customer, Number of People.

ListView Panel: Displays columns for ID, Name, Last Month, This Month, Consumption, Price, and Total Bill.

Detailed Bill Panel: Displays detailed billing information with a "Payment" button.



Code Organization
Forms:
MainForm.cs: Contains the logic for the main UI components, including customer input and ListView display.
ShowBillForm.cs: Displays detailed billing information.


Business Logic:
BillCalculator.cs: Handles the logic for calculating the water bill.


Data Management:
CustomerData.cs: Manages customer information and bill data.


Contributing
Guidelines
Fork the repository.
Create a new branch for your feature or bug fix.
Submit a pull request with a description of your changes.

License

This project is licensed under the MIT License.

Contact Information

Author: Nguyen Thanh Chang
Email: chang2tech@gmai.com

