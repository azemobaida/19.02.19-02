using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
	class Program
	{
		static void Main(string[] args)
		{
			int x;
			double sum = 0;
			int i = 0;

			Console.WriteLine("Enter numbers for average (negative to exit):");

			x = Convert.ToInt32(Console.ReadLine());

			while (x >= 0)
			{
				i++;
				sum = sum + x;

				x = Convert.ToInt32(Console.ReadLine());

				
			}

			Console.WriteLine("average = " + sum / i);
		}
	}
}
