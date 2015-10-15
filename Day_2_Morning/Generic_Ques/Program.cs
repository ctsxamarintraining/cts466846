using System;
using System.Collections.Generic;

namespace Generic_Ques
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			LinkedList<object> linkedList = new LinkedList<object> ();
			linkedList.AddFirst (1);
			linkedList.AddAfter (linkedList.Find(1),2);
			linkedList.AddLast ("Bye");
			linkedList.AddBefore (linkedList.Find(1),3.55);
			 
			Console.WriteLine ("The Elements are: ");
			 
			PrintElements (linkedList);
			Console.WriteLine ("No. of items in list: {0}",linkedList.Count);

			linkedList.Remove (1);
			Console.WriteLine ("The Elements after removing are: ");
			PrintElements (linkedList);
			Console.WriteLine ("No. of items in list after removing: {0}",linkedList.Count);

		}

		public static void PrintElements(LinkedList<object> linkedList){
			foreach(var element in linkedList){
				Console.WriteLine (element);
			}
		}
	}
}
