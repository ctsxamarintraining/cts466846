using System;
using System.Collections;
using System.Collections.Generic;

namespace Ques_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			MyEnumerable myEnumerable = new MyEnumerable();

			foreach (Person person in myEnumerable) 
			{
				Console.WriteLine (person.Name);
			}
		}

		class MyEnumerable : IEnumerable
		{

			public IEnumerator GetEnumerator ()
			{
				return new MyEnumerator();
			}

		}



		class MyEnumerator : IEnumerator
		{
			public static LinkedList<Person> personLinkedList;

			public LinkedListNode<Person> currentObj;
			public object Current {
				get{
					return currentObj.Value;
				}
			}

			public bool MoveNext ()
			{
				if (personLinkedList == null) {
					personLinkedList = new LinkedList<Person>();

					personLinkedList.AddLast(new Person {Id = 1, Name = "ABC", Location = "AAA"} );
					personLinkedList.AddLast(new Person {Id = 2, Name = "DEF", Location = "BBB"} );
					personLinkedList.AddLast(new Person {Id = 3, Name = "GHI", Location = "CCC"} );
				}
				if (currentObj == null && personLinkedList.First != null)
				{

					currentObj = personLinkedList.First;
					return true;
				} 
				if ( currentObj.Next!=null)
				{
					currentObj = currentObj.Next;
					return true;
				} 
				else
				{
					return false;
				}

			}

			public void Reset ()
			{
				currentObj = null;
			}
	}
	}
}
