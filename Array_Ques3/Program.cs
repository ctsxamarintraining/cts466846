using System;

namespace Array_Ques3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] personArray = new Person[5] {
				new Person{ firstName = "ABC", lastName = "AAA", age = 55 },
				new Person{ firstName = "DEF", lastName = "DDD", age = 22 },
				new Person{ firstName = "GHI", lastName = "GGG", age = 25 },
				new Person{ firstName = "JKL", lastName = "JJJ", age = 44 },
				new Person{ firstName = "MNO", lastName = "MMM", age = 19 }
			};
			Array.Sort (personArray);
			foreach (Person person in personArray) {
				Console.WriteLine (person.firstName + " " + person.lastName + " " + person.age);
			}
		}
	}
}
