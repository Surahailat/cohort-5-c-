
using System;
using System.Collections.Generic;
using System.Threading;

namespace project2_19_1
{
    internal class Program
    {
        static int smaller(int x, int y)
        {
            if (x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }


        static double speed()
        {
            double value = Convert.ToInt32(Console.ReadLine());
            double val = value * 0.621371;
            return val;

        }

        static int clock()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string s = $"{a} hours, {b} minutes";
            int sum = (a * 60) + b;
            return sum;

        }

        static string clock2()
        {
            int mins = Convert.ToInt32(Console.ReadLine());
            int h = mins / 60;
            int secs = mins % 60;
            string oclock = ($"{h} Hours , {secs} Minutes");
            return oclock;
        }


        static string Compare(int num1, int num2)
        {
            if (num1 == num2)
            {
                return "Equal";
            }
            else if (num1 > num2)
            {
                return "Greater";
            }
            else
            {
                return "Smaller";
            }
        }




        static int sumnum(int num0)
        {
            int sumn = 0;
            int divi;
            while (num0 > 0)
            {
                divi = num0 % 10;
                sumn += divi;
                num0 = num0 / 10;
            }
            return sumn;
        }












        static void Main(string[] args)
        {

            // 1 - Write a C# program that accepts a double input and converts it into an int. Display both values.
            //•	Example:
            // Input: 9.8

            double dub = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(dub);
            Console.WriteLine((int)dub);


            //2 - Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.
            //Example:
            //Input: 25
            //Output: "Your number is: 25"

            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + Convert.ToString(num));


            //3 - Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
            //Input: "C# is fun!"

            string sentence = Console.ReadLine();
            Console.WriteLine("Uppercase: C# IS " + sentence.ToUpper());
            Console.WriteLine("Lowercase: c# is " + sentence.ToLower());


            //            4 - Write a program that takes a user's full name as input and prints:
            //The first name.
            //The last name.
            //The length of the full name.
            //•	Example:
            //        Input: "John Doe"

            string fName = Console.ReadLine();
            string LName = Console.ReadLine();
            string fullName = fName + " " + LName;
            Console.WriteLine(fullName);
            Console.WriteLine("First Name: " + fName);
            Console.WriteLine("Last Name: " + LName);
            Console.WriteLine(fullName.Length);


            //5 - Write a program that accepts two integers and prints the smaller of the two.
            //Input: 5, 9

            Console.WriteLine(smaller(5, 9));


            //6 - Write a method that converts kilometers per hour to miles per hour.Use this method in a program to convert and display the result.
            //Input: 15 km / h
            //Output: "9.320568 mph"

            Console.WriteLine(speed() + " mph");

            //7 - Write a method that takes hours and minutes as input and returns the total number of minutes.
            //Input: 5 hours, 37 minutes

            Console.WriteLine("Total: " + clock() + " minutes ");



            // 8 - Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            //•	Input: 546 minutes

            Console.WriteLine(clock2());

            //9 - Compare Two Numbers
            //Write a program that prints:
            //            "Equal" if two numbers are the same.
            //"Greater" if the first is greater.
            //"Smaller" if the second is greater.
            //Use only comparison and ternary operators.
            //•	Input: 10, 20

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Compare(num1, num2));


            //  Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
            //Input: 123
            //Output: "Sum of digits: 6"


            int num0 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sumnum(num0));


            //10 - Reverse a Number
            //Write a program that reverses a number using arithmetic operators and loops.
            //Input: 1234

            int[] arr = { 1, 2, 3, 4 };

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();





            //11 - Check Divisibility
            //Write a program to check if a number is divisible by another number using logical and arithmetic operators. Return a message "Divisible" or "Not Divisible".
            //Input: 25, 5

            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());


            if (number1 % number2 == 0)
            {
                Console.WriteLine("Divisible");
            }
            else
            {
                Console.WriteLine("Not Divisible");
            }



            //            12 - Find the Middle Value
            //Write a program to find the middle value of three numbers using arithmetic and comparison operators.


            int firstnum = Convert.ToInt32(Console.ReadLine());
            int midnum = Convert.ToInt32(Console.ReadLine());
            int finalnum = Convert.ToInt32(Console.ReadLine());
            int sort;
            if (firstnum > midnum)
            {
                sort = firstnum;
                firstnum = midnum;
                midnum = sort;
            }
            if (midnum > finalnum)
            {
                sort = midnum;
                midnum = finalnum;
                finalnum = sort;
            }
            if (firstnum > midnum)
            {
                sort = firstnum;
                firstnum = midnum;
                midnum = sort;
            }


            //Console.WriteLine($"{firstnum}, {midnum}, {finalnum}");
            Console.WriteLine($"The middle value is:  {midnum}");



            //Console.WriteLine("Enter three numbers:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());
            //int num3 = Convert.ToInt32(Console.ReadLine());


            //int middle;

            //if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
            //{
            //    middle = num1;
            //}
            //else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num2 < num1))
            //{
            //    middle = num2;
            //}
            //else
            //{
            //    middle = num3;
            //}


            //Console.WriteLine($"The middle value is: {middle}");



            //Problem solving

            //string word = Console.ReadLine().ToLower();
            //char[] chars = { 'a', 'e','i','o', 'u' };
            //int count = 0;
            //foreach (var item in word)
            //{
            //    foreach (var item1 in chars)
            //    {
            //        if (item==item1)
            //        {
            //            count++; 
            //        }
            //    }
            //}
            //Console.WriteLine(count);




            //  Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
            //Input: 123
            //Output: "Sum of digits: 6"

            string sumindex = "123";

            int count = 0;

            for (int i = 0; i < sumindex.Length; i++)
            {

                count += int.Parse(sumindex[i].ToString());
            }
            Console.WriteLine(count);
        }
    }
}
