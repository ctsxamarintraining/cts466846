using System;
using System.IO;

namespace Exception_Ques_3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try{
				Console.WriteLine("Enter the file name with full path");
				string filename=Console.ReadLine();
				string valueFromFile=System.IO.File.ReadAllText(filename);
				Console.Write (valueFromFile);
			}

			catch(FileNotFoundException){

				Console.WriteLine ("File does not exists.....");
			}
			catch(FileLoadException){
				Console.WriteLine ("File Cannot be Loaded.....");
			}
			finally 
			{
				Console.WriteLine ("Finally Block Executed.....");
			}
		}
	}
}
