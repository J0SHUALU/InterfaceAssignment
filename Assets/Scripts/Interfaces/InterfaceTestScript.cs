using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start runs once when Play is pressed
    void Start()
    {
        Debug.Log(" INTERFACE TEST START ");

        // Trapezium
        Trapezium trapezium = new Trapezium();
        trapezium.CalculateUnknownSides();
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();

        // Circle
        Circle circle = new Circle();
        circle.CalculateRadius();   // must run first so radius isn't 0
        circle.CalculateArea();
        circle.CalculatePerimeter();

        // Nonagon
        Nonagon nonagon = new Nonagon();
        Debug.Log("Nonagon number of sides: " + nonagon.CalculateNumberOfSides());
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();

        Debug.Log(" INTERFACE TEST END ");
    }

    void Update()
    {

    }
}

// Shared interface: only the methods common to ALL shapes
public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    float sideA = 8f;       // top parallel side
    float sideB = 5f;       // bottom parallel side
    float height = 4f;
    float legC = 4.5f;
    float legD = 4.5f;

    public void CalculateUnknownSides()
    {
        // Simulated calculation for an unknown leg using arbitrary values
        legD = Mathf.Sqrt((height * height) + 1f);
        Debug.Log("Trapezium unknown side (legD): " + legD);
    }

    public void CalculateArea()
    {
        float area = ((sideA + sideB) / 2f) * height;
        Debug.Log("Trapezium area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = sideA + sideB + legC + legD;
        Debug.Log("Trapezium perimeter: " + perimeter);
    }
}

public class Circle : IShape
{
    float radius;
    float diameter = 10f;

    public void CalculateRadius()
    {
        radius = diameter / 2f;
        Debug.Log("Circle radius: " + radius);
    }

    public void CalculateArea()
    {
        float area = Mathf.PI * radius * radius;
        Debug.Log("Circle area: " + area);
    }

    public void CalculatePerimeter()
    {
        // Perimeter of a circle is its circumference
        float circumference = 2f * Mathf.PI * radius;
        Debug.Log("Circle perimeter (circumference): " + circumference);
    }
}

public class Nonagon : IShape
{
    int numberOfSides = 9;
    float sideLength = 6f;

    public void CalculateArea()
    {
        
        float area = (9f / 4f) * (sideLength * sideLength) / Mathf.Tan(Mathf.PI / 9f);
        Debug.Log("Nonagon area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon perimeter: " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}