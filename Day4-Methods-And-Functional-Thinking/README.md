# Day 4 - Methods & Functional Thinking

## Tasks Completed

- Method structure
- Return types
- PascalCase naming convention
- Parameters & Arguments
- Variable scope & lifetime
- Refactoring logic into reusable methods
- Static vs Non-static methods

---

# Concepts Practiced

## Methods

Created reusable methods to:
- reduce code duplication
- improve readability
- separate logic from `Main()`

---

## Parameters & Return Types

Implemented methods using:
- input parameters
- return values
- `void` methods

---

## Refactoring

Refactored previous programs by moving logic into reusable methods instead of writing everything inside `Main()`.

---

# Programs Refactored

## 1. FizzBuzz Refactored

Moved FizzBuzz logic into a dedicated reusable method.

---

## 2. Even/Odd Range Generator Refactored

Separated Even/Odd generation logic into reusable methods.


---

# Method Invocation Styles Practiced

## Non-static Method Invocation

```csharp
RefactoredPreviousCodes fizzBuzz = new RefactoredPreviousCodes();

fizzBuzz.FizzBuzz(30);
```

---

## Static Method Invocation

```csharp
RefactoredPreviousCodes.EvenOrOdd(45);
```

---

# Git Workflow Followed

```bash
git checkout -b feature/day4-methods-functional-thinking
git add .
git commit -m "Complete Day 4 methods and refactoring tasks"
git push origin feature/day4-methods-functional-thinking
```

---

# Folder Structure

```text
Day4-Methods-And-Functional-Thinking
 ├── RefactoredPreviousCodes.cs
 ├── Program.cs
 └── Day4.csproj
```