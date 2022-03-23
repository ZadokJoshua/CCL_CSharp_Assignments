/*
Make Q5 dynamic by accepting variable a, b and c in ax2+bx+c=0 from the console to 
determine the kind of root
*/

using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter a: ");
		double a = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter b: ");
		double b = Convert.ToDouble(Console.ReadLine());
		Console.Write("Enter c: ");
		double c = Convert.ToDouble(Console.ReadLine());
		
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
