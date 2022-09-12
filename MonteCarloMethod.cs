using System;

namespace ega_lab1;

public static class MonteCarloMethod
{
	public static (string, int) FindSolution(SearchDomain domain, uint iterationCount)
	{
		var bestFitness = 0;
		var bestWord = "";

		for (var i = 0; i < iterationCount; i++)
		{
			Console.WriteLine($"\nИтерация №{i+1}  |  \"Лучшее\" слово: {bestWord} ({bestFitness})");

			var word = domain.PickRandomWord();
			var fitness = domain.CalculateFitness(word);

			Console.WriteLine($"> Отобранный кандидат: {word} ({fitness})");

			if (fitness > bestFitness)
			{
				bestFitness = fitness;
				bestWord = word;

				Console.WriteLine("> Рассматриваемая приспособленность лучше имеющейся, обновляем");
			}
			else
			{
				Console.WriteLine("> Рассматриваемая приспособленность не лучше имеющейся, пропускаем");
			}
		}

		return (bestWord, bestFitness);
	}
}
