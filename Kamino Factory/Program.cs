using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;

            int bestLenght = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int sequenceCounter = 0;
            int bestSequenceIndex = 0;
            int[] bestSequence = new int[n];

            while ((input = Console.ReadLine()) != "Clone them!") //1!0!1!1!0
            {

                int[] currentSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                //1 0 1 1 0
                sequenceCounter++;

                int lenght = 1;
                int bestCurrentLenght = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        lenght++;
                    }
                    else
                    {
                        lenght = 1;
                    }

                    if (lenght > bestCurrentLenght)
                    {
                        bestCurrentLenght = lenght;
                        startIndex = i;
                    }
                    currentSequenceSum += currentSequence[i];

                }
                currentSequenceSum += currentSequence[n - 1];

                if (bestCurrentLenght > bestLenght)
                {
                    bestLenght = bestCurrentLenght;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();

                }
                else if (bestCurrentLenght == bestLenght)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLenght = bestCurrentLenght;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();
                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLenght = bestCurrentLenght;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();
                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(' ',bestSequence));
        }
    }
}
