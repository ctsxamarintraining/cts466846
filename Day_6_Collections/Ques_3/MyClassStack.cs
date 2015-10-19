using System;

namespace Ques_3
{
	public class MyClassStack
	{
		int[] stackArray = new int[10];

		int top = -1;

		public void push(int item)
		{
			top ++;

			if (top < stackArray.Length) 
			{
				stackArray [top] = item;
			}
		}

		public int pop()
		{
			top --;

			if (top >= 0) 
			{
				return stackArray [top];
			} 
			else 
			{
				return -1;
			}
		}
	}
}

