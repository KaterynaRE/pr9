using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl4
{
	class Stack<T>
	{

		public List<T> values = new List<T>();

		public void Push(T value)
		{
			values.Add(value);
		}

		public void Pop()
		{
			if (values.Count > 0)
			{
				values.RemoveAt(values.Count - 1);
			}
			else
			{
				Console.WriteLine("Stack is empty. Cannot pop.");
			}
		}

		public void Peek()
		{
			if (values.Count > 0)
			{
				Console.WriteLine(values[values.Count - 1]);
			}
			else
			{
				Console.WriteLine("Stack is empty. Nothing to peek.");
			}
		}

		public void Count()
		{
			Console.WriteLine(values.Count);
		}
		

	}
}
