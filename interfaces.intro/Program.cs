using System;
using interfaces.intro;

Console.WriteLine("Starting");
Car car = new Car();
Accelerator.AccelerateToMaxSpeed(car, speed=>Console.WriteLine(speed));

