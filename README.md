# C# Windows Forms: Employee Details(Serialization PT.2)

This repository contains the completed source code for Tutorial # on my YouTube channel. It demonstrates how to serialize and deserialize custom user objects to local binary files using C# and Windows Forms.

**📺 Watch the full tutorial here:** (https://www.youtube.com/@CodedByVin).

## Features
* Collects structured employee records (Name, Phone, Department, Salary) and validates fields prior to processing.
* Persists instantiated `Employee` objects directly to a local binary file (`employees.binary`) using `FileStream` and `BinaryFormatter`.
* Reads stored binary data, reinstantiates the `Employee` object on the Managed Heap, and repopulates the form fields.
* Implements `try-catch` blocks to gracefully handle missing file errors (`FileNotFoundException`) without crashing the application.
* Clears all input controls with a single click to prepare the form for new data entry.

## Tech Stack
* **Language:** C#
* **Framework:** .NET Framework (Windows Forms)
* **IDE:** Visual Studio

## How to Run This Code
1. Click the green **Code** button and download the ZIP file, or clone the repository.
2. Extract the folder and open the `.sln` (Solution) file using Visual Studio.
3. Ensure you have the **.NET desktop development** workload installed.
4. Press **Start** (or `F5`) in Visual Studio to run the application.

## Screenshots
<img width="785" height="478" alt="Screenshot 2026-09-23 210420" src="https://github.com/user-attachments/assets/1407443d-b06e-44f1-93d2-f24807f16eca" />
<img width="911" height="530" alt="Screenshot 2026-09-23 210407" src="https://github.com/user-attachments/assets/547ece04-557d-4739-9183-bff5e2d09dc1" />
<img width="844" height="568" alt="Screenshot 2026-09-23 210349" src="https://github.com/user-attachments/assets/daefa037-9967-483b-9a39-2af6194edb67" />

