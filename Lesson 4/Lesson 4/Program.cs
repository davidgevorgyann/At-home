using System;
using System.Linq;


namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //string[] cars = new string[4]
            //{ "Bmw", "Mercedes", "Ferrari", "Lamborghini" };
            //Console.WriteLine(cars[1]);



            //string[] cars = new string[4]
            //{ "Bmw", "Mercedes", "Ferrari", "Lamborghini" };
            //cars[0] = "Tesla";
            //Console.WriteLine(cars[0]);



            //string[] cars = new string[]
            //{ "Bmw", "Mercedes", "Ferrari", "Lamborghini", "Tesla"};
            //Console.WriteLine(cars.Length);



            //string[] cars = new string[]
            //{ "Bmw", "Mercedes", "Ferrari", "Lamborghini", "Tesla"};

            // for (int i = 0; i<cars.Length; i++) 
            // {
            //     Console.WriteLine(cars[i]);
            // }



            //string[] cars= new string[]
            //{ "Bmw", "Mercedes", "Ferrari", "Lamborghini", "Tesla"};

            //foreach(string i in cars)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] cars = new int[]
            //{ 12, 34, 54, 88, 766};

            //Array.Sort(cars);
            //foreach(int i in cars)
            //{
            //    Console.WriteLine(i);
            //}



            //int[] numbers = new int[]
            //{21,5,78,4};

            //// You should add using System.Linq

            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());
            //Console.WriteLine(numbers.Sum());

            // Loops

            //int i , j;

            //for (i = 2; i < 100; i++)
            //{
            //    for (j = 2; j <= (i / j); j++) {

            //        if ((i % j) == 0) break;
            //        if (j > (i / j)) Console.WriteLine("{0} is prime", i);


            //    }
            //}
            //Console.ReadLine();

            

            int day = 1 ;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;

            }
           
           




        }
    }
}
