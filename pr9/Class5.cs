using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl5
{
	class Queue<T>
	{
		public List<T>	values = new List<T>();
		int headIndex = 0;
		public T Head { get { return values[headIndex]; } } 
		public T Tail { get; set; }
		public void Enqueue(T value)
		{
			values.Add(value);
			Tail = value;
			headIndex++;
		}
		public T Dequeue()
		{
			if (values.Count == 0) 
			{
				Console.WriteLine("Queue is empty");
			}

			T dequeuedValue = values[headIndex]; 
			values.RemoveAt(headIndex);
			headIndex--;
			return dequeuedValue; 
		}

		public void Peek()
		{
			if (values.Count > 0)
			{
				Console.WriteLine(values[values.Count - 1]);
			}
			else
			{
				Console.WriteLine("Queve is empty. Nothing to peek.");
			}
		}

		public void Count()
		{
			Console.WriteLine(values.Count);
		}

	}
}
