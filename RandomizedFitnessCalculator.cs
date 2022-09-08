namespace ega_lab1;

public class RandomizedFitnessCalculator: IFitnessCalculator<string, int>
{
	private readonly Dictionary<string, int> _cache = new();
	private static readonly Random Random = new();
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

		var fitness = Random.Next(_maxValue);
		_cache.Add(preimage, fitness);

		return fitness;
	}
}
