using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.Write("Welcome to the Grand Circus Casino!");
                Console.WriteLine(" Roll the dice? (y/n): ");
                choice = Console.ReadLine();
            } while (choice != "y");
            string cont;
            do
            {
                Console.WriteLine("Rolling dice");
                Dice newRun = new Dice();
                newRun.Roll();
                Console.WriteLine("Die 1 rolled a {0}", newRun.Die1);
                Console.WriteLine("Die 2 rolled a {0}", newRun.Die2);
                int total = newRun.Die1 + newRun.Die2;
                Console.WriteLine("Roll again? (y/n)");
                cont = Console.ReadLine();
            } while (cont == "y");
        }

        class Dice
        {
            private int die1;
            private int die2;

            public int Die1
            {
                get { return die1; }
                set { die1 = value; }
            }


            public int Die2
            {
                get { return die2; }
                set { die2 = value; }
            }

            public void Roll()
            {
                //get a random number object we can the use to determine the die face
                Random rand1 = new Random();
                Die1 = rand1.Next(1, 1000);
                Die2 = rand1.Next(1, 1000);
            }
        }
    }
}
