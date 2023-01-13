using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachingFirstProgram
{
    public class Methods
    {
        //1. must always work until stopped manually
        //2. must add, subtract, multiply and divide
        public void Calculator()
        {
            while (true)
            {
                Console.WriteLine("please choose what you would like to do:\n" +
                    "a: addition \n" +
                    "s: subtraction \n" +
                    "d: division \n" +
                    "m: multiplication \n" +
                    "e: ends the program \n");
                string input = Console.ReadLine();
                input = input.ToLower();

                if (input == "a")
                {
                    int x = GetNumber();
                    int y = GetNumber();
                    
                    int z = Addition(x, y);
                    Console.WriteLine("your numbers are: " + x + " and " + y);
                    Console.WriteLine("added they are " + z);
                }
                else if (input == "s")
                {
                    int x = GetNumber();
                    int y = GetNumber();

                    int z = Subtraction(x, y);
                    Console.WriteLine("your numbers are: " + x + " and " + y);
                    Console.WriteLine("subtracted they are " + z);
                }
                else if (input == "d")
                {
                    int x = GetNumber();
                    int y = GetNumber();

                    float z = Division(x, y);
                    Console.WriteLine("your numbers are: " + x + " and " + y);
                    Console.WriteLine("divided they are " + z);
                }
                else if (input == "m")
                {
                    int x = GetNumber();
                    int y = GetNumber();

                    int z = Multiplication(x, y);
                    Console.WriteLine("your numbers are: " + x + " and " + y);
                    Console.WriteLine("multiplied they are " + z);
                }
                else if (input == "e")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("not an option");
                    
                }
            }

        }

        public int GetNumber()
        {
            int result2 = 0;
            bool n1 = true;
            do
            {
                Console.WriteLine("Enter number: ");
                string input = Console.ReadLine();
                n1 = int.TryParse(input, out result2);

                if (n1 == false)
                {
                    Console.WriteLine("That's not a number");
                }
            } while (n1 == false);

            return result2;
        }



        //public void GetInput()
        //{
        //    while(true)
        //    {
        //        Console.WriteLine("hello world");

        //        string string1 = Console.ReadLine();
        //        string completeString = string1.ToLower();
        //        completeString = completeString.Trim();

        //        bool isInt = int.TryParse(string1, out int result1);

        //        if (isInt == true)
        //        {
        //            GetInput2(result1);
        //        }
        //        else if (completeString == "end")
        //        {
        //            break;
        //        }
        //        else
        //        {
        //            Console.WriteLine("thats not a number");
        //        }
        //        int answer = Addition(1,6);
        //        string answerString = answer.ToString();
        //        Console.WriteLine("Answer is: " + answerString);
        //    }
        //}
        //public void GetInput2(int int1)
        //{
        //    int int2 = int1 + 10;
        //    Console.WriteLine(int2.ToString());
        //}

        public int Addition(int a, int b)
        {
            return a + b;
        }
        public int Subtraction(int a, int b)
        {
            return a - b;
        }
        public float Division(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a / b;
        }
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
    }
}
