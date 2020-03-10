using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uDemy
{
    class VeryEasy
    {
    // Return the sum of Two Number
    // Create a function that takes two numnbers as arguments
    // and return their sum.
    public static int SumOfTwoNumbers(int a, int b)
        {
            var Mars = (a + b);
            return Mars;
        }

        //Create a function that takes a number as an argument, 
        //increments the number by +1 and returns the result.
        public static int Addition (int a)
        {
            var numsum = (a + 1);
            return numsum;
        }

        //Write a function that takes the base and height of a triangle and return its area.
        public static int TriArea(int basee, int height)
        {
            int Bason = (basee * height);
            return Bason; 
        }

        //Return the Remainder from Two Numbers
        public static int Remainder(int a, int b)
        {
            int Remain = (a % b);
            return Remain;
        }

        // Create a function that takes a number as its only argument and returns true  
        // if it's less than or equal to zero, otherwise return false.
        public static bool LessThenOrEqual(int a)
        {
            if (a <= 0)
            {
                return true;
            }
            return false;
        }

        //Create a function that reverses a boolean value.
        public static bool BooBoo(bool Reverse) 
        {
            return !Reverse;
        }

        // In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals.
        // The farmer breeds three species: chickens = 2 legs, cows = 4 legs, goats = 4 legs
        // The farmer has counted his animals and he gives you a subtotal for each species. 
        // You have to implement a function that returns the total number of legs of all the animals.

        public static int FarmProblem(int Chicken, int cow, int goat)
        {
            int chkleg = (Chicken * 2);
            int cowleg = (cow * 4);
            int gotleg = (goat * 4);
            int ttlleg = (chkleg + cowleg + gotleg);
            return ttlleg;

        }
        //Create a function that returns true if an integer is evenly divisible by 5, and false otherwise.
        public static bool FiveDiv (int five)
        {
            if (five%5 == 0)
            {
                return true;
            }
            return false;
        }

    }
}
