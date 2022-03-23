/*
What kind of root does the equation have x2 + 6x + 5 = 0. N:B b2-4ac >0 (real roots), < 
0(complex roots), =0(equal roots). Display your result in a console
*/

using System;
					
public class Program
{
	public static void Main()
	{
		double a = 1;
		double b = 6;
		double c = 5;
		
		var x = Math.Pow(b, 2) - (4 * a *c);
		
		if(x > 0)
		{
			Console.WriteLine("The equation has real roots");
		}
		else if(x == 0)
		{
			Console.WriteLine("The equation has equal roots");
		}
		else
		{
			Console.WriteLine("The equation has complex roots");
		}
		
		
	}
}
