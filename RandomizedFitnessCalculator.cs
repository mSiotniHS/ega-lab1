using System;
using System.Collections.Generic;

namespace ega_lab1;

public class RandomizedFitnessCalculator: IFitnessCalculator<string, int>
{
	private readonly Dictionary<string, int> _cache = new();
	private readonly Random _random = new();
	private readonly int _maxValue;

	public RandomizedFitnessCalculator(int maxValue)
	{
		_maxValue = maxValue;
	}

	public int Calculate(string preimage)
	{
		if (_cache.ContainsKey(preimage))
		{
			return _cache[preimage];
		}

		var fitness = _random.Next(_maxValue);
		_cache.Add(preimage, fitness);

		return fitness;
	}
}
