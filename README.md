# 💰 ByteBank

## 📄 Description

ByteBank is a C# educational project that simulates a banking system while progressively introducing core OOP concepts such as encapsulation, composition, inheritance, polymorphism, and exception handling.

Each folder or file group represents an incremental step in learning through hands-on implementation.

---

## 📚 Features and Concepts

### 🧱 Basic Banking Logic

-   Account creation with fields like agency, account number, and balance.
-   Deposit, withdrawal, and transfer methods.

### 👥 Client and Ownership

-   Composition between accounts and `Cliente` objects.
-   Basic data validation for fields like CPF.

### 🔐 Encapsulation

-   Use of private fields with public properties for controlled access.
-   Validation inside property setters (e.g., non-negative balance, valid agency).

### 📈 Static Members

-   Tracks total number of accounts created via static class members.
-   Calculates `TaxaOperacao` dynamically based on number of accounts.

### 🧠 Inheritance and Polymorphism

-   `Funcionario` and `Diretor` classes.
-   Base method `GetBonificacao()` overridden in derived classes.
-   `GerenciadorBonificacao` accumulates bonuses from different employee types.

### ⚠️ Exception Handling

-   `ContaCorrente` constructors throw `ArgumentException` for invalid parameters.
-   `try-catch` blocks used to manage runtime errors gracefully.

---

## 🗂️ Project Structure

The code is organized by lesson or feature evolution:

-   `_01_ByteBank` to `_07_ByteBank`: progressive improvements on `ContaCorrente` and `Cliente`
-   `ByteBank.Funcionarios`: demonstrates inheritance and polymorphism
-   Final version includes static logic, tax rate calculation and exception safety
-   `Program.cs`: main runner files for each stage
-   `GerenciadorBonificacao.cs`: centralizes bonus tracking

---

## 🛠️ Requirements

-   .NET Framework or .NET SDK compatible with C# 7.0+
-   IDE: Visual Studio / VS Code / Rider
-   No external libraries required

---

## 🚀 How to Run

1. Open the solution or compile any `Program.cs` manually depending on the stage you want to test.
2. Run using terminal or IDE debugger.

---

## ✅ Status

📘 Educational / In Progress

This repository is not intended for production. It's a step-by-step learning archive built to deepen C# understanding.
