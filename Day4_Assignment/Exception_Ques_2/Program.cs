using System;

namespace Exception_Ques_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double numberSquareRoot;
			int number=0;
			try
			{
				Console.WriteLine("Enter Number");
				number= Convert.ToInt32 (Console.ReadLine());
				numberSquareRoot=Math.Sqrt(number);

				if(number<0)
					throw new ApplicationException("Entered number must be positive.....");
				Console.WriteLine("Square root of {0} is: {1}", number, numberSquareRoot);

			}
			catch(FormatException formatException) 
			{
				Console.WriteLine (formatException.Message);
			}
			catch(Exception exception) 
			{
				Console.WriteLine (exception.Message);
			}
			finally
			{
				Console.WriteLine ("GoodBye.......");
			}
		}
	}
}
