using cl1;
using que;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr9
{
	class Arr<T>
	{
		public static T Sum(T[] arr)
		{
			T sum = default(T);
			for (int i = 0; i < arr.Length; i++)
			{
				sum += (dynamic)arr[i];
			}

			return sum;
		}
	}

	internal class Program
	{
		static void Main(string[] args)
		{
			//Завдання 1
			//Створіть generic-версію методу обчислення максимуму з трьох чисел.

			Zavdannya12<int>.MaxNum(5, 10, 7);
			Zavdannya12<double>.MaxNum(3.14, 2.71, 1.618);

			//Завдання 2
			//Створіть generic-версію методу обчислення мінімуму з трьох чисел

			Zavdannya12<int>.MinNum(5, 10, 7);

			//Завдання 3
			//Створіть generic-версію методу пошуку суми елементів у масиві.

			int[] arrNew = new int[3] { 3, 2, 4 };
			Console.WriteLine("Array: ");
			foreach (var item in arrNew)
			{
				Console.Write(item + " ");
			}
			int sum = Arr<int>.Sum(arrNew);
			Console.WriteLine($"Sum element of array: {sum}");

			//Завдання 4
			//Створіть generic-клас «Стек». Реалізуйте стандартні
			//методи і властивості для роботи стеку:
			//+ ■ pop;
			//+ ■ push;
			//+ ■ peek;
			//+ ■ count

			Stack<int> stack1 = new Stack<int>();
			stack1.Push(2);
			stack1.Push(4);
			stack1.Push(3);
			stack1.Push(9);

			Console.WriteLine("\nStack: ");
            foreach (var item in stack1)
            {
				Console.Write(item + " ");
            }
			Console.WriteLine("\nPeek metod: ");
			Console.WriteLine(stack1.Peek());

			Console.WriteLine("\nCount metod: ");
			Console.WriteLine(stack1.Count());

			Console.WriteLine("\nPop metod: ");
			Console.WriteLine(stack1.Pop());

			Console.WriteLine("\nStack after Pop: ");
			foreach (var item in stack1)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();


			//Завдання 5
			//Створіть generic-клас «Черга». Реалізуйте стандартні
			//методи і властивості для роботи черги:
			//+ ■ enqueue;
			//+ ■ dequeue;
			//+ ■ peek;
			//+ ■ count

			Queue<int> queue = new Queue<int>();
			queue.Enqueue(6);
			queue.Enqueue(2);
			queue.Enqueue(3);
			queue.Enqueue(9);

			Console.WriteLine("\nQueve: ");
            foreach (var item in queue)
            {
				Console.Write(item + " ");
            }


			queue.Dequeue();

			Console.WriteLine("\nAfter dequeve: ");
			foreach (var item in queue)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			Console.WriteLine("\nPeek metod: ");
			Console.WriteLine(queue.Peek());

			Console.WriteLine("\nCount metod: ");
			Console.WriteLine(queue.Count());

			//--те саме

			QueueNew<int> queueNew = new QueueNew<int>();
			queueNew.Enqueue(99);
			queueNew.Enqueue(4);
			queueNew.Enqueue(2);

			Console.WriteLine("\nQueve new: ");
			foreach (var item in queueNew.values)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			queueNew.Dequeue();
			Console.WriteLine("\nQueve new after delete: ");
			foreach (var item in queueNew.values)
			{
				Console.Write(item + " ");
			}
			Console.WriteLine();

			Console.WriteLine($"Peek: {queueNew.Peek()}");

			int count = queueNew.Count;
			Console.WriteLine($"Count: {count}");

		}
	}
}
