using System;
using System.Collections.Generic;

namespace Ques_2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			NumberList<int> itemList = new NumberList<int>();

			itemList.insertItem (1);
			itemList.insertItem (2);
			itemList.insertItem (3);
			itemList.insertItem (4);
			itemList.insertItem (5);
			itemList.insertItem (6);
			itemList.insertItem (7);

			Console.WriteLine(itemList.Count);

			if (itemList.containsItem (1)) 
			{
				itemList.deleteitem (1);
			}

			Console.WriteLine(itemList.Count);

			itemList.clearAllItems ();

			Console.WriteLine(itemList.Count);
		}
	}
}
