using System;
namespace Mission2Test {
    public class Dice {
        private int rolls;
        private int value;

        public Dice() {
            rolls = 0;
            value = 0;
        }

        public int rollDie() {
            // Picks a random number between 1-6 since it is a 6 sided die
            Random rnd = new Random();
            value = rnd.Next(1, 7);

            return value;
        }

    }
}

