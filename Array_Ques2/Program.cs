using System;

namespace Array_Ques2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] arrayInt = new int[4]{ 1, 2, 3, 4};
			double[,] arrayFloat = new double[2, 2]{ { 1.1, 1.2}, { 1.3, 1.4 } };
			string[,,] arrayString = new string[2, 2, 2]{ 
				{ 
					{"ABC","CDE"}, 
					{"EFG","GHI"} 
				}, 
				{ 
					{"IJK","KLM"}, 
					{"MNO","OPQ"} 
				} 
			};
			ThePrintFunction (arrayInt);
			ThePrintFunction (arrayFloat);
			ThePrintFunction (arrayString);
		}
		public static void ThePrintFunction(Array arrayType)
		{
			Console.WriteLine ("Elements : ");
			foreach (var val in arrayType) {
				Console.WriteLine (val);
			}
		}
	}
}
