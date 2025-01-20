
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


            Console.WriteLine(FirstName + " " + LastName + " " + birth);




            //   5 - Write a program in C # to store elements in an array and print it. 
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

            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("age " + num);


            //double number = 5.5555;
            //string fname = "sura";
            //char character = 'l';
            //bool boolian = true;
            //int intnum = 10;
            //const float pi = 3.14f;
            //Console.WriteLine(number);
            //Console.WriteLine(fname);
            //Console.WriteLine(character);
            //Console.WriteLine(boolian);
            //Console.WriteLine(intnum);
            //Console.WriteLine(pi);


            //string[] car = { "bmw", "mercedes", "honda" };

            //foreach (var i in car)
            //{
            //    Console.WriteLine(i);

            //};
            //car[0] = "golf";
            //foreach (var i in car)
            //{
            //    Console.WriteLine(i);
            //}



            //string firstName = Console.ReadLine();
            //Console.Write(firstName);

            //string lastName = Console.ReadLine();
            //Console.Write(firstName);

            //int birth = Convert.ToInt32(Console.ReadLine());
            //Console.Write(birth);


            //int[] arr = new int[10];
            //Console.WriteLine("Enter the element: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach (var i in arr)
            //{
            //    Console.WriteLine(i);
            //}


            //string[] fruits = new string[5];
            //Console.WriteLine("write 5 fruits: ");
            //for (int i = 0; i < fruits.Length; i++)
            //{
            //    fruits[i] = Console.ReadLine();
            //}
            //foreach (var i in fruits)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(fruits.Length);





            //string[] colors ={ "Red", "Blue", "Green", "Yellow", "Rose", "Purple", "black", "Ruby"};

            //string color = "";
            //int count = 0;

            //foreach (string co in colors)
            //{
            //    if (co.StartsWith("R", StringComparison.OrdinalIgnoreCase))
            //    {
            //        color += co + ' ';
            //        count++;

            //    }
            //}
            //if (count>0)
            //    {
            //        Console.WriteLine("colors starting with 'R' :"+color);

            //    }
            //Console.WriteLine("Total count :" + count);
            //}



            //int[] numbers1 = new int[6];
            //for (int i = 0; i < numbers1.Length; i++)
            //{
            //    numbers1[i]= Convert.ToInt32(Console.ReadLine());
            //}


            //float sum = 0;
            //foreach (int element in numbers1)
            //{
            //    sum += element;
            //}
            //Console.WriteLine("Sum of elements : " + sum);
            //Console.WriteLine("Avarege of elements : "+sum/(numbers1.Length));

            //int min = numbers1[0];
            //foreach (var item in numbers1)
            //{
            //    if (item<min)
            //    {
            //        min = item; 
            //    }
            //}
            //Console.WriteLine("Minimum value :" + min);


            //int max = numbers1[0];
            //foreach (var i in numbers1)
            //{
            //    if (i>max)
            //    {
            //        max = i;
            //    }
            //}
            //Console.WriteLine("Maximam value : " + max );


            //Array.Sort(numbers1);
            //Console.Write("sort");
            //foreach (var x in numbers1)
            //{
            //    Console.Write(" "+x);
            //}



















        }
    }
}
