# Groesster Gemeinsamer Teiler (ASP.NET WebForms)

## Overview
WebForms project for computing the greatest common divisor (GGT) of two numbers.
It includes multiple algorithm variants and displays rough runtime measurements.

## Main Features
- Input validation for integer values
- Naive divisor scan (`ggt1`)
- Iterative Euclidean algorithm (`GigaMethode`)
- Recursive Euclidean algorithm (`ggT_Euklid_Rekursiv`)
- Runtime display in UI

## Tech Stack
- C#
- ASP.NET WebForms
- .NET Framework 4.7.2
- IIS Express (Visual Studio)

## Project Structure
- `GgtRechner.aspx`: WebForms page and controls
- `GgtRechner.aspx.cs`: algorithm implementations
- `Global.asax`: app lifecycle entry
- `Web.config`: runtime configuration

## Requirements
- Windows
- Visual Studio with ASP.NET/Web development tools

## Run Locally
1. Open `Groesster_gemeinsamer_Teiler.sln` in Visual Studio.
2. Restore NuGet packages.
3. Start with IIS Express (`F5`).

## Security and Data Hygiene
- Do not commit `App_Data` content, local database files, or private keys.
- Keep environment variables and credentials in local-only files.
- Source currently contains legacy demo naming; avoid adding real personal data.

