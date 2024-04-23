using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl1
{
	class Zavdannya12<T> where T : IComparable<T>
	{
		public static void MaxNum(T num1, T num2, T num3)
		{
			T max = num1;
			if (num2.CompareTo(max) > 0)
			{
				max = num2;
			}
			if (num3.CompareTo(max) > 0)
			{
				max = num3;
			}
			Console.WriteLine($"Max number is: {max}");
		}
		public static void MinNum(T num1, T num2, T num3)
		{
			T min = num1;
			if (num2.CompareTo(min) < 0)
			{
				min = num2;
			}
			if (num3.CompareTo(min) < 0)
			{
				min = num3;
			}
			Console.WriteLine($"Min number is: {min}");
		}

	}
}
