using System;

namespace Ques_3
{
	class MainClass
	{
	delegate int MyDelegateAddition(int number1,int number2);

		public static void Main (string[] args)
		{
			MyDelegateAddition myDelegateAddition = delegate(int num1,int num2) {
				return num1+num2;
			};

			int result = myDelegateAddition (22,44);

			Console.WriteLine (result);
		}
	}
}
