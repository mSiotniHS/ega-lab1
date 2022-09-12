using System;
using System.Collections.Generic;
using System.Text;

namespace ega_lab1;

public sealed class SearchDomain
{
	private readonly List<char> _alphabet;
	private readonly uint _wordLength;
	private readonly Random _random = new();
	private readonly IFitnessCalculator<string, int> _fitnessCalculator;

	public SearchDomain(List<char> alphabet, uint wordLength)
	{
		_alphabet = alphabet;
		_wordLength = wordLength;

		//var wordCount = Convert.ToInt32(Math.Pow(alphabet.Count, wordLength));
		_fitnessCalculator = new RandomizedFitnessCalculator(1000);
	}

	public string PickRandomWord()
	{
		var sb = new StringBuilder();
		for (var i = 0; i < _wordLength; i++)
		{
			sb.Append(_alphabet[_random.Next(_alphabet.Count)]);
		}

		return sb.ToString();
	}

	public int CalculateFitness(string word)
	{
		return _fitnessCalculator.Calculate(word);
	}
}
