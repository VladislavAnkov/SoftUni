using System;
using System.Collections.Generic;
using System.Text;

namespace GenericBox
{
    class Box<T>
    {
		private T Value;

		public Box(T input)
		{
			this.Value = input;

		}

		public override string ToString()
		{
			return $"{Value.GetType()}: {this.Value}";
		}
	}
}
