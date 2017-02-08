using System;
using System.Linq;

namespace RandomizeWords
{
	public class MainClass
	{
		public static void Main()
		{
			var words = Console.ReadLine()
							   .Split(' ')
			                   .ToList();

			var randomize = new Random();

			for (var i = 0; i < words.Count; i++)
			{
				var currentWord = words[i];

				var newPos = randomize.Next(words.Count);

				var tempWord = words[newPos];

				words[i] = tempWord;

				words[newPos] = currentWord;
			}

			Console.WriteLine(string.Join("\n", words));
		}
	}
}
