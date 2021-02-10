using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethod
{
    public class Box<T> where T : IComparable
    {
		public int Count { get; private set; }

		public int CountGreaterElements(List<T> list, T element)
		{
			CheckIfEmpty(list);

			foreach (T item in list)
			{
				if (element.CompareTo(item) < 0)
				{
					this.Count++;
				}
			}

			return this.Count;
		}

		private static void CheckIfEmpty(List<T> list)
		{
			if (list.Count == 0)
			{
				throw new InvalidOperationException("Collection is empty!");
			}
		}
	}
}
