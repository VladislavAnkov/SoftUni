using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethod
{
    class Box<T>
    {
		private List<T> list;

		public Box()
		{
			this.list = new List<T>();
		}

		public void Add(T element)
		{
			this.list.Add(element);
		}

		public void SwapElements(int firstIndex, int secondIndex)
		{
			CheckIfEmpty();
			CheckIndecies(firstIndex, secondIndex);

			T temp = this.list[firstIndex];
			this.list[firstIndex] = this.list[secondIndex];
			this.list[secondIndex] = temp;

		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			foreach (T item in this.list)
			{
				sb.AppendLine($"{item.GetType()}: {item}");
			}

			return sb.ToString();
		}

		private void CheckIfEmpty()
		{
			if (this.list.Count == 0)
			{
				throw new InvalidOperationException("Collection is empty!");
			}
		}

		private void CheckIndecies(int firstIndex, int secondIndex)
		{
			if (firstIndex < 0 || firstIndex >= this.list.Count ||
			   secondIndex < 0 || secondIndex >= this.list.Count)
			{
				throw new ArgumentOutOfRangeException("Invalid indecies!");
			}
		}
	}
}
