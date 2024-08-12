# Day4_CSharpProblems

This project contains implementations of a `Fraction` class and a `Point3D` class, along with a `Program` class that demonstrates their functionality.

## Classes

### 1. Fraction Class

The `Fraction` class represents a mathematical fraction and provides methods for basic operations, as well as operator overloading.

#### Properties
- `Nom`: The numerator of the fraction.
- `Den`: The denominator of the fraction.

#### Constructor
- `Fraction(double _Nom, double _Den)`: Initializes a new instance of the `Fraction` class with a specified numerator and denominator.

#### Methods
- `setNom(double _Num)`: Sets the value of the numerator.
- `getNom()`: Returns the value of the numerator.
- `setDen(int _Den)`: Sets the value of the denominator. If the denominator is zero, it sets the denominator to 1 and displays a message.
- `getDen()`: Returns the value of the denominator.
- `display()`: Displays the numerator and denominator of the fraction.
- `add(Fraction f1, Fraction f2)`: Adds two fractions and returns the result.

#### Operator Overloading
- `operator +(Fraction f1, Fraction f2)`: Adds two fractions using the `+` operator.
- `implicit operator Fraction(double num)`: Allows implicit conversion from `double` to `Fraction`.
- `explicit operator double(Fraction f)`: Allows explicit conversion from `Fraction` to `double`.

### 2. Point3D Class

The `Point3D` class represents a point in 3D space and provides methods for basic operations, as well as operator overloading.

#### Properties
- `x`: The x-coordinate of the point.
- `y`: The y-coordinate of the point.
- `z`: The z-coordinate of the point.

#### Constructor
- `Point3D(int _x, int _y, int _z)`: Initializes a new instance of the `Point3D` class with specified coordinates.

#### Methods
- `displayAll()`: Displays the x, y, and z coordinates of the point.
- `CalcDistance(Point3D p1)`: Calculates and returns the distance between the current point and another `Point3D` object.

#### Operator Overloading
- `operator ==(Point3D p1, Point3D p2)`: Compares two `Point3D` objects for equality.
- `operator !=(Point3D p1, Point3D p2)`: Compares two `Point3D` objects for inequality.

### 3. Program Class

The `Program` class contains the `Main` method, which serves as the entry point for the application. It demonstrates the functionality of the `Fraction` and `Point3D` classes.

#### Main Method Demonstrations
- Creates two `Point3D` objects and compares them using the overloaded `==` and `!=` operators.
- Creates `Fraction` objects and demonstrates addition using both the `add` method and the overloaded `+` operator.
- Demonstrates implicit and explicit conversions between `Fraction` and `double`.

## How to Run

1. Clone the repository to your local machine.
2. Open the project in your preferred C# development environment (e.g., Visual Studio).
3. Build the project to restore dependencies and compile the code.
4. Run the project to see the output in the console.
