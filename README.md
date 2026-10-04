<img width="1408" height="768" alt="Gemini_Generated_Image_jmrd47jmrd47jmrd" src="https://github.com/user-attachments/assets/b2c4f6d2-8787-4b54-bf45-074e705e627d" />
# OOPC#-Assignment

**Prepared by:** Nour Hani Alsouri  
**Language / Platform:** C# / .NET  

---

##  Repository Overview

This repository contains solutions for four Object-Oriented Programming (OOP) C# exercises. The exercises demonstrate fundamental OOP concepts including **Single & Multilevel Inheritance**, **Constructor Chaining (`base`)**, **Polymorphism (`virtual`/`override`)**, **Dynamic Dispatch**, and **Runtime Type Inspection (`GetType()`)**.

---

## Assignments

### 1. Independent Exercise – Vehicle Hierarchy
Demonstrates single-level inheritance and base constructor chaining across different vehicle types.

* **Class Hierarchy:**
  * `Vehicle` (Base) $\rightarrow$ `Car`, `Bus`, `Motorcycle` (Derived)
* **Key Implementation Points:**
  * `Vehicle`: Contains properties `Brand`, `Year`, and a `Start()` method.
  * `Car`: Extends `Vehicle` and adds `NumberOfDoors`.
  * `Bus`: Extends `Vehicle` and adds `Capacity`.
  * `Motorcycle`: Extends `Vehicle` and adds `HasSidecar`.
  * Uses constructor chaining with `base(...)` across all derived classes.
  * Demonstrates object creation and execution of `Start()` for each vehicle type.

---

### 2. Independent Exercise – Shape Areas
Demonstrates runtime polymorphism and dynamic dispatch without abstract classes.

* **Class Hierarchy:**
  * `Shape` (Base) $\rightarrow$ `Circle`, `Rectangle` (Derived)
* **Key Implementation Points:**
  * `Shape`: Contains `virtual double CalculateArea()`.
  * `Circle`: Contains `Radius` and overrides `CalculateArea()`.
  * `Rectangle`: Contains `Width` and `Height` and overrides `CalculateArea()`.
  * Stores shape instances in a `List<Shape>`.
  * Iterates through the list to print each object's runtime type (`GetType().Name`) and calculated area.

---

### 3. Guided Exercise – University Members (Polymorphism)
Demonstrates direct inheritance, method overriding, and generic base reference handling.

* **Class Hierarchy:**
  * `Person` (Base) $\rightarrow$ `Student`, `Employee`, `Teacher` (Derived)
* **Key Implementation Points:**
  * `Person`: Contains `Name` and `virtual void DisplayInfo()`.
  * `Student`: Adds `StudentId` and overrides `DisplayInfo()`.
  * `Employee`: Adds `Salary` and overrides `DisplayInfo()`.
  * `Teacher`: Adds `CourseName` and overrides `DisplayInfo()`.
  * Stores instances of each class in a `List<Person>`.
  * Uses a single `foreach` loop to call `DisplayInfo()` and print runtime types via `GetType()`.
  * Implements a standalone method that accepts a `Person` parameter and calls `DisplayInfo()`.

---

### 4. Guided Exercise – University Members (Multilevel Inheritance)
Demonstrates multilevel inheritance hierarchy, constructor execution order, and specialized method creation.

* **Class Hierarchy:**
  * `Person` (Base)
    * `Student` (Derived from `Person`)
    * `Employee` (Derived from `Person`)
      * `Teacher` (Derived from `Employee`)
* **Key Implementation Points:**
  * `Person`: Contains `Name`, `Email`, constructor, and `DisplayBasicInfo()`.
  * `Student`: Contains `StudentId` and `GPA`.
  * `Employee`: Contains `EmployeeId` and `Salary`.
  * `Teacher`: Inherits from `Employee` (multilevel); adds `CourseName` and a `Teach()` method.
  * Explicitly passes parameters using `base(...)` constructors.
  * Outputs constructor execution order to demonstrate base-to-derived initialization sequence.

---

## How to Run

1. Open the solution file `.sln` or individual project folders in **Visual Studio**.
2. Run.
