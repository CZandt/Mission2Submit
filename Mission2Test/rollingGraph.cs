using System;
namespace Mission2Test {
    public class rollingGraph {
        private int[] rollCounts = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private int numRolls = 0;

        public rollingGraph() {
        }

        public void addRoll(int rollValue) {
            rollCounts[rollValue - 1] += 1;
            numRolls += 1;

        }

        public void printGraph() {
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numRolls);

            // Starts printing the graph portion of the assignment
            //Uses a for loop to go through the roll counts

            for (int i = 1; i < 12; i++) {
                Console.Write("\n" + (i + 1) + ": "); //Prints the 2: before the ***
                // calculates the number of stars
                double numStarsFloat;



                numStarsFloat = (Convert.ToDouble(rollCounts[i]) / Convert.ToDouble(numRolls)) * 100.00;



                for (int j = 0; j < Convert.ToInt32(numStarsFloat); j++) //numStarsFloat is a float so comparing to an int may be weird
                {
                    Console.Write("*");


                }

            }

            // Finishing printing the graph

            Console.WriteLine("\nThank you for using the dice throwing simulator");


        }
    }
}

