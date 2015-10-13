using System;
using System.Collections.Generic;

namespace Array_Ques4
{
	public class Person
	{
		public Person ()
		{
		}
		public string firstName;
		public string lastName;
		public int age;
		public int CompareTo(Person thePerson)
		{
			return thePerson.age.CompareTo (this.age);
		}
	}
	public class ComparerClassCommon:IComparer<Person>
	{
		public int Compare(Person p1, Person p2)
		{
			return p2.age.CompareTo (p1.age);
		}
	}
}

