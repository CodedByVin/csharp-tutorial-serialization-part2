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
<img width="460" height="480" alt="Screenshot 2026-09-23 205329" src="https://github.com/user-attachments/assets/ecb06961-a5a2-4e80-99f8-0c52c305ae35" />
<img width="461" height="483" alt="Screenshot 2026-09-23 205303" src="https://github.com/user-attachments/assets/ac859432-ee59-4d73-92cd-ade5344526be" />
<img width="460" height="479" alt="Screenshot 2026-09-23 205238" src="https://github.com/user-attachments/assets/d09e18c6-16a1-48c9-849b-1dbc26d37da8" />


