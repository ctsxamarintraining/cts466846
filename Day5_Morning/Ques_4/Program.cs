using System;
using System.Collections.Generic;

namespace Ques_4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<Person> PersonList = new List<Person> {
				new Person { Id = 1, Name = "ABC", City = "AAA" },
				new Person { Id = 2, Name = "DEF", City = "FFF" },
				new Person { Id = 3, Name = "GHI", City = "GGG" },
			};
			foreach (Person person in PersonList) {
				Console.WriteLine ("The Person's Name : {0}", person.Name);
				Console.WriteLine("The Person's Id : {0}",person.Id);
				Console.WriteLine ("The Person's City : {0}", person.City);
			}
		}
	}
}
