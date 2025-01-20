

using System;
using System.Diagnostics;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace task3_20_1
{
    internal class Program
    {

        //1
        static string print1(int x)
        {

            if (x % 2 == 0)
            {
                return (x + " is even");
            }
            else
            {
                return (x + " is odd");
            }
        }

        //2
        static int sorter()
        {
            int[] ints = new int[5];
            for (int i = 0; i < ints.Length; i++)
            {

                ints[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(ints);

            return ints[1];


        }

        //3
        static int factorial()
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            for (int i = A; i > 0; i--)
            {
                n *= i;
            }
            return n;

        }

        //4
        static int integers()
        {
            int startNumber = Convert.ToInt32(Console.ReadLine());
            int endNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = startNumber; i <= endNumber; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0 && i != 1)
                {
                    Console.Write("{0} ", i);
                }
            }
            return 0;

        }

        //5
        static int integerArray()
        {
            int[] array1 = new int[6];

            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array1);
            return array1[5];

        }

        //6
        static int numberpattern()
        {
            int n = 5;
            int currentNum = 1;
            for (int row = 1; row <= n; row++)
            {
                for (int Column = 1; Column <= row; Column++)
                {
                    Console.Write(Column + " ");
                    currentNum++;
                }
                Console.WriteLine();

            }

            return currentNum;
        }




        //7
        static string starprint()
        {
            string star = "*";
            for (int i = 1; i < 5; i++)
            {
                for (global::System.Int32 j = 1; j <= i; j++)
                {
                    Console.Write("*");
                    star += "*";
                }
                Console.WriteLine();
            }
            return star;
        }


        //8
        static void sumprint()
        {

            int evensum = 0;
            int oddsum= 0;
            int[] array0 = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < array0.Length; i++)
            {
                if (i%2==0)
                {
                   evensum += array0[i];
                }
                else
                {
                    oddsum += array0[i];
                }
            }
            Console.WriteLine("Sum of Even Numbers: " + evensum);
            Console.WriteLine("Sum of Odd Numbers: "+oddsum);
        }



        //static void compartion()
        //{
        //    int[] Array1 = {1, 2, 3, 4 };
        //    int[] Array2 = { 3, 4, 5, 6 };


        //    int[] value = { };
        //    for (int i = 0; i < Array1.Length; i++)
        //    {
        //        for (global::System.Int32 j = 0; j < Array2.Length; j++)
        //        {
        //            if (Array1[i] == Array2[j])
        //            {
        //                value = j;
        //            }
        //        }
        //    }
        //    Console.WriteLine(value);
        //}


        static void Main(string[] args)
        {

            // 1 - Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.
            //•	Example Input: 7
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The number " + print1(x));

            // 2 - Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
            //•	Example Input: 4, -3, 7, 2, 0




            Console.WriteLine(sorter());



            //  3 - Write a program that calculates the factorial of a given number using a for loop.
            //•	Example Input: 5

            Console.WriteLine(factorial());


            //            4 - Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.
            //•	Example Input:
            //o Start: 10
            //o End: 30

            integers();

            //5 - Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            //•	Example Array: { 3, 1, 4, 1, 5, 9}

            Console.WriteLine(integerArray());


            //6 - Write a program that prints the following number pattern using nested loops:
            //For n = 5, the output should be:
            //1
            //2 3
            //4 5 6
            //7 8 9 10
            //11 12 13 14 15


            Console.WriteLine(numberpattern());



            // 7 - Write a program that prints a pyramid pattern using stars (*) based on the input height.Use nested loops. (optional)
            //•	Example Input: n = 4


            Console.WriteLine(starprint());



            //8 - Write a program that takes an array of integers and calculates the sum of even numbers and odd numbers separately using loops.  (optional)
            //•	Example Input: { 1, 2, 3, 4, 5, 6}


            sumprint();


            //9 - Write a program that compares two arrays and prints their common elements using loops.
            compartion();

            //Class && Object


            Hotel room1 = new Hotel();
            Console.WriteLine(Hotel.HotelName);

            room1.RoomNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(room1.RoomNumber);

            room1.RoomType = Console.ReadLine();
            Console.WriteLine(room1.RoomType);

            room1.PricePerNight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(room1.PricePerNight);

            Console.WriteLine(Hotel.Booked);

            //*****************************************************************
            Hotel room2 = new Hotel();
            Console.WriteLine(Hotel.HotelName);


            room2.RoomNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(room2.RoomNumber);

            room2.RoomType = Console.ReadLine();
            Console.WriteLine(room2.RoomType);

            room2.PricePerNight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(room2.PricePerNight);

            Console.WriteLine(Hotel.Booked);





        }
    }
    class Hotel
    {
        public const string HotelName = "Grand Stay Hotel";
        public int RoomNumber;
        public string RoomType;
        public double PricePerNight;
        public const Boolean Booked = true;

    }
}
