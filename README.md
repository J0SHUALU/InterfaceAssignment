# Unity Interface Assignment

A Unity project demonstrating C# interfaces by defining a shared `IShape` interface and implementing it across three shape classes.

## Overview

This project applies the concept of interfaces in C#. The `IShape` interface declares the two methods common to all shapes, `CalculateArea()` and `CalculatePerimeter()`, and each shape class implements them with its own logic.

## Shapes Implemented

1. **Trapezium** — calculates area, perimeter, and an unknown side.
2. **Circle** — calculates radius (from diameter), area, and circumference.
3. **Nonagon** — calculates area, perimeter, and number of sides.

## How to Run

1. Open the project in Unity.
2. Open the scene and press **Play**.
3. View the results in the **Console** window (Window → General → Console).

All shape values are printed using `Debug.Log()`.

## Author

Joshua Moses
