using System;

namespace Ques_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int? number = null;
			if(!number.HasValue)
				Console.WriteLine ("Is there any value? {0}",number.HasValue);
			number = 10;
			if(number.HasValue)
				Console.WriteLine (number.Value);
		}
	}
}
