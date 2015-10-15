using System;

namespace Ques_1
{
	public class ExtensionClass
	{


		public static int numberOfWords(this string s)
		{
			string[] wordsArray=s.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
			return wordsArray.Length;
		}
		public static int numberOfCharacters(this string charString)
		{
			int count = 0;
			string[] wordsArray=charString.Split((string[]) null, StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < wordsArray.Length; i++)
			{
				int length = wordsArray [i].Length;
				count = count + length;
			}
			return count;
		}
	}
}

