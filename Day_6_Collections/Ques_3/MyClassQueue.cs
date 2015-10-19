using System;

namespace Ques_3
{
	public class MyClassQueue
	{
		int[] queueArray = new int[10];

		int front = -1;
		int rear = -1;

		public void enqueu(int item)
		{
			rear ++;
			if (rear < queueArray.Length) 
			{
				queueArray [rear] = item;
			} 
		}

		public int dequeu()
		{
			front ++;

			if (front < queueArray.Length) 
			{
				return queueArray [front];
			} 
			else 
			{
				return -1;
			}
		}
	}
}

