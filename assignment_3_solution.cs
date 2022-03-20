// Declare variables
double a, b, y, f, s, n, w;

// Read and Assign values
Console.Write("Enter f: ");
f = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter n: ");
n = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter W: ");
w = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter s: ");
s = Convert.ToDouble(Console.ReadLine());

a = Math.Pow(f, n) * (((s - 1) / f) + Math.Pow((20 / f), w));
b = Math.Pow(20, n);

y = 1 - (a / b);

// Display Result
Console.WriteLine($"Y = {y}");
