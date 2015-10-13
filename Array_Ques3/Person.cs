using System;

namespace Array_Ques3
{
	class Person: IComparable<Person>
	{
		public Person ()
		{
		}
		public string firstName{ get; set;}
		public string lastName{ get; set;}
		public int age;
		public int CompareTo(Person thePerson)
		{
			return thePerson.age.CompareTo (this.age);
		}
	}
}

