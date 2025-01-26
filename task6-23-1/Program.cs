

using System;

namespace task6_23_1
{

    //polymorphism
    class Calculator     //class    
    {
        public int add(int num1, int num2)  //overload (with 2 parameter)
        {
            return num1 + num2;
        }
        public int add(int num1, int num2, int num3)  //overload   (with 3 parameter)
        {
            return num1 + num2 + num3;
        }
        public double add(double num1, double num2)   //overload  (with different datatypy of parameter)
        {
            return num1 + num2;
        }


    }


    //Overriding
    class Shape   //super or base class
    {
        public virtual void draw()   //Overriding (different contant in method)
        {
            Console.WriteLine("From shap class");
        }
    }
    class Circle : Shape   //Derived or sub class
    {
        public override void draw()    //Overriding (different contant in method)
        {
            Console.WriteLine("Drawing a Circle.");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()   //Overriding (different contant in method)
        {
            Console.WriteLine("Drawing a Rectangle.");
        }
        
    }


    //Abstract Class
    abstract class Animal  //You cannot instantiate an abstract class. (Contains both abstract and non-abstract methods.)
    {
        public abstract void makeSound();  //abstract method (without contant)
        public void sleep()
        {
            Console.WriteLine("Animal is sleeping.");
        }
    }
     class Dog : Animal
    {
        public override void makeSound()   //override method
        {
            Console.WriteLine("Dog barks.");
        }
    }
    class Cat : Animal
    {
        public override void makeSound()  //override method
        {
            Console.WriteLine("Cat meows.");
        }
    }

    interface Playable   //Interface (method without emplimintation)
    {
        void play();
    }
    class Guitar : Playable
    {
        public void play()
        {
            Console.WriteLine("Playing the guitar.");
        }
    }
    class Piano : Playable
    {
        public void play()
        {
            Console.WriteLine("Playing the piano.");
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {

            Calculator calc1 = new Calculator();
            Console.WriteLine(calc1.add(1, 2));
            Console.WriteLine(calc1.add(10, 2));
            Console.WriteLine(calc1.add(3.55, 6.11));

            Console.WriteLine("**********************************");

            Shape shape = new Shape();
            shape.draw();
            Circle circle = new Circle();
            circle.draw();
            Rectangle rectangle = new Rectangle();
            rectangle.draw();
            Console.WriteLine("**********************************");
            Dog dog = new Dog();
            dog.makeSound();
            Cat cat = new Cat();
            cat.makeSound();
            Console.WriteLine("**********************************");
            Guitar guitar = new Guitar();
            guitar.play();
            Piano pi = new Piano();
            pi.play();

        }
    }
}
