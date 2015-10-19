using System;

namespace Ques_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyClassStack stack = new MyClassStack ();

			stack.push (1);
			stack.push (2);
			stack.pop();
			stack.push (3);

			MyClassQueue queue = new MyClassQueue ();

			queue.enqueu (1);
			queue.enqueu (2);
			queue.dequeu();
			queue.enqueu (3);
		}
	}
}
