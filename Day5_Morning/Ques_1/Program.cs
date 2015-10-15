using System;

namespace Ques_1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
				string sentence = Console.ReadLine();
			Console.WriteLine("No. of words is : {0} ",sentence.numberOfWords());
				Console.WriteLine($"No. of characters without space is : {sentence.numberOfCharacters()} ");
		}
	}

	public static class MyExtensionClass
	{

		public static int numberOfWords(this string word)
		{
			string[] words=word.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
			return words.Length;
		}
		public static int numberOfCharacters(this string charString)
		{
			int count = 0;
			string[] character=charString.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < character.Length; i++)
			{
				int length = character [i].Length;
				count = count + length;
			}
			return count;
		}
			
	}
}
