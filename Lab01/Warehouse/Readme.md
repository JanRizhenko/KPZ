# Warehouse Management System

This project demonstrates the implementation of a Warehouse Management System, designed following best practices for clean and maintainable code. The system adheres to multiple software design principles to ensure scalability, readability, and ease of maintenance.

---

## **Applied Software Design Principles**

### 1. **DRY (Don't Repeat Yourself)**
The **DRY** principle minimizes code duplication by reusing logic through abstractions.

**Example:**
- The `Cart` class has an `AddItem` method that prevents redundant logic by checking if a product already exists in the cart before updating the quantity.
  
  **Code Example:** [`Cart.cs - AddItem Method`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Classes/Cart.cs#L15)

---

### 2. **KISS (Keep It Simple, Stupid)**
The **KISS** principle promotes simplicity in code structure and logic.

**Example:**
- The project is divided into small, focused methods like `ViewCart`, `AddProduct`, and `RemoveProduct`, ensuring each function has a clear responsibility.

  **Code Example:** [`Program.cs - ViewCart Method`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Warehouse/Program.cs#L61)

---

## 🔹 **SOLID Principles**

### 1. **S - Single Responsibility Principle (SRP)**
Each class is responsible for only one functionality.
- `Product` manages product details.
- `Cart` manages cart operations.
- `Warehouse` handles inventory.

  **Code Example:** [`Product.cs`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Classes/Product.cs)

### 2. **O - Open/Closed Principle (OCP)**
The system allows extension without modifying existing code.
- The `Product` class supports multiple currencies without altering its core logic.

  **Code Example:** [`Product.cs - Currency Handling`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Classes/Product.cs#L25)

### 3. **L - Liskov Substitution Principle (LSP)**
Subclasses can be used interchangeably with their base class.
- Different currency implementations (`USD`, `EUR`, `UAH`) can replace each other without breaking the program.

  **Code Example:** [`Money classes`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Classes/Money.cs#L54)

### 4. **I - Interface Segregation Principle (ISP)**
Classes do not implement unnecessary methods.
- The `Cart` class only interacts with `Product` and avoids implementing unrelated interfaces.

  **Code Example:** [`Cart.cs`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Classes/Cart.cs)

### 5. **D - Dependency Inversion Principle (DIP)**
High-level modules do not depend on low-level modules.
- `Program.cs` interacts with `Cart` and `Warehouse` without direct dependencies on concrete implementations.

  **Code Example:** [`Program.cs`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Warehouse/Program.cs)

---

### 4. **YAGNI (You Aren't Gonna Need It)**
The project does not include unnecessary features until they are required.
- The system focuses on core inventory and cart management without adding premature features like discounts or advanced analytics.

  **Code Example:** [`Program.cs`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Warehouse/Program.cs)

---

### 5. **Composition Over Inheritance**
Instead of complex class hierarchies, the project uses composition to structure functionality.
- `Product` and `Cart` are composed of smaller reusable functionalities rather than deep inheritance trees.

  **Code Example:** [`Product.cs`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Classes/Product.cs)

---

### 6. **Program to Interfaces, Not Implementations**
Code is written to interact with interfaces rather than concrete classes.
- Although not fully implemented yet, the `Cart` class can be refactored to use interfaces for better flexibility.

  **Future Improvement:** Introduce interfaces for `Product` and `Cart` to decouple dependencies.

---

### 7. **Fail Fast**
Errors are detected and handled early instead of allowing the program to continue in an invalid state.
- If a product is not found in the warehouse, an immediate message is returned instead of proceeding with invalid data.

  **Code Example:** [`Program.cs - Register Outcoming`](https://github.com/JanRizhenko/KPZ/blob/master/Lab01/Warehouse/Warehouse/Program.cs#L79)

---

## 📌 **Conclusion**
This project follows multiple clean code principles to ensure maintainability, flexibility, and scalability. By adhering to these best practices, we create a robust and efficient Warehouse Management System.

🚀 **Repository:** [`GitHub Repo`](https://github.com/JanRizhenko/KPZ/tree/master/Lab01/Warehouse)

