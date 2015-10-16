#define HELLO
#define BYE
using System;
using System.Diagnostics;


namespace Ques_1
{
	class MainClass
	{

		[Conditional("HELLO")]  
		void hello() { 
			Console.WriteLine("Welcome and Hello Everyone "); 
		} 

		[Conditional("BYE")]  
		void bye() { 
			Console.WriteLine("Bye See you Soon......"); 
		} 

		public static void Main (string[] args)
		{
			MainClass mainClass = new MainClass(); 

			mainClass.hello ();
			mainClass.bye ();
		}
	}
}
