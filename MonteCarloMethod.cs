namespace ega_lab1;

public static class MonteCarloMethod
{
	public static (string, int) FindSolution(SearchDomain domain, uint iterationCount)
	{
		var bestFitness = 0;
		var bestWord = "";

		for (var i = 0; i < iterationCount; i++)
		{
			Console.WriteLine($"\nИтерация №{i}  |  \"Лучшее\" слово: {bestWord} ({bestFitness})");

			var word = domain.PickRandomWord();
			var fitness = domain.CalculateFitness(word);

			Console.WriteLine($"> Отобранный кандидат: {word} ({fitness})");

			if (fitness <= bestFitness)
			{
				Console.WriteLine("> Рассматриваемая приспособленность не лучше максимальной, пропускаем");
				continue;
			}

			bestFitness = fitness;
			bestWord = word;

			Console.WriteLine("> Рассматриваемая приспособленность лучше максимальной, обновляем");
		}

		return (bestWord, bestFitness);
	}
}
