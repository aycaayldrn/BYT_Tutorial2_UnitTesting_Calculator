using Tut2_s26735_Part2;


Calculator calculator = new Calculator(10, 5, '+');
Console.WriteLine($"Result: {calculator.Calculation()}");

Calculator calculator1 = new Calculator(3527, 7374, '-');
Console.WriteLine($"Result: {calculator1.Calculation()}");

Calculator calculator2 = new Calculator(94, 23, '*');
Console.WriteLine($"Result: {calculator2.Calculation()}");

Calculator calculator3 = new Calculator(75, 3, '/');
Console.WriteLine($"Result: {calculator3.Calculation()}");


