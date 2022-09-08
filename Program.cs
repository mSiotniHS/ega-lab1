namespace ega_lab1;

internal static class Program
{
	private static void Main()
	{
		var domain = new SearchDomain(new List<char> {'0', '1'}, 15);

		DomainTestDrive(domain);

		var (word, fitness) = MonteCarloMethod.FindSolution(domain, 20);
		Console.WriteLine($"\nНайдённое решение: {word} ({fitness})");
	}

	private static void DomainTestDrive(SearchDomain domain)
	{
		for (int i = 0; i < 32; i++)
		{
			var word = domain.PickRandomWord();
			var fitness = domain.CalculateFitness(word);

			Console.WriteLine($"{word} ({fitness})");
		}
	}
}
