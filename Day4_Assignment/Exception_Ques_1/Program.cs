using System;

namespace Exception_Ques_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
				int [] arrayElements=new int[6];
				int i=0;
				while(i<arrayElements.Length)
				{
					Console.WriteLine("Enter number");
					int val=Convert.ToInt32(Console.ReadLine());
					arrayElements[i]=val;
					Console.WriteLine("Elements in the array are:");
					for(int j=0;j<=i;j++)
					{
						Console.Write("{0},",arrayElements[j]);
					}
					Console.WriteLine();
					i++;
				}
			}
			catch(IndexOutOfRangeException indexException) 
			{
				Console.WriteLine (indexException.Message);
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
				Console.WriteLine ("Finally Block Executed.....");
			}
		}
	}
}
