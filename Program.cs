using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
	class Program
	{
		static void Main(string[] args)
		{
			int x = 1;
			int a, b, c;
			do
			{
				Console.WriteLine(x); // i know x
				Console.WriteLine("Please give 3 numbers till a * b == c");
				a = Convert.ToInt32(Console.ReadLine());
				b = Convert.ToInt32(Console.ReadLine());
				c = Convert.ToInt32(Console.ReadLine());

			}
			while (a * b != c);

			Console.WriteLine("a =" + a);
			Console.WriteLine("b =" + b);
			Console.WriteLine("c =" + c);


		}
	}
}
