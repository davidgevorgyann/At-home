using System;

namespace Readonly_and_const
{
    class Myclass
    {
        public const double PI = 3.14;
        public const string ERROR = "some error";

        public readonly int _a;

        public static readonly int _b;


        static Myclass()
        {
            _b= 3;
        }


    public Myclass(int a)
    {
            _a = a;
    }
     public void Abc()
        {
            Console.WriteLine(PI);
            Console.WriteLine(_a);
            Console.WriteLine(_b);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Myclass myclass = new Myclass(4);
            myclass.Abc();

        }
    }
}
