# C# Concepts and Examples
=====================================

## Table of Contents
-----------------

* [Variables and Data Types](#variables-and-data-types)
* [Operators](#operators)
* [Control Structures](#control-structures)
* [Methods](#methods)
* [Classes and Objects](#classes-and-objects)
* [Inheritance](#inheritance)
* [Polymorphism](#polymorphism)
* [Encapsulation](#encapsulation)
* [Abstraction](#abstraction)
* [Interfaces](#interfaces)
* [Exception Handling](#exception-handling)
* [File Input/Output](#file-input/output)
* [Multithreading](#multithreading)
* [Generics](#generics)
* [LINQ](#linq)

## Variables and Data Types
---------------------------

### Variables

Variables are used to store data in a program. In C#, variables must be declared before they can be used.

```csharp
// Declare a variable
int myVariable;

// Assign a value to the variable
myVariable = 10;

// Declare and assign a value in one step
int myVariable = 10;
```

### Data Types

C# has several built-in data types, including:

* Integers (`int`)
* Floating-point numbers (`float`, `double`, `decimal`)
* Characters (`char`)
* Boolean values (`bool`)
* Strings (`string`)

```csharp
// Integer
int myInt = 10;

// Floating-point number
double myDouble = 10.5;

// Character
char myChar = 'A';

// Boolean value
bool myBool = true;

// String
string myString = "Hello, World!";
```

## Operators
------------

### Arithmetic Operators

Arithmetic operators are used to perform mathematical operations.

```csharp
// Addition
int result = 10 + 5;

// Subtraction
int result = 10 - 5;

// Multiplication
int result = 10 * 5;

// Division
int result = 10 / 5;

// Modulus (remainder)
int result = 10 % 5;
```

### Comparison Operators

Comparison operators are used to compare values.

```csharp
// Equal to
bool result = 10 == 5;

// Not equal to
bool result = 10 != 5;

// Greater than
bool result = 10 > 5;

// Less than
bool result = 10 < 5;

// Greater than or equal to
bool result = 10 >= 5;

// Less than or equal to
bool result = 10 <= 5;
```

### Logical Operators

Logical operators are used to combine conditions.

```csharp
// And
bool result = true && true;

// Or
bool result = true || false;

// Not
bool result = !true;
```

### Assignment Operators

Assignment operators are used to assign values to variables.

```csharp
// Assign a value
int myVariable = 10;

// Add and assign
int myVariable = 10;
myVariable += 5;

// Subtract and assign
int myVariable = 10;
myVariable -= 5;

// Multiply and assign
int myVariable = 10;
myVariable *= 5;

// Divide and assign
int myVariable = 10;
myVariable /= 5;

// Modulus and assign
int myVariable = 10;
myVariable %= 5;
```

## Control Structures
--------------------

### Conditional Statements

Conditional statements are used to execute different blocks of code based on conditions.

```csharp
// If statement
int myVariable = 10;
if (myVariable > 5)
{
    Console.WriteLine("myVariable is greater than 5");
}

// If-else statement
int myVariable = 10;
if (myVariable > 5)
{
    Console.WriteLine("myVariable is greater than 5");
}
else
{
    Console.WriteLine("myVariable is less than or equal to 5");
}

// Switch statement
int myVariable = 10;
switch (myVariable)
{
    case 5:
        Console.WriteLine("myVariable is 5");
        break;
    case 10:
        Console.WriteLine("myVariable is 10");
        break;
    default:
        Console.WriteLine("myVariable is not 5 or 10");
        break;
}
```

### Loops

Loops are used to execute blocks of code repeatedly.

```csharp
// For loop
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

// While loop
int i = 0;
while (i < 5)
{
    Console.WriteLine(i);
    i++;
}

// Do-while loop
int i = 0;
do
{
    Console.WriteLine(i);
    i++;
} while (i < 5);

// Foreach loop
int[] myArray = { 1, 2, 3, 4, 5 };
foreach (int item in myArray)
{
    Console.WriteLine(item);
}
```

## Methods
---------

Methods are used to group blocks of code that can be called multiple times.

```csharp
// Method with no parameters
void MyMethod()
{
    Console.WriteLine("Hello, World!");
}

// Method with parameters
void MyMethod(int myParameter)
{
    Console.WriteLine("Hello, " + myParameter);
}

// Method with return value
int MyMethod(int myParameter)
{
    return myParameter * 2;
}
```

## Classes and Objects
----------------------

Classes are used to define custom data types, and objects are instances of classes.

```csharp
// Class definition
public class MyClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        Console.WriteLine("Hello, World!");
    }
}

// Object creation
MyClass myObject = new MyClass();
myObject.MyProperty = 10;
myObject.MyMethod();
```

## Inheritance
-------------

Inheritance is used to create a new class based on an existing class.

```csharp
// Base class
public class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }
}

// Derived class
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking...");
    }
}

// Object creation
Dog myDog = new Dog();
myDog.Eat();
myDog.Bark();
```

## Polymorphism
--------------

Polymorphism is used to perform different actions based on the type of object.

```csharp
// Base class
public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("Animal sound...");
    }
}

// Derived class
public class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("Barking...");
    }
}

// Object creation
Animal myAnimal = new Dog();
myAnimal.Sound();
```

## Encapsulation
--------------

Encapsulation is used to hide the implementation details of an object.

```csharp
// Class definition
public class MyClass
{
    private int myField;

    public int MyProperty
    {
        get { return myField; }
        set { myField = value; }
    }
}

// Object creation
MyClass myObject = new MyClass();
myObject.MyProperty = 10;
```

## Abstraction
-------------

Abstraction is used to show only the necessary information to the outside world.

```csharp
// Interface definition
public interface IMyInterface
{
    void MyMethod();
}

// Class definition
public class MyClass : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("Hello, World!");
    }
}

// Object creation
IMyInterface myObject = new MyClass();
myObject.MyMethod();
```

## Interfaces
-------------

Interfaces are used to define a contract that must be implemented by any class that implements it.

```csharp
// Interface definition
public interface IMyInterface
{
    void MyMethod();
}

// Class definition
public class MyClass : IMyInterface
{
    public void MyMethod()
    {
        Console.WriteLine("Hello, World!");
    }
}

// Object creation
IMyInterface myObject = new MyClass();
myObject.MyMethod();
```

## Exception Handling
--------------------

Exception handling is used to handle runtime errors.

```csharp
// Try-catch block
try
{
    int myVariable = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}

// Try-catch-finally block
try
{
    int myVariable = 10 / 0;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
finally
{
    Console.WriteLine("Finally block executed...");
}
```

## File Input/Output
--------------------

File input/output is used to read and write files.

```csharp
// Reading a file
using (StreamReader reader = new StreamReader("myFile.txt"))
{
    string line;
    while ((line = reader.ReadLine()) != null)
    {
        Console.WriteLine(line);
    }
}

// Writing a file
using (StreamWriter writer = new StreamWriter("myFile.txt"))
{
    writer.WriteLine("Hello, World!");
}
```

## Multithreading
----------------

Multithreading is used to execute multiple threads concurrently.

```csharp
// Thread creation
Thread myThread = new Thread(new ThreadStart(MyMethod));
myThread.Start();

// Method definition
void MyMethod()
{
    Console.WriteLine("Hello, World!");
}
```

## Generics
-------------

Generics are used to create reusable code that can work with any data type.

```csharp
// Generic class definition
public class MyGenericClass<T>
{
    private T myField;

    public T MyProperty
    {
        get { return myField; }
        set { myField = value; }
    }
}

// Object creation
MyGenericClass<int> myIntObject = new MyGenericClass<int>();
myIntObject.MyProperty = 10;

MyGenericClass<string> myStringObject = new MyGenericClass<string>();
myStringObject.MyProperty = "Hello, World!";
```

## LINQ
------

LINQ (Language Integrated Query) is used to query data in a SQL-like syntax.

```csharp
// LINQ query
int[] numbers = { 1, 2, 3, 4, 5 };
var evenNumbers = from number in numbers
                  where number % 2 == 0
                  select number;

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
```

## Async/Await
-------------

Async/await is used to write asynchronous code that is easier to read and maintain.

```csharp
// Async method definition
async Task MyAsyncMethod()
{
    await Task.Delay(1000);
    Console.WriteLine("Async method completed...");
}

// Calling the async method
await MyAsyncMethod();
```

## Lambda Expressions
-------------------

Lambda expressions are used to create small, anonymous functions.

```csharp
// Lambda expression
Func<int, int> myLambda = x => x * 2;
Console.WriteLine(myLambda(5)); // Outputs: 10
```

## Extension Methods
------------------

Extension methods are used to add new functionality to existing classes.

```csharp
// Extension method definition
public static class MyExtensions
{
    public static void MyExtensionMethod(this string str)
    {
        Console.WriteLine("Extension method called...");
    }
}       

// Calling the extension method
"Hello, World!".MyExtensionMethod();
```

