
using System;
using System.Runtime.Remoting.Contexts;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace task4_21_1
{
    class StudentClass
    {
        private string Name; //feild

        public string _name // property
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        private int StudentID;

        public int _Id // property 
        {
            get
            {
                return StudentID;
            }
            set
            {
                if (value > 0)
                    StudentID = value;
                else
                    StudentID = 0;
            }
        }


        private int Age; //feild
        public int _age // property 
        {
            get
            {
                return Age;
            }
            set
            {
                if (value > MinAge && value<MaxAge)
                {
                    Age = value;
                }
                else
                {
                    Age = MinAge;
                }

            }
        }
        private string Email;
        public string _email { get; set; } //auto property 
        public const int MinAge = 18; //Constants feild
        public const int MaxAge = 40; //Constants feild






        public void GetDetails() //void method
        {

            Console.WriteLine(_name);
            Console.WriteLine(_age);
            Console.WriteLine(_Id);


        }
        public StudentClass()
        {
            Console.WriteLine();
        }

        public StudentClass(string name1, int age, int id) //constructor
        {
            Name = name1;
            Age = age;
            StudentID = id;

        }

        ~StudentClass() //Destructor
        {
            Console.WriteLine("******************************");
        }



        internal class Program
        { }
        static void Main(string[] args)
        {

            StudentClass student = new StudentClass();
            student._name = "Ahmad";
            student._age = 12;
            student._Id = 1001;

            student.GetDetails();

            StudentClass constructor1 = new StudentClass("sura", 24, 143721);
            constructor1.GetDetails();




            //1-What is class
            //A blueprint or template used to create objects, containing properties and methods.
            //2-What is object
            //A specific instance of a class that represents a real-world entity, storing data and performing actions.
            //3-Difference between class && object
            //Templet and blueprint
            //    Instanse of class
            //4-Mention the OOP Principles 

            //Encapsulation
            //    Inheritance
            //    Polymorphism
            //    Abstraction

            //5-What is property 

            //characteristic or attribute that represents data or state in a class, like name or age.
            //6-What is field 
            //A variable within a class used to store data.
            //7-What is constructor 
            //A special method in a class used to initialize objects when they are created.
            //8-What is encapsulation
            //encapsulation is a fundamental concept in object-oriented programming



        }
    }
}
