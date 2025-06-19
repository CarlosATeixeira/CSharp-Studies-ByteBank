# 💼 ByteBank (C# Console Application)

## 📄 Description
ByteBank is a C# console application developed as a learning project to practice object-oriented programming concepts such as encapsulation, inheritance, properties, method overloading, and class responsibilities.

Throughout the project, multiple versions of `ContaCorrente`, `Cliente`, and `Program` demonstrate progressive enhancements in class design and functionality.

## 🎯 Goals
- Practice OOP with C#
- Understand how data encapsulation and property validation works
- Simulate a simple bank system with accounts and transactions
- Explore class hierarchies (`Funcionario`, `Diretor`) and polymorphism

## 🛠️ Technologies Used
- C# (.NET Framework or .NET Core)
- Console Application

## 🧱 Features

- `ContaCorrente` with deposit, withdraw, and transfer methods
- Validation logic in setters (`Saldo`, `Agencia`)
- Static property to track number of accounts created
- `Cliente` class evolution: from public fields to encapsulated properties
- `Funcionario` and `Diretor` classes using inheritance and polymorphism for bonuses
- `GerenciadorBonificacao` class to track total bonuses

## 📁 Structure Highlights

- `Program.cs` (1–7): multiple exercises showing different evolution steps
- `ContaCorrente.cs`: from basic structure to full-featured class with validation
- `Cliente.cs`: refactored with auto-properties and CPF validation placeholder
- `Funcionario` / `Diretor`: demonstrates inheritance and bonus calculation
- `GerenciadorBonificacao`: manages multiple employee bonuses

## 🚀 How to Run

1. Open the solution in Visual Studio (or compile via CLI if organized in a `.sln`).
2. Set the desired `Program.cs` as the startup file to run specific scenario.
3. Run the project (F5 or `dotnet run` if using SDK-style).

## 🗒️ Notes
This project was created for educational purposes. Each version of `Program.cs` and its supporting classes represents an incremental step in C# OOP learning.
