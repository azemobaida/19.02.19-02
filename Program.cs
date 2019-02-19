using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("enter number: ");
			int a = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter number: ");
			int b = Convert.ToInt32(Console.ReadLine());
			Console.Write("enter number: ");
			int c = Convert.ToInt32(Console.ReadLine());

			if (a > b && a > c)
			{
				Console.WriteLine(a + " is the biggest");
			}
			else if (b > a && b > c)
			{
				Console.WriteLine(b + " is the biggest");
			}
			else
			{
				Console.WriteLine(c + " is the biggest");
			}
		}
	}
}
