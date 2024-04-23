using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que
{
	class QueueNew<T>
	{
		public Queue<T> values = new Queue<T>();

		public void Enqueue(T value)
		{
			values.Enqueue(value);
		}
		public T Dequeue()
		{
			return values.Dequeue();
		}

		public T Peek()
		{
			return values.Peek();
		}

		public int Count
		{
			get { return values.Count; }
		}


	}
}
