/*
 If a=10, b=20, c=30. Programmatically determine if a equal 
 to b and c is greater than a+b-c and c-b is equal to a.
*/

// Declare variables
int a = 10;
int b = 20;
int c = 30;

bool aEqualtoB = a == b;
bool cGreaterABC = c > (a + b -c);
bool cbEqualtoA = (c - b) == a;

// Display results
Console.WriteLine("A is equal B: " + aEqualtoB);
Console.WriteLine("C is greater than (A + B - C): " + cGreaterABC);
Console.WriteLine("(C - B) is equal A: " + cbEqualtoA);
