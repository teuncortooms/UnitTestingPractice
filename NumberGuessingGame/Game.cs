using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    public class Game
    {
        public int LowerBoundary { get; private set; }
        public int UpperBoundary { get; private set; }
        public List<int> SavedGuesses { get; private set; }
        public int GuessCount { get; private set; }
        public bool HasWon { get; private set; }

        private int answer;

        public void Start(int min, int max)
        {
            LowerBoundary = min;
            UpperBoundary = max;
            SavedGuesses = new List<int>();
            GuessCount = 0;
            HasWon = false;
            answer = (new Random()).Next(LowerBoundary, UpperBoundary + 1);
        }

        public bool Guess(int input)
        {
            if (input < LowerBoundary || input > UpperBoundary)
                throw new ArgumentOutOfRangeException();
            if (HasWon)
                throw new GameOverException("You have already won!");
            if (SavedGuesses.Contains(input))
                throw new DuplicateGuessException();

            GuessCount++;
            if (input == answer)
            {
                HasWon = true;
                return true;
            }
            SavedGuesses.Add(input);
            return false;
        }
    }
}
