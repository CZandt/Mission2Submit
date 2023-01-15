using System;

namespace Mission2Test {
    class Program {
        static void Main(string[] args) {
            // REFEREANCE CODE ABOVE
            // ASSIGNMENT CODE BELOW

            rollingGraph rg = new rollingGraph(); // Creates the new graph object

            Dice dice1 = new Dice();
            Dice dice2 = new Dice();

            int rollTotal = 0;

            Console.Write("Welcome to the dice throwing simulator!\n");
            Console.Write("How many rolls would you like to simulate: ");

            int numRolls = 0;

            numRolls = Convert.ToInt32(Console.ReadLine()); // Collects the amount of rolls they want
            Console.WriteLine("");
            // Performs and records the rolls
            for (int i = 0; i < numRolls; i++) {
                //Roll Die 
                rollTotal = dice1.rollDie() + dice2.rollDie();

                // records the rolls
                rg.addRoll(rollTotal);

            }

            // Prints out the results

            rg.printGraph();

            //test comit

        }
    }
}

