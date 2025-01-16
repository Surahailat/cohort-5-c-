
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace cohort_5_c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Create console application that read string from user and print the same string

            string name = Console.ReadLine();
            Console.WriteLine("HELLO  " + name);



            //            2 - Define variables with kind of
            //a.Double
            //b.String
            //c.Char
            //d.Bool
            //e.Int
            //f.Const
            //Then display it in console application

            double price = 15.55;
            string name1 = "sura";
            char a = 'A';
            bool boolian = false;
            int number = 50;
            const float num = 3.14f;

            Console.WriteLine(name1);



            //3 - Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] cars = { "BMW", "KIA", "HONDA" };
            foreach (var i in cars) // i ==> value
            {
                Console.WriteLine(i);
            }




            //  4 - Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially.Go to the editor
            //•	Input your firstname: Sami
            //•	Input your lastname: Ali
            //•	Input your year of birth: 1999
            //•	Sami Ali 1999


            
            Console.Write("Input Your First Name: ");
            string FirstName = Console.ReadLine();

            
            Console.Write("Input Your Last Name: ");
            string LastName = Console.ReadLine();


            Console.Write("Input Your Date of Birth: ");
            int birth = Convert.ToInt32(Console.ReadLine());


            Console.Write("");




            //            5 - Write a program in C # to store elements in an array and print it. 
            //•	Test Data :	
            //•	Input 10 elements in the array :
            //•	element - 0 : 1
            //•	element - 1 : 1
            //•	element - 2 : 2
            //•	.......
            //•	Expected Output :
            //•	Elements in array are: 1 1 2 3 4 5 6 7 8 9


            int[] elements = new int[10];
            Console.WriteLine("Enter 10 elements:");

            for (int i = 0; i < elements.Length; i++)
            {

                elements[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array elements: ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i] + " ");
            }







        }
    }
}
