# Printing & Branding Shop System

A simple Windows Forms desktop application built in **VB.NET** for processing customer orders in a printing and branding shop.  
This is a Decision-Based Service System — a side project outside my main focus on data science and machine learning.

## Features

- **Menu-driven interface** with File, Tools, and Help options
- Customer order entry:
  - Customer Name
  - Service Type (Business Cards, Flyers, Banners, Stickers, T-Shirts)
  - Urgency Level (Normal / Express)
  - Quantity (number of copies/units)
- **Dynamic pricing logic**:
  - Different base prices per service type
  - 35% surcharge for Express orders
  - Quantity-based discounts (8% for 50–149 units, 15% for 150+)
  - Fixed setup/design fee for Banners and T-Shirts
- Professional receipt generation with proper formatting (2 decimal places)
- Saves completed transactions to a **SQL Server LocalDB** database
- Input validation and user-friendly error messages

## Technologies Used

- **VB.NET** (Windows Forms)
- **.NET Framework** 4.8 (or compatible)
- **ADO.NET** with **Microsoft.Data.SqlClient** (or System.Data.SqlClient)
- **SQL Server LocalDB** for data storage
- Visual Studio 2022 (Community Edition)

## Project Requirements Met (Assignment)

- Functional **MenuStrip** (File → New Transaction / Exit, Tools → Clear Form, Help → About)
- Intelligent inputs with ComboBoxes and validation
- Conditional logic + at least two calculations (base charge × quantity, express surcharge, discount, setup fee)
- Structured receipt output using concatenation / StringBuilder
- Database connection & storage of transaction details
- Theory answer: Two key ADO.NET components → **Connection** object and **Command** object

## Setup Instructions (for running locally)

### Prerequisites

- Windows 10/11
- Visual Studio 2022 (with .NET desktop development workload)
- SQL Server LocalDB (install via Visual Studio Installer → Individual components → "SQL Server LocalDB")

### Steps

1. Clone the repository
   ```bash
   git clone https://github.com/YOUR-USERNAME/PrintingShopSystem.git
   cd PrintingShopSystem
