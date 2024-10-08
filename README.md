﻿# EmployeeInMemoryCRUD

## Overview
**EmployeeInMemoryCRUD** is a simple console-based Employee Management System that performs basic CRUD (Create, Read, Update, Delete) operations. The application stores employee data in memory and allows users to add, display, and delete employee records. It is designed using clean code practices with proper validation and error handling.

## Features
- **In-memory storage**: No external database, all employee data is stored and managed in memory.
- **CRUD operations**:
  - **Add**: Add new employee data.
  - **Display**: View a formatted list of all employees in a clean, tabular format.
  - **Delete**: Remove an employee record by `EmployeeID`.

## Technology Stack
- **Language**: C#
- **Framework**: .NET
- **Data Storage**: In-memory using `Dictionary`

## Application Structure
The project follows a modular structure to maintain clean code practices and separation of concerns:
- **Models**: Defines the `Employee` model.
- **Interfaces**: Declares the interface `IEmployeeOperations` to define the contract for CRUD operations.
- **Services**: Contains the `EmployeeManager` class which implements CRUD operations.
- **Program.cs**: The entry point of the application that runs and interacts with the `EmployeeManager`.

### Directory Structure
```bash
EmployeeInMemoryCRUD/
├── Models/
│   └── Employee.cs         
├── Interfaces/
│   └── IEmployeeOperations.cs
├── Services/
│   └── EmployeeManager.cs   
└── Program.cs               
```


## How to Run the Application

### Prerequisites
- **.NET SDK**: Make sure you have [.NET SDK](https://dotnet.microsoft.com/download) installed on your system.

### Steps
1. **Clone the repository**:
   ```bash
   git clone https://github.com/your-username/EmployeeInMemoryCRUD.git
2. **Open the Project in Visual Studio 2022**:
- Open Visual Studio 2022.
- Click on File > Open > Project/Solution....
- Navigate to the folder where you cloned the repository and open the .sln (solution) file.

3. Run the Application:
- Click on the `Start` button (or press `F5`).
- The console window will open, and the application will run, showing hardcoded employee data and performing operations like adding and deleting employees.


### Explanation:
1. **Overview**: A brief description of the project.
2. **Features**: Highlights key functionality.
3. **Technology Stack**: Lists technologies used.
4. **Application Structure**: Explains how the project is organized.


