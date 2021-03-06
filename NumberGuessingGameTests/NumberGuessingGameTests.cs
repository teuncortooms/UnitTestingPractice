using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberGuessingGame;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NumberGuessingGameTests
{
    [TestClass]
    public class NumberGuessingGameTests
    {
        private int[] GuessMany(Game g, int[] inputs)
        {
            List<int> results = new List<int>();
            inputs.ToList().ForEach(input =>
                results.Add(g.Guess(input))
            );
            return results.ToArray();
        }

        [TestMethod]
        public void Create_Game()
        {
            Game g = new Game();

            Assert.IsInstanceOfType(g, typeof(Game));
        }

        [TestMethod]
        public void Start_should_set_boundaries()
        {
            Game g = new Game();

            g.Start(0, 3000);

            Assert.AreEqual(0, g.LowerBoundary);
            Assert.AreEqual(3000, g.UpperBoundary);
        }

        [TestMethod]
        public void Lower_boundary_cannot_be_higher_than_upper_boundary()
        {
            Game g = new Game();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => g.Start(10, 0));
        }

        [TestMethod]
        public void Guess_1_in_game_range_1_through_1_returns_true()
        {
            Game g = new Game();

            g.Start(1, 1);
            int result = g.Guess(1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Guess_outside_boundaries_throws_exception()
        {
            Game g = new Game();

            g.Start(1, 3);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => g.Guess(4));
        }

        [TestMethod]
        public void Guess_all_possibilities_twice_throws_exception()
        {
            Game g = new Game();

            g.Start(1, 3);

            void guessAllPossibilitiesTwice()
            {
                int[] results = GuessMany(g, new int[] { 1, 2, 3 });
                int[] results2 = GuessMany(g, new int[] { 1, 2, 3 });
            }

            Assert.ThrowsException<GameOverException>(() => guessAllPossibilitiesTwice());
        }

        [TestMethod]
        public void Guess_same_number_twice_throws_exception()
        {
            Game g = new Game();

            do
            {
                g.Start(1, 10);
                g.Guess(2);
            }
            while (g.HasWon); // redo if you win on first try

            Assert.ThrowsException<DuplicateGuessException>(() => g.Guess(2));
        }

        [TestMethod]
        public void Guess_negative_numbers()
        {
            Game g = new Game();

            g.Start(-3, 0);
            int result = g.Guess(-2);

            // Assert Success
        }
    }
}
