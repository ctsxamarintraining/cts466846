using System;
using System.Collections.Generic;

namespace Ques_4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<string> MyList = new List<string>();
			MyList.Add ("A");
			Console.WriteLine ("Elements in list:");
			foreach (var element in MyList)
				Console.WriteLine (element);
			MyList.AddRange (new List<string> (){ "B", "C", "D" });
			Console.WriteLine ("Elements in list:");
			foreach (var element in MyList)
				Console.WriteLine (element);
			MyList.Remove ("B");
			Console.WriteLine ("Element deleted is B");
			Console.WriteLine ("Elements in list:");
			foreach (var element in MyList)
				Console.WriteLine (element);
			MyList.Insert (1,"F");
			Console.WriteLine ("Elements in list:");
			foreach (var element in MyList)
				Console.WriteLine (element);
			MyList.Clear ();
			Console.WriteLine ("List is cleared");
			Dictionary<int,string> MyDictionary = new Dictionary<int, string> (){{1,"AAAA"},{2,"BBBB"}};
			MyDictionary.Add (3, "CCCC");
			Console.WriteLine ("Keys in Dictionary:");
			foreach (int element in MyDictionary.Keys)
				Console.WriteLine (element);
			Console.WriteLine ("Values in Dictionary:");
			foreach (string element in MyDictionary.Values)
				Console.WriteLine (element);
			MyDictionary.ContainsValue ("DDDD");
			MyDictionary.Remove (3);
			Console.WriteLine ("Keys in Dictionary:");
			foreach (int element in MyDictionary.Keys)
				Console.WriteLine (element);
			Console.WriteLine ("Values in Dictionary:");
			foreach (string element in MyDictionary.Values)
				Console.WriteLine (element);
			MyDictionary.Clear ();
		}
	}
}
