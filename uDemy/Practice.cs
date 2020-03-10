using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uDemy
{
    class Practice
    {

        public static void Number()
        //Write a program and ask the user to enter a number.The number should be between 1 to 10.
        //If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
        {
            Console.WriteLine("Please enter number between 1 - 10");
            var response = Int32.Parse(Console.ReadLine());
            if (response >= 1 && response <= 10)
            {
                Console.WriteLine("This is a valid number");
            }
            else
            {
                Console.WriteLine("This is an invalid number");
            }
        }

        public static void Divisible()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            
            {
                if (i % 3 == 0)
                    count++;
            
            }
            Console.WriteLine("{0}", count);


        }

        public static bool Case(string str)
        {
            return str == str.ToUpper() | str == str.ToLower();
        }


        //public static bool DoubleLetters(string word)
        //{
        //for (int i =1; i<word.Length-1; i++)
        //    {
        //        if (word[i]== word[i + 1]) { return true;}
        //    }
        //    return false;
            
        //}

        public static string DoubleChar(string str)
        {
            string newstr = "";
            foreach(char s in str)
            {
                newstr += s.ToString() + s.ToString();
            }
            return newstr;
        }   
            
       
    }      
}