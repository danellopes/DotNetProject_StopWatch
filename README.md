### StopWatch

Developed this code as part of the exercises proposed in the course [C# Intermediate: Classes, Interfaces and OOP](https://www.udemy.com/course/csharp-intermediate-classes-interfaces-and-oop/).

This particular exercise demonstrates how a class should always be in a valid state. We do this by setting the `IsRunning` property as `true` when calling the `Start()` method. If we try to call the `Start()` method twice in a row, it'll throw an exception.
