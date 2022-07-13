using System;

namespace Lesson_5
{
    class Program
    {
        //static void Mymethod(string names)
        //{
        //    Console.WriteLine(names);
        //}
        //static void Main(string[] args)
        //{
        //    Mymethod("Karen");
        //    Mymethod("Narek");
        //    Mymethod("Alex");
        //}



        //static void Mymethod(string country = "Erevan")
        //{
        //    Console.WriteLine(country);
        //}
        //static void Main(string[] args)
        //{
        //    Mymethod();
        //    Mymethod("New York");
        //    Mymethod("London");
        //}



        //static void Mymethod(string name , int age)
        //{
        //    Console.WriteLine(name + " is " + age);
        //}
        //static void Main(string[] args)
        //{
        //    Mymethod("Karen", 20);
        //    Mymethod("David", 16);
        //    Mymethod("Alex", 18);
        //}



        //static int Mymethod(int x)
        //{
        //    return 5 + x;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Mymethod(5));
        //}



        //static int Mymethod(int x , int y)
        //{
        //    return x / y;
        //}
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Mymethod(10 , 2));
        //}



        //static int Mymethod(int x , int y)
        //{
        //    return x * y;
        //}
        //static void Main(string[] args)
        //{
        //    int a = Mymethod(11,11);
        //    Console.WriteLine(a);
        //}



        //static void Mymethod(string child1 , string child2 , string child3)
        //{
        //    Console.WriteLine("The oldest child is:" + child2);
        //}
        //static void Main(string[] args)
        //{
        //    Mymethod(child1: "David", child2: "Karen", child3: "Alex");
        //}



        //static int MymethodInt(int x , int y)
        //{
        //    return x * y;
        //}
        //static double MymethodDouble(double x  , double y)
        //{
        //    return x + y;
        //}
        //static void Main(string[] args)
        //{
        //    int number1 = MymethodInt(10, 10);
        //    double number2 = MymethodDouble(4.5 , 2.25);
        //    Console.WriteLine("Int is:" + number1);
        //    Console.WriteLine("Double is :" + number2);
        //}



        //This example we can write only in one method

        //static int Mymethod(int x , int y)
        //{
        //    return x / y;
        //}
        //static double Mymethod(double x , double y)
        //{
        //    return x - y;
        //}
        //static void Main(string[] args)
        //{
        //    int m1 = Mymethod(81, 9);
        //    double m2 = Mymethod(7.35, 4.35);
        //    Console.WriteLine("Int is:" + m1);
        //    Console.WriteLine("Double is:" + m2);
        //}



        public static bool Mymethod(int a , int[] x)
        {
           

            foreach(int item in x)
            {
                if(a == item)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
         

        }
        static void Main(string[] args)
        {
            int[] tver = { 12, 23, 55, 8, 97 };
            Mymethod(5,tver);
        }









    }
}
